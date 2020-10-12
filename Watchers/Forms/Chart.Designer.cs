﻿namespace Watchers.Forms
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
            this.lblList = new System.Windows.Forms.Label();
            this.lblChartDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pieChartMovies
            // 
            this.pieChartMovies.Location = new System.Drawing.Point(41, 53);
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
            // lblList
            // 
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(37, 199);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(144, 33);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List of Movies:";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChartDate
            // 
            this.lblChartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartDate.Location = new System.Drawing.Point(582, 18);
            this.lblChartDate.Name = "lblChartDate";
            this.lblChartDate.Size = new System.Drawing.Size(247, 33);
            this.lblChartDate.TabIndex = 3;
            this.lblChartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 552);
            this.Controls.Add(this.lblChartDate);
            this.Controls.Add(this.lblList);
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
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblChartDate;
    }
}