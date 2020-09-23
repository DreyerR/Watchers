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
    public partial class tabSnacks : UserControl
    {
        private static tabSnacks _instance;

        public static tabSnacks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabSnacks();
                }
                return _instance;
            }
        }

        public tabSnacks()
        {
            InitializeComponent();
        }

        private void lblClearOrder_Click(object sender, EventArgs e)
        {

        }

        private void lblSkipOrder_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaceOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
