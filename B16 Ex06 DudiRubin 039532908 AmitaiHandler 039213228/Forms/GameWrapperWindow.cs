using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms
{
    using System.Diagnostics;

    public partial class GameWrapperWindow : Form
    {

        public event EventHandler StartNewGame;
        public event EventHandler StartNewTournement;
        public event EventHandler SetGameProperties;
        public event EventHandler Exit;
        public event EventHandler HowToPlay;
        public event EventHandler About;
        public delegate void ColumnSelectEventHandler(int col);
        public event ColumnSelectEventHandler OnColumnSelectPressed;

        public string CurrentPlayer
        {
            set { GameStatusBar.PlayerName = value; }
            get { return GameStatusBar.PlayerName; }
        }

        public string Scores
        {
            set { GameStatusBar.Scores = value; }
            get { return GameStatusBar.Scores; }
        }

        public GameWrapperWindow()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (SetGameProperties != null)
            {
                SetGameProperties.Invoke(null,null);
            }
        }

        /// <summary>
        /// Mark coordinates in board
        /// </summary>
        /// <param name="i_WinningCoordinates"></param>
        public void MarkWinningRow(List<Point> i_WinningCoordinates)
        {

        }

        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StartNewGame != null)
            {
                StartNewGame.Invoke(sender, e);
            }
        }

        private void startANewTournementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StartNewTournement != null)
            {
                StartNewTournement.Invoke(sender, e);
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SetGameProperties != null)
            {
                SetGameProperties.Invoke(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Exit != null)
            {
                Exit.Invoke(sender, e);
            }
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HowToPlay != null)
            {
                HowToPlay.Invoke(sender, e);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (About != null)
            {
                About.Invoke(sender, e);   
            }
        }
    }
}
