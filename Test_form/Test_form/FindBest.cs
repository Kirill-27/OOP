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
    public partial class FindBest : Form
    {
        CarShowroom CarShowroom1;
        public Buyer CurentBuyer { get; set; }
        public FindBest()
        {
            InitializeComponent();
            CarShowroom1 = new CarShowroom();
            CarShowroom1.Load();
            carBindingSource.DataSource = CarShowroom1.Cars;
        }
        public FindBest(Buyer curent)
        {
            InitializeComponent();
            CarShowroom1 = new CarShowroom();
            CarShowroom1.Load();
            CurentBuyer = curent;
            CarShowroom1.FindAllthebest(CurentBuyer);
            carBindingSource.DataSource = CarShowroom1.ShoppingCart;
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
            CarShowroom1.FindAllthebest(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.LimeGreen;
            ModelBut.BackColor = Color.PaleGreen;
            PriceBut.BackColor = Color.PaleGreen;
        }

        private void ModelBut_Click(object sender, EventArgs e)
        {
            CarShowroom1.FindBestModel(CurentBuyer); 
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.PaleGreen;
            ModelBut.BackColor = Color.LimeGreen;
            PriceBut.BackColor = Color.PaleGreen;
        }

        private void PriceBut_Click(object sender, EventArgs e)
        {
            CarShowroom1.FindBestPrice(CurentBuyer);
            carBindingSource.ResetBindings(false);
            AllBut.BackColor = Color.PaleGreen;
            ModelBut.BackColor = Color.PaleGreen;
            PriceBut.BackColor = Color.LimeGreen;
        }

        private void BuyBut_Click(object sender, EventArgs e)
        {
            if (CarShowroom1.ShoppingCart.Count == 0) return;
            var ToBuy = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
            var res = MessageBox.Show($"Buy {ToBuy}?", "Сonfirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            List<Car> ForBuy = new List<Car>();
            ForBuy.Add(ToBuy);
            Report buy = new Report(ForBuy, CurentBuyer.Name, DateTime.Now);
            CarShowroom1.Reports.Add(buy);
            foreach(var c in CarShowroom1.Cars)
            {
                if(c.ID.Equals(ToBuy.ID))
                {
                    CarShowroom1.Cars.Remove(c);
                    break;
                }
            }
            foreach (var c in CarShowroom1.ShoppingCart)
            {
                if (c.ID.Equals(ToBuy.ID))
                {
                    CarShowroom1.ShoppingCart.Remove(c);
                    break;
                }
            }
            CarShowroom1.Save();
            carBindingSource.ResetBindings(false);
        }
    }
}
