﻿using System;
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
        private Mode mode;
        public Register(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        public enum Mode
        {
            Register,
            Update
        }

        private async void UpdateMethod()
        {
            try
            {
                if (IsValid())
                {
                    int userID = Properties.Settings.Default.UserID;
                    string name = txtName.Text;
                    string surname = txtSurname.Text;
                    string email = txtEmail.Text;

                    bool isSuccessful = await Api.UpdateUserAsync(userID, name, surname, email);
                    if (isSuccessful)
                    {
                        Message.ShowMessage("Account was updated successfully", Message.MessageType.Information);
                        this.Close();
                    }
                    else
                    {
                        Message.ShowMessage("Could not update your account", Message.MessageType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private async void RegisterMethod()
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
                        MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu main = new MainMenu();
                        this.Close();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (mode == Mode.Register)
                {
                    RegisterMethod();
                    btnRegister.Enabled = true;
                }
                else
                {
                    UpdateMethod();
                    btnRegister.Enabled = false;
                    Properties.Settings.Default.Surname = txtSurname.Text;
                    Properties.Settings.Default.Name = txtName.Text;
                    Properties.Settings.Default.Email = txtEmail.Text;
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        private bool IsValid()
        {
            try
            {
                bool valid = true;

                if (txtName.Text == "") // if textbox is empty, show an error
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
                else if (!(txtEmail.Text.Contains("@"))) // validate email by checking if it contains a @ character
                {
                    errorProvider.SetError(txtEmail, "Invalid email address");
                    valid = false;
                }
                else if (txtPassword.Text == "" && mode == Mode.Register)
                {
                    errorProvider.SetError(txtPassword, "Password cannot be empty");
                    valid = false;
                }
                else if ((txtConfirmPassword.Text == "" || txtConfirmPassword.Text != txtPassword.Text) && mode == Mode.Register) // checks if passwords match
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txtConfirmPassword, "Passwords do not match");
                    valid = false;
                }

                return valid;
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
                return false;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                if (mode == Mode.Register)
                {
                    this.Text = "Register";
                    btnRegister.Text = "Register";
                    lblNewUser.Text = "New user";
                }
                else
                {
                    this.Text = "Update Account";
                    lblNewUser.Text = "Update your account";
                    btnRegister.Text = "Update Account";
                    txtPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;
                    txtName.Text = Properties.Settings.Default.Name;
                    txtSurname.Text = Properties.Settings.Default.Surname;
                    txtEmail.Text = Properties.Settings.Default.Email;
                    txtName.Text = Properties.Settings.Default.Name;
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }
    }
}
