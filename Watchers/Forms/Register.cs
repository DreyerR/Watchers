using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchers
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            this.Close();
            welcome.ShowDialog();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void lblNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
