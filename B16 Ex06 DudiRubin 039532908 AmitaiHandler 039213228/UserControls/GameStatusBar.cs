﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    public partial class GameStatusBar : UserControl
    {
        public GameStatusBar()
        {
            InitializeComponent();
        }

        public string PlayerName
        {
            set
            {
                LabelCurrentPlayerName.Text = value;
            }
        }

        public string Scores
        {
            set
            {
                LabelScore.Text = value;
            }
        }
    }
}
