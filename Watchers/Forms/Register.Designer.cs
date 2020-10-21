namespace Watchers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblNewUser = new System.Windows.Forms.Label();
            this.imgGradientWel = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPW = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientWel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewUser
            // 
            this.lblNewUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNewUser.Location = new System.Drawing.Point(351, 212);
            this.lblNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(285, 40);
            this.lblNewUser.TabIndex = 36;
            this.lblNewUser.Text = "New User";
            this.lblNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgGradientWel
            // 
            this.imgGradientWel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgGradientWel.Image = global::Watchers.Properties.Resources.GradientNew1;
            this.imgGradientWel.Location = new System.Drawing.Point(0, 0);
            this.imgGradientWel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgGradientWel.Name = "imgGradientWel";
            this.imgGradientWel.Size = new System.Drawing.Size(1006, 134);
            this.imgGradientWel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGradientWel.TabIndex = 39;
            this.imgGradientWel.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.White;
            this.imgLogo.Image = global::Watchers.Properties.Resources.Watchers2;
            this.imgLogo.Location = new System.Drawing.Point(357, 83);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(279, 123);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 40;
            this.imgLogo.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(334, 279);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 26);
            this.txtName.TabIndex = 41;
            this.toolTip1.SetToolTip(this.txtName, "Enter your name here");
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSurname.Location = new System.Drawing.Point(334, 340);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(318, 26);
            this.txtSurname.TabIndex = 42;
            this.toolTip1.SetToolTip(this.txtSurname, "Enter your surname here");
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(334, 399);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 26);
            this.txtEmail.TabIndex = 43;
            this.toolTip1.SetToolTip(this.txtEmail, "Enter your email address here");
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(334, 456);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(318, 26);
            this.txtPassword.TabIndex = 44;
            this.toolTip1.SetToolTip(this.txtPassword, "Choose a password and enter it here");
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(334, 518);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(318, 26);
            this.txtConfirmPassword.TabIndex = 45;
            this.toolTip1.SetToolTip(this.txtConfirmPassword, "Re-enter your password to confirm that they match");
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(330, 252);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurname.Location = new System.Drawing.Point(330, 313);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(89, 24);
            this.lblSurname.TabIndex = 47;
            this.lblSurname.Text = "Surname:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(330, 372);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(122, 24);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(330, 430);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 24);
            this.lblPassword.TabIndex = 49;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPW
            // 
            this.lblConfirmPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConfirmPW.Location = new System.Drawing.Point(330, 491);
            this.lblConfirmPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPW.Name = "lblConfirmPW";
            this.lblConfirmPW.Size = new System.Drawing.Size(153, 24);
            this.lblConfirmPW.TabIndex = 50;
            this.lblConfirmPW.Text = "Confirm Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImage = global::Watchers.Properties.Resources.ButtonGrad;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(387, 570);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 44);
            this.btnRegister.TabIndex = 51;
            this.btnRegister.Text = "Register";
            this.toolTip1.SetToolTip(this.btnRegister, "Click here to register as a new user");
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1006, 637);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblConfirmPW);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.imgGradientWel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 683);
            this.MinimumSize = new System.Drawing.Size(1022, 597);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGradientWel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.PictureBox imgGradientWel;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPW;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}