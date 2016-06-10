using System;
using System.Collections.Generic;
using System.Text;

namespace B16_Ex05
{
    internal class Player
    {
        private int m_score;
        private string m_name;
        private bool m_isHuman;
        private Board.eSlotState m_pieceType;

        public bool IsHuman
        {
            get
            {
                return m_isHuman;
            }
        }

        public int Score
        {
            get
            {
                return m_score;
            }

            set
            {
                m_score = value;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public Player(string i_name, bool i_isHuman, Board.eSlotState i_pieceType)
        {
            m_isHuman = i_isHuman;
            m_name = i_name;
            m_pieceType = i_pieceType;
            m_score = 0;
        }

        /// public int SelectColumn(ref Board i_board)
        /// {
        ///    Board.eSlotState opponentPieceType = Board.eSlotState.Player1;
        ///    return AI.SelectMove(ref i_board, m_pieceType, opponentPieceType);
        /// }
    }
}
