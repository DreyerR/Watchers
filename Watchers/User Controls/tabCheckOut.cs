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
        public static string movieName; // Used for booking summary
        public static dynamic bookingResponse; // Contains the ticketID and total price of the booking (received from server).
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

        private void TextFieldClick(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = "";
        }

        public void AddOrderItem(Snack snack)
        {
            try
            {
                ListViewItem item = new ListViewItem(snack.Name);
                item.SubItems.Add(snack.Price.ToString("c"));
                item.SubItems.Add(snack.Quantity.ToString());
                item.SubItems.Add((snack.Price * snack.Quantity).ToString("c"));
                lvOrderSummary.Items.Add(item);
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        public void RemoveOrderItemAt(int index)
        {
            lvOrderSummary.Items.RemoveAt(index);
        }

        public void ClearOrders()
        {
            lvOrderSummary.Items.Clear();
            lvOrderSummary.Items.Add("No snacks in cart");
        }

        public void PopulateForm()
        {
            try
            {
                if (bookingResponse != null)
                {
                    lbBookSum.Items.Add("Movie name: " + movieName);
                    lbBookSum.Items.Add("Seat quantity: " + booking.seatQuantity.ToString());
                    lbBookSum.Items.Add("Seat number(s): " + SeatNumToString());
                    lbBookSum.Items.Add("Booking time: " + booking.time);
                    lbBookSum.Items.Add("Ticket ID: " + bookingResponse["ticketID"]);

                    decimal total_price = 0.0m;
                    lblTotal.Text = "Total " + bookingResponse["totalPrice"].ToString("C");
                    foreach (Orders order in booking.orders)
                    {
                        foreach (Snack snack in snacks)
                        {
                            if (snack.Barcode == order.snackBarcode)
                            {
                                total_price += snack.Price * order.quantity;
                            }
                        }
                    }
                    lblOrderTotal.Text = "Orders Total: " + total_price.ToString("c");
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        private string SeatNumToString()
        {
            string seatNumbers = "";
            int length = booking.seatNumbers.Count;
            for (int i = 0; i < length; i++)
            {
                seatNumbers += booking.seatNumbers[i].seatNumber;
                if (i < length - 1)
                    seatNumbers += ", ";
            }

            return seatNumbers;
        }

        private async void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bool isSuccessful = await Api.DeleteBookingAsync(bookingResponse["ticketID"]); // delete the booking from the serever

                    if (isSuccessful)
                    {
                        Message.ShowMessage("Your booking was successfully canceled", Message.MessageType.Information);
                        Reset(sender, e); // reset the application (all the tabs instances is set to null and navigate to the movie tab)
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        public void Reset(object sender, EventArgs e)
        {
            try
            {
                MainMenu menu = (MainMenu)this.FindForm();
                menu.btnMovies_Click(sender, e);
                tabMovies.Instance.ResetApplication();
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbCard.Checked)
                {
                    if (txtCardNum.Text.Length != 16)
                    {
                        checkOut_error.SetError(txtCardNum, "Enter valid card number");
                        if (txtCVV.Text.Length != 3)
                        {
                            checkOut_error.SetError(txtCardNum, "Enter valid CVV number");
                            if (!txtExpDate.Text.Contains("/"))
                            {
                                checkOut_error.SetError(txtCardNum, "Enter valid expiration date (MM/YY)");
                            }
                        }
                    }
                    else
                    {
                        Message.ShowMessage("Your payment was successful", Message.MessageType.Information);
                        tabMovies.booking = booking;
                        Reset(sender, e);
                    }
                }
                else if(rbCash.Checked)
                {
                    Message.ShowMessage("Pay for your booking at the cash till", Message.MessageType.Information);
                    tabMovies.booking = booking;
                    Reset(sender, e);
                }else
                {
                    Message.ShowMessage("Select a payment option", Message.MessageType.Error);
                    checkOut_error.SetError(rbCard, "Select a payment option");
                }
            }catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }
    }
}
