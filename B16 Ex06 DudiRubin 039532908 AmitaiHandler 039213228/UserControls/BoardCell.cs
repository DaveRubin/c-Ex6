using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using System.Drawing.Drawing2D;

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

            BackColor = Color.Transparent;
            CurrentState = Board.eSlotState.Empty;
            MaximumSize = new Size(Image.Width, Image.Height);
            MinimumSize = new Size(Image.Width, Image.Height);
            Size = new Size(Image.Width, Image.Height);
            ToggleEmptyRegion(true);
        }

        private void ToggleEmptyRegion(bool i_Empty)
        {
            GraphicsPath path = new GraphicsPath();
            int padding = 3;
            path.AddRectangle(new Rectangle(0, 0, Size.Width, Size.Height));
            if (i_Empty)
            {
                path.AddEllipse(new Rectangle(padding, padding, Size.Width - padding * 2, Size.Height - padding * 2));   
            }
            Region = new Region(path);
        }

        private void UpdateImage()
        {
            bool empty = false;
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
                empty = true;
            }
            ToggleEmptyRegion(empty);
        }

        
    }
}
