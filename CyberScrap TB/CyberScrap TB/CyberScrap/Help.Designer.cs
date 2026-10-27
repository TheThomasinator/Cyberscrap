
namespace CyberScrap
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.controlBox = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainThemePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonNoisePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.controlBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Image = global::CyberScrap.Properties.Resources.ControlsImage;
            this.controlBox.Location = new System.Drawing.Point(167, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(461, 448);
            this.controlBox.TabIndex = 11;
            this.controlBox.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::CyberScrap.Properties.Resources.BackBtn;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(665, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 74);
            this.btnBack.TabIndex = 12;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mainThemePlayer
            // 
            this.mainThemePlayer.Enabled = true;
            this.mainThemePlayer.Location = new System.Drawing.Point(695, 252);
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
            this.buttonNoisePlayer.Location = new System.Drawing.Point(704, 339);
            this.buttonNoisePlayer.Name = "buttonNoisePlayer";
            this.buttonNoisePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buttonNoisePlayer.OcxState")));
            this.buttonNoisePlayer.Size = new System.Drawing.Size(58, 51);
            this.buttonNoisePlayer.TabIndex = 18;
            this.buttonNoisePlayer.TabStop = false;
            this.buttonNoisePlayer.Visible = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNoisePlayer);
            this.Controls.Add(this.mainThemePlayer);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.btnBack);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.controlBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox controlBox;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
    }
}