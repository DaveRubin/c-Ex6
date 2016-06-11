using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    public partial class BoardUserControl : UserControl
    {
        private Point m_boardSize;
        private Point m_CellSize;
        private BoardCell[,] m_CellMatrix;
        private List<ColumnSelector> m_ColumnSelectors;


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

        private void RedrawBoard()
        {
            m_CellMatrix = new BoardCell[m_boardSize.X, m_boardSize.Y];
            //create board
            CreateBoardMatrix();
            //create column selectors
            CreateSelectors();
            SetControlSizes();
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
                Controls.Add(selector);
            }
        }

        /// <summary>
        /// Set stiff size for component according to its size
        /// </summary>
        private void SetControlSizes()
        {
            //add extra row for selectors
            Point sizeInPixels = new Point(BoardSize.X* m_CellSize.X, (BoardSize.Y + 1) * m_CellSize.Y);
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
    }
}
