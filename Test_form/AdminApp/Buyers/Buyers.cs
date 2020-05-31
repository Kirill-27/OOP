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
    //класс формы на которой админу 
    //предоставляется возможность взаимодействия с базой покупателей
    
    public partial class Buyers : Form
    {
        CarShowroom carShowroom1;
        public Buyers()
        {
            InitializeComponent();
            carShowroom1 = new CarShowroom();
            carShowroom1.Load();
            buyerBindingSource.DataSource = carShowroom1.Buyers;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.Save();
            carShowroom1.ifSaved = true;
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carShowroom1.Load();
            carShowroom1.ifSaved = true;
            buyerBindingSource.ResetBindings(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void Buyers_FormClosing(object sender, FormClosingEventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (carShowroom1.Buyers.Count != 0)
            {
                var toDel = BuyersdataGridView.SelectedRows[0].DataBoundItem as Buyer;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        carShowroom1.Buyers.Remove(toDel);
                        carShowroom1.ifSaved = false;
                        buyerBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void AddBuyerBut_Click(object sender, EventArgs e)
        {
            var fo = new BuyerDialog();
            if (fo.ShowDialog() == DialogResult.OK) 
            {
                carShowroom1.ifSaved = false;
                carShowroom1.Buyers.Add(fo.Buyer);
                buyerBindingSource.ResetBindings(false);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
                var fo = new BuyerDialog();
                if (fo.ShowDialog() == DialogResult.OK)
                {
                    carShowroom1.ifSaved = false;
                    carShowroom1.Buyers.Add(fo.Buyer);
                    buyerBindingSource.ResetBindings(false);
                }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a window for interacting with a buyer's base.", "Help");
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carShowroom1.Buyers.Count != 0)
            {
                var toDel = BuyersdataGridView.SelectedRows[0].DataBoundItem as Buyer;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        carShowroom1.Buyers.Remove(toDel);
                        carShowroom1.ifSaved = false;
                        buyerBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
