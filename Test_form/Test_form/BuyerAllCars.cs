using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyerApp;
using CarShowroomLibrary.Models;

namespace CarShowroomLibrary
{
    public partial class BuyerAllCars : Form
    {
        CarShowroom CarShowroom1;
        public Buyer CurentBuyer { get; set; }
        public BuyerAllCars()
        {
            CarShowroom1 = new CarShowroom();
            InitializeComponent();
            CarShowroom1.Load();
            carBindingSource.DataSource = CarShowroom1.Cars;
        }
        public BuyerAllCars(Buyer curent)
        {
            CarShowroom1 = new CarShowroom();
            InitializeComponent();
            CarShowroom1.Load();
            carBindingSource.DataSource = CarShowroom1.Cars;
            this.CurentBuyer = curent;
        }
        private void Back_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Save();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Load();
            carBindingSource.ResetBindings(false);
        }


        private void Buy_but_Click(object sender, EventArgs e)
        {

        }

        private void ShowBut_Click(object sender, EventArgs e)
        {
            carBindingSource.DataSource = CarShowroom1.ShoppingCart;
        }

        private void AllCars_Click(object sender, EventArgs e)
        {
            carBindingSource.DataSource = CarShowroom1.Cars;
        }

        private void AddCarBut_Click(object sender, EventArgs e)
        {
            if (CarShowroom1.Cars.Count != 0 && carBindingSource.DataSource == CarShowroom1.Cars)
            {
                var toAdd = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                bool chekincart = false;
                foreach(var c in CarShowroom1.ShoppingCart)
                {
                    if(c.ID.Equals(toAdd.ID))
                    {
                        MessageBox.Show($"This car is already in your cart", "Attention!", MessageBoxButtons.OK);
                        chekincart = true;
                        break;
                    }
                }
                if(chekincart == true) return;
                var res = MessageBox.Show($"Add {toAdd.Model} to Shopping Cart?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        CarShowroom1.ShoppingCart.Add(
                            new Car
                            {
                                Features = toAdd.Features,
                                ID = toAdd.ID,
                                MaksSpeed = toAdd.MaksSpeed,
                                Model = toAdd.Model,
                                Price = toAdd.Price,
                                ProdCountry = toAdd.ProdCountry,
                                TechState = toAdd.TechState,
                                YearOfIssue = toAdd.YearOfIssue
                            }
                        );
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            if (CarShowroom1.ShoppingCart.Count != 0 && carBindingSource.DataSource == CarShowroom1.ShoppingCart)
            {
                var toDel = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                var res = MessageBox.Show($"Remove{toDel.Model} from the Shopping Cart?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        CarShowroom1.ShoppingCart.Remove(toDel);
                        carBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
