using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroomLibrary
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

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Help();
            f.ShowDialog();
        }
    }
}
