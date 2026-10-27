
namespace CyberScrap
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnReg = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblComf = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainThemePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonNoisePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnReg.BackgroundImage = global::CyberScrap.Properties.Resources.RegisterBtn;
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReg.Location = new System.Drawing.Point(311, 319);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(205, 99);
            this.btnReg.TabIndex = 0;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblReg
            // 
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Image = global::CyberScrap.Properties.Resources.Please_register;
            this.lblReg.Location = new System.Drawing.Point(149, 29);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(539, 67);
            this.lblReg.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Image = global::CyberScrap.Properties.Resources.Username;
            this.lblUser.Location = new System.Drawing.Point(110, 113);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(337, 76);
            this.lblUser.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.ForeColor = System.Drawing.Color.Transparent;
            this.lblPass.Image = global::CyberScrap.Properties.Resources.Password;
            this.lblPass.Location = new System.Drawing.Point(110, 177);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(339, 61);
            this.lblPass.TabIndex = 3;
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(491, 134);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(240, 38);
            this.userBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passBox.Location = new System.Drawing.Point(491, 189);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(240, 38);
            this.passBox.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox3.Location = new System.Drawing.Point(491, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(240, 38);
            this.textBox3.TabIndex = 7;
            // 
            // lblComf
            // 
            this.lblComf.BackColor = System.Drawing.Color.Transparent;
            this.lblComf.Image = global::CyberScrap.Properties.Resources.ConfirmPassword;
            this.lblComf.Location = new System.Drawing.Point(66, 245);
            this.lblComf.Name = "lblComf";
            this.lblComf.Size = new System.Drawing.Size(419, 47);
            this.lblComf.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnBack.BackgroundImage = global::CyberScrap.Properties.Resources.BackBtn;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Indigo;
            this.btnBack.Location = new System.Drawing.Point(704, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 72);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mainThemePlayer
            // 
            this.mainThemePlayer.Enabled = true;
            this.mainThemePlayer.Location = new System.Drawing.Point(654, 355);
            this.mainThemePlayer.Name = "mainThemePlayer";
            this.mainThemePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainThemePlayer.OcxState")));
            this.mainThemePlayer.Size = new System.Drawing.Size(58, 51);
            this.mainThemePlayer.TabIndex = 16;
            this.mainThemePlayer.TabStop = false;
            this.mainThemePlayer.Visible = false;
            // 
            // buttonNoisePlayer
            // 
            this.buttonNoisePlayer.Enabled = true;
            this.buttonNoisePlayer.Location = new System.Drawing.Point(735, 355);
            this.buttonNoisePlayer.Name = "buttonNoisePlayer";
            this.buttonNoisePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buttonNoisePlayer.OcxState")));
            this.buttonNoisePlayer.Size = new System.Drawing.Size(58, 51);
            this.buttonNoisePlayer.TabIndex = 17;
            this.buttonNoisePlayer.TabStop = false;
            this.buttonNoisePlayer.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CyberScrap.Properties.Resources.RegisterAndLoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNoisePlayer);
            this.Controls.Add(this.mainThemePlayer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblComf);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnReg);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblComf;
        private System.Windows.Forms.Button btnBack;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
    }
}