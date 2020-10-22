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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory + @"\Resources\Watchers2.png";
            Message.ShowMessage(workingDirectory, Message.MessageType.Information);
            Register register = new Register(Register.Mode.Register);
            register.ShowDialog();
        }
    }
}
