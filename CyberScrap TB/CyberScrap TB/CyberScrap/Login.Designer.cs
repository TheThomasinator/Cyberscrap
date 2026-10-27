
namespace CyberScrap
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLog = new System.Windows.Forms.Button();
            this.lblLogOrReg = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblNoAcc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainThemePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonNoisePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.AccessibleName = "";
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnLog.BackgroundImage = global::CyberScrap.Properties.Resources.LoginBtn;
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.Color.Transparent;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLog.Location = new System.Drawing.Point(311, 319);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(205, 99);
            this.btnLog.TabIndex = 9;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // lblLogOrReg
            // 
            this.lblLogOrReg.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOrReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogOrReg.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogOrReg.Image = global::CyberScrap.Properties.Resources.PleaseLoginOrRegister;
            this.lblLogOrReg.Location = new System.Drawing.Point(69, 25);
            this.lblLogOrReg.Name = "lblLogOrReg";
            this.lblLogOrReg.Size = new System.Drawing.Size(629, 59);
            this.lblLogOrReg.TabIndex = 1;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnReg.BackgroundImage = global::CyberScrap.Properties.Resources.RegisterBtn;
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.ForeColor = System.Drawing.Color.Transparent;
            this.btnReg.Location = new System.Drawing.Point(26, 319);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(205, 99);
            this.btnReg.TabIndex = 10;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblNoAcc
            // 
            this.lblNoAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblNoAcc.ForeColor = System.Drawing.Color.Transparent;
            this.lblNoAcc.Image = global::CyberScrap.Properties.Resources.NoAccount;
            this.lblNoAcc.Location = new System.Drawing.Point(26, 270);
            this.lblNoAcc.Name = "lblNoAcc";
            this.lblNoAcc.Size = new System.Drawing.Size(205, 46);
            this.lblNoAcc.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnExit.BackgroundImage = global::CyberScrap.Properties.Resources.ExitBtn;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(704, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 61);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(484, 133);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(240, 38);
            this.userBox.TabIndex = 12;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Image = global::CyberScrap.Properties.Resources.Username;
            this.lblUser.Location = new System.Drawing.Point(103, 112);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(337, 76);
            this.lblUser.TabIndex = 11;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passBox.Location = new System.Drawing.Point(484, 204);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(240, 38);
            this.passBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::CyberScrap.Properties.Resources.Password;
            this.label1.Location = new System.Drawing.Point(103, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 61);
            this.label1.TabIndex = 13;
            // 
            // mainThemePlayer
            // 
            this.mainThemePlayer.Enabled = true;
            this.mainThemePlayer.Location = new System.Drawing.Point(650, 349);
            this.mainThemePlayer.Name = "mainThemePlayer";
            this.mainThemePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainThemePlayer.OcxState")));
            this.mainThemePlayer.Size = new System.Drawing.Size(58, 51);
            this.mainThemePlayer.TabIndex = 15;
            this.mainThemePlayer.TabStop = false;
            this.mainThemePlayer.Visible = false;
            // 
            // buttonNoisePlayer
            // 
            this.buttonNoisePlayer.Enabled = true;
            this.buttonNoisePlayer.Location = new System.Drawing.Point(735, 349);
            this.buttonNoisePlayer.Name = "buttonNoisePlayer";
            this.buttonNoisePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buttonNoisePlayer.OcxState")));
            this.buttonNoisePlayer.Size = new System.Drawing.Size(58, 51);
            this.buttonNoisePlayer.TabIndex = 16;
            this.buttonNoisePlayer.TabStop = false;
            this.buttonNoisePlayer.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CyberScrap.Properties.Resources.RegisterAndLoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNoisePlayer);
            this.Controls.Add(this.mainThemePlayer);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblNoAcc);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lblLogOrReg);
            this.Controls.Add(this.btnLog);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainThemePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoisePlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblLogOrReg;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblNoAcc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer mainThemePlayer;
        private AxWMPLib.AxWindowsMediaPlayer buttonNoisePlayer;
    }
}

