using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Webservice;
using Watchers.Forms;

namespace Watchers
{
    public partial class tabAccount : UserControl
    {
        private static tabAccount _instance;

        public static tabAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabAccount();
                }
                return _instance;
            }
        }
        public tabAccount()
        {
            InitializeComponent();
        }

        private void tabAccount_Load(object sender, EventArgs e)
        {
            string name = Properties.Settings.Default.Name;
            string surname = Properties.Settings.Default.Surname;

            lblName.Text = name + " " + surname;
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            Register updateUser = new Register(Register.Mode.Update);
            updateUser.ShowDialog();
            tabAccount_Load(sender, e); //refresh the information of the user
        }

        private async void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to delete " + lblName.Text + "?", "Confirm Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool isDeleted = await Api.DeleteUserAsync(Properties.Settings.Default.UserID);
                    if(isDeleted)
                    {
                        Message.ShowMessage("Account has been deleted", Message.MessageType.Information);
                        Application.Exit();
                    }
                    else
                    {
                        Message.ShowMessage("There is a error on the server's side: could not delete the account", Message.MessageType.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private async void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            string val = string.Empty;
            if (InputBox.ShowInputBox("Delete Booking", "Enter your ticket ID to delete:", ref val) == DialogResult.OK)
            {
                bool isDeleted = await Api.DeleteBookingAsync(val);

                if (isDeleted)
                    Message.ShowMessage("Your booking was deleted successfully", Message.MessageType.Information);
                else
                    Message.ShowMessage("Your ticket ID could not be found", Message.MessageType.Error);
            }           
        }
    }
}
