
namespace CyberScrap
{
    partial class GameWinLose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWinLose));
            this.scoreLbl = new System.Windows.Forms.Label();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreBox = new System.Windows.Forms.PictureBox();
            this.WinLoseBox = new System.Windows.Forms.PictureBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.buttonNoisePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.loseMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.winMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loseMusicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.Color.Red;
            this.scoreLbl.Location = new System.Drawing.Point(514, 164);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(2, 33);
            this.scoreLbl.TabIndex = 5;
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLbl.ForeColor = System.Drawing.Color.Red;
            this.highScoreLbl.Location = new System.Drawing.Point(514, 240);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(2, 33);
            this.highScoreLbl.TabIndex = 6;
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.BackgroundImage = global::CyberScrap.Properties.Resources.TryAgainBtn;
            this.tryAgainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tryAgainBtn.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.tryAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryAgainBtn.Location = new System.Drawing.Point(340, 306);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(144, 88);
            this.tryAgainBtn.TabIndex = 10;
            this.tryAgainBtn.UseVisualStyleBackColor = true;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CyberScrap.Properties.Resources.HighScore;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(183, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 72);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreBox.BackgroundImage = global::CyberScrap.Properties.Resources.Score;
            this.scoreBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scoreBox.Location = new System.Drawing.Point(220, 141);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(183, 72);
            this.scoreBox.TabIndex = 8;
            this.scoreBox.TabStop = false;
            // 
            // WinLoseBox
            // 
            this.WinLoseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WinLoseBox.Location = new System.Drawing.Point(267, 47);
            this.WinLoseBox.Name = "WinLoseBox";
            this.WinLoseBox.Size = new System.Drawing.Size(295, 88);
            this.WinLoseBox.TabIndex = 7;
            this.WinLoseBox.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.BackgroundImage = global::CyberScrap.Properties.Resources.MainMenuBtn;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBtn.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Location = new System.Drawing.Point(514, 306);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(144, 88);
            this.menuBtn.TabIndex = 4;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::CyberScrap.Properties.Resources.QuitGameBtn;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(154, 306);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(144, 88);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // buttonNoisePlayer
            // 
            this.buttonNoisePlayer.Enabled = true;
            this.buttonNoisePlayer.Location = new System.Drawing.Point(716, 357);
            this.buttonNoisePlayer.Name = "buttonNoisePlayer";
            this.buttonNoisePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buttonNoisePlayer.OcxState")));
            this.buttonNoisePlayer.Size = new System.Drawing.Size(58, 51);
            this.buttonNoisePlayer.TabIndex = 17;
            this.buttonNoisePlayer.TabStop = false;
            this.buttonNoisePlayer.Visible = false;
            // 
            // loseMusicPlayer
            // 
            this.loseMusicPlayer.Enabled = true;
            this.loseMusicPlayer.Location = new System.Drawing.Point(716, 179);
            this.loseMusicPlayer.Name = "loseMusicPlayer";
            this.loseMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("loseMusicPlayer.OcxState")));
            this.loseMusicPlayer.Size = new System.Drawing.Size(58, 51);
            this.loseMusicPlayer.TabIndex = 18;
            this.loseMusicPlayer.TabStop = false;
            this.loseMusicPlayer.Visible = false;
            // 
            // winMusicPlayer
            // 
            this.winMusicPlayer.Enabled = true;
            this.winMusicPlayer.Location = new System.Drawing.Point(716, 265);
            this.winMusicPlayer.Name = "winMusicPlayer";
            this.winMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winMusicPlayer.OcxState")));
            this.winMusicPlayer.Size = new System.Drawing.Size(58, 51);
            this.winMusicPlayer.TabIndex = 19;
            this.winMusicPlayer.TabStop = false;
            this.winMusicPlayer.Visible = false;
            // 
            // GameWinLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.winMusicPlayer);
            this.Controls.Add(this.loseMusicPlayer);
            this.Controls.Add(this.buttonNoisePlayer);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.WinLoseBox);
            this.Controls.Add(this.highScoreLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "GameWinLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWinLose";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loseMusicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label highScoreLbl;
        private System.Windows.Forms.PictureBox WinLoseBox;
        private System.Windows.Forms.PictureBox scoreBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tryAgainBtn;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
        private AxWMPLib.AxWindowsMediaPlayer loseMusicPlayer;
        private AxWMPLib.AxWindowsMediaPlayer winMusicPlayer;
    }
}