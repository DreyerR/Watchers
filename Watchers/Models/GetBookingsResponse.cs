using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchers.Models
{
    class GetBookingsResponse
    {
        public bool IsSuccessful { get; set; }
        public List<Booking> Bookings { get; set; }
    }

    class Booking
    {
        public string TicketID { get; set; }
        public string MovieName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BookingTime { get; set; }
        public string SeatNumber { get; set; }
        public int SeatQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
