using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchers.Models.Post_Models
{
    public class BookingPost
    {
        public int mode { get; set; }
        public string movieID { get; set; }
        public int userID { get; set; }
        public int seatQuantity { get; set; }
        public string time { get; set; }
        public List<SeatNumber> seatNumbers { get; set; }
        public List<Orders> orders { get; set; }
    }

    public class SeatNumber
    {
        public string seatNumber { get; set; }
    }
    
    public class Orders
    {
        public string snackBarcode { get; set; }
        public int quantity { get; set; }
        public string name { get; set; }
    }
}
