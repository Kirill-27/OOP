﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShowroomLibrary.Models;

namespace BuyerApp
{
    public partial class BuyerAllCars : Form // форма для просмотра всех авто в автосалоне и для покупки
    {
        CarShowroom carShowroom1;
        public Buyer CurentBuyer { get; set; }
        public BuyerAllCars()
        {
            carShowroom1 = new CarShowroom();
            InitializeComponent();
            carShowroom1.Load();
            carBindingSource.DataSource = carShowroom1.Cars;
        }
        public BuyerAllCars(Buyer curent)
        {
            carShowroom1 = new CarShowroom();
            InitializeComponent();
            carShowroom1.Load();
            carBindingSource.DataSource = carShowroom1.Cars;
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
            carShowroom1.Save();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.Load();
            carBindingSource.ResetBindings(false);
        }


        private void Buy_but_Click(object sender, EventArgs e)
        {
            if (carShowroom1.ShoppingCart.Count == 0)
            {
                MessageBox.Show("Shopping cart is empty", "Attention!");
                return;
            }
            var res = MessageBox.Show("Buy all cars from the shopping cart?", "Сonfirmation", MessageBoxButtons.YesNo);
            if (res==DialogResult.No) return;
            List<Car>ForBuy = new List<Car>();
            foreach (var shop in carShowroom1.ShoppingCart)
            {
                ForBuy.Add(new Car
                {
                    ID = shop.ID,
                    Features=shop.Features,
                    MaksSpeed=shop.MaksSpeed,
                    Model=shop.Model,
                    Price=shop.Price,
                    ProdCountry=shop.ProdCountry,
                    TechState=shop.TechState,
                    YearOfIssue=shop.YearOfIssue
                }) ;
            }
            Report buy = new Report(ForBuy, CurentBuyer.Name, DateTime.Now);
            carShowroom1.Reports.Add(buy);
            while(carShowroom1.ShoppingCart.Count>0)
            {
                foreach (var shop in carShowroom1.ShoppingCart)
                {
                    foreach (var car in carShowroom1.Cars)
                    {
                        if (shop.ID == car.ID)
                        {
                            carShowroom1.Cars.Remove(car);
                            break;
                        }
                    }
                    carShowroom1.ShoppingCart.Remove(shop);
                    break;
                }
            }
            carShowroom1.Save();
            carBindingSource.ResetBindings(false);
        }

        private void ShowBut_Click(object sender, EventArgs e)
        {
            carBindingSource.DataSource = carShowroom1.ShoppingCart;
            AllCars.BackColor = Color.PaleGreen;
            ShowBut.BackColor = Color.LimeGreen;
            
        }

        private void AllCars_Click(object sender, EventArgs e)
        {
            carBindingSource.DataSource = carShowroom1.Cars;
            ShowBut.BackColor = Color.PaleGreen;
            AllCars.BackColor = Color.LimeGreen;
        }

        private void AddCarBut_Click(object sender, EventArgs e)
        {
            if (carShowroom1.Cars.Count != 0 && carBindingSource.DataSource == carShowroom1.Cars)
            {
                var toAdd = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                bool chekincart = false;
                foreach(var c in carShowroom1.ShoppingCart)
                {
                    if(c.ID.Equals(toAdd.ID))
                    {
                        MessageBox.Show($"This car is already in your cart", "Attention!", MessageBoxButtons.OK);
                        chekincart = true;
                        break;
                    }
                }
                if(chekincart == true) return;
                var res = MessageBox.Show($"Add {toAdd.Model} to shopping cart?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        carShowroom1.ShoppingCart.Add(
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
            if (carShowroom1.ShoppingCart.Count != 0 && carBindingSource.DataSource == carShowroom1.ShoppingCart)
            {
                var toDel = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                var res = MessageBox.Show($"Remove{toDel.Model} from the shopping cart?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        carShowroom1.ShoppingCart.Remove(toDel);
                        carBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void BuyerAllCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(carShowroom1.ShoppingCart.Count!=0)
            {
                var res = MessageBox.Show($"Exit and empty the shopping cart?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        e.Cancel=true;
                        break;
                }
            }
             
        }

        private void shopingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carBindingSource.DataSource = carShowroom1.ShoppingCart;
            AllCars.BackColor = Color.PaleGreen;
            ShowBut.BackColor = Color.LimeGreen;
        }

        private void allCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carBindingSource.DataSource = carShowroom1.Cars;
            ShowBut.BackColor = Color.PaleGreen;
            AllCars.BackColor = Color.LimeGreen;
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This window provides a list of all cars.\n" +
                "You can buy a car, to do this, select the appropriate one from the list and click the " +
                "\"Add to cart  Remove from cart \" button. The car will be added to the cart." +
                " You cannot add more than one car to the basket.\n" +
                "To view the basket, click the \"My shopping cart \" button here you can " +
                "remove the selected item from the basket using the \"Add to cart Remove from cart \" button.\n" +
            "To buy all cars from the basket click \"Buy \" \n" +
            "If you exit this window, then the basket will be dumped.", "Help");
        }
    }
}
