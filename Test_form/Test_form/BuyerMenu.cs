using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_form
{
    public partial class BuyerMenu : Form
    {
       // CarShowroom CarShowroom1=
        public BuyerMenu()
        {
            InitializeComponent();

        }

        private void AllCars_but_Click(object sender, EventArgs e)
        {
            var AllCar = new BuyerAllCars();
            this.Hide();
            AllCar.ShowDialog();
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CarShowroom1.Save();
        }
    }
}
