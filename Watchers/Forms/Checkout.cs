﻿using System;
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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOutMM_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }
    }
}
