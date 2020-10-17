using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Models.Post_Models;
using Watchers.Webservice;

namespace Watchers
{
    public partial class tabCheckOut : UserControl
    {
        private static tabCheckOut _instance;
        public static dynamic bookingResponse;
        public static BookingPost booking;

        public tabCheckOut()
        {
            InitializeComponent();
        }

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

        public void PopulateForm()
        {
            if (bookingResponse != null)
            {
                lblTotal.Text = "Total " + bookingResponse["totalPrice"].ToString("C");
            }
        }

        private async void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bool isSuccessful = await Api.DeleteBookingAsync(bookingResponse["ticketID"]);

                    if (isSuccessful)
                    {
                        Message.ShowMessage("Your booking was successfully canceled", Message.MessageType.Information);
                        MainMenu menu = (MainMenu)this.FindForm();

                        tabBookings._instance = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {

        }
    }
}
