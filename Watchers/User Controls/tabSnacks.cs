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
        private List<Snack> snacks = new List<Snack>();
        private List<Orders> orders = new List<Orders>();
        string outputFormat = "{0, -30}{1, -40}{2, -45}{3, -50}";

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
            lvOutput.Items.Clear();
        }

        private void AddItem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = btn.Tag.ToString();
            foreach(Snack snack in snacks)
            {
                if(snack.Barcode == tag)
                {
                    if(snack.Quantity == 0)
                    {
                        snack.Quantity++;

                        orders.Add(new Orders
                        {
                            snackBarcode = tag,
                            quantity = snack.Quantity
                        });
                    }
                    else //already exists
                    {
                        foreach(Orders order in orders)
                        {
                            if(order.snackBarcode == snack.Barcode)
                            {
                                order.quantity++;
                            }
                        }
                    }
                    lvOutput.Items.Add(String.Format(outputFormat, snack.Name, snack.Price.ToString("c"),  snack.Quantity.ToString(),  (snack.Price * snack.Quantity).ToString("c")));
                }
            }
        }

        private void tabSnacks_Load(object sender, EventArgs e)
        {
            lvOutput.Items.Clear();
            lvOutput.Items.Add(String.Format(outputFormat, "Product Name", "Product Price(R)", "Quantity", "Total(R)"));
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
            Snack snack7 = new Snack
            {
                Barcode = "GH7712",
                Name = "Small Popcorn",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack8 = new Snack
            {
                Barcode = "DB5516",
                Name = "Medium Popcorn",
                Price = 29.99M,
                Quantity = 0
            };
            Snack snack9 = new Snack
            {
                Barcode = "LH4413",
                Name = "Large Popcorn",
                Price = 39.99M,
                Quantity = 0
            };
            Snack snack10 = new Snack
            {
                Barcode = "LL4513",
                Name = "Small Coca-Cola",
                Price = 14.99M,
                Quantity = 0
            };
            Snack snack11 = new Snack
            {
                Barcode = "HQ8319",
                Name = "Small Sprite",
                Price = 14.99M,
                Quantity = 0
            };
            Snack snack12 = new Snack
            {
                Barcode = "BC8547",
                Name = "Small Fanta",
                Price = 14.99M,
                Quantity = 0
            };
            Snack snack13 = new Snack
            {
                Barcode = "KL6574",
                Name = "Small Coca-Cola (Zero)",
                Price = 14.99M,
                Quantity = 0
            };
            Snack snack14 = new Snack
            {
                Barcode = "HI8246",
                Name = "Small Sprite (Zero)",
                Price = 14.99M,
                Quantity = 0
            };
            Snack snack15 = new Snack
            {
                Barcode = "JD5511",
                Name = "Small Fanta (Zero)",
                Price = 14.99M,
                Quantity = 0
            };
            Snack snack16 = new Snack
            {
                Barcode = "FG6412",
                Name = "Medium Coca-Cola",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack17 = new Snack
            {
                Barcode = "JJ4554",
                Name = "Medium Sprite",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack18 = new Snack
            {
                Barcode = "LP0018",
                Name = "Medium Fanta",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack19 = new Snack
            {
                Barcode = "OP8800",
                Name = "Medium Coca-Cola (Zero)",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack20 = new Snack
            {
                Barcode = "MM0413",
                Name = "Medium Sprite (Zero)",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack21 = new Snack
            {
                Barcode = "NN0894",
                Name = "Medium Fanta (Zero)",
                Price = 19.99M,
                Quantity = 0
            };
            Snack snack22 = new Snack
            {
                Barcode = "KU1214",
                Name = "Large Coca-Cola",
                Price = 24.99M,
                Quantity = 0
            };
            Snack snack23 = new Snack
            {
                Barcode = "HU4565",
                Name = "Large Coca-Cola (Zero)",
                Price = 24.99M,
                Quantity = 0
            };
            Snack snack24 = new Snack
            {
                Barcode = "KK0716",
                Name = "Large Sprite",
                Price = 24.99M,
                Quantity = 0
            };
            Snack snack25 = new Snack
            {
                Barcode = "GH8467",
                Name = "Large Sprite (Zero)",
                Price = 24.99M,
                Quantity = 0
            };
            Snack snack26 = new Snack
            {
                Barcode = "LL6427",
                Name = "Large Fanta",
                Price = 24.99M,
                Quantity = 0
            };
            Snack snack27 = new Snack
            {
                Barcode = "PR6419",
                Name = "Large Fanta (Zero)",
                Price = 24.99M,
                Quantity = 0
            };
            Snack snack28 = new Snack
            {
                Barcode = "ED4561",
                Name = "Water",
                Price = 9.99M,
                Quantity = 0
            };
            Snack snack29 = new Snack
            {
                Barcode = "KK8888",
                Name = "Ice Tea (Peach)",
                Price = 17.99M,
                Quantity = 0
            };
            Snack snack30 = new Snack
            {
                Barcode = "HJ8467",
                Name = "Ice Tea (Lemon)",
                Price = 17.99M,
                Quantity = 0
            };
            snacks.Add(snack1);
            snacks.Add(snack2);
            snacks.Add(snack3);
            snacks.Add(snack4);
            snacks.Add(snack5);
            snacks.Add(snack6);
            snacks.Add(snack7);
            snacks.Add(snack8);
            snacks.Add(snack9);
            snacks.Add(snack10);
            snacks.Add(snack11);
            snacks.Add(snack12);
            snacks.Add(snack13);
            snacks.Add(snack14);
            snacks.Add(snack15);
            snacks.Add(snack16);
            snacks.Add(snack17);
            snacks.Add(snack18);
            snacks.Add(snack19);
            snacks.Add(snack20);
            snacks.Add(snack21);
            snacks.Add(snack22);
            snacks.Add(snack23);
            snacks.Add(snack24);
            snacks.Add(snack25);
            snacks.Add(snack26);
            snacks.Add(snack27);
            snacks.Add(snack28);
            snacks.Add(snack29);
            snacks.Add(snack30);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (orders.Count == 0)
            {
                Message.ShowMessage("No snacks were chosen\nPlease click on 'Skip Order' instead.", Message.MessageType.Warning);
                return;
            }

            booking.orders = orders;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lvOutput.Items.Clear();
            orders.Clear();
        }

        private void btnSkipOrder_Click(object sender, EventArgs e)
        {
            orders.Clear();
            btnPlaceOrder_Click(sender, e);
        }
    }
}
