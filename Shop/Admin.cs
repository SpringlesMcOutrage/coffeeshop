using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace Shop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void orderhistory_Click(object sender, EventArgs e)
        {
            orders ordersForm = new orders();
            ordersForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            suppliers supp = new suppliers();
            supp.Show();
            this.Hide();
        }

        private void sklad_Click(object sender, EventArgs e)
        {
            skladadmin supp = new skladadmin();
            supp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            workersform wrok = new workersform();
            wrok.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            zvit zvit = new zvit();
            zvit.Show();
            this.Hide();
        }
    }
}
