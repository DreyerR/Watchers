namespace Watchers
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.lblCheckout = new System.Windows.Forms.Label();
            this.pnlCheckout = new ns1.BunifuGradientPanel();
            this.btnLogOutMM = new System.Windows.Forms.Button();
            this.imgCheckout = new System.Windows.Forms.PictureBox();
            this.lbBookSum = new System.Windows.Forms.ListBox();
            this.lblBookSum = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lsOrderSummary = new System.Windows.Forms.ListBox();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlCheckoutBTN = new ns1.BunifuGradientPanel();
            this.lblCheckoutBTN = new System.Windows.Forms.Label();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckout)).BeginInit();
            this.gbPayment.SuspendLayout();
            this.pnlCheckoutBTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCheckout
            // 
            this.lblCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(664, 38);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(278, 88);
            this.lblCheckout.TabIndex = 45;
            this.lblCheckout.Text = "Checkout";
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCheckout.BackgroundImage")));
            this.pnlCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCheckout.Controls.Add(this.btnLogOutMM);
            this.pnlCheckout.Controls.Add(this.imgCheckout);
            this.pnlCheckout.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlCheckout.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlCheckout.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlCheckout.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlCheckout.Location = new System.Drawing.Point(0, 0);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Quality = 10;
            this.pnlCheckout.Size = new System.Drawing.Size(254, 925);
            this.pnlCheckout.TabIndex = 44;
            // 
            // btnLogOutMM
            // 
            this.btnLogOutMM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOutMM.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOutMM.FlatAppearance.BorderSize = 0;
            this.btnLogOutMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutMM.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutMM.ForeColor = System.Drawing.Color.White;
            this.btnLogOutMM.Location = new System.Drawing.Point(2, 861);
            this.btnLogOutMM.Name = "btnLogOutMM";
            this.btnLogOutMM.Size = new System.Drawing.Size(251, 49);
            this.btnLogOutMM.TabIndex = 20;
            this.btnLogOutMM.Text = "Log out";
            this.btnLogOutMM.UseVisualStyleBackColor = false;
            this.btnLogOutMM.Click += new System.EventHandler(this.btnLogOutMM_Click);
            // 
            // imgCheckout
            // 
            this.imgCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCheckout.BackColor = System.Drawing.Color.Transparent;
            this.imgCheckout.Image = global::Watchers.Properties.Resources.Watchers2;
            this.imgCheckout.Location = new System.Drawing.Point(1, 3);
            this.imgCheckout.Name = "imgCheckout";
            this.imgCheckout.Size = new System.Drawing.Size(251, 123);
            this.imgCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCheckout.TabIndex = 16;
            this.imgCheckout.TabStop = false;
            // 
            // lbBookSum
            // 
            this.lbBookSum.BackColor = System.Drawing.Color.LightGray;
            this.lbBookSum.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSum.FormattingEnabled = true;
            this.lbBookSum.ItemHeight = 36;
            this.lbBookSum.Location = new System.Drawing.Point(304, 213);
            this.lbBookSum.Name = "lbBookSum";
            this.lbBookSum.Size = new System.Drawing.Size(445, 256);
            this.lbBookSum.TabIndex = 46;
            // 
            // lblBookSum
            // 
            this.lblBookSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookSum.AutoSize = true;
            this.lblBookSum.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblBookSum.Location = new System.Drawing.Point(294, 150);
            this.lblBookSum.Name = "lblBookSum";
            this.lblBookSum.Size = new System.Drawing.Size(334, 60);
            this.lblBookSum.TabIndex = 47;
            this.lblBookSum.Text = "Booking Summary";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblOrderSummary.Location = new System.Drawing.Point(828, 150);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(296, 60);
            this.lblOrderSummary.TabIndex = 49;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // lsOrderSummary
            // 
            this.lsOrderSummary.BackColor = System.Drawing.Color.LightGray;
            this.lsOrderSummary.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsOrderSummary.FormattingEnabled = true;
            this.lsOrderSummary.ItemHeight = 36;
            this.lsOrderSummary.Location = new System.Drawing.Point(838, 213);
            this.lsOrderSummary.Name = "lsOrderSummary";
            this.lsOrderSummary.Size = new System.Drawing.Size(445, 256);
            this.lsOrderSummary.TabIndex = 48;
            // 
            // gbPayment
            // 
            this.gbPayment.BackColor = System.Drawing.Color.LightGray;
            this.gbPayment.Controls.Add(this.txtCVV);
            this.gbPayment.Controls.Add(this.txtExpDate);
            this.gbPayment.Controls.Add(this.txtCardNum);
            this.gbPayment.Controls.Add(this.rbCash);
            this.gbPayment.Controls.Add(this.rbCard);
            this.gbPayment.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayment.Location = new System.Drawing.Point(304, 591);
            this.gbPayment.Margin = new System.Windows.Forms.Padding(4);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Padding = new System.Windows.Forms.Padding(4);
            this.gbPayment.Size = new System.Drawing.Size(445, 219);
            this.gbPayment.TabIndex = 50;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Options";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(320, 128);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(83, 37);
            this.txtCVV.TabIndex = 4;
            this.txtCVV.Text = "CVV";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(43, 128);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(132, 37);
            this.txtExpDate.TabIndex = 3;
            this.txtExpDate.Text = "MM/YY";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(43, 83);
            this.txtCardNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(360, 37);
            this.txtCardNum.TabIndex = 2;
            this.txtCardNum.Text = "Card Number";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(43, 175);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(180, 40);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Pay at Cinema";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(43, 38);
            this.rbCard.Margin = new System.Windows.Forms.Padding(4);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(208, 40);
            this.rbCard.TabIndex = 0;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Debit/Credit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.lblTotal.Location = new System.Drawing.Point(306, 499);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 88);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(470, 499);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(67, 88);
            this.lblTotalPrice.TabIndex = 52;
            this.lblTotalPrice.Text = "R";
            // 
            // pnlCheckoutBTN
            // 
            this.pnlCheckoutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCheckoutBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCheckoutBTN.BackgroundImage")));
            this.pnlCheckoutBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCheckoutBTN.Controls.Add(this.lblCheckoutBTN);
            this.pnlCheckoutBTN.ForeColor = System.Drawing.Color.White;
            this.pnlCheckoutBTN.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlCheckoutBTN.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlCheckoutBTN.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pnlCheckoutBTN.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlCheckoutBTN.Location = new System.Drawing.Point(987, 799);
            this.pnlCheckoutBTN.Name = "pnlCheckoutBTN";
            this.pnlCheckoutBTN.Quality = 10;
            this.pnlCheckoutBTN.Size = new System.Drawing.Size(333, 67);
            this.pnlCheckoutBTN.TabIndex = 53;
            // 
            // lblCheckoutBTN
            // 
            this.lblCheckoutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckoutBTN.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckoutBTN.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblCheckoutBTN.Location = new System.Drawing.Point(0, 0);
            this.lblCheckoutBTN.Name = "lblCheckoutBTN";
            this.lblCheckoutBTN.Size = new System.Drawing.Size(333, 67);
            this.lblCheckoutBTN.TabIndex = 27;
            this.lblCheckoutBTN.Text = "Checkout";
            this.lblCheckoutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1368, 912);
            this.Controls.Add(this.pnlCheckoutBTN);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lsOrderSummary);
            this.Controls.Add(this.lblBookSum);
            this.Controls.Add(this.lbBookSum);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.pnlCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.pnlCheckout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckout)).EndInit();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.pnlCheckoutBTN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCheckout;
        private ns1.BunifuGradientPanel pnlCheckout;
        private System.Windows.Forms.Button btnLogOutMM;
        private System.Windows.Forms.PictureBox imgCheckout;
        private System.Windows.Forms.ListBox lbBookSum;
        private System.Windows.Forms.Label lblBookSum;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.ListBox lsOrderSummary;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private ns1.BunifuGradientPanel pnlCheckoutBTN;
        private System.Windows.Forms.Label lblCheckoutBTN;
    }
}