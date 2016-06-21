using System.Collections.Generic;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228
{
    public class Board
    {
        public readonly int r_NumOfRows;
        public readonly int r_NumOfColumns;
        public eSlotState[,] m_SlotsMatrix;

        public delegate void BoardUpdateHandler(eSlotState[,] i_CellMatrix);

        public event BoardUpdateHandler BoardViewUpdate;

        public eSlotState[,] SlotsMatrix
        {
            get
            {
                // TODO: ask about a more efficient way to get the matrix out and still protect 'slotsMatrix' data
                return (eSlotState[,])m_SlotsMatrix.Clone();
            }
        }

        public bool IsFull
        {
            get
            {
                bool result = true;
                for (int i = 0; i < r_NumOfColumns; i++)
                {
                    if (IsColumnFree(i))
                    {
                        result = false;
                        break;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// on construction, create the new matrix and initialize memebers
        /// </summary>
        /// <param name="i_columns"></param>
        /// <param name="i_rows"></param>
        public Board(int i_columns, int i_rows)
        {
            r_NumOfRows = i_rows;
            r_NumOfColumns = i_columns;
            m_SlotsMatrix = new eSlotState[i_columns, i_rows];
            EmptyBoard();
            UpdateBoardView();
        }

        public void UpdateBoardView()
        {
            if (BoardViewUpdate != null)
            {
                BoardViewUpdate.Invoke(m_SlotsMatrix);
            }
        }

        // add piece to column , 
        // return false if column is full
        public bool AddPieceToColumn(int i_column, eSlotState i_pieceType)
        {
            bool success = true;

            if (IsColumnFree(i_column))
            {
                int targetRow = r_NumOfRows - 1;
                while (m_SlotsMatrix[i_column, targetRow] != eSlotState.Empty)
                {
                    targetRow--;
                }

                m_SlotsMatrix[i_column, targetRow] = i_pieceType;
                UpdateBoardView();
            }
            else
            {
                success = false;
            }

            return success;
        }

        // remove piece from column
        public void RemovePieceFromColumn(int i_column)
        {
            int targetRow = r_NumOfRows - 1;
            if (IsColumnFree(i_column))
            {
                if (m_SlotsMatrix[i_column, targetRow] != eSlotState.Empty)
                {
                    while (m_SlotsMatrix[i_column, targetRow] != eSlotState.Empty)
                    {
                        targetRow--;
                    }

                    m_SlotsMatrix[i_column, targetRow + 1] = eSlotState.Empty;
                }
            }
            else
            {
                m_SlotsMatrix[i_column, 0] = eSlotState.Empty;
            }

            UpdateBoardView();
        }

        /// <summary>
        /// Set all slots to be "Empty"
        /// </summary>
        public void EmptyBoard()
        {
            for (int i = 0; i < r_NumOfColumns; i++)
            {
                for (int j = 0; j < r_NumOfRows; j++)
                {
                    m_SlotsMatrix[i, j] = eSlotState.Empty;
                }
            }

            UpdateBoardView();
        }

        private List<int> full = new List<int>();

        /// <summary>
        /// Check if a given column is free 
        /// </summary>
        /// <param name="i_column"></param>
        /// <returns></returns>
        private bool IsColumnFree(int i_column)
        {
            bool res = m_SlotsMatrix[i_column, 0] == eSlotState.Empty;
            if (!full.Contains(i_column) && res == false)
            {
                full.Add(i_column);
            }

            return res;
        }

        /// <summary>
        /// Enum representing each board slot
        /// </summary>
        public enum eSlotState
        {
            Empty,
            Player1,
            Player2
        }
    }
}
