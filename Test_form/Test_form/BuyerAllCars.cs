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
        CarShowroom Carss = new CarShowroom();
        public BuyerAllCars()
        {
            InitializeComponent();
            Carss.FillTestData(20);
            
        }

        private void Back_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
