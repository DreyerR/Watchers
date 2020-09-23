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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void pnlExit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            //this.Close();
            login.ShowDialog();
        }

        private void imgLogoWel_Click(object sender, EventArgs e)
        {

        }

        private void imgGradientWel_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegisterNow_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            //this.Close();
            register.ShowDialog();
        }
    }
}
