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

namespace AdminApp
{
    public partial class CarsDialog : Form
    {
        public Car Car { get; set; }
        public CarsDialog()
        {
            InitializeComponent();
        }
        public CarsDialog(Car Edited): this()
        {
            Car = Edited;
            ModeltextBox.Text = Car.Model;
            Speed_numeric.Value = Car.MaksSpeed;
            Prise_numericUp.Value = Car.Price;
            FeaturestextBox.Text = Car.Features;
            Year_numeric.Value = Car.YearOfIssue;
            CountrytextBox.Text = Car.ProdCountry;
            Tech_numeric.Value = Car.TechState;
        }
        private void CarsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Car == null) Car = new Car { ID = -1 };
            Car.Features = FeaturestextBox.Text;
            Car.Model = ModeltextBox.Text;
            Car.ProdCountry = CountrytextBox.Text;
            Car.MaksSpeed = Convert.ToInt32(Speed_numeric.Value);
            Car.Price = Convert.ToInt32(Prise_numericUp.Value);
            Car.TechState = Convert.ToInt32(Tech_numeric.Value);
            Car.YearOfIssue = Convert.ToInt32(Year_numeric.Value);
           
        }
    }
}
