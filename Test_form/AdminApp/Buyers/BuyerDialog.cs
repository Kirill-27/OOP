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
            if (DialogResult != DialogResult.OK) return;
            ChekText(ContacttextBox, e);
            ChekText(NametextBox, e);
            ChekText(PastextBox, e);
            if (e.Cancel == false)
            {
                if (Buyer == null) Buyer = new Buyer();
                Buyer.Contacts = ContacttextBox.Text;
                Buyer.FinancialOpp = Convert.ToInt32(Prise_numericUp.Value);
                Buyer.MaksSpeedRequired = Convert.ToInt32(Speed_numeric.Value);
                Buyer.ModelRequired = ModelcomboBox.Text;
                Buyer.Name = NametextBox.Text;
                Buyer.Password = PastextBox.Text;
                Buyer.PerfomanceRequired = Convert.ToInt32(Perf_numeric.Value);
                if(string.IsNullOrWhiteSpace(ModelcomboBox.Text))
                {
                    Buyer.ModelRequired = "nope";
                }
            }
        }
        private void ChekText(Control text, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text) || text.Text.Length >= 25)
            {
                text.BackColor = Color.LightPink;
                e.Cancel = true;
            }
            else text.BackColor = Color.White;
        }


        private void NametextBox_Click(object sender, EventArgs e)
        {
            NametextBox.BackColor = Color.White;
        }

        private void PastextBox_Click(object sender, EventArgs e)
        {
            PastextBox.BackColor = Color.White;
        }

        private void ContacttextBox_Click(object sender, EventArgs e)
        {
            ContacttextBox.BackColor = Color.White;
        }
    }
}
