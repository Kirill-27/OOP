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
    public partial class FindBest : Form //форма поиска лучшей машини для текущего покупателя
    {
        CarShowroom carShowroom1;
        public Buyer CurentBuyer { get; set; }
        public FindBest()
        {
            InitializeComponent();
            carShowroom1 = new CarShowroom();
            carShowroom1.Load();
            carBindingSource.DataSource = carShowroom1.Cars;
        }
        public FindBest(Buyer curent)
        {
            InitializeComponent();
            carShowroom1 = new CarShowroom();
            carShowroom1.Load();
            CurentBuyer = curent;
            carShowroom1.FindAllthebest(CurentBuyer);
            carBindingSource.DataSource = carShowroom1.ShoppingCart;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void AllBut_Click(object sender, EventArgs e)
        {
            carShowroom1.FindAllthebest(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.LimeGreen;
            ModelBut.BackColor = Color.PaleGreen;
            PriceBut.BackColor = Color.PaleGreen;
        }

        private void ModelBut_Click(object sender, EventArgs e)
        {
            carShowroom1.FindBestModel(CurentBuyer); 
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.PaleGreen;
            ModelBut.BackColor = Color.LimeGreen;
            PriceBut.BackColor = Color.PaleGreen;
        }

        private void PriceBut_Click(object sender, EventArgs e)
        {
            carShowroom1.FindBestPrice(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.PaleGreen;
            ModelBut.BackColor = Color.PaleGreen;
            PriceBut.BackColor = Color.LimeGreen;
        }

        private void BuyBut_Click(object sender, EventArgs e)
        {
            if (carShowroom1.ShoppingCart.Count == 0) return;
            var ToBuy = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
            var res = MessageBox.Show($"Buy {ToBuy.Model}?", "Сonfirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            List<Car> ForBuy = new List<Car>();
            ForBuy.Add(ToBuy);
            Report buy = new Report(ForBuy, CurentBuyer.Name, DateTime.Now);
            carShowroom1.Reports.Add(buy);
            foreach(var c in carShowroom1.Cars)
            {
                if(c.ID.Equals(ToBuy.ID))
                {
                    carShowroom1.Cars.Remove(c);
                    break;
                }
            }
            foreach (var c in carShowroom1.ShoppingCart)
            {
                if (c.ID.Equals(ToBuy.ID))
                {
                    carShowroom1.ShoppingCart.Remove(c);
                    break;
                }
            }
            carShowroom1.Save();
            carBindingSource.ResetBindings(false);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This window allows you to find the car that suits you best and buy it if you wish.\n" +
                "You can view the list of cars that suit you personally at the" +
                " price of either a model, as well as a list of cars " +
                "that fully meet your requirements, to do this, use the buttons at the bottom of the screen.\n" +
                "To buy a car, select it from the list and click the buy button.", "Help");
        }

        private void byAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.FindAllthebest(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.LimeGreen;
            ModelBut.BackColor = Color.PaleGreen;
            PriceBut.BackColor = Color.PaleGreen;
        }

        private void byModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.FindBestModel(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.PaleGreen;
            ModelBut.BackColor = Color.LimeGreen;
            PriceBut.BackColor = Color.PaleGreen;
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.FindBestPrice(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.PaleGreen;
            ModelBut.BackColor = Color.PaleGreen;
            PriceBut.BackColor = Color.LimeGreen;
        }
    }
}
