namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms
{
    partial class HowToPlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonOk = new System.Windows.Forms.Button();
            this.TextBoxHowToPlay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOk.Location = new System.Drawing.Point(197, 226);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 0;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // TextBoxHowToPlay
            // 
            this.TextBoxHowToPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxHowToPlay.Location = new System.Drawing.Point(0, 0);
            this.TextBoxHowToPlay.Multiline = true;
            this.TextBoxHowToPlay.Name = "TextBoxHowToPlay";
            this.TextBoxHowToPlay.Size = new System.Drawing.Size(284, 220);
            this.TextBoxHowToPlay.TabIndex = 1;
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonOk;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TextBoxHowToPlay);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HowToPlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "How To Play?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.TextBox TextBoxHowToPlay;
    }
}