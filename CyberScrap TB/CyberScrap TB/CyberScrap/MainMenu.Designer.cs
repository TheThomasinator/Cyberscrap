
namespace CyberScrap
{
    partial class MainMenu
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
            this.btnStory = new System.Windows.Forms.Button();
            this.btnLdrBrd = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.stripFIle = new System.Windows.Forms.ToolStripMenuItem();
            this.stripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stripUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.stripChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.stripRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStory
            // 
            this.btnStory.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStory.BackgroundImage = global::CyberScrap.Properties.Resources.StoryBtn;
            this.btnStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStory.FlatAppearance.BorderSize = 0;
            this.btnStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStory.Location = new System.Drawing.Point(325, 150);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(166, 82);
            this.btnStory.TabIndex = 0;
            this.btnStory.UseVisualStyleBackColor = false;
            this.btnStory.Click += new System.EventHandler(this.btnStory_Click);
            // 
            // btnLdrBrd
            // 
            this.btnLdrBrd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLdrBrd.BackgroundImage = global::CyberScrap.Properties.Resources.LeaderboardBtn;
            this.btnLdrBrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLdrBrd.FlatAppearance.BorderSize = 0;
            this.btnLdrBrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLdrBrd.Location = new System.Drawing.Point(325, 326);
            this.btnLdrBrd.Name = "btnLdrBrd";
            this.btnLdrBrd.Size = new System.Drawing.Size(166, 82);
            this.btnLdrBrd.TabIndex = 5;
            this.btnLdrBrd.UseVisualStyleBackColor = false;
            this.btnLdrBrd.Click += new System.EventHandler(this.btnLdrBrd_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHelp.BackgroundImage = global::CyberScrap.Properties.Resources.HelpBtn;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(325, 238);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(166, 82);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // stripFIle
            // 
            this.stripFIle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripExit});
            this.stripFIle.ForeColor = System.Drawing.Color.Cyan;
            this.stripFIle.Name = "stripFIle";
            this.stripFIle.Size = new System.Drawing.Size(37, 24);
            this.stripFIle.Text = "File";
            // 
            // stripExit
            // 
            this.stripExit.AutoSize = false;
            this.stripExit.Name = "stripExit";
            this.stripExit.Size = new System.Drawing.Size(180, 22);
            this.stripExit.Text = "Exit game";
            this.stripExit.Click += new System.EventHandler(this.stripLogOut_Click);
            // 
            // stripUserChange
            // 
            this.stripUserChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripChangeUser});
            this.stripUserChange.ForeColor = System.Drawing.Color.Cyan;
            this.stripUserChange.Name = "stripUserChange";
            this.stripUserChange.Size = new System.Drawing.Size(42, 24);
            this.stripUserChange.Text = "User";
            // 
            // stripChangeUser
            // 
            this.stripChangeUser.Name = "stripChangeUser";
            this.stripChangeUser.Size = new System.Drawing.Size(140, 22);
            this.stripChangeUser.Text = "Change user";
            this.stripChangeUser.Click += new System.EventHandler(this.stripChangeUser_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripBackup,
            this.stripRestore});
            this.backupToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // stripBackup
            // 
            this.stripBackup.Name = "stripBackup";
            this.stripBackup.Size = new System.Drawing.Size(219, 22);
            this.stripBackup.Text = "Backup current player";
            this.stripBackup.Click += new System.EventHandler(this.stripBackup_Click);
            // 
            // stripRestore
            // 
            this.stripRestore.Name = "stripRestore";
            this.stripRestore.Size = new System.Drawing.Size(219, 22);
            this.stripRestore.Text = "Restore player from backup";
            this.stripRestore.Click += new System.EventHandler(this.stripRestore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripFIle,
            this.stripUserChange,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CyberScrap.Properties.Resources.GameTitle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(200, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 78);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CyberScrap.Properties.Resources.CurrentUser;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(545, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 94);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Blue;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(572, 258);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(134, 31);
            this.username.TabIndex = 9;
            this.username.Text = "username";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::CyberScrap.Properties.Resources.MenuBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLdrBrd);
            this.Controls.Add(this.btnStory);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStory;
        private System.Windows.Forms.Button btnLdrBrd;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolStripMenuItem stripFIle;
        private System.Windows.Forms.ToolStripMenuItem stripExit;
        private System.Windows.Forms.ToolStripMenuItem stripUserChange;
        private System.Windows.Forms.ToolStripMenuItem stripChangeUser;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripBackup;
        private System.Windows.Forms.ToolStripMenuItem stripRestore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label username;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
    }
}