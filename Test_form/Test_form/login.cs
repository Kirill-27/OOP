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
            bool chek = false;
            Buyer CurentBuyer=new Buyer();
            if (string.IsNullOrWhiteSpace(PassTextBox.Text))
            {
                PassTextBox.BackColor = Color.LightPink;
                chek = true;
            }
            if (string.IsNullOrWhiteSpace(LogTextbox.Text))
            {
                LogTextbox.BackColor = Color.LightPink;
                chek = true;
            }
            if (chek == true) return;
            string cheklog = LogTextbox.Text;
            string chekpass= PassTextBox.Text;
            CarShowroom1.Load();
            foreach(var b in CarShowroom1.Buyers)
            {
                if (b.Name.Equals(cheklog)&&b.Password.Equals(chekpass))
                {
                    chek = true;
                    CurentBuyer = b;
                }
            }
            if (chek == false)
            {
                MessageBox.Show("No user with this username and password", "Attantion!", MessageBoxButtons.OK);
                return;
            }
            var buyerF = new BuyerMenu(CurentBuyer);
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
