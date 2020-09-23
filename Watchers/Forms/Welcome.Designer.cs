namespace Watchers
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.imgLogoWel = new System.Windows.Forms.PictureBox();
            this.imgGradientWel = new System.Windows.Forms.PictureBox();
            this.pnlRegister = new ns1.BunifuGradientPanel();
            this.lblRegisterNow = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoWel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientWel)).BeginInit();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(345, 341);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(319, 51);
            this.pnlLogin.TabIndex = 13;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblLogin.Location = new System.Drawing.Point(72, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(176, 51);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // imgLogoWel
            // 
            this.imgLogoWel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogoWel.BackColor = System.Drawing.Color.White;
            this.imgLogoWel.Image = global::Watchers.Properties.Resources.Watchers2;
            this.imgLogoWel.Location = new System.Drawing.Point(319, 120);
            this.imgLogoWel.Name = "imgLogoWel";
            this.imgLogoWel.Size = new System.Drawing.Size(372, 151);
            this.imgLogoWel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoWel.TabIndex = 17;
            this.imgLogoWel.TabStop = false;
            this.imgLogoWel.Click += new System.EventHandler(this.imgLogoWel_Click);
            // 
            // imgGradientWel
            // 
            this.imgGradientWel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgGradientWel.Image = global::Watchers.Properties.Resources.GradientNew1;
            this.imgGradientWel.Location = new System.Drawing.Point(0, 0);
            this.imgGradientWel.Name = "imgGradientWel";
            this.imgGradientWel.Size = new System.Drawing.Size(1012, 169);
            this.imgGradientWel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGradientWel.TabIndex = 16;
            this.imgGradientWel.TabStop = false;
            this.imgGradientWel.Click += new System.EventHandler(this.imgGradientWel_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRegister.BackgroundImage")));
            this.pnlRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegister.Controls.Add(this.lblRegisterNow);
            this.pnlRegister.ForeColor = System.Drawing.Color.White;
            this.pnlRegister.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlRegister.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlRegister.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlRegister.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlRegister.Location = new System.Drawing.Point(345, 424);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Quality = 10;
            this.pnlRegister.Size = new System.Drawing.Size(319, 51);
            this.pnlRegister.TabIndex = 15;
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // lblRegisterNow
            // 
            this.lblRegisterNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterNow.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterNow.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblRegisterNow.Location = new System.Drawing.Point(41, 0);
            this.lblRegisterNow.Name = "lblRegisterNow";
            this.lblRegisterNow.Size = new System.Drawing.Size(250, 51);
            this.lblRegisterNow.TabIndex = 6;
            this.lblRegisterNow.Text = "Register Now";
            this.lblRegisterNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegisterNow.Click += new System.EventHandler(this.lblRegisterNow_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.imgLogoWel);
            this.Controls.Add(this.imgGradientWel);
            this.Controls.Add(this.pnlRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoWel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientWel)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox imgLogoWel;
        private System.Windows.Forms.PictureBox imgGradientWel;
        private ns1.BunifuGradientPanel pnlRegister;
        private System.Windows.Forms.Label lblRegisterNow;
    }
}

