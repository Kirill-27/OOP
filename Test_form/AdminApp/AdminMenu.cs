﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }


        private void AllCarsBut_Click(object sender, EventArgs e)
        {
            var f = new AdmListCars();
            this.Hide();
            f.ShowDialog();
            this.Visible=true;
        }

        private void Buyersbut_Click(object sender, EventArgs e)
        {
            var f = new Buyers();
            this.Hide();
            f.ShowDialog();
            this.Visible = true;
        }
    }
}
