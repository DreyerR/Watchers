using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Common;

namespace Watchers.Forms
{
    public partial class frmChart : Form
    {
        public frmChart(SeriesCollection series)
        {
            InitializeComponent();
            pieChartMovies.LegendLocation = LegendLocation.Right;
            pieChartMovies.Series = series;
            string chartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lblChartDate.Text = "Date: " + chartDate;
        }
    }
}
