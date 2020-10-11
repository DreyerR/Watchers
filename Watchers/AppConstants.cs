using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchers
{
    class AppConstants
    {
        private static string BASE = "https://www.technetic.co.za/php";
        public static string AuthURL = BASE + "/auth.php";
        public static string UsersURL = BASE + "/user.php";
        public static string BookingURL = BASE + "/booking.php?mode={0}";
        public static string MovieURl = BASE + "/movie.php";
        public static string OrderURL = BASE + "/order.php";
    }
}
