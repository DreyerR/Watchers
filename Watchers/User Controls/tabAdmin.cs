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
    public partial class tabAdmin : UserControl
    {

        private static tabAdmin _instance;

        public static tabAdmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabAdmin();
                }
                return _instance;
            }
        }

        public tabAdmin()
        {
            InitializeComponent();
        }

        private void cbbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
