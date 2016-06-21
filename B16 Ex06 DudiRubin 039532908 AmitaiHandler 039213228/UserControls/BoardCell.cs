using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using System.Diagnostics;
    using System.Drawing.Drawing2D;

    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228;
    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Properties;

    public partial class BoardCell : PictureBox
    {
        private readonly Color r_HighlightColor = Color.HotPink;
        private Board.eSlotState m_CurrentState;
        private Timer m_BlinkTimer;
        private Panel m_ColorPanel;

        public Board.eSlotState CurrentState
        {
            get
            {
                return m_CurrentState;
<<<<<<< HEAD
=======
                ;
>>>>>>> origin/master
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
            InitializeBlinkTimer();
            BackColor = Color.Transparent;
            CurrentState = Board.eSlotState.Empty;
            MaximumSize = new Size(Image.Width, Image.Height);
            MinimumSize = new Size(Image.Width, Image.Height);
            Size = new Size(Image.Width, Image.Height);
            CreateColiorPanel();
            ToggleEmptyRegion(true);
            Highlight = false;
        }

        public void SetBlink(bool i_Blink)
        {
            if (i_Blink)
            {
                m_BlinkTimer.Start();
            }
            else
            {
                m_BlinkTimer.Stop();
            }

            UpdateImage();
        }

        private bool Highlight
        {
            get
            {
                return m_ColorPanel.Visible;
            }

            set
            {
                m_ColorPanel.Visible = value;
            }
        }

        private void CreateColiorPanel()
        {
            m_ColorPanel = new Panel();
            m_ColorPanel.Size = Size;
            Controls.Add(m_ColorPanel);
            m_ColorPanel.Enabled = false;
            m_ColorPanel.BackColor = r_HighlightColor;
        }

        private void InitializeBlinkTimer()
        {
            m_BlinkTimer = new Timer();
            m_BlinkTimer.Interval = 500;
            m_BlinkTimer.Tick += m_BlinkTimer_Tick;
        }

        internal void m_BlinkTimer_Tick(object sender, EventArgs e)
        {
            Highlight = !Highlight;
        }

        private void ToggleEmptyRegion(bool i_Empty)
        {
            GraphicsPath emptyPath = new GraphicsPath();
            int padding = 3;
            emptyPath.AddRectangle(new Rectangle(0, 0, Size.Width, Size.Height));
            emptyPath.AddEllipse(new Rectangle(padding, padding, Size.Width - (padding * 2), Size.Height - (padding * 2)));
            if (i_Empty)
            {
                Region = new Region(emptyPath);
            }
            else
            {
                Region = null;
                m_ColorPanel.Region = new Region(emptyPath);
            }
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
