using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228
{
    internal class BoardAnalyzer
    {
        internal static List<Point> m_WinningCoordinates = new List<Point>();

        internal static bool IsGameWon(ref Board i_Board)
        {
            /// Vertical search for winner
            for (int row = 0; row < i_Board.r_NumOfRows - 3; row++)
            {
                for (int col = 0; col < i_Board.r_NumOfColumns; col++)
                {
                    if (i_Board.m_SlotsMatrix[col, row] != Board.eSlotState.Empty &&
                    i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col, row + 1] &&
                    i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col, row + 2] &&
                    i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col, row + 3])
                    {
                        m_WinningCoordinates.Add(new Point(col, row));
                        m_WinningCoordinates.Add(new Point(col, row + 1));
                        m_WinningCoordinates.Add(new Point(col, row + 2));
                        m_WinningCoordinates.Add(new Point(col, row + 3));
                        return true;
                    }
                }
            }

            /// Horizontal search for winner
            for (int row = 0; row < i_Board.r_NumOfRows; row++)
            {
                for (int col = 0; col < i_Board.r_NumOfColumns - 3; col++)
                {
                    if (i_Board.m_SlotsMatrix[col, row] != Board.eSlotState.Empty &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 1, row] &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 2, row] &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 3, row])
                    {
                        m_WinningCoordinates.Add(new Point(col, row));
                        m_WinningCoordinates.Add(new Point(col + 1, row));
                        m_WinningCoordinates.Add(new Point(col + 2, row));
                        m_WinningCoordinates.Add(new Point(col + 3, row));
                        return true;
                    }
                } 
            }

            /// Right and down diagonal search for winner
            for (int row = 0; row < i_Board.r_NumOfRows - 3; row++)
            {
                for (int col = 0; col < i_Board.r_NumOfColumns - 3; col++)
                {
                    if (i_Board.m_SlotsMatrix[col, row] != Board.eSlotState.Empty &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 1, row + 1] &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 2, row + 2] &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 3, row + 3])
                    {
                        m_WinningCoordinates.Add(new Point(col, row));
                        m_WinningCoordinates.Add(new Point(col + 1, row + 1));
                        m_WinningCoordinates.Add(new Point(col + 2, row + 2));
                        m_WinningCoordinates.Add(new Point(col + 3, row + 3));
                        return true;
                    }
                }
            }

            /// Right and up diagonal search for winner
            for (int row = 3; row < i_Board.r_NumOfRows; row++)
            {
                for (int col = 0; col < i_Board.r_NumOfColumns - 3; col++)
                {
                    if (i_Board.m_SlotsMatrix[col, row] != Board.eSlotState.Empty &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 1, row - 1] &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 2, row - 2] &&
                        i_Board.m_SlotsMatrix[col, row] == i_Board.m_SlotsMatrix[col + 3, row - 3])
                    {
                        m_WinningCoordinates.Add(new Point(col, row));
                        m_WinningCoordinates.Add(new Point(col + 1, row - 1));
                        m_WinningCoordinates.Add(new Point(col + 2, row - 2));
                        m_WinningCoordinates.Add(new Point(col + 3, row - 3));
                        return true;
                    }
                }
            }

            return false;
        }

        internal static bool IsWinnningMove(ref Board i_board, int i_col, Board.eSlotState i_pieceType)
        {
            if (i_board.AddPieceToColumn(i_col, i_pieceType))
            {
                if (IsGameWon(ref i_board))
                {
                    i_board.RemovePieceFromColumn(i_col);
                    return true;
                }
                else
                {
                    i_board.RemovePieceFromColumn(i_col);
                    return false;
                }
            }

            return false;
        }
    }
}
