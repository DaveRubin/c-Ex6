using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    using B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Properties;

    public partial class ColumnSelector : UserControl
    {
        public ColumnSelector()
        {
            InitializeComponent();
            SetSize();
        }

        private void SetSize()
        {
            Point size = new Point(Resources.EmptyCell.Size.Width, Resources.EmptyCell.Size.Height);
            Size = new Size(size);
            MaximumSize = new Size(size);
            MinimumSize = new Size(size);
            BackColor = Color.FromArgb(30, Color.Aqua);
        }
    }
}
