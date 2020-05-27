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
    public partial class AdmListCars : Form
    {
        CarShowroom CarShowroom1;
        public AdmListCars()
        {
            InitializeComponent();
            CarShowroom1 = new CarShowroom();
            //CarShowroom1.FillTestData(20);
            CarShowroom1.Load();
            CarsBindingSource.DataSource = CarShowroom1.Cars;
            listAllCars.DisplayMember="Model";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = listAllCars.SelectedItem as Car;
            var res = MessageBox.Show($"Delete {toDel.Model} ?", "Сonfirmation", MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.Yes:
                    CarShowroom1.Cars.Remove(toDel);
                    CarShowroom1.ifSaved = false;
                    CarsBindingSource.ResetBindings(false);
                    listAllCars.DisplayMember = "Model";
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void AdmListCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CarShowroom1.ifSaved)
            {
                var res = MessageBox.Show("Save the data before exit?", "Verification", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        CarShowroom1.Save();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Save();
            CarShowroom1.ifSaved = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var toDel = listAllCars.SelectedItem as Car;
            var res = MessageBox.Show($"Delete {toDel.Model} ?", "Сonfirmation", MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.Yes:
                    CarShowroom1.Cars.Remove(toDel);
                    CarShowroom1.ifSaved = false;
                    CarsBindingSource.ResetBindings(false);
                    listAllCars.DisplayMember = "Model";
                    break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Load();
            CarsBindingSource.ResetBindings(false);
            listAllCars.DisplayMember = "Model";
            CarShowroom1.ifSaved = true;
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var fo = new CarsDialog();
            if(fo.ShowDialog()==DialogResult.OK);
            {
                CarShowroom1.ifSaved = false;
                CarShowroom1.AddCar(fo.Car);
                CarsBindingSource.ResetBindings(false);
                listAllCars.DisplayMember = "Model";
            }
        }

       
    }
}
