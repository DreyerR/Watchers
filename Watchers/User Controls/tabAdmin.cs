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

namespace Watchers
{
    public partial class tabAdmin : UserControl
    {

        private static tabAdmin _instance;

        public static tabAdmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabAdmin();
                }
                return _instance;
            }
        }

        public tabAdmin()
        {
            InitializeComponent();
        }

        private void cbbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbCategory.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    PopulateUsers();
                    break;
            }
        }

        private async void PopulateUsers()
        {
            try
            {
                cbbCategory.Enabled = false;
                lblCategory.Text = "Please wait...";

                DataTable users = await Api.GetAllUsersAsync();

                if (users != null)
                {
                    dgvReport.DataSource = users;

                    dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    lblCategory.Text = "Choose a report:";
                    cbbCategory.Enabled = true;
                }
                else
                {
                    Message.ShowMessage("Error on server side\nUsers: null", Message.MessageType.Error);
                }
  
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }
    }
}
