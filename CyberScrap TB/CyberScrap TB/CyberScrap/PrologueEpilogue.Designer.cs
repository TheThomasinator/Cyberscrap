namespace CyberScrap
{
    partial class Prologue_Epilogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prologue_Epilogue));
            this.storyLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.skipBtn = new System.Windows.Forms.Button();
            this.mainThemePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonNoisePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.winMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // storyLbl
            // 
            this.storyLbl.BackColor = System.Drawing.Color.Transparent;
            this.storyLbl.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLbl.ForeColor = System.Drawing.Color.Cyan;
            this.storyLbl.Location = new System.Drawing.Point(12, 562);
            this.storyLbl.Name = "storyLbl";
            this.storyLbl.Size = new System.Drawing.Size(1437, 159);
            this.storyLbl.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skipBtn
            // 
            this.skipBtn.BackColor = System.Drawing.Color.Sienna;
            this.skipBtn.BackgroundImage = global::CyberScrap.Properties.Resources.SkipBtn;
            this.skipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skipBtn.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.skipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipBtn.Location = new System.Drawing.Point(1336, 12);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(113, 69);
            this.skipBtn.TabIndex = 13;
            this.skipBtn.TabStop = false;
            this.skipBtn.UseVisualStyleBackColor = false;
            this.skipBtn.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // mainThemePlayer
            // 
            this.mainThemePlayer.Enabled = true;
            this.mainThemePlayer.Location = new System.Drawing.Point(701, 340);
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
            this.buttonNoisePlayer.Location = new System.Drawing.Point(829, 362);
            this.buttonNoisePlayer.Name = "buttonNoisePlayer";
            this.buttonNoisePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buttonNoisePlayer.OcxState")));
            this.buttonNoisePlayer.Size = new System.Drawing.Size(58, 51);
            this.buttonNoisePlayer.TabIndex = 18;
            this.buttonNoisePlayer.TabStop = false;
            this.buttonNoisePlayer.Visible = false;
            // 
            // winMusicPlayer
            // 
            this.winMusicPlayer.Enabled = true;
            this.winMusicPlayer.Location = new System.Drawing.Point(754, 459);
            this.winMusicPlayer.Name = "winMusicPlayer";
            this.winMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winMusicPlayer.OcxState")));
            this.winMusicPlayer.Size = new System.Drawing.Size(58, 51);
            this.winMusicPlayer.TabIndex = 20;
            this.winMusicPlayer.TabStop = false;
            this.winMusicPlayer.Visible = false;
            // 
            // Prologue_Epilogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1461, 730);
            this.ControlBox = false;
            this.Controls.Add(this.winMusicPlayer);
            this.Controls.Add(this.buttonNoisePlayer);
            this.Controls.Add(this.mainThemePlayer);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.storyLbl);
            this.DoubleBuffered = true;
            this.Name = "Prologue_Epilogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prologue_Epilogue";
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMusicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storyLbl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button skipBtn;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
        private AxWMPLib.AxWindowsMediaPlayer winMusicPlayer;
    }
}