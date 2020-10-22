using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Common;
using Watchers.Models;
using Watchers.Models.Post_Models;

namespace Watchers
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            bool admin = Properties.Settings.Default.IsAdmin;
            if (admin) // tests wheter the logged in user is admin or not
                btnAdmin.Visible = true; // if user is admin, show the admin button
            else
                btnAdmin.Visible = false;

            btnBookings.Click += (sender1, e1) => BtnBooking_Click(sender1, e1); // create a customer event handler for btnBooking
            btnSnacks.Click += (sender1, e1) => BtnSnack_Click(sender1, e1);
            btnCheckOut.Click += (sender1, e1) => BtnCheckOut_Click(sender1, e1);
            btnMovies_Click(sender, e); // open the movie tab
        }

        public void BtnCheckOut_Click(object sender1, EventArgs e1, dynamic bookingResponse = null, BookingPost booking = null)
        {
            if (!pnlBack.Controls.Contains(tabCheckOut.Instance))
            {
                pnlBack.Controls.Add(tabCheckOut.Instance);
                tabCheckOut.Instance.Dock = DockStyle.Fill;
                tabCheckOut.Instance.BringToFront();
            }
            else
                tabCheckOut.Instance.BringToFront();

            tabCheckOut.bookingResponse = bookingResponse;
            tabCheckOut.booking = booking;
            tabCheckOut.Instance.PopulateForm();
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

        private void btnAccount_Click(object sender, EventArgs e)
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            tabMovies.Instance = null;
            tabBookings.Instance = null;
            tabSnacks.Instance = null;
            tabCheckOut.Instance = null;
            tabAdmin.Instance = null;
            this.Close();
        }

        public void btnMovies_Click(object sender, EventArgs e)
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

        public void BtnBooking_Click(object sender, EventArgs e, Movie movie = null, BookingPost booking = null)
        {
            tabBookings.movie = movie;
            tabBookings.Instance.bookingModel = booking;
            if (!pnlBack.Controls.Contains(tabBookings.Instance))
            {
                pnlBack.Controls.Add(tabBookings.Instance);
                tabBookings.Instance.Dock = DockStyle.Fill;
                tabBookings.Instance.BringToFront();
            }
            else
            {
                tabBookings.Instance.BringToFront();
            }
            tabBookings.Instance.PopulateForm();
        }

        public void BtnSnack_Click(object sender, EventArgs e, BookingPost booking = null)
        {
            tabSnacks.booking = booking;
            if (!pnlBack.Controls.Contains(tabSnacks.Instance))
            {
                pnlBack.Controls.Add(tabSnacks.Instance);
                tabSnacks.Instance.Dock = DockStyle.Fill;
                tabSnacks.Instance.BringToFront();
            }
            else
                tabSnacks.Instance.BringToFront();
            tabSnacks.booking = booking;
        }
    }
}
