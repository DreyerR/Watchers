using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Webservice;

namespace Watchers
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    string name = txtName.Text;
                    string surname = txtSurname.Text;
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;

                    bool isSuccessful = await Api.RegisterUserAsync(name, surname, email, password);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Registration Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu main = new MainMenu();
                        this.Close();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Registration Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValid()
        {
            bool valid = true;

            if (txtName.Text == "")
            {
                errorProvider.SetError(txtName, "Name cannot be empty");
                valid = false;
            }
            else if (txtSurname.Text == "")
            {
                errorProvider.SetError(txtSurname, "Surname cannot be empty");
                valid = false;
            }
            else if (txtEmail.Text == "")
            {
                errorProvider.SetError(txtEmail, "Email cannot be empty");
                valid = false;
            }
            else if (!(txtEmail.Text.Contains("@")))
            {
                errorProvider.SetError(txtEmail, "Invalid email address");
                valid = false;
            }
            else if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Password cannot be empty");
                valid = false;
            }
            else if (txtConfirmPassword.Text == "" || txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider.Clear();
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match");
                valid = false;
            }

            return valid;
        }
    }
}
