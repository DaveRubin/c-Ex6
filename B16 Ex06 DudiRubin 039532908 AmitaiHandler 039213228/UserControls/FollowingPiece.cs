using System;
using System.Drawing;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using System.Drawing.Drawing2D;

    public partial class FollowingPiece : Piece
    {
        private const int k_LoopInterval = 10;
        private Timer m_LoopTimer = new Timer();

        public FollowingPiece()
        {
            InitializeComponent();

            m_LoopTimer.Interval = k_LoopInterval;
            m_LoopTimer.Tick += loopTimer_Tick;

            Enabled = false;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
        }

        public void SetActive(bool i_Active)
        {
            if (i_Active)
            {
                m_LoopTimer.Start();
            }
            else
            {
                m_LoopTimer.Stop();
            }
        }

        private void loopTimer_Tick(object sender, EventArgs e)
        {
            Location = Parent.PointToClient(Cursor.Position);
            BringToFront();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
