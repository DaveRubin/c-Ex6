namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms
{
    using System;
    public class GamePreferences : EventArgs
    {

        private int m_Rows;
        private int m_Columns;
        private string m_Player1Name;
        private string m_Player2Name;

        public int Rows
        {
            get
            {
                return m_Rows;
            }
            set
            {
                m_Rows = value;
            }
        }

        public int Columns
        {
            get
            {
                return m_Columns;
            }
            set
            {
                m_Columns = value;
            }
        }

        public string Player1Name
        {
            get
            {
                return m_Player1Name;
            }
            set
            {
                m_Player1Name = value;
            }
        }
        public string Player2Name
        {
            get
            {
                return m_Player2Name;
            }
            set
            {
                m_Player2Name = value;
            }
        }
    }
}