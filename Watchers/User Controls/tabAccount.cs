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
    public partial class tabAccount : UserControl
    {
        private static tabAccount _instance;

        public static tabAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabAccount();
                }
                return _instance;
            }
        }
        public tabAccount()
        {
            InitializeComponent();
        }

        private void tabAccount_Load(object sender, EventArgs e)
        {
            string name = Properties.Settings.Default.Name;
            string surname = Properties.Settings.Default.Surname;

            lblName.Text = name + " " + surname;
        }
    }
}
