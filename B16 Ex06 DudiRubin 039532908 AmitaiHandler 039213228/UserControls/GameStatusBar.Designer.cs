namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls
{
    partial class GameStatusBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelCurrentPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Player: ";
            // 
            // LabelScore
            // 
            this.LabelScore.AccessibleDescription = "";
            this.LabelScore.AccessibleName = "LabelScore";
            this.LabelScore.AutoSize = true;
            this.LabelScore.Location = new System.Drawing.Point(224, 11);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(35, 13);
            this.LabelScore.TabIndex = 1;
            this.LabelScore.Text = "label2";
            // 
            // LabelCurrentPlayerName
            // 
            this.LabelCurrentPlayerName.AccessibleDescription = "";
            this.LabelCurrentPlayerName.AccessibleName = "LabelCurrentPlayerName";
            this.LabelCurrentPlayerName.AutoSize = true;
            this.LabelCurrentPlayerName.Location = new System.Drawing.Point(99, 11);
            this.LabelCurrentPlayerName.Name = "LabelCurrentPlayerName";
            this.LabelCurrentPlayerName.Size = new System.Drawing.Size(64, 13);
            this.LabelCurrentPlayerName.TabIndex = 2;
            this.LabelCurrentPlayerName.Text = "PlayerName";
            // 
            // GameStatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.LabelCurrentPlayerName);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.label1);
            this.Name = "GameStatusBar";
            this.Size = new System.Drawing.Size(551, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelCurrentPlayerName;
    }
}
