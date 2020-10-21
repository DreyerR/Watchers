using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Models;
using Watchers.Properties;
using Watchers.Models.Post_Models;

namespace Watchers
{
    public partial class tabBookings : UserControl
    {

        private static tabBookings _instance;
        public static Movie movie;
        public BookingPost bookingModel;
        private List<SeatNumber> seatNumbers;
        private Image available;
        private Image booked;

        public static tabBookings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabBookings();
                }
                return _instance;
            }
            set
            {
                _instance = null;
            }
        }

        public tabBookings()
        {
            InitializeComponent();
            dtpDate.MinDate = DateTime.Now;
            available = Resources.Available;
            booked = Resources.Booked;
            lblSeatNum.Text = "0";
            cbbTime.SelectedIndex = 0;
        }

        public void PopulateForm()
        {
            try
            {
                if (movie != null)
                {
                    lblMovie.Text = movie.Name;
                    imgMovie.Image = movie.MovieImage;
                    rtbDescription.Text = movie.Description;
                    lblCinemaNumber.Text = movie.CinemaNumber.ToString();
                    lblSeatNum.Text = "0";

                    if (bookingModel == null)
                    {
                        bookingModel = new BookingPost();
                    }

                    bookingModel.movieID = movie.MovieID;
                    bookingModel.userID = Settings.Default.UserID;

                    if (seatNumbers == null)
                    {
                        seatNumbers = new List<SeatNumber>();
                    }
                    CheckBooked();
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        private void SeatClicked(object sender, EventArgs e)
        {
            try
            {
                PictureBox seat = (PictureBox)sender;

                if (seat.Image == booked)
                {
                    seat.Image = available;
                    if (int.TryParse(lblSeatNum.Text, out int numSeats) && numSeats > 0)
                        lblSeatNum.Text = (int.Parse(lblSeatNum.Text) - 1).ToString();

                    for (int i = 0; i < seatNumbers.Count; i++)
                    {
                        if (seatNumbers[i].seatNumber == seat.Tag.ToString())
                        {
                            seatNumbers.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    seat.Image = booked;
                    lblSeatNum.Text = (int.Parse(lblSeatNum.Text) + 1).ToString();
                    string moviePrice = (movie.MoviePrice * int.Parse(lblSeatNum.Text)).ToString("C");
                    lblMoviePrice.Text = moviePrice;
                    tabCheckOut.Instance.lblMovieTotal.Text = "Booking Total: " + moviePrice;
                    seatNumbers.Add(new SeatNumber { seatNumber = seat.Tag.ToString() });
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        private void CheckBooked()
        {
            try
            {
                if (bookingModel != null && bookingModel.seatNumbers != null)
                {
                    if (bookingModel.seatNumbers.Count > 0)
                    {
                        List<string> seats = new List<string>();
                        foreach (SeatNumber seat in bookingModel.seatNumbers)
                        {
                            seats.Add(seat.seatNumber);
                        }

                        for (int i = 0; i < pnlCinema.Controls.Count; i++)
                        {
                            Control ctrl = pnlCinema.Controls[i];
                            if (ctrl is PictureBox)
                            {
                                PictureBox image = (PictureBox)ctrl;
                                if (image.Tag != null)
                                {
                                    string tag = image.Tag.ToString();
                                    if (seats.Contains(image.Tag.ToString())) {
                                        image.Image = Resources.Unavailable;
                                        image.Enabled = false;
                                    }
                                }
                            }
                        }
                        seatNumbers = new List<SeatNumber>();
                        bookingModel.seatNumbers.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                bookingModel.time = dtpDate.Value.ToString("yyyy-MM-dd") + " " + cbbTime.SelectedItem.ToString();
                int seatQuantity = int.Parse(lblSeatNum.Text);
                if (seatQuantity > 0)
                {
                    bookingModel.seatNumbers = seatNumbers;
                    bookingModel.seatQuantity = seatQuantity;

                    MainMenu main = (MainMenu)this.FindForm();
                    main.btnSnacks.Visible = true;
                    main.BtnSnack_Click(sender, e, bookingModel);
                }
                else
                {
                    Message.ShowMessage("Please choose seats first", Message.MessageType.Warning);
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }
    }
}
