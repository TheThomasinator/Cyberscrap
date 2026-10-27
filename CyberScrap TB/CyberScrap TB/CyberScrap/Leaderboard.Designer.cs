
namespace CyberScrap
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.highScoreTbl = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.mainThemePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonNoisePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // highScoreTbl
            // 
            this.highScoreTbl.AllowUserToAddRows = false;
            this.highScoreTbl.AllowUserToDeleteRows = false;
            this.highScoreTbl.AllowUserToResizeColumns = false;
            this.highScoreTbl.AllowUserToResizeRows = false;
            this.highScoreTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.highScoreTbl.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.highScoreTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.highScoreTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highScoreTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.score,
            this.character});
            this.highScoreTbl.GridColor = System.Drawing.Color.Indigo;
            this.highScoreTbl.Location = new System.Drawing.Point(1, 2);
            this.highScoreTbl.Name = "highScoreTbl";
            this.highScoreTbl.ReadOnly = true;
            this.highScoreTbl.Size = new System.Drawing.Size(797, 371);
            this.highScoreTbl.TabIndex = 0;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // score
            // 
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // character
            // 
            this.character.HeaderText = "Character";
            this.character.Name = "character";
            this.character.ReadOnly = true;
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackgroundImage = global::CyberScrap.Properties.Resources.MainMenuBtn;
            this.mainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn.ForeColor = System.Drawing.Color.Transparent;
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 379);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(116, 65);
            this.mainMenuBtn.TabIndex = 1;
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainThemePlayer
            // 
            this.mainThemePlayer.Enabled = true;
            this.mainThemePlayer.Location = new System.Drawing.Point(730, 387);
            this.mainThemePlayer.Name = "mainThemePlayer";
            this.mainThemePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainThemePlayer.OcxState")));
            this.mainThemePlayer.Size = new System.Drawing.Size(58, 51);
            this.mainThemePlayer.TabIndex = 17;
            this.mainThemePlayer.TabStop = false;
            this.mainThemePlayer.Visible = false;
            // 
            // buttonNoisePlayer
            // 
            this.buttonNoisePlayer.Enabled = true;
            this.buttonNoisePlayer.Location = new System.Drawing.Point(643, 393);
            this.buttonNoisePlayer.Name = "buttonNoisePlayer";
            this.buttonNoisePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buttonNoisePlayer.OcxState")));
            this.buttonNoisePlayer.Size = new System.Drawing.Size(58, 51);
            this.buttonNoisePlayer.TabIndex = 18;
            this.buttonNoisePlayer.TabStop = false;
            this.buttonNoisePlayer.Visible = false;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNoisePlayer);
            this.Controls.Add(this.mainThemePlayer);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.highScoreTbl);
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.highScoreTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView highScoreTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn character;
        private System.Windows.Forms.Button mainMenuBtn;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
    }
}