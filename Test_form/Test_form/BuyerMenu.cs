using BuyerApp;
using CarShowroomLibrary;
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

namespace BuyerApp
{
    public partial class BuyerMenu : Form //форма основого меню покупателя
    {
        public Buyer CurentBuyer { get; set; }
        CarShowroom carShowroom1 = new CarShowroom();
       
        public BuyerMenu()
        {
           
           InitializeComponent();
            carShowroom1.Load();
        }
        public BuyerMenu(Buyer curent)
        {
            InitializeComponent();
            this.CurentBuyer = curent;
            carShowroom1.Load();
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

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountBut_Click(object sender, EventArgs e)
        {
            carShowroom1.Load();
            foreach(var b in carShowroom1.Buyers)
            {
                if (b.Name.Equals(CurentBuyer.Name)) CurentBuyer = b;
            }
            var f = new Register(CurentBuyer);
            f.ShowDialog();
            carShowroom1.Save();
        }
    }
}
