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
            this.lblBookSum = new System.Windows.Forms.Label();
            this.lbBookSum = new System.Windows.Forms.ListBox();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lvOrderSummary = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.checkOut_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMovieTotal = new System.Windows.Forms.Label();
            this.gbPayment.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOut_error)).BeginInit();
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
            this.txtCVV.Click += new System.EventHandler(this.TextFieldClick);
            // 
            // txtExpDate
            // 
            this.txtExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExpDate.Location = new System.Drawing.Point(32, 104);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(100, 26);
            this.txtExpDate.TabIndex = 3;
            this.txtExpDate.Text = "MM/YY";
            this.txtExpDate.Click += new System.EventHandler(this.TextFieldClick);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardNum.Location = new System.Drawing.Point(32, 67);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(271, 26);
            this.txtCardNum.TabIndex = 2;
            this.txtCardNum.Text = "Card Number";
            this.txtCardNum.Click += new System.EventHandler(this.TextFieldClick);
            // 
            // rbCash
            // 
            this.rbCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCash.Location = new System.Drawing.Point(32, 136);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(116, 36);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Pay Cash";
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
            this.lbBookSum.BackColor = System.Drawing.SystemColors.Window;
            this.lbBookSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSum.FormattingEnabled = true;
            this.lbBookSum.ItemHeight = 20;
            this.lbBookSum.Location = new System.Drawing.Point(27, 134);
            this.lbBookSum.Margin = new System.Windows.Forms.Padding(2);
            this.lbBookSum.Name = "lbBookSum";
            this.lbBookSum.Size = new System.Drawing.Size(335, 164);
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
            this.btnPayNow.Location = new System.Drawing.Point(802, 575);
            this.btnPayNow.Margin = new System.Windows.Forms.Padding(2);
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
            this.pnlTitle.Size = new System.Drawing.Size(1018, 76);
            this.pnlTitle.TabIndex = 71;
            // 
            // lblAccount
            // 
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(0, 0);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(1018, 76);
            this.lblAccount.TabIndex = 62;
            this.lblAccount.Text = "Booking Summary";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelBooking.BackgroundImage = global::Watchers.Properties.Resources.ButtonDark;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(595, 575);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(202, 44);
            this.btnCancelBooking.TabIndex = 62;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.toolTip1.SetToolTip(this.btnCancelBooking, "Click here to go to previous page");
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // lvOrderSummary
            // 
            this.lvOrderSummary.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvOrderSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvOrderSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price});
            this.lvOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOrderSummary.HideSelection = false;
            this.lvOrderSummary.HoverSelection = true;
            this.lvOrderSummary.Location = new System.Drawing.Point(426, 134);
            this.lvOrderSummary.Name = "lvOrderSummary";
            this.lvOrderSummary.Size = new System.Drawing.Size(573, 187);
            this.lvOrderSummary.TabIndex = 100;
            this.lvOrderSummary.UseCompatibleStateImageBehavior = false;
            this.lvOrderSummary.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Name = "tabCheckOut";
            this.Name.Text = "Name";
            this.Name.Width = 300;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 120;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblOrderTotal.Location = new System.Drawing.Point(505, 322);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(385, 39);
            this.lblOrderTotal.TabIndex = 72;
            this.lblOrderTotal.Text = "Total: R";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkOut_error
            // 
            this.checkOut_error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.checkOut_error.ContainerControl = this;
            // 
            // lblMovieTotal
            // 
            this.lblMovieTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMovieTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(51)))));
            this.lblMovieTotal.Location = new System.Drawing.Point(20, 322);
            this.lblMovieTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieTotal.Name = "lblMovieTotal";
            this.lblMovieTotal.Size = new System.Drawing.Size(385, 39);
            this.lblMovieTotal.TabIndex = 101;
            this.lblMovieTotal.Text = "Total: R";
            this.lblMovieTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMovieTotal);
            this.Controls.Add(this.lvOrderSummary);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblBookSum);
            this.Controls.Add(this.lbBookSum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name.Name = "tabCheckOut";
            this.Size = new System.Drawing.Size(1018, 678);
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkOut_error)).EndInit();
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
        private System.Windows.Forms.Label lblBookSum;
        private System.Windows.Forms.ListBox lbBookSum;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.ErrorProvider checkOut_error;
        private System.Windows.Forms.ListView lvOrderSummary;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        public System.Windows.Forms.Label lblMovieTotal;
        public System.Windows.Forms.Label lblOrderTotal;
    }
}
