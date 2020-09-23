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
    public partial class Bookings : Form
    {
        bool a1 = false, a2 = false, a3 = false, a4 = false, a5 = false, a6 = false, a7 = false, a8 = false, a9 = false, a10 = false;
        bool b1 = false, b2 = false, b3 = false, b4 = false, b5 = false, b6 = false, b7 = false, b8 = false, b9 = false, b10 = false;

        private void btnBookingBook_Click(object sender, EventArgs e)
        {
            Bookings book = new Bookings();
            this.Close();
            book.ShowDialog();
        }

        private void btnAccountBook_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();
            this.Close();
            account.ShowDialog();
        }

        private void btnLogOutBook_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }

        private void btnMoviesBook_Click(object sender, EventArgs e)
        {
            
        }

        Boolean c1 = false, c2 = false, c3 = false, c4 = false, c5 = false, c6 = false, c7 = false, c8 = false, c9 = false, c10 = false;



        int nrSeats = 0;
        private void btnA3_Click(object sender, EventArgs e)
        {
            if (!a3)
            {
                a3 = true;
                btnA3.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a3 = false;
                btnA3.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (!a4)
            {
                a4 = true;
                btnA4.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a4 = false;
                btnA4.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (!a5)
            {
                a5 = true;
                btnA5.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a5 = false;
                btnA5.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (!a6)
            {
                a6 = true;
                btnA6.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a6 = false;
                btnA6.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            if (!a7)
            {
                a7 = true;
                btnA7.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a7 = false;
                btnA7.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            if (!a8)
            {
                a8 = true;
                btnA8.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a8 = false;
                btnA8.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            if (!a9)
            {
                a9 = true;
                btnA9.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a9 = false;
                btnA9.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            if (!a10)
            {
                a10 = true;
                btnA10.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a10 = false;
                btnA10.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (!a2)
            {
                a2 = true;
                btnA2.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a2 = false;
                btnA2.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (!a1)
            {
                a1 = true;
                btnA1.BackgroundImage = Watchers.Properties.Resources.Booked;
                nrSeats = nrSeats + 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
            else
            {
                a1 = false;
                btnA1.BackgroundImage = Watchers.Properties.Resources.Available;
                nrSeats = nrSeats - 1;
                lblSeatNum.Text = nrSeats.ToString();
            }
        }

       
        public Bookings()
        {
            InitializeComponent();
        }

        private void pnlCinema_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblScreen_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }
    }
}
