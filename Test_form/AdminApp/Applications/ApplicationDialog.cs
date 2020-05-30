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

namespace AdminApp
{
    //класс формы диалогового окна для изменения или добавления новой позиции в заявку поставщикам
    public partial class ApplicationDialog : Form
    {
        public CarInApplic Appl { get; set; }
        public ApplicationDialog()
        {
            InitializeComponent();
        }

        public ApplicationDialog(CarInApplic Edited) : this()
        {
            Appl = Edited;
            AmountNumretic.Value = Appl.Amount;
            ModelcomboBox.Text = Appl.Model;
            Yearnumeric.Value = Appl.YearOfIssue;
            CountrycomboBox.Text = Appl.ProdCountry;
            Technumeric.Value = Appl.TechState;
        }
        private void ApplicantDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;
            ChekText(ModelcomboBox, e);
            ChekText(CountrycomboBox, e);
            if (e.Cancel==false)
            {
                if (Appl == null) Appl = new CarInApplic();
                Appl.Amount = Convert.ToInt32(AmountNumretic.Value);
                Appl.Model = ModelcomboBox.Text;
                Appl.ProdCountry = CountrycomboBox.Text;
                Appl.TechState = Convert.ToInt32(Technumeric.Value);
                Appl.YearOfIssue = Convert.ToInt32(Yearnumeric.Value);
            }
            
        }

        private void ChekText(Control text, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text) || text.Text.Length >= 25 )
            {
                text.BackColor = Color.LightPink;
                e.Cancel = true;
            }
            else text.BackColor = Color.White;
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
