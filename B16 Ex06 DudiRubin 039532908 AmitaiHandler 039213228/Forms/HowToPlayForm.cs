using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms
{
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
            LoadTextFromDiskAndUpdateTextBox();
        }

        private void LoadTextFromDiskAndUpdateTextBox()
        {
            string text = System.IO.File.ReadAllText(@"C:\FourInARowHelp.txt");
            TextBoxHowToPlay.Text = text;
        }
    }
}
