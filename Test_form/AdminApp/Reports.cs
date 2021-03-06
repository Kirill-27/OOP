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
    public partial class Reports : Form // класс формы на которой отображаются отчеты
    {
        CarShowroom carShowroom1;
        public Reports()
        {
            InitializeComponent();
            carShowroom1 = new CarShowroom();
            carShowroom1.Load();
            reportBindingSource.DataSource = carShowroom1.Reports;
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a report window, in the " +
                "left table there is information about the name of the buyer and the date, " +
                "in order to see the list of cars that were sold, " +
                "click on the corresponding line","Help");
        }
    }
}
