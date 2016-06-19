using System;
using System.Drawing;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Properties;

    public partial class FallingPiece : Piece
    {

        private int m_TartgetPos;
        private float  m_ProceedEachTick;
        private float m_Position;
        private Timer m_LoopTimer;
        private const int k_MillisecondsInterval = 30;

        public event EventHandler MotionFinished;


        public FallingPiece()
        {
            InitializeComponent();
            m_LoopTimer = new Timer();
            m_LoopTimer.Interval = k_MillisecondsInterval;
            m_LoopTimer.Tick += m_LoopTimer_Tick;
            m_Position = Top;
        }

        public void MoveToY(int i_YTargetPos, int i_DurationInMS)
        {
            //calculate how many pixels per 10 ms we'll need 
            int times = i_DurationInMS / k_MillisecondsInterval;
            int delta = i_YTargetPos - Top;
            m_TartgetPos = i_YTargetPos;
            m_ProceedEachTick = (float)delta / times;
            m_LoopTimer.Start();
        }


        void m_LoopTimer_Tick(object sender, EventArgs e)
        {
            if (Top < m_TartgetPos)
            {
                m_Position += m_ProceedEachTick;
                Top += (int)m_Position;
            }
            else
            {
                if (MotionFinished != null)
                {
                    MotionFinished.Invoke(this,EventArgs.Empty);
                    MotionFinished = null;
                }
            }
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
