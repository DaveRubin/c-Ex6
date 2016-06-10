using System;
using System.Collections.Generic;
using System.Text;

namespace B16_Ex05
{
    using System.Windows.Forms;

    using B16_Ex05.Forms;

    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms;

    internal class FourInARowGame
    {
        public const int k_MinDimension = 4;
        public const int k_MaxDimension = 8;

        private bool firstRun = true;
        private Board m_board;
        private BoardViewForm m_BoardViewForm;
        private GamePreferencesForm m_GamePreferences;
        private GameWrapperWindow m_GameWrapperWindow;
        private List<Player> m_players;
        private int m_currentPlayerIndex;

        public FourInARowGame()
        {
            m_GameWrapperWindow = new GameWrapperWindow();
            m_GamePreferences = new GamePreferencesForm(k_MinDimension, k_MaxDimension);
            ConnectEvenetsLeteners();
            m_GameWrapperWindow.ShowDialog();
        }

        private void ConnectEvenetsLeteners()
        {
            m_GameWrapperWindow.SetGameProperties += GameWrapperWindow_SetGameProperties;
            m_GameWrapperWindow.StartNewGame += GameWrapperWindow_StartNewGame;
            m_GameWrapperWindow.StartNewTournement += GameWrapperWindow_StartNewTournement;
            m_GameWrapperWindow.Exit += m_GameWrapperWindow_Exit;
            m_GameWrapperWindow.HowToPlay += GameWrapperWindow_HowToPlay;
            m_GameWrapperWindow.About += GameWrapperWindow_About;
        }

        void GameWrapperWindow_About(object sender, EventArgs e)
        {
            
        }

        void GameWrapperWindow_HowToPlay(object sender, EventArgs e)
        {
            HowToPlayForm howToPlayForm = new HowToPlayForm();
            howToPlayForm.ShowDialog();
        }

        void m_GameWrapperWindow_Exit(object sender, EventArgs e)
        {
            m_GameWrapperWindow.Close();
        }

        void GameWrapperWindow_StartNewTournement(object sender, EventArgs e)
        {
            StartNewTournemet();
        }

        private void StartNewTournemet()
        {
            foreach (Player player in m_players)
            {
                player.Score = 0;
            }
            StartNewGame();
        }

        void GameWrapperWindow_StartNewGame(object sender, EventArgs e)
        {
            StartNewGame();
        }

        void GameWrapperWindow_SetGameProperties(object sender, EventArgs e)
        {
            DialogResult result = m_GamePreferences.ShowDialog();
            if (result == DialogResult.OK)
            {
                // if not first time, Ask to start a new game
                // if selected OK then start a new game
                // else display a message that changes will effect only in the next game 
                if (firstRun)
                {
                    StartNewGame();
                    firstRun = false;
                }
                else 
                {
                    DialogResult startAnotherGameResult = ShowYesNoMessageBox("Start a new game?", "4 in a row");
                    if (startAnotherGameResult == DialogResult.Yes)
                    {
                        StartNewGame();
                    }
                    else
                    {
                        ShowMessageBox("Changes will take effect only in the next game","4 in a row");
                    }
                }
            }
        }

        void StartNewGame()
        {
            GamePreferences gameSettings = m_GamePreferences.GameSettings;
            // from here we should initialize the game
            InitializePlayers(gameSettings.Player1Name, gameSettings.Player2Name);
            InitializeBoardForm(gameSettings);
            InitializeBoard(gameSettings.Columns, gameSettings.Rows, m_BoardViewForm);

            m_BoardViewForm.ShowDialog();
        }

        /// <summary>
        /// Get Board dimensions from user and initialize it
        /// </summary>
        private void InitializeBoard(int i_Columns, int i_Rows, BoardViewForm i_BoardView) 
        {
            // initialize board
            m_board = new Board(i_Columns, i_Rows, i_BoardView);
        }

        /// <summary>
        /// Create the Board View Form from setting argument 
        /// <param name="MainMenuGameSettingsArgs args"></param>
        /// </summary>
        private void InitializeBoardForm(GamePreferences i_Preferences)
        {
            m_BoardViewForm = new BoardViewForm(i_Preferences);
            UpdateStatusBar();
            m_BoardViewForm.OnColumnSelectPressed += m_BoardViewForm_OnColumnSelectPressed;
        }

        private void UpdateStatusBar()
        {
            Player player1 = m_players[0];
            Player player2 = m_players[1];

            //update score
            m_GameWrapperWindow.Scores = string.Format(
                "{0}:{1},{2}:{3}",
                player1.Name,
                player1.Score,
                player2.Name,
                player2.Score);

            //update current player
            Player currentPlayer = m_players[m_currentPlayerIndex];
            m_GameWrapperWindow.CurrentPlayer = currentPlayer.Name;
        }

        void m_BoardViewForm_OnColumnSelectPressed(int col)
        {
            TakeTurn(col);
        }

        /// <summary>
        /// Get the game mode from user and initialize players
        /// </summary>
        private void InitializePlayers(string i_Player1Name, string i_Player2Name)
        {
            if (m_players == null)
            {
                m_players = new List<Player>();
                m_players.Add(new Player(i_Player1Name, true, Board.eSlotState.Player1));
                m_players.Add(new Player(i_Player2Name, true, Board.eSlotState.Player2));
            }
            else
            {
                m_players[0].Name = i_Player1Name;
                m_players[1].Name = i_Player2Name;
            }
        }

        /// <summary>
        /// Game turn sequence
        /// </summary>
        private void TakeTurn(int i_ColSelected)
        {
            //GameView.ShowTurnScreen(m_board, m_players[m_currentPlayerIndex].r_name);
            PlayerMove(i_ColSelected);
            
            if (CheckIfWin())
            {
                ShowGameWinScreen();
            }
            else if (m_board.IsFull)
            {
                ShowGameTieScreen();
            }
            else
            {
                m_currentPlayerIndex = (m_currentPlayerIndex + 1) % 2;
                if (!m_players[m_currentPlayerIndex].IsHuman)
                {
                    int selectedColumn = ComputerColumnSelection();
                    TakeTurn(selectedColumn);
                }
            }
        }

        private void ShowGameTieScreen()
        {
            ShowEndingMessageBox(GameTexts.k_TieMainText, GameTexts.k_TieWindowTitle);
        }

        private void PlayAgain()
        {
            m_board.EmptyBoard();
            m_currentPlayerIndex = 0;
            UpdateStatusBar();
            //TakeTurn();
        }

        /// <summary>
        /// Congradulate winner
        /// </summary>
        private void ShowGameWinScreen()
        {
            Player winner = m_players[m_currentPlayerIndex];
            winner.Score++;
            m_BoardViewForm.UpdatePlayersScore(m_players[0].Score, m_players[1].Score);
            string winText = string.Format(GameTexts.k_WinScreenTemplate, winner.Name);
            ShowEndingMessageBox(winText, GameTexts.k_WinWindowTitle);
        }

        private void ShowEndingMessageBox(string i_MainBoxText, string i_WindowTitle)
        {
            DialogResult result = ShowYesNoMessageBox(i_MainBoxText, i_WindowTitle);
            if (result == DialogResult.Yes)
            {
                PlayAgain();
            }
        }

        private DialogResult ShowYesNoMessageBox(string i_MainBoxText, string i_WindowTitle)
        {
            DialogResult result = MessageBox.Show(
                i_MainBoxText,
                i_WindowTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return result;
        }

        private void ShowMessageBox(string i_Message, string i_WindowTitle)
        {
            MessageBox.Show(i_Message, i_WindowTitle);
        }

        /// <summary>
        /// Check board for winner
        /// </summary>
        /// <returns></returns>
        private bool CheckIfWin()
        {
            return BoardAnalyzer.IsGameWon(ref m_board);
        }

        /// <summary>
        /// The player should select a column
        /// </summary>
        private void PlayerMove(int i_ColumnSelected)
        {
            //int selectedColumn = i_ColumnSelected;
            //if (!m_players[m_currentPlayerIndex].IsHuman)
            //{
            //    selectedColumn = ComputerColumnSelection();
            //}

            Board.eSlotState playerPieceType = (m_currentPlayerIndex == 0)
                                                   ? Board.eSlotState.Player1
                                                   : Board.eSlotState.Player2;
            m_board.AddPieceToColumn(i_ColumnSelected, playerPieceType);
        }

        private int ComputerColumnSelection()
        {
            Board.eSlotState opponentPieceType = Board.eSlotState.Player1;
            return AI.SelectMove(ref m_board, Board.eSlotState.Player2, opponentPieceType);
        }
    }
}
