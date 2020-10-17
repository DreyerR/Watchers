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
using Watchers.Models;

namespace Watchers
{
    public partial class tabSnacks : UserControl
    {
        private static tabSnacks _instance;
        public static BookingPost booking;
        private List<Snack> snacks;
        private List<Orders> orders;

        public static tabSnacks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabSnacks();
                }
                return _instance;
            }
        }

        public tabSnacks()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbOrder.Items.Clear();
        }

        private void AddItem(object sender, EventArgs e)
        {
            Button snack = (Button)sender;

        }

        private void tabSnacks_Load(object sender, EventArgs e)
        {
            Snack snack1 = new Snack
            {
                Barcode = "OP9874",
                Name = "Astros",
                Price = 11.99M,
                Quantity = 0
            };
            Snack snack2 = new Snack
            {
                Barcode = "FC4551",
                Name = "Whispers",
                Price = 18.99M,
                Quantity = 0
            };
            Snack snack3 = new Snack
            {
                Barcode = "AE6612",
                Name = "Dairy Milk",
                Price = 15.99M,
                Quantity = 0
            };
            Snack snack4 = new Snack
            {
                Barcode = "FE5578",
                Name = "Wine gums",
                Price = 21.99M,
                Quantity = 0
            };
            Snack snack5 = new Snack
            {
                Barcode = "KE9913",
                Name = "Jelly Babies",
                Price = 21.99M,
                Quantity = 0
            };
            Snack snack6 = new Snack
            {
                Barcode = "AA2137",
                Name = "Montagu",
                Price = 49.99M,
                Quantity = 0
            };
        }
    }
}
