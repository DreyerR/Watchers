namespace Watchers
{
    partial class tabCheckOut
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
            this.lblCheckoutBTN = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lsOrderSummary = new System.Windows.Forms.ListBox();
            this.lblBookSum = new System.Windows.Forms.Label();
            this.lbBookSum = new System.Windows.Forms.ListBox();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbPayment.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCheckoutBTN
            // 
            this.lblCheckoutBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckoutBTN.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCheckoutBTN.Location = new System.Drawing.Point(0, 0);
            this.lblCheckoutBTN.Name = "lblCheckoutBTN";
            this.lblCheckoutBTN.Size = new System.Drawing.Size(333, 67);
            this.lblCheckoutBTN.TabIndex = 27;
            this.lblCheckoutBTN.Text = "Pay now";
            this.lblCheckoutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCheckoutBTN.Click += new System.EventHandler(this.lblCheckoutBTN_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblTotal.Location = new System.Drawing.Point(36, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(223, 63);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "Total: R";
            // 
            // gbPayment
            // 
            this.gbPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbPayment.BackColor = System.Drawing.Color.LightGray;
            this.gbPayment.Controls.Add(this.txtCVV);
            this.gbPayment.Controls.Add(this.txtExpDate);
            this.gbPayment.Controls.Add(this.txtCardNum);
            this.gbPayment.Controls.Add(this.rbCash);
            this.gbPayment.Controls.Add(this.rbCard);
            this.gbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayment.Location = new System.Drawing.Point(36, 543);
            this.gbPayment.Margin = new System.Windows.Forms.Padding(4);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Padding = new System.Windows.Forms.Padding(4);
            this.gbPayment.Size = new System.Drawing.Size(445, 219);
            this.gbPayment.TabIndex = 59;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Options";
            this.toolTip1.SetToolTip(this.gbPayment, "Choose your payment option here");
            // 
            // txtCVV
            // 
            this.txtCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCVV.Location = new System.Drawing.Point(320, 128);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(83, 30);
            this.txtCVV.TabIndex = 4;
            this.txtCVV.Text = "CVV";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExpDate.Location = new System.Drawing.Point(43, 128);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(132, 30);
            this.txtExpDate.TabIndex = 3;
            this.txtExpDate.Text = "MM/YY";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardNum.Location = new System.Drawing.Point(43, 83);
            this.txtCardNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(360, 30);
            this.txtCardNum.TabIndex = 2;
            this.txtCardNum.Text = "Card Number";
            // 
            // rbCash
            // 
            this.rbCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(43, 175);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(161, 29);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Pay at Cinema";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(43, 38);
            this.rbCard.Margin = new System.Windows.Forms.Padding(4);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(184, 29);
            this.rbCard.TabIndex = 0;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Debit/Credit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblOrderSummary.Location = new System.Drawing.Point(560, 102);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(257, 39);
            this.lblOrderSummary.TabIndex = 58;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // lsOrderSummary
            // 
            this.lsOrderSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lsOrderSummary.BackColor = System.Drawing.Color.LightGray;
            this.lsOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsOrderSummary.FormattingEnabled = true;
            this.lsOrderSummary.ItemHeight = 25;
            this.lsOrderSummary.Location = new System.Drawing.Point(570, 165);
            this.lsOrderSummary.Name = "lsOrderSummary";
            this.lsOrderSummary.Size = new System.Drawing.Size(445, 254);
            this.lsOrderSummary.TabIndex = 57;
            this.toolTip1.SetToolTip(this.lsOrderSummary, "Summary of snacks ordered");
            // 
            // lblBookSum
            // 
            this.lblBookSum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBookSum.AutoSize = true;
            this.lblBookSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBookSum.Location = new System.Drawing.Point(26, 102);
            this.lblBookSum.Name = "lblBookSum";
            this.lblBookSum.Size = new System.Drawing.Size(295, 39);
            this.lblBookSum.TabIndex = 56;
            this.lblBookSum.Text = "Booking Summary";
            // 
            // lbBookSum
            // 
            this.lbBookSum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBookSum.BackColor = System.Drawing.Color.LightGray;
            this.lbBookSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSum.FormattingEnabled = true;
            this.lbBookSum.ItemHeight = 25;
            this.lbBookSum.Location = new System.Drawing.Point(32, 165);
            this.lbBookSum.Name = "lbBookSum";
            this.lbBookSum.Size = new System.Drawing.Size(445, 254);
            this.lbBookSum.TabIndex = 55;
            this.toolTip1.SetToolTip(this.lbBookSum, "Summary of booking made");
            // 
            // btnPayNow
            // 
            this.btnPayNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayNow.BackColor = System.Drawing.Color.Transparent;
            this.btnPayNow.BackgroundImage = global::Watchers.Properties.Resources.ButtonGrad;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(490, 764);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(270, 54);
            this.btnPayNow.TabIndex = 61;
            this.btnPayNow.Text = "Check out";
            this.toolTip1.SetToolTip(this.btnPayNow, "Click here to check out");
            this.btnPayNow.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Watchers.Properties.Resources.ButtonDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(766, 764);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(270, 54);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.toolTip1.SetToolTip(this.btnBack, "Click here to go to previous page");
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(51)))));
            this.pnlTitle.Controls.Add(this.lblAccount);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1066, 94);
            this.pnlTitle.TabIndex = 71;
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
            // tabCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lsOrderSummary);
            this.Controls.Add(this.lblBookSum);
            this.Controls.Add(this.lbBookSum);
            this.Name = "tabCheckOut";
            this.Size = new System.Drawing.Size(1066, 835);
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCheckoutBTN;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.ListBox lsOrderSummary;
        private System.Windows.Forms.Label lblBookSum;
        private System.Windows.Forms.ListBox lbBookSum;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
