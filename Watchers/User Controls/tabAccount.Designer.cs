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
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.tblLayoutAccount = new System.Windows.Forms.TableLayoutPanel();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.tblLayoutAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageAccount
            // 
            this.lblManageAccount.AutoSize = true;
            this.lblManageAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManageAccount.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblManageAccount.Location = new System.Drawing.Point(3, 0);
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Size = new System.Drawing.Size(372, 123);
            this.lblManageAccount.TabIndex = 65;
            this.lblManageAccount.Text = "Manage Account";
            this.lblManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblName.Location = new System.Drawing.Point(28, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(322, 62);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "NAME SURNAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccount.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblAccount.Location = new System.Drawing.Point(0, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(248, 88);
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
            this.tblLayoutAccount.Controls.Add(this.lblManageAccount, 0, 0);
            this.tblLayoutAccount.Controls.Add(this.lblName, 0, 1);
            this.tblLayoutAccount.Controls.Add(this.btnPersonalInfo, 0, 2);
            this.tblLayoutAccount.Controls.Add(this.btnDeleteAcc, 0, 3);
            this.tblLayoutAccount.Location = new System.Drawing.Point(400, 134);
            this.tblLayoutAccount.Name = "tblLayoutAccount";
            this.tblLayoutAccount.RowCount = 4;
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tblLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutAccount.Size = new System.Drawing.Size(378, 369);
            this.tblLayoutAccount.TabIndex = 69;
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalInfo.BackgroundImage = global::Watchers.Properties.Resources.ButtonLight;
            this.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalInfo.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.Location = new System.Drawing.Point(34, 253);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(309, 52);
            this.btnPersonalInfo.TabIndex = 70;
            this.btnPersonalInfo.Text = "Personal Information";
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAcc.BackgroundImage = global::Watchers.Properties.Resources.ButtonLight;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnDeleteAcc.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAcc.Location = new System.Drawing.Point(35, 311);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(307, 54);
            this.btnDeleteAcc.TabIndex = 71;
            this.btnDeleteAcc.Text = "Delete Account";
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            // 
            // tabAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutAccount);
            this.Controls.Add(this.lblAccount);
            this.Name = "tabAccount";
            this.Size = new System.Drawing.Size(1140, 805);
            this.Load += new System.EventHandler(this.tabAccount_Load);
            this.tblLayoutAccount.ResumeLayout(false);
            this.tblLayoutAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblManageAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TableLayoutPanel tblLayoutAccount;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnDeleteAcc;
    }
}
