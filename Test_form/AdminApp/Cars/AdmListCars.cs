﻿using System;
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
    //класс формы на которой админу 
    //предоставляется возможность взаимодействия с базой автомобилей
    public partial class AdmListCars : Form 
    {
        CarShowroom carShowroom1;
        public AdmListCars()
        {
            InitializeComponent();
            carShowroom1 = new CarShowroom();
            //CarShowroom1.FillTestData(100);
            carShowroom1.Load();
            carBindingSource.DataSource = carShowroom1.Cars; 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Close();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carShowroom1.Cars.Count != 0)
            {
                var toDel = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                var res = MessageBox.Show($"Delete {toDel.Model} ?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        carShowroom1.Cars.Remove(toDel);
                        carShowroom1.ifSaved = false;
                        carBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void AdmListCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!carShowroom1.ifSaved)
            {
                var res = MessageBox.Show("Save the data before exit?", "Verification", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        carShowroom1.Save();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.Save();
            carShowroom1.ifSaved = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (carShowroom1.Cars.Count != 0)
            {
                var toDel = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                var res = MessageBox.Show($"Delete {toDel.Model} ?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        carShowroom1.Cars.Remove(toDel);
                        carShowroom1.ifSaved = false;
                        carBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }

        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.Load();
            carBindingSource.ResetBindings(false);
            carShowroom1.ifSaved = true;
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var fo = new CarsDialog();
            if(fo.ShowDialog()==DialogResult.OK)
            {
                carShowroom1.ifSaved = false;
                carShowroom1.AddCar(fo.Car);
                carBindingSource.ResetBindings(false);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carShowroom1.Cars.Count != 0)
            {
                var ToEdit = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                var fo = new CarsDialog(ToEdit);
                if (fo.ShowDialog() == DialogResult.OK)
                {
                    carShowroom1.ifSaved = false;
                    carBindingSource.ResetBindings(false);
                }
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {

            if (carShowroom1.Cars.Count != 0)
            {
                var ToEdit = CarsdataGridView.SelectedRows[0].DataBoundItem as Car;
                var fo = new CarsDialog(ToEdit);
                if (fo.ShowDialog() == DialogResult.OK)
                {
                    carShowroom1.ifSaved = false;
                    carBindingSource.ResetBindings(false);
                }
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a window for interacting with the car base.", "Help");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fo = new CarsDialog();
            if (fo.ShowDialog() == DialogResult.OK) 
            {
                carShowroom1.ifSaved = false;
                carShowroom1.AddCar(fo.Car);
                carBindingSource.ResetBindings(false);
            }
        }
    }
}
