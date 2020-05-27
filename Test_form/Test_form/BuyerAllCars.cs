using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_form.Models;

namespace Test_form
{
    public partial class BuyerAllCars : Form
    {
        CarShowroom CarShowroom1;
        public BuyerAllCars()
        {
            CarShowroom1 = new CarShowroom();
            InitializeComponent();
            CarShowroom1.FillTestData(20);
            carBindingSource.DataSource = CarShowroom1.Cars;
        }

        private void Back_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Save();
        }


    }
}
