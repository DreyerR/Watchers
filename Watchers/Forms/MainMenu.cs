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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMoviesMM_Click(object sender, EventArgs e)
        {
            if (!pnlBack.Controls.Contains(tabMovies.Instance))
            {
                pnlBack.Controls.Add(tabMovies.Instance);
                tabMovies.Instance.Dock = DockStyle.Fill;
                tabMovies.Instance.BringToFront();
            }
            else
                tabMovies.Instance.BringToFront();
        }

        private void btnSnacksMM_Click(object sender, EventArgs e)
        {
            if (!pnlBack.Controls.Contains(tabSnacks.Instance))
            {
                pnlBack.Controls.Add(tabSnacks.Instance);
                tabSnacks.Instance.Dock = DockStyle.Fill;
                tabSnacks.Instance.BringToFront();
            }
            else
                tabSnacks.Instance.BringToFront();
        }

        private void btnBookingsMM_Click(object sender, EventArgs e)
        {
            if (!pnlBack.Controls.Contains(tabBookings.Instance))
            {
                pnlBack.Controls.Add(tabBookings.Instance);
                tabBookings.Instance.Dock = DockStyle.Fill;
                tabBookings.Instance.BringToFront();
            }
            else
                tabBookings.Instance.BringToFront();
        }

        private void btnAccountMM_Click(object sender, EventArgs e)
        { 
            if (!pnlBack.Controls.Contains(tabAccount.Instance))
            {
                pnlBack.Controls.Add(tabAccount.Instance);
                tabAccount.Instance.Dock = DockStyle.Fill;
                tabAccount.Instance.BringToFront();
            }
            else
                tabAccount.Instance.BringToFront();
        }

        private void btnLogOutMM_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!pnlBack.Controls.Contains(tabCheckOut.Instance))
            {
                pnlBack.Controls.Add(tabCheckOut.Instance);
                tabCheckOut.Instance.Dock = DockStyle.Fill;
                tabCheckOut.Instance.BringToFront();
            }
            else
                tabCheckOut.Instance.BringToFront();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (!pnlBack.Controls.Contains(tabAdmin.Instance))
            {
                pnlBack.Controls.Add(tabAdmin.Instance);
                tabAdmin.Instance.Dock = DockStyle.Fill;
                tabAdmin.Instance.BringToFront();
            }
            else
                tabAdmin.Instance.BringToFront();
        }
    }
}
