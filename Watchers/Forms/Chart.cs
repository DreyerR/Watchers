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

namespace Watchers.Forms
{
    public partial class frmChart : Form
    {
        public frmChart(SeriesCollection series)
        {
            InitializeComponent();
            pieChartMovies.LegendLocation = LegendLocation.Left;
            pieChartMovies.Series = series;
        }
    }
}
