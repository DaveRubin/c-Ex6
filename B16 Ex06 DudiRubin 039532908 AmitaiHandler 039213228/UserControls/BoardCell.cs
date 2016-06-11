using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228;
    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Properties;

    public partial class BoardCell : PictureBox
    {
        private Board.eSlotState m_CurrentState;
        public Board.eSlotState CurrentState
        {
            get
            {
                return m_CurrentState;;
            }
            set
            {
                m_CurrentState = value;
                UpdateImage();
            }
        }

        public BoardCell()
        {
            InitializeComponent();
            CurrentState = Board.eSlotState.Empty;
            MaximumSize = new Size(Image.Width, Image.Height);
            MinimumSize = new Size(Image.Width, Image.Height);
            Size = new Size(Image.Width, Image.Height);
        }

        private void UpdateImage()
        {
            if (m_CurrentState == Board.eSlotState.Player1)
            {
                Image = Resources.FullCellRed;
            }
            else if (m_CurrentState == Board.eSlotState.Player2)
            {
                Image = Resources.FullCellYellow;
            }
            else
            {
                Image = Resources.EmptyCell;
            }
        }

        
    }
}
