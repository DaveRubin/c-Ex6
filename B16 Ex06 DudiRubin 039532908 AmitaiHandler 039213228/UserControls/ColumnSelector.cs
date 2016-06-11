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

        private const int k_IdleOpacity = 0;
        private const int k_HoverOpacity = 30;
        private const int k_ClickOpacity = 80;
        private static readonly Color rs_BaseColor = Color.Crimson;

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
            BackColor = Color.FromArgb(k_IdleOpacity, rs_BaseColor);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.FromArgb(k_IdleOpacity, rs_BaseColor);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Color.FromArgb(k_HoverOpacity, rs_BaseColor);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            BackColor = Color.FromArgb(k_ClickOpacity, rs_BaseColor);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            BackColor = Color.FromArgb(k_HoverOpacity, rs_BaseColor);
        }
    }
}
