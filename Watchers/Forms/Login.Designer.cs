namespace Watchers
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPassword = new ns1.BunifuMaterialTextbox();
            this.txtUsername = new ns1.BunifuMaterialTextbox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.pnlLogin = new ns1.BunifuGradientPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.imgLogoLog = new System.Windows.Forms.PictureBox();
            this.imgGradientLog = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 5;
            this.txtPassword.Location = new System.Drawing.Point(357, 420);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(376, 62);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Text = "testpass123";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HintForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsername.LineThickness = 5;
            this.txtUsername.Location = new System.Drawing.Point(357, 328);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(376, 62);
            this.txtUsername.TabIndex = 22;
            this.txtUsername.Text = "rdreyer@gmail.com";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblForgotPassword.Location = new System.Drawing.Point(466, 489);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(159, 25);
            this.lblForgotPassword.TabIndex = 26;
            this.lblForgotPassword.Text = "Forgot Password";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlLogin.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlLogin.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlLogin.Location = new System.Drawing.Point(409, 598);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Quality = 10;
            this.pnlLogin.Size = new System.Drawing.Size(273, 51);
            this.pnlLogin.TabIndex = 25;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblLogin.Location = new System.Drawing.Point(3, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(270, 51);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // imgLogoLog
            // 
            this.imgLogoLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogoLog.BackColor = System.Drawing.Color.White;
            this.imgLogoLog.Image = global::Watchers.Properties.Resources.Watchers2;
            this.imgLogoLog.Location = new System.Drawing.Point(322, 91);
            this.imgLogoLog.Name = "imgLogoLog";
            this.imgLogoLog.Size = new System.Drawing.Size(422, 170);
            this.imgLogoLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoLog.TabIndex = 21;
            this.imgLogoLog.TabStop = false;
            // 
            // imgGradientLog
            // 
            this.imgGradientLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgGradientLog.Image = global::Watchers.Properties.Resources.GradientNew;
            this.imgGradientLog.Location = new System.Drawing.Point(0, 0);
            this.imgGradientLog.Name = "imgGradientLog";
            this.imgGradientLog.Size = new System.Drawing.Size(1012, 169);
            this.imgGradientLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGradientLog.TabIndex = 20;
            this.imgGradientLog.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1012, 699);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.imgLogoLog);
            this.Controls.Add(this.imgGradientLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuMaterialTextbox txtPassword;
        private ns1.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Label lblForgotPassword;
        private ns1.BunifuGradientPanel pnlLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox imgLogoLog;
        private System.Windows.Forms.PictureBox imgGradientLog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}