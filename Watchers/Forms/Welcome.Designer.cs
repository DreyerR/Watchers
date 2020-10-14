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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imgLogoWel = new System.Windows.Forms.PictureBox();
            this.imgGradientWel = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoWel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientWel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImage = global::Watchers.Properties.Resources.ButtonGrad;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(372, 417);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(270, 54);
            this.btnRegister.TabIndex = 31;
            this.btnRegister.Text = "Register Now";
            this.toolTip1.SetToolTip(this.btnRegister, "Click here to go to the register page to register as a new user");
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::Watchers.Properties.Resources.ButtonLight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(372, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 54);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Login";
            this.toolTip1.SetToolTip(this.btnLogin, "Click here to go to the log in page");
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.imgLogoWel);
            this.Controls.Add(this.imgGradientWel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoWel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientWel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogoWel;
        private System.Windows.Forms.PictureBox imgGradientWel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

