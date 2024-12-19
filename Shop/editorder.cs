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
    public partial class editorder : Form
    {
        private int orderId;

        public editorder(int id)
        {
            InitializeComponent();
            orderId = id;
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            DB database = new DB();
            database.openConnection();

            string query = @"
    SELECT o.id_order, o.created_at, o.status, o.payment_amount, c.id_customers AS id_customer, c.name AS customer_name, e.id_employee, e.name AS employee_name
    FROM orders o
    JOIN customers c ON o.id_customer = c.id_customers
    JOIN employees e ON o.id_employee = e.id_employee
    WHERE o.id_order = @OrderId
    ";

            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            command.Parameters.AddWithValue("@OrderId", orderId);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                lblOrderId.Text = reader["id_order"].ToString();
                dateTimePickerCreatedAt.Value = Convert.ToDateTime(reader["created_at"]);
                txtStatus.Text = reader["status"].ToString();
                txtPaymentAmount.Text = reader["payment_amount"].ToString();

                // Set selected values for Customer and Employee ComboBoxes
                comboBoxCustomer.SelectedValue = reader["id_customer"];
                comboBoxEmployee.SelectedValue = reader["id_employee"];
            }

            reader.Close();
            database.closeConnection();
        }

        private void LoadEmployeesAndCustomers()
        {
            DB database = new DB();
            database.openConnection();

            string employeeQuery = "SELECT id_employee, CONCAT(name, ' ', surname) AS employee_name FROM employees";
            MySqlDataAdapter employeeAdapter = new MySqlDataAdapter(employeeQuery, database.GetConnection());
            DataTable employeeDataTable = new DataTable();
            employeeAdapter.Fill(employeeDataTable);

            comboBoxEmployee.DataSource = employeeDataTable;
            comboBoxEmployee.DisplayMember = "employee_name";
            comboBoxEmployee.ValueMember = "id_employee";

            string customerQuery = "SELECT id_customers, name AS customer_name FROM customers";
            MySqlDataAdapter customerAdapter = new MySqlDataAdapter(customerQuery, database.GetConnection());
            DataTable customerDataTable = new DataTable();
            customerAdapter.Fill(customerDataTable);

            comboBoxCustomer.DataSource = customerDataTable;
            comboBoxCustomer.DisplayMember = "customer_name";
            comboBoxCustomer.ValueMember = "id_customers";

            database.closeConnection();
        }

        private void editorder_Load(object sender, EventArgs e)
        {
            LoadEmployeesAndCustomers();
            LoadOrderDetails();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            database.openConnection();

            string updateQuery = @"
        UPDATE orders
        SET created_at = @CreatedAt, status = @Status, payment_amount = @PaymentAmount, id_customer = @CustomerId, id_employee = @EmployeeId
        WHERE id_order = @OrderId";

            MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.GetConnection());
            updateCommand.Parameters.AddWithValue("@OrderId", orderId);
            updateCommand.Parameters.AddWithValue("@CreatedAt", dateTimePickerCreatedAt.Value);
            updateCommand.Parameters.AddWithValue("@Status", txtStatus.Text);
            updateCommand.Parameters.AddWithValue("@PaymentAmount", txtPaymentAmount.Text);
            updateCommand.Parameters.AddWithValue("@CustomerId", comboBoxCustomer.SelectedValue);
            updateCommand.Parameters.AddWithValue("@EmployeeId", comboBoxEmployee.SelectedValue);

            updateCommand.ExecuteNonQuery();

            database.closeConnection();

            MessageBox.Show("Замовлення успішно оновлено!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
