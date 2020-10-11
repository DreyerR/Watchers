using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchers.Models
{
    class GetOrderResponse
    {
        public bool IsSuccessful { get; set; }
        public List<Order> Orders { get; set; }
    }

    class Order
    {
        public int OrderID { get; set; }
        public string TicketID { get; set; }
        public string SnackBarcode { get; set; }
        public string ProductName { get; set; }
        public int SnackQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
