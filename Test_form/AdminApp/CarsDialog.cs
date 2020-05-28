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

        private void CarsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Car = new Car
            {
                ID=-1,
                Features = FeaturestextBox.Text,
                Model = ModeltextBox.Text,
                ProdCountry = CountrytextBox.Text,
                MaksSpeed = Convert.ToInt32(Speed_numeric.Value),
                Price = Convert.ToInt32(Prise_numericUp.Value),
                TechState = Convert.ToInt32(Tech_numeric.Value),
                YearOfIssue = Convert.ToInt32(Year_numeric.Value)
            };
        }
    }
}
