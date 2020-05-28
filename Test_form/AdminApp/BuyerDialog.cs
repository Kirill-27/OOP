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
    public partial class BuyerDialog : Form
    {
        public Buyer Buyer { get; set; }
        public BuyerDialog()
        {
            InitializeComponent();
        }
        public BuyerDialog(Buyer Edited) : this()
        {
            Buyer = Edited;
            ContacttextBox.Text=Buyer.Contacts ;
            Prise_numericUp.Value = Buyer.FinancialOpp;
            Speed_numeric.Value = Buyer.MaksSpeedRequired;
            ModelcomboBox.Text = Buyer.ModelRequired;
            NametextBox.Text = Buyer.Name;
            PastextBox.Text = Buyer.Password;
            Perf_numeric.Value = Buyer.PerfomanceRequired;
        }
        private void BuyerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Buyer == null) Buyer = new Buyer();
            Buyer.Contacts = ContacttextBox.Text;
            Buyer.FinancialOpp= Convert.ToInt32(Prise_numericUp.Value);
            Buyer.MaksSpeedRequired = Convert.ToInt32(Speed_numeric.Value);
            Buyer.ModelRequired = ModelcomboBox.Text;
            Buyer.Name = NametextBox.Text;
            Buyer.Password = PastextBox.Text;
            Buyer.PerfomanceRequired = Convert.ToInt32(Perf_numeric.Value);
        }
    }
}
