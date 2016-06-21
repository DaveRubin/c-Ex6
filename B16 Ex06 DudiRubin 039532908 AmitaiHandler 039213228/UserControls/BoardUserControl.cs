using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using System.Diagnostics;

    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms;

    public partial class BoardUserControl : UserControl
    {
        private Point m_boardSize;
        private Point m_CellSize;
        private BoardCell[,] m_CellMatrix;
        private List<ColumnSelector> m_ColumnSelectors; 
        public event GameWrapperWindow.ColumnSelectEventHandler OnColumnSelectPressed;
        private Board.eSlotState m_CuerrentPlayer;
        private int m_ColumnSelected;

        public Board.eSlotState CurrrentPlayer
        {
            get
            {
                return m_CuerrentPlayer;
            }

            set
            {
                m_CuerrentPlayer = value;
            }
        }

        public Point BoardSize
        {
            get
            {
                return m_boardSize;
            }

            set
            {
                ClearCells();
                m_boardSize = value;
                RedrawBoard();
            }
        }

        public BoardUserControl()
        {
            InitializeComponent();
            m_ColumnSelectors = new List<ColumnSelector>();
            m_CellSize = Point.Empty;
            BoardSize = new Point(4, 4);
        }

        private void BringAllBoardCellsToFrontAndSelectorsToBack()
        {
            foreach (BoardCell boardCell in m_CellMatrix)
            {
                boardCell.BringToFront();
            }

            foreach (ColumnSelector columnSelector in m_ColumnSelectors)
            {
                columnSelector.SendToBack();
            }
        }

        private void RedrawBoard()
        {
            m_CellMatrix = new BoardCell[m_boardSize.X, m_boardSize.Y];

            // create board
            CreateBoardMatrix();

            // create column selectors
            CreateSelectors();
            SetControlDimensions();
        }

        private void CreateBoardMatrix()
        {
            for (int y = 0; y < m_boardSize.Y; y++)
            {
                for (int x = 0; x < m_boardSize.X; x++)
                {
                    BoardCell newCell = new BoardCell();

                    if (m_CellSize == Point.Empty)
                    {
                        m_CellSize = new Point(newCell.Width, newCell.Height);
                    }

                    m_CellMatrix[x, y] = newCell;
                    newCell.Location = new Point(m_CellSize.X * x, m_CellSize.Y * (y + 1));
                    Controls.Add(m_CellMatrix[x, y]);
                }
            }
        }

        private void CreateSelectors()
        {
            for (int x = 0; x < m_boardSize.X; x++)
            {
                ColumnSelector selector = new ColumnSelector();
                selector.Location = new Point(m_CellSize.X * x, 0);
                selector.Click += selector_Click;
                m_ColumnSelectors.Add(selector);
                Controls.Add(selector);
            }
        }

        private void selector_Click(object sender, EventArgs e)
        {
            ColumnSelector senderSelector = sender as ColumnSelector;
            int columnSelected = m_ColumnSelectors.IndexOf(senderSelector);

            FallingPiece fallingPiece = new FallingPiece();
            Controls.Add(fallingPiece);
            fallingPiece.Type = m_CuerrentPlayer;
            fallingPiece.Left = m_CellSize.X * columnSelected;
            int targetHeight = GetTargetHeight(columnSelected);
            fallingPiece.MoveToY(targetHeight, 1000);
            fallingPiece.MotionFinished += fallingPiece_MotionFinished;
            m_ColumnSelected = columnSelected;
            BringAllBoardCellsToFrontAndSelectorsToBack();

            Debug.Print(columnSelected.ToString());
        }

        private int GetTargetHeight(int i_ColumnSelected)
        {
            int index = 0;
            for (int y = 0; y < BoardSize.Y; y++)
            {
                BoardCell cell = m_CellMatrix[i_ColumnSelected, y];
                if (cell.CurrentState == Board.eSlotState.Empty)
                {
                    index = y;
                }
                else
                {
                    break;
                }
            }

            return (index + 1) * m_CellSize.Y;
        }

        private void fallingPiece_MotionFinished(object sender, EventArgs e)
        {
            FallingPiece piece = sender as FallingPiece;
            piece.MotionFinished -= fallingPiece_MotionFinished;
            Controls.Remove(piece);

            if (OnColumnSelectPressed != null)
            {
                OnColumnSelectPressed.Invoke(m_ColumnSelected);
            }
        }

        /// <summary>
        /// Set stiff size for component according to its size
        /// </summary>
        private void SetControlDimensions()
        {
            // add extra row for selectors
            Point sizeInPixels = new Point(BoardSize.X * m_CellSize.X, (BoardSize.Y + 1) * m_CellSize.Y);
            Size = new Size(sizeInPixels);
            MaximumSize = new Size(sizeInPixels);
            MinimumSize = new Size(sizeInPixels);
        }

        private void ClearCells()
        {
            ClearSelectors();
            ClearMatrix();
        }

        private void ClearMatrix()
        {
            if (m_CellMatrix != null)
            {
                foreach (BoardCell boardCell in m_CellMatrix)
                {
                    Controls.Remove(boardCell);
                }
            }

            m_CellMatrix = null;
        }

        private void ClearSelectors()
        {
            if (m_ColumnSelectors != null)
            {
                foreach (ColumnSelector columnSelector in m_ColumnSelectors)
                {
                    Controls.Remove(columnSelector);
                }
            }

            m_ColumnSelectors.Clear();
        }

        /// <summary>
        /// Update board and validate selectors
        /// </summary>
        /// <param name="i_CellMatrix"></param>
        public void UpdateBoard(Board.eSlotState[,] i_CellMatrix)
        {
            int width = i_CellMatrix.GetLength(0);
            int height = i_CellMatrix.GetLength(1);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (i_CellMatrix[x, y] != Board.eSlotState.Empty)
                    {
                        Debug.Print("{0}, {1}", x, y);
                    }

                    m_CellMatrix[x, y].CurrentState = i_CellMatrix[x, y];
                }   
            }

            CheckForFullColumnsAndLockSelectors();
        }

        /// <summary>
        /// Check if column selectors is enables or not
        /// </summary>
        private void CheckForFullColumnsAndLockSelectors()
        {
            for (int i = 0; i < m_ColumnSelectors.Count; i++)
            {
                m_ColumnSelectors[i].Enabled = m_CellMatrix[i, 0].CurrentState == Board.eSlotState.Empty;
            }
        }

        public void HighLightCoordinates(List<Point> i_WinningCoordinates)
        {
            foreach (Point point in i_WinningCoordinates)
            {
                m_CellMatrix[point.X, point.Y].SetBlink(true);
            }
        }
    }
}
