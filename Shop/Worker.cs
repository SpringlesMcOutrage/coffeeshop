using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class Worker : Form
    {
        private int employeeId;
        public Worker(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            LoadEmployeeData();

        }
        private void LoadEmployeeData()
        {
            try
            {
                DB database = new DB();
                database.openConnection();

                string query = "SELECT name FROM employees WHERE id_employee = @EmployeeId";
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string name = result.ToString();
                    label1.Text = $"Привіт, {name}!";
                }
                else
                {
                    label1.Text = "Привіт, користувач!";
                }

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних користувача: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            postavka possForm = new postavka(employeeId);
            possForm.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            zamovlenia zam = new zamovlenia(employeeId);
            zam.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sklad sklad = new sklad(employeeId);
            sklad.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            vzav vzav = new vzav(employeeId);
            vzav.Show();
        }
    }
}
