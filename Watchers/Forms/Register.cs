using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchers
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsValid()) // To-do: Complete the login method. Use the Api.RegisterUserAsync method.
            {
                MessageBox.Show("Everything looks good!");
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
