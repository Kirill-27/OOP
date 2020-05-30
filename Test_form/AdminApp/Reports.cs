﻿using CarShowroomLibrary.Models;
using System;
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
    public partial class Reports : Form
    {
        CarShowroom CarShowroom1;
        public Reports()
        {
            InitializeComponent();
            CarShowroom1 = new CarShowroom();
            CarShowroom1.Load();
            reportBindingSource.DataSource = CarShowroom1.Reports;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReportdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Report ReportCar = (Report)reportBindingSource.Current;
            carBindingSource.DataSource = ReportCar.Cars_R;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}