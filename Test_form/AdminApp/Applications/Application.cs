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
            CarShowroom1.ifSaved = false;
            carInApplicBindingSource.DataSource = CarShowroom1.Application;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Application_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                if (CarShowroom1.Application.Count != 0 && CarShowroom1.ifSaved == true)
                {
                    var res = MessageBox.Show("Send the application before exit?", "Verification", MessageBoxButtons.YesNoCancel);
                    switch (res)
                    {
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                        case DialogResult.Yes:
                            CarShowroom1.Send();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            
            
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if(CarShowroom1.Application.Count!=0) CarShowroom1.Send();
            CarShowroom1.ifSaved = true;
            Close();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var fo = new ApplicationDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                CarShowroom1.Application.Add(fo.Appl);
                carInApplicBindingSource.ResetBindings(false);
            }
        }

        private void SendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarShowroom1.Application.Count != 0) CarShowroom1.Send();
            CarShowroom1.ifSaved = true;
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fo = new ApplicationDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                CarShowroom1.Application.Add(fo.Appl);
                carInApplicBindingSource.ResetBindings(false);
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var he = new Help();
            he.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (CarShowroom1.Application.Count != 0)
            {
                var toDel = AppldataGridView.SelectedRows[0].DataBoundItem as CarInApplic;
                var res = MessageBox.Show($"Delete {toDel.Model} ?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        CarShowroom1.Application.Remove(toDel);
                        carInApplicBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarShowroom1.Application.Count != 0)
            {
                var toDel = AppldataGridView.SelectedRows[0].DataBoundItem as CarInApplic;
                var res = MessageBox.Show($"Delete {toDel.Model} ?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        CarShowroom1.Application.Remove(toDel);
                        carInApplicBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            if(CarShowroom1.Application.Count!=0)
            {
                var ToEdit = AppldataGridView.SelectedRows[0].DataBoundItem as CarInApplic;
                var fo = new ApplicationDialog(ToEdit);
                if (fo.ShowDialog() == DialogResult.OK) carInApplicBindingSource.ResetBindings(false);
                
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarShowroom1.Application.Count != 0)
            {
                var ToEdit = AppldataGridView.SelectedRows[0].DataBoundItem as CarInApplic;
                var fo = new ApplicationDialog(ToEdit);
                if (fo.ShowDialog() == DialogResult.OK)carInApplicBindingSource.ResetBindings(false);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
