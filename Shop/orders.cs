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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
            LoadOrders();
            LoadEmployees();

        }
        private void LoadOrders()
        {
            DB database = new DB();
            database.openConnection();

            string query = @"
                SELECT o.id_order, o.created_at, o.status, o.payment_amount, c.name AS customer_name, e.name AS employee_name 
                FROM orders o 
                JOIN customers c ON o.id_customer = c.id_customers 
                JOIN employees e ON o.id_employee = e.id_employee";

            if (dateTimePickerFrom.Value != null && dateTimePickerTo.Value != null)
            {
                query += " WHERE o.created_at BETWEEN @StartDate AND @EndDate";
            }

            if (comboBoxEmployees.SelectedIndex != -1)
            {
                query += " AND o.id_employee = @EmployeeId";
            }

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            if (dateTimePickerFrom.Value != null && dateTimePickerTo.Value != null)
            {
                dataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", dateTimePickerFrom.Value.Date);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", dateTimePickerTo.Value.Date.AddDays(1).AddMilliseconds(-1)); // Додати час для кінця дня
            }

            if (comboBoxEmployees.SelectedIndex != -1)
            {
                dataAdapter.SelectCommand.Parameters.AddWithValue("@EmployeeId", comboBoxEmployees.SelectedValue);
            }

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewOrders.DataSource = dataTable;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.Columns["id_order"].HeaderText = "ID замовлення";
            dataGridViewOrders.Columns["created_at"].HeaderText = "Дата";
            dataGridViewOrders.Columns["status"].HeaderText = "Статус";
            dataGridViewOrders.Columns["payment_amount"].HeaderText = "Сума платежу";
            dataGridViewOrders.Columns["customer_name"].HeaderText = "Ім'я клієнта";
            dataGridViewOrders.Columns["employee_name"].HeaderText = "Ім'я працівника";


            database.closeConnection();
        }

        private void LoadEmployees()
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT id_employee, name FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBoxEmployees.DataSource = dataTable;
            comboBoxEmployees.DisplayMember = "name";
            comboBoxEmployees.ValueMember = "id_employee";

            database.closeConnection();
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("Дата З не повинна бути пізніше чим дата До.");
                return;
            }

            LoadOrders();

        }

        private void comboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewOrders.Rows.Count)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells["id_order"].Value);

                editorder editForm = new editorder(orderId);
                editForm.ShowDialog();
            }

        }
    }
}
