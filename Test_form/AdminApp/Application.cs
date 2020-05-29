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
    public partial class Application : Form
    {
        CarShowroom CarShowroom1;
        public Application()
        {
            InitializeComponent();
            CarShowroom1 = new CarShowroom();
            carInApplicBindingSource.DataSource = CarShowroom1.Application;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Application_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                if (!CarShowroom1.ifSaved&& CarShowroom1.Application.Count != 0)
                {
                    var res = MessageBox.Show("Send the application before exit?", "Verification", MessageBoxButtons.YesNoCancel);
                    switch (res)
                    {
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                        case DialogResult.Yes:
                            CarShowroom1.SaveAppl();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            
            
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if(CarShowroom1.Application.Count!=0) CarShowroom1.SaveAppl();
            CarShowroom1.ifSaved = true;
            Close();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var fo = new ApplicantDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                CarShowroom1.ifSaved = false;
                CarShowroom1.Application.Add(fo.Appl);
                carInApplicBindingSource.ResetBindings(false);
            }
        }
    }
}
