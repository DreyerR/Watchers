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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void btnMoviesAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBookingsAccount_Click(object sender, EventArgs e)
        {
            Bookings book = new Bookings();
            this.Close();
            book.ShowDialog();
        }

        private void btnAccountAccount_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();
            this.Close();
            account.ShowDialog();
        }

        private void btnLogOutAccount_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }
    }
}
