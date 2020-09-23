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
    public partial class tabCheckOut : UserControl
    {
        public tabCheckOut()
        {
            InitializeComponent();
        }

        private static tabCheckOut _instance;

        public static tabCheckOut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabCheckOut();
                }
                return _instance;
            }
        }

        private void lblCheckoutBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
