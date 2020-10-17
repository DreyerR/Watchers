﻿using System;
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
        private BookingPost bookingModel;
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
        }

        public tabBookings()
        {
            InitializeComponent();
            dtpDate.MinDate = DateTime.Now;
            available = Resources.Available;
            booked = Resources.Booked;
            lblSeatNum.Text = "0";
        }

        public void PopulateForm()
        {
            if (movie != null)
            {
                lblMovie.Text = movie.Name;
                imgMovie.Image = movie.MovieImage;
                rtbDescription.Text = movie.Description;
                lblCinemaNumber.Text = movie.CinemaNumber.ToString();
                lblSeatNum.Text = "0";

                bookingModel = new BookingPost();
                bookingModel.movieID = movie.MovieID;
                bookingModel.userID = Settings.Default.UserID;

                seatNumbers = new List<SeatNumber>();
            }
        }

        private void SeatClicked(object sender, EventArgs e)
        {
            PictureBox seat = (PictureBox)sender;

            if (seat.Image == booked)
            {
                seat.Image = available;
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
                seatNumbers.Add(new SeatNumber { seatNumber = seat.Tag.ToString() });
            } 
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int seatQuantity = int.Parse(lblSeatNum.Text);
            if (seatQuantity > 0)
            {
                bookingModel.seatNumbers = seatNumbers;
                bookingModel.seatQuantity = seatQuantity;

                MainMenu main = (MainMenu)this.FindForm();
            }
            else
            {
                Message.ShowMessage("Please choose seats first", Message.MessageType.Warning);
            }
        }
    }
}
