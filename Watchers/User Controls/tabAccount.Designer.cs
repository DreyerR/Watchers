namespace Watchers
{
    partial class tabAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.tblLayoutAccount = new System.Windows.Forms.TableLayoutPanel();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tblLayoutAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageAccount
            // 
            this.lblManageAccount.AutoSize = true;
            this.lblManageAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblManageAccount.Location = new System.Drawing.Point(3, 0);
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Size = new System.Drawing.Size(417, 83);
            this.lblManageAccount.TabIndex = 65;
            this.lblManageAccount.Text = "Manage Account";
            this.lblManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblName.Location = new System.Drawing.Point(7, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(409, 62);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "NAME SURNAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(5, 17);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(206, 58);
            this.lblAccount.TabIndex = 62;
            this.lblAccount.Text = "Account";
            // 
            // tblLayoutAccount
            // 
            this.tblLayoutAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutAccount.ColumnCount = 1;
            this.tblLayoutAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutAccount.Controls.Add(this.btnDeleteBooking, 0, 4);
            this.tblLayoutAccount.Controls.Add(this.lblManageAccount, 0, 0);
            this.tblLayoutAccount.Controls.Add(this.lblName, 0, 1);
            this.tblLayoutAccount.Controls.Add(this.btnPersonalInfo, 0, 2);
            this.tblLayoutAccount.Controls.Add(this.btnDeleteAcc, 0, 3);
            this.tblLayoutAccount.Location = new System.Drawing.Point(508, 208);
            this.tblLayoutAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayoutAccount.Name = "tblLayoutAccount";
            this.tblLayoutAccount.RowCount = 5;
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutAccount.Size = new System.Drawing.Size(423, 366);
            this.tblLayoutAccount.TabIndex = 69;
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalInfo.BackgroundImage = global::Watchers.Properties.Resources.ButtonLight;
            this.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.Location = new System.Drawing.Point(57, 170);
            this.btnPersonalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(309, 52);
            this.btnPersonalInfo.TabIndex = 70;
            this.btnPersonalInfo.Text = "Personal Information";
            this.toolTip1.SetToolTip(this.btnPersonalInfo, "Click here to change your personal information");
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAcc.BackgroundImage = global::Watchers.Properties.Resources.ButtonLight;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDeleteAcc.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAcc.Location = new System.Drawing.Point(58, 233);
            this.btnDeleteAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(307, 54);
            this.btnDeleteAcc.TabIndex = 71;
            this.btnDeleteAcc.Text = "Delete Account";
            this.toolTip1.SetToolTip(this.btnDeleteAcc, "Click here to permanently delete your account ");
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lblAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 75);
            this.panel1.TabIndex = 70;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBooking.BackgroundImage = global::Watchers.Properties.Resources.ButtonLight;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Location = new System.Drawing.Point(58, 299);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(307, 54);
            this.btnDeleteBooking.TabIndex = 72;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.toolTip1.SetToolTip(this.btnDeleteBooking, "Click here to permanently delete your account ");
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-19, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblLayoutAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tabAccount";
            this.Size = new System.Drawing.Size(1364, 811);
            this.Load += new System.EventHandler(this.tabAccount_Load);
            this.tblLayoutAccount.ResumeLayout(false);
            this.tblLayoutAccount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblManageAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TableLayoutPanel tblLayoutAccount;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button button1;
    }
}
