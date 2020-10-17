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
            this.lbOrderSummary = new System.Windows.Forms.ListBox();
            this.lblBookSum = new System.Windows.Forms.Label();
            this.lbBookSum = new System.Windows.Forms.ListBox();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lblOrderTotal = new System.Windows.Forms.Label();
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
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblTotal.Location = new System.Drawing.Point(27, 387);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(334, 51);
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
            this.gbPayment.Location = new System.Drawing.Point(27, 441);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(334, 178);
            this.gbPayment.TabIndex = 59;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Options";
            this.toolTip1.SetToolTip(this.gbPayment, "Choose your payment option here");
            // 
            // txtCVV
            // 
            this.txtCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCVV.Location = new System.Drawing.Point(240, 104);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(63, 26);
            this.txtCVV.TabIndex = 4;
            this.txtCVV.Text = "CVV";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExpDate.Location = new System.Drawing.Point(32, 104);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(100, 26);
            this.txtExpDate.TabIndex = 3;
            this.txtExpDate.Text = "MM/YY";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardNum.Location = new System.Drawing.Point(32, 67);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(271, 26);
            this.txtCardNum.TabIndex = 2;
            this.txtCardNum.Text = "Card Number";
            // 
            // rbCash
            // 
            this.rbCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(32, 142);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(129, 24);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Pay at Cinema";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCard.AutoSize = true;
            this.rbCard.Checked = true;
            this.rbCard.Location = new System.Drawing.Point(32, 31);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(149, 24);
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
            this.lblOrderSummary.Location = new System.Drawing.Point(420, 83);
            this.lblOrderSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(205, 31);
            this.lblOrderSummary.TabIndex = 58;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOrderSummary.BackColor = System.Drawing.Color.LightGray;
            this.lbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderSummary.FormattingEnabled = true;
            this.lbOrderSummary.ItemHeight = 20;
            this.lbOrderSummary.Location = new System.Drawing.Point(428, 134);
            this.lbOrderSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(335, 204);
            this.lbOrderSummary.TabIndex = 57;
            this.toolTip1.SetToolTip(this.lbOrderSummary, "Summary of snacks ordered");
            // 
            // lblBookSum
            // 
            this.lblBookSum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBookSum.AutoSize = true;
            this.lblBookSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBookSum.Location = new System.Drawing.Point(20, 83);
            this.lblBookSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookSum.Name = "lblBookSum";
            this.lblBookSum.Size = new System.Drawing.Size(234, 31);
            this.lblBookSum.TabIndex = 56;
            this.lblBookSum.Text = "Booking Summary";
            // 
            // lbBookSum
            // 
            this.lbBookSum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBookSum.BackColor = System.Drawing.Color.LightGray;
            this.lbBookSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSum.FormattingEnabled = true;
            this.lbBookSum.ItemHeight = 20;
            this.lbBookSum.Location = new System.Drawing.Point(27, 134);
            this.lbBookSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbBookSum.Name = "lbBookSum";
            this.lbBookSum.Size = new System.Drawing.Size(335, 204);
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
            this.btnPayNow.Location = new System.Drawing.Point(584, 575);
            this.btnPayNow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(202, 44);
            this.btnPayNow.TabIndex = 61;
            this.btnPayNow.Text = "Check out";
            this.toolTip1.SetToolTip(this.btnPayNow, "Click here to check out");
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(51)))));
            this.pnlTitle.Controls.Add(this.lblAccount);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 76);
            this.pnlTitle.TabIndex = 71;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(4, 14);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(167, 46);
            this.lblAccount.TabIndex = 62;
            this.lblAccount.Text = "Account";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelBooking.BackgroundImage = global::Watchers.Properties.Resources.ButtonDark;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(377, 575);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(202, 44);
            this.btnCancelBooking.TabIndex = 62;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.toolTip1.SetToolTip(this.btnCancelBooking, "Click here to go to previous page");
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblOrderTotal.Location = new System.Drawing.Point(455, 354);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(276, 39);
            this.lblOrderTotal.TabIndex = 72;
            this.lblOrderTotal.Text = "Total: R";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lbOrderSummary);
            this.Controls.Add(this.lblBookSum);
            this.Controls.Add(this.lbBookSum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tabCheckOut";
            this.Size = new System.Drawing.Size(800, 678);
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
        private System.Windows.Forms.ListBox lbOrderSummary;
        private System.Windows.Forms.Label lblBookSum;
        private System.Windows.Forms.ListBox lbBookSum;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label lblOrderTotal;
    }
}
