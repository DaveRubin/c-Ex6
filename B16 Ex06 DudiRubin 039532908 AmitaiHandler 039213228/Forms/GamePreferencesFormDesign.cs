using System;
using System.Collections.Generic;
using System.Text;

namespace B16_Ex05.Forms
{
    partial class GamePreferencesForm
    {
        private System.Windows.Forms.NumericUpDown NumericRows;
        private System.Windows.Forms.NumericUpDown NumericCols;
        private System.Windows.Forms.TextBox TextboxPlayer2Name;
        private System.Windows.Forms.TextBox TextboxPlayer1Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;

        private void InitializeComponent()
        {
            this.ButtonOk = new System.Windows.Forms.Button();
            this.NumericRows = new System.Windows.Forms.NumericUpDown();
            this.NumericCols = new System.Windows.Forms.NumericUpDown();
            this.TextboxPlayer2Name = new System.Windows.Forms.TextBox();
            this.TextboxPlayer1Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCols)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(12, 161);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(94, 23);
            this.ButtonOk.TabIndex = 0;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // NumericRows
            // 
            this.NumericRows.Location = new System.Drawing.Point(71, 117);
            this.NumericRows.Name = "NumericRows";
            this.NumericRows.Size = new System.Drawing.Size(35, 20);
            this.NumericRows.TabIndex = 1;
            // 
            // NumericCols
            // 
            this.NumericCols.Location = new System.Drawing.Point(166, 117);
            this.NumericCols.Name = "NumericCols";
            this.NumericCols.Size = new System.Drawing.Size(35, 20);
            this.NumericCols.TabIndex = 2;
            // 
            // TextboxPlayer2Name
            // 
            this.TextboxPlayer2Name.Location = new System.Drawing.Point(106, 58);
            this.TextboxPlayer2Name.Name = "TextboxPlayer2Name";
            this.TextboxPlayer2Name.Size = new System.Drawing.Size(95, 20);
            this.TextboxPlayer2Name.TabIndex = 4;
            // 
            // TextboxPlayer1Name
            // 
            this.TextboxPlayer1Name.AccessibleDescription = "";
            this.TextboxPlayer1Name.AccessibleName = "";
            this.TextboxPlayer1Name.Location = new System.Drawing.Point(106, 32);
            this.TextboxPlayer1Name.Name = "TextboxPlayer1Name";
            this.TextboxPlayer1Name.Size = new System.Drawing.Size(95, 20);
            this.TextboxPlayer1Name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Board Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rows:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cols:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Player 2:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(112, 161);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(94, 23);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // GamePreferencesForm
            // 
            this.AcceptButton = this.ButtonOk;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(213, 196);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxPlayer1Name);
            this.Controls.Add(this.TextboxPlayer2Name);
            this.Controls.Add(this.NumericCols);
            this.Controls.Add(this.NumericRows);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GamePreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game settings";
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
