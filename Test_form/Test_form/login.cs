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

namespace Test_form
{
    
    public partial class login : Form
    {
        CarShowroom CarShowroom1 =  new CarShowroom();
        
        public login()
        {
            InitializeComponent();
            this.Text = "Автосалон <У ХНУРЭ>";
        }

        

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Save();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarShowroom1.Load();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Login_but_Click(object sender, EventArgs e)
        {
            var buyerF = new BuyerMenu();
            this.Hide();
            buyerF.ShowDialog();
            this.Close();
        }

        
    }
}
