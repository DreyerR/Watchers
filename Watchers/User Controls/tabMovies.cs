using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchers
{
    public partial class tabMovies : UserControl
    {
        private static tabMovies _instance;

        public static tabMovies Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new tabMovies();
                }
                return _instance;
            }
        }

        public tabMovies()
        {
            InitializeComponent();
        }

        private void btnBookMovie3_Click(object sender, EventArgs e)
        {

        }
    }
}
