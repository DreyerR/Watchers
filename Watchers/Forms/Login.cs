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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            this.Close();
            welcome.ShowDialog();
        }

        private bool IsValid()
        {
            bool valid = true;

            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Username cannot be empty");
                valid = false;
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Password cannot be empty");
                valid = false;
            }

            return valid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Close();
            main.ShowDialog();
            //if (IsValid())   Commented this out for faster development.
            //{
            //    try
            //    {
            //        Cursor = Cursors.WaitCursor;

            //        string username = txtUsername.Text;
            //        string password = txtPassword.Text;

            //        bool success = await Api.AuthUserAsync(username, password);   !! Remember to put async next to the private keyword in the method heading.

            //        if (success)
            //        {
            //            Cursor = Cursors.Default;

            //            MainMenu main = new MainMenu();
            //            this.Close();
            //            main.ShowDialog();
            //        }
            //        else
            //        {
            //            Cursor = Cursors.Default;
            //            MessageBox.Show("Username or password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Cursor = Cursors.Default;
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}
