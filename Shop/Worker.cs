using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            postavka possForm = new postavka();
            possForm.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            zamovlenia zam = new zamovlenia();
            zam.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sklad sklad = new sklad();
            sklad.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
