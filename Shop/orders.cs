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

        }
        private void LoadOrders()
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT o.id_order, o.created_at, o.status, o.payment_amount, c.name AS customer_name, e.name AS employee_name " +
                           "FROM orders o " +
                           "JOIN customers c ON o.id_customer = c.id_customers " +
                           "JOIN employees e ON o.id_employee = e.id_employee";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewOrders.DataSource = dataTable;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.Columns["id_order"].HeaderText = "Order ID";
            dataGridViewOrders.Columns["created_at"].HeaderText = "Date";
            dataGridViewOrders.Columns["status"].HeaderText = "Status";
            dataGridViewOrders.Columns["payment_amount"].HeaderText = "Payment Amount";
            dataGridViewOrders.Columns["customer_name"].HeaderText = "Customer Name";
            dataGridViewOrders.Columns["employee_name"].HeaderText = "Employee Name";

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
    }
}
