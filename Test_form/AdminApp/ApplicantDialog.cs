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
    public partial class ApplicantDialog : Form
    {
        public CarInApplic Appl { get; set; }
        public ApplicantDialog()
        {
            InitializeComponent();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            Close();
        }
        public ApplicantDialog(CarInApplic Edited) : this()
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
            if (Appl == null) Appl = new CarInApplic();
            Appl.Amount = Convert.ToInt32(AmountNumretic.Value);
            Appl.Model= ModelcomboBox.Text;
            Appl.ProdCountry = CountrycomboBox.Text;
            Appl.TechState = Convert.ToInt32(Technumeric.Value);
            Appl.YearOfIssue = Convert.ToInt32(Yearnumeric.Value);
        }
    }
}
