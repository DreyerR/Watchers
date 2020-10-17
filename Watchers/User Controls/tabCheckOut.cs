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
using Watchers.Models;

namespace Watchers
{
    public partial class tabCheckOut : UserControl
    {
        private static tabCheckOut _instance;
        public static List<Snack> snacks = new List<Snack>();
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
            set
            {
                _instance = null;
            }
        }

        public void PopulateForm()
        {
            decimal total_price = 0.0m;
            if (bookingResponse != null)
            {
                lblTotal.Text = "Total " + bookingResponse["totalPrice"].ToString("C");
                foreach(Orders order in booking.orders)
                {
                    foreach(Snack snack in snacks)
                    {
                        if(snack.Barcode == order.snackBarcode)
                        {
                            lbOrderSummary.Items.Add(snack.Name + "\t x " + snack.Quantity + "\t" + snack.Price.ToString("c"));
                            total_price += snack.Price * snack.Quantity;
                        }
                    }
                }
                lblOrderTotal.Text = "Orders Total: " + total_price.ToString("c");
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
                        ResetApplication(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private void ResetApplication(object sender, EventArgs e)
        {
            MainMenu menu = (MainMenu)this.FindForm();
            tabMovies.Instance = null;
            tabBookings.Instance = null;
            tabSnacks.Instance = null;

            menu.btnBookings.Visible = false;
            menu.btnSnacks.Visible = false;
            menu.btnCheckOut.Visible = false;

            lblOrderTotal.Text = "";
            lblTotal.Text = "";

            menu.btnMovies_Click(sender, e);
            _instance = null;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCardNum.Text.Length != 16)
                {
                    checkOut_error.SetError(txtCardNum, "Enter valid card number");
                    if(txtCVV.Text.Length != 3)
                    {
                        checkOut_error.SetError(txtCardNum, "Enter valid CVV number");
                        if(!txtExpDate.Text.Contains("/"))
                        {
                            checkOut_error.SetError(txtCardNum, "Enter valid expiration date (MM/YY)");
                        }
                    }
                }else
                {
                    Message.ShowMessage("Your payment was successful", Message.MessageType.Information);
                    ResetApplication(sender, e);
                }
            }catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }
    }
}
