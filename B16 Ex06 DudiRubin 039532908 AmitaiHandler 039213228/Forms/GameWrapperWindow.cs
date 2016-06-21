using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms
{
    using System.Diagnostics;
    using System.Drawing.Drawing2D;

    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Properties;

    public partial class GameWrapperWindow : Form
    {
        public event EventHandler StartNewGame;

        public event EventHandler StartNewTournement;

        public event EventHandler SetGameProperties;

        public event EventHandler Exit;

        public event EventHandler HowToPlay;

        public event EventHandler About;

        public event ColumnSelectEventHandler OnColumnSelectPressed;

        public delegate void ColumnSelectEventHandler(int col);

        public Point GameDimensions
        {
            get
            {
                return GameBoard.BoardSize;
            }

            set
            {
                GameBoard.BoardSize = value;
                FitWindowToGame();
            }
        }

        public string CurrentPlayer
        {
            get
            {
                return GameStatusBar.PlayerName;
            }

            set
            {
                GameStatusBar.PlayerName = value;
            }
        }

        public Board.eSlotState CurrentESlotState
        {
            set
            {
                GameBoard.CurrrentPlayer = value;
                CursorFollower.Image = (value == Board.eSlotState.Player1) ? Resources.CoinRed : Resources.CoinYellow;
            }
        }

        public string Scores
        {
            get
            {
                return GameStatusBar.Scores;
            }

            set
            {
                GameStatusBar.Scores = value;
            }
        }

        public GameWrapperWindow()
        {
            InitializeComponent();
            GameDimensions = new Point(4, 4);
            GameBoard.OnColumnSelectPressed += GameBoard_OnColumnSelectPressed;
            SetCursorFollower();
        }

        private void SetCursorFollower()
        {
            CursorFollower.SetActive(true);
        }

        private void GameBoard_OnColumnSelectPressed(int col)
        {
            if (OnColumnSelectPressed != null)
            {
                OnColumnSelectPressed.Invoke(col);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (SetGameProperties != null)
            {
                SetGameProperties.Invoke(null, null);
            }
        }

        /// <summary>
        /// Mark coordinates in board
        /// </summary>
        /// <param name="i_WinningCoordinates"></param>
        public void MarkWinningRow(List<Point> i_WinningCoordinates)
        {
            GameBoard.HighLightCoordinates(i_WinningCoordinates);
        }

        public void UpdateBoard(Board.eSlotState[,] i_CellMatrix)
        {
            GameBoard.UpdateBoard(i_CellMatrix);
        }

        /// <summary>
        /// Calculate all elements and resize client view
        /// </summary>
        private void FitWindowToGame()
        {
            Point size = new Point(GameBoard.Size.Width, GameBoard.Size.Height);
            size.Y += GameMenu.Height;
            size.Y += GameStatusBar.Height;
            ClientSize = new Size(size);
        }

        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StartNewGame != null)
            {
                StartNewGame.Invoke(sender, e);
            }
        }

        private void startANewTournementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StartNewTournement != null)
            {
                StartNewTournement.Invoke(sender, e);
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SetGameProperties != null)
            {
                SetGameProperties.Invoke(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Exit != null)
            {
                Exit.Invoke(sender, e);
            }
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HowToPlay != null)
            {
                HowToPlay.Invoke(sender, e);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (About != null)
            {
                About.Invoke(sender, e);
            }
        }

        private void boardCell1_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.Print("A");
        }
    }
}
