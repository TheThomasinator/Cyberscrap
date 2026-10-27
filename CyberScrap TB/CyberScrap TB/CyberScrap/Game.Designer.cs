
namespace CyberScrap
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ammoDisplayLbl = new System.Windows.Forms.Label();
            this.reloadBox = new System.Windows.Forms.PictureBox();
            this.CharacterDialogueLbl = new System.Windows.Forms.Label();
            this.roundBox = new System.Windows.Forms.PictureBox();
            this.pauseBackground = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reloadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ammoDisplayLbl
            // 
            this.ammoDisplayLbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ammoDisplayLbl.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoDisplayLbl.ForeColor = System.Drawing.Color.Transparent;
            this.ammoDisplayLbl.Location = new System.Drawing.Point(214, 779);
            this.ammoDisplayLbl.Name = "ammoDisplayLbl";
            this.ammoDisplayLbl.Size = new System.Drawing.Size(283, 48);
            this.ammoDisplayLbl.TabIndex = 5;
            // 
            // reloadBox
            // 
            this.reloadBox.BackColor = System.Drawing.Color.Transparent;
            this.reloadBox.Location = new System.Drawing.Point(567, 704);
            this.reloadBox.Name = "reloadBox";
            this.reloadBox.Size = new System.Drawing.Size(123, 123);
            this.reloadBox.TabIndex = 3;
            this.reloadBox.TabStop = false;
            // 
            // CharacterDialogueLbl
            // 
            this.CharacterDialogueLbl.BackColor = System.Drawing.Color.Indigo;
            this.CharacterDialogueLbl.Font = new System.Drawing.Font("Papyrus", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterDialogueLbl.ForeColor = System.Drawing.Color.Cyan;
            this.CharacterDialogueLbl.Location = new System.Drawing.Point(819, 716);
            this.CharacterDialogueLbl.Name = "CharacterDialogueLbl";
            this.CharacterDialogueLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CharacterDialogueLbl.Size = new System.Drawing.Size(761, 111);
            this.CharacterDialogueLbl.TabIndex = 10;
            this.CharacterDialogueLbl.Visible = false;
            this.CharacterDialogueLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // roundBox
            // 
            this.roundBox.BackColor = System.Drawing.Color.Transparent;
            this.roundBox.Image = global::CyberScrap.Properties.Resources.Round_1;
            this.roundBox.Location = new System.Drawing.Point(2, 3);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(138, 47);
            this.roundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundBox.TabIndex = 13;
            this.roundBox.TabStop = false;
            // 
            // pauseBackground
            // 
            this.pauseBackground.BackColor = System.Drawing.Color.BlueViolet;
            this.pauseBackground.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBackground.ForeColor = System.Drawing.Color.Transparent;
            this.pauseBackground.Location = new System.Drawing.Point(-275, -82);
            this.pauseBackground.Name = "pauseBackground";
            this.pauseBackground.Size = new System.Drawing.Size(2188, 998);
            this.pauseBackground.TabIndex = 20;
            this.pauseBackground.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(130, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 52);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Visible = false;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.Color.Indigo;
            this.infoLbl.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.ForeColor = System.Drawing.Color.Cyan;
            this.infoLbl.Location = new System.Drawing.Point(819, 827);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.infoLbl.Size = new System.Drawing.Size(416, 25);
            this.infoLbl.TabIndex = 22;
            this.infoLbl.Text = "Click on text to speed up or press Z to skip dialogue entirely";
            this.infoLbl.Visible = false;
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.mainMenuBtn.BackgroundImage = global::CyberScrap.Properties.Resources.MainMenuBtn;
            this.mainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(606, 160);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(337, 225);
            this.mainMenuBtn.TabIndex = 23;
            this.mainMenuBtn.TabStop = false;
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Visible = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click_1);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.quitBtn.BackgroundImage = global::CyberScrap.Properties.Resources.QuitGameBtn;
            this.quitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitBtn.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(606, 421);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(337, 225);
            this.quitBtn.TabIndex = 24;
            this.quitBtn.TabStop = false;
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Visible = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CyberScrap.Properties.Resources.Ground;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.ControlBox = false;
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterDialogueLbl);
            this.Controls.Add(this.pauseBackground);
            this.Controls.Add(this.roundBox);
            this.Controls.Add(this.reloadBox);
            this.Controls.Add(this.ammoDisplayLbl);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowInTaskbar = false;
            this.Text = "CyberScrap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.reloadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox reloadBox;
        private System.Windows.Forms.Label ammoDisplayLbl;
        private System.Windows.Forms.Label CharacterDialogueLbl;
        private System.Windows.Forms.PictureBox roundBox;
        private System.Windows.Forms.Label pauseBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLbl;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
        private AxWMPLib.AxWindowsMediaPlayer smgShotPlayer;
        private AxWMPLib.AxWindowsMediaPlayer smgReloadPlayer;
        private AxWMPLib.AxWindowsMediaPlayer lifeLostPlayer;
        private AxWMPLib.AxWindowsMediaPlayer swordSlashPlayer;
        private AxWMPLib.AxWindowsMediaPlayer railgunBlastPlayer;
        private AxWMPLib.AxWindowsMediaPlayer railgunChargePlayer;
        private AxWMPLib.AxWindowsMediaPlayer shotgunShotPlayer;
        private AxWMPLib.AxWindowsMediaPlayer shotgunReloadPlayer;
        private AxWMPLib.AxWindowsMediaPlayer enemyHitPlayer;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}