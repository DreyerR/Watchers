﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchers
{
    public partial class tabBookings : UserControl
    {

        private static tabBookings _instance;

        public static tabBookings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabBookings();
                }
                return _instance;
            }
        }

        //public void SetMyCustomFormat()
        //{
        //    dtpDate.Format = DateTimePickerFormat.Custom;
        //    dtpDate.CustomFormat = "MMMM dd, yyyy";
        //}

        public tabBookings()
        {
            InitializeComponent();
        }

        private void tabBookings_Load(object sender, EventArgs e)
        {

        }
    }
}
