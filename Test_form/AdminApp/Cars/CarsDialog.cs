using System;
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
            if (Car == null) Car = new Car { ID = -1 };
            Car.Features = FeaturestextBox.Text;
            Car.Model = ModelcomboBox.Text;
            Car.ProdCountry = CountrycomboBox.Text;
            Car.MaksSpeed = Convert.ToInt32(Speed_numeric.Value);
            Car.Price = Convert.ToInt32(Prise_numericUp.Value);
            Car.TechState = Convert.ToInt32(Tech_numeric.Value);
            Car.YearOfIssue = Convert.ToInt32(Year_numeric.Value);
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Exit(without saving data)?", "Exit", MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.Yes:
                    Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Help();
            f.ShowDialog();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            if (Car != null)
            {
                ModelcomboBox.Text = Car.Model;
                Speed_numeric.Value = Car.MaksSpeed;
                Prise_numericUp.Value = Car.Price;
                FeaturestextBox.Text = Car.Features;
                Year_numeric.Value = Car.YearOfIssue;
                CountrycomboBox.Text = Car.ProdCountry;
                Tech_numeric.Value = Car.TechState;
            }
        }
    }
}
