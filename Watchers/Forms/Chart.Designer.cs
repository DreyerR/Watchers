namespace Watchers.Forms
{
    partial class frmChart
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
            this.pieChartMovies = new LiveCharts.WinForms.PieChart();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pieChartMovies
            // 
            this.pieChartMovies.Location = new System.Drawing.Point(29, 57);
            this.pieChartMovies.Margin = new System.Windows.Forms.Padding(2);
            this.pieChartMovies.Name = "pieChartMovies";
            this.pieChartMovies.Size = new System.Drawing.Size(788, 488);
            this.pieChartMovies.TabIndex = 0;
            this.pieChartMovies.Text = "Booking chart";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Number of movies booked";
            // 
            // lblMovies
            // 
            this.lblMovies.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.Location = new System.Drawing.Point(12, 204);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(157, 33);
            this.lblMovies.TabIndex = 2;
            this.lblMovies.Text = "List of movies:";
            this.lblMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(546, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(304, 41);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date chart generated: ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 552);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pieChartMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChartMovies;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblDate;
    }
}