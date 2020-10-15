using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Models;
using Watchers.Properties;

namespace Watchers
{
    public partial class tabBookings : UserControl
    {

        private static tabBookings _instance;
        public static Movie movie;

        public static tabBookings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabBookings();
                }
                return _instance;
            }
        }

        public tabBookings()
        {
            InitializeComponent();
        }

        public void PopulateForm()
        {
            if (movie != null)
            {
                lblMovie.Text = movie.Name;
                imgMovie.Image = movie.MovieImage;
            }
        }
    }
}
