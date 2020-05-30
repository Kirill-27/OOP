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
    public partial class AdminMenu : Form  //класс формы главного меню админа
    {
        public AdminMenu()
        {
            InitializeComponent();
        }


        private void AllCarsBut_Click(object sender, EventArgs e)
        {
            var f = new AdmListCars();
            this.Hide();
            f.ShowDialog();
            this.Visible=true;
        }

        private void Buyersbut_Click(object sender, EventArgs e)
        {
            var f = new Buyers();
            this.Hide();
            f.ShowDialog();
            this.Visible = true;
        }

        private void ApplicationsBut_Click(object sender, EventArgs e)
        {
            var f = new Application();
            this.Hide();
            f.ShowDialog();
            this.Visible = true;
        }

        private void Reportsbut_Click(object sender, EventArgs e)
        {
            var f = new Reports();
            this.Hide();
            f.ShowDialog();
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the main menu where you can go to any section", "Help");
        }
    }
}
