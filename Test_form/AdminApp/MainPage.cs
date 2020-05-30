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
    public partial class MainPage : Form // класс формы авторизации админа
    {
        CarShowroom CarShowroom1;
        public MainPage()
        {
            InitializeComponent();
            CarShowroom1 = new CarShowroom();
            CarShowroom1.FillTestData(20);
            CarShowroom1.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_but_Click(object sender, EventArgs e)
        {
            bool chek = false;
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
            string chekpass = PassTextBox.Text;
            CarShowroom1.Load();
            foreach (var b in CarShowroom1.Admins)
            {
                if (b.Name.Equals(cheklog) && b.Password.Equals(chekpass))
                {
                    chek = true;
                }
            }
            if (chek == false)
            {
                MessageBox.Show("No admin with this username and password", "Attantion!", MessageBoxButtons.OK);
                return;
            }
            var F = new AdminMenu();
            this.Hide();
            F.ShowDialog();
            this.Close();
        }

        private void LogTextbox_Click(object sender, EventArgs e)
        {
            LogTextbox.BackColor = Color.White;
        }

        private void PassTextBox_Click(object sender, EventArgs e)
        {
            PassTextBox.BackColor = Color.White;
        }

      
    }
}
