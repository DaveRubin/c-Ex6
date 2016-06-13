namespace B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Forms
{
    partial class GameWrapperWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWrapperWindow));
            this.GameMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startANewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startANewTournementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CursorFollower = new B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls.FallingPiece();
            this.GameBoard = new B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls.BoardUserControl();
            this.GameStatusBar = new B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.UserControls.GameStatusBar();
            this.GameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CursorFollower)).BeginInit();
            this.SuspendLayout();
            // 
            // GameMenu
            // 
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.GameMenu.Location = new System.Drawing.Point(0, 0);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(501, 24);
            this.GameMenu.TabIndex = 0;
            this.GameMenu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startANewGameToolStripMenuItem,
            this.startANewTournementToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startANewGameToolStripMenuItem
            // 
            this.startANewGameToolStripMenuItem.Name = "startANewGameToolStripMenuItem";
            this.startANewGameToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.startANewGameToolStripMenuItem.Text = "Start a New Game";
            this.startANewGameToolStripMenuItem.Click += new System.EventHandler(this.startANewGameToolStripMenuItem_Click);
            // 
            // startANewTournementToolStripMenuItem
            // 
            this.startANewTournementToolStripMenuItem.Name = "startANewTournementToolStripMenuItem";
            this.startANewTournementToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.startANewTournementToolStripMenuItem.Text = "Start a New Tournement";
            this.startANewTournementToolStripMenuItem.Click += new System.EventHandler(this.startANewTournementToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.propertiesToolStripMenuItem.Text = "Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play?";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CursorFollower
            // 
            this.CursorFollower.Image = ((System.Drawing.Image)(resources.GetObject("CursorFollower.Image")));
            this.CursorFollower.Location = new System.Drawing.Point(43, 116);
            this.CursorFollower.MaximumSize = new System.Drawing.Size(60, 60);
            this.CursorFollower.MinimumSize = new System.Drawing.Size(60, 60);
            this.CursorFollower.Name = "CursorFollower";
            this.CursorFollower.Size = new System.Drawing.Size(60, 60);
            this.CursorFollower.TabIndex = 3;
            this.CursorFollower.TabStop = false;
            this.CursorFollower.Type = B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Board.eSlotState.Player1;
            // 
            // GameBoard
            // 
            this.GameBoard.BoardSize = new System.Drawing.Point(4, 4);
            this.GameBoard.CurrrentPlayer = B16_Ex06_DudiRubin_039532908_AmitaiHandler_039213228.Board.eSlotState.Empty;
            this.GameBoard.Location = new System.Drawing.Point(0, 27);
            this.GameBoard.MaximumSize = new System.Drawing.Size(268, 335);
            this.GameBoard.MinimumSize = new System.Drawing.Size(268, 335);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(268, 335);
            this.GameBoard.TabIndex = 2;
            // 
            // GameStatusBar
            // 
            this.GameStatusBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GameStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameStatusBar.Location = new System.Drawing.Point(0, 435);
            this.GameStatusBar.Name = "GameStatusBar";
            this.GameStatusBar.PlayerName = "-";
            this.GameStatusBar.Scores = "Waiting to start";
            this.GameStatusBar.Size = new System.Drawing.Size(501, 22);
            this.GameStatusBar.TabIndex = 1;
            // 
            // GameWrapperWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 457);
            this.Controls.Add(this.CursorFollower);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.GameStatusBar);
            this.Controls.Add(this.GameMenu);
            this.MainMenuStrip = this.GameMenu;
            this.MaximizeBox = false;
            this.Name = "GameWrapperWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWrapperWindow";
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CursorFollower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GameMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startANewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startANewTournementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private UserControls.GameStatusBar GameStatusBar;
        private UserControls.BoardUserControl GameBoard;
        private UserControls.FallingPiece CursorFollower;
    }
}