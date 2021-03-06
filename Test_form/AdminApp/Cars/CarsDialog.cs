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

namespace AdminApp
{
    //класс формы диалогового окна для изменения или добавления автомобиля
    public partial class CarsDialog : Form
    {
        public Car Car { get; set; }
        public CarsDialog()
        {
            InitializeComponent();
        }
        public CarsDialog(Car edited): this()
        {
            Car = edited;
            ModelcomboBox.Text = Car.Model;
            Speed_numeric.Value = Car.MaksSpeed;
            Prise_numericUp.Value = Car.Price;
            FeaturestextBox.Text = Car.Features;
            Year_numeric.Value = Car.YearOfIssue;
            CountrycomboBox.Text = Car.ProdCountry;
            Tech_numeric.Value = Car.TechState;
        }
        private void CarsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;
            ChekText(ModelcomboBox, e);
            ChekText(CountrycomboBox, e);
            if (e.Cancel == false)
            {
                if (Car == null) Car = new Car { ID = -1 };
                Car.Model = ModelcomboBox.Text;
                Car.ProdCountry = CountrycomboBox.Text;
                Car.MaksSpeed = Convert.ToInt32(Speed_numeric.Value);
                Car.Price = Convert.ToInt32(Prise_numericUp.Value);
                Car.TechState = Convert.ToInt32(Tech_numeric.Value);
                Car.YearOfIssue = Convert.ToInt32(Year_numeric.Value);
                if (string.IsNullOrWhiteSpace(FeaturestextBox.Text)) Car.Features = "none";

            }
            else MessageBox.Show("You cannot add an empty text field or more than 25 characters","Attention!");
           
        }
        private void ChekText(Control text, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text)||text.Text.Length>=25)
            {
                text.BackColor = Color.LightPink;
                e.Cancel = true;
            }
        }

        private void ModelcomboBox_Click(object sender, EventArgs e)
        {
            ModelcomboBox.BackColor = Color.White;
        }

        private void CountrycomboBox_Click(object sender, EventArgs e)
        {
            CountrycomboBox.BackColor = Color.White;
        }

        
    }
}
