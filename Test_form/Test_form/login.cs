using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyerApp;
using CarShowroomLibrary.Models;

namespace CarShowroomLibrary
{
    
    public partial class login : Form
    {
        CarShowroom CarShowroom1 =  new CarShowroom();
        public login()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Login_but_Click(object sender, EventArgs e)
        {
            var buyerF = new BuyerMenu();
            this.Hide();
            buyerF.ShowDialog();
            this.Close();
        }


        private void RegistrationBut_Click(object sender, EventArgs e)
        {
            CarShowroom1.Load();
            var fo = new Register();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                CarShowroom1.ifSaved = false;
                CarShowroom1.Buyers.Add(fo.Buyer);
                CarShowroom1.Save();
            }
        }
    }
}
