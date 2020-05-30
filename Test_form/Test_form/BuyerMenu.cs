using BuyerApp;
using CarShowroomLibrary.Models;
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
    public partial class BuyerMenu : Form //форма основого меню покупателя
    {
        public Buyer CurentBuyer { get; set; }
        
        public BuyerMenu()
        {
            InitializeComponent();
        }
        public BuyerMenu(Buyer curent)
        {
            InitializeComponent();
            this.CurentBuyer = curent;
        }
        private void AllCars_but_Click(object sender, EventArgs e)
        {
            var AllCar = new BuyerAllCars();
            this.Hide();
            AllCar.ShowDialog();
            this.Visible = true;
        }

        private void AllCarsBut_Click(object sender, EventArgs e)
        {
            var f = new BuyerAllCars(CurentBuyer);
            Hide();
            if (f.ShowDialog() != DialogResult.Yes)
            {
                Close();
                return;
            }
            Visible = true;
        }

        private void FindCarBut_Click(object sender, EventArgs e)
        {
            var f = new FindBest(CurentBuyer);
            Hide();
            if (f.ShowDialog() != DialogResult.Yes)
            {
                Close();
                return;
            }
            Visible = true;
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Main user menu. use buttons to take advantage" +
                " of your opportunities", "Help");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountBut_Click(object sender, EventArgs e)
        {
            var f = new Register(CurentBuyer);
            f.ShowDialog();
        }
    }
}
