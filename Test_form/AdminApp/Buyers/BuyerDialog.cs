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
    //класс формы диалогового окна для изменения или добавления покупателя
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
            ChekPass(NametextBox, e);
            ChekPass(PastextBox, e);
            if (e.Cancel != false)
                MessageBox.Show("Password and login must be at least 3 characters and no more than 12", "Attention!");
            ChekText(ContacttextBox, e);
            if (e.Cancel == false)
            {
                CarShowroom CarShowroom1 = new CarShowroom();
                CarShowroom1.Load();
                foreach(var b in CarShowroom1.Buyers)
                {
                    if (b.Name.Equals(NametextBox.Text))
                    {
                        e.Cancel = true;
                        NametextBox.BackColor = Color.LightPink;
                        MessageBox.Show("User with the same name already exists", "Attantion!", MessageBoxButtons.OK);
                    }
                }
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
                    if (string.IsNullOrWhiteSpace(ModelcomboBox.Text))
                    {
                        Buyer.ModelRequired = "nope";
                    }
                }
            }
        }
        private void ChekText(Control text, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text) || text.Text.Length >= 20)
            {
                text.BackColor = Color.LightPink;
                e.Cancel = true;
            }
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

        private void ChekPass(Control text, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text) || text.Text.Length > 12 || text.Text.Length < 3)
            {
                text.BackColor = Color.LightPink;
                e.Cancel = true;
            }
            else text.BackColor = Color.White;
        }
    }
}
