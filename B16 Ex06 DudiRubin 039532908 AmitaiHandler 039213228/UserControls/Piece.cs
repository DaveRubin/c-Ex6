using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Properties;

    public partial class Piece : PictureBox
    {
        private Board.eSlotState m_type;

        public Board.eSlotState Type
        {
            get
            {
                return m_type;
            }

            set
            {
                m_type = value;
                RedrawImage();
            }
        }

        public Piece()
        {
            InitializeComponent();
            Type = Board.eSlotState.Player1;
        }

        private void RedrawImage()
        {
            Bitmap result;
            if (m_type == Board.eSlotState.Player1)
            {
                result = Resources.CoinRed;
            }
            else
            {
                result = Resources.CoinYellow;
            }

            Image = result;
            Size = new Size(result.Width, result.Height);
            MinimumSize = Size;
            MaximumSize = Size;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
