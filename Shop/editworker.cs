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
    public partial class editworker : Form
    {
        private int? employeeId = null;
        public editworker(int? employeeId = null)
        {
            InitializeComponent();
            this.employeeId = employeeId;

            if (employeeId.HasValue)
            {
                LoadWorkerData(employeeId.Value);
                btnSave.Text = "Оновити";
            }
            else
            {
                btnSave.Text = "Додати";
            }

        }
        private void LoadWorkerData(int employeeId)
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT * FROM employees WHERE id_employee = @EmployeeId";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader.GetString("name");
                txtSurname.Text = reader.GetString("surname");
                txtRole.Text = reader.GetString("role");
                txtShift.Text = reader.GetString("shift");
                txtSalary.Text = reader.GetString("salary");
                dtpBirthday.Text = reader.GetString("birthday");
                txtPhoneNumber.Text = reader.GetString("phone_number");
                txtEmail.Text = reader.GetString("email");
                txtAddress.Text = reader.GetString("address");
                txtLogin.Text = reader.GetString("login");
                txtPassword.Text = reader.GetString("password");
            }

            database.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string role = txtRole.Text;
            string shift = txtShift.Text;
            string salary = txtSalary.Text;
            string birthday = dtpBirthday.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            DB database = new DB();
            database.openConnection();

            string query;
            MySqlCommand cmd = new MySqlCommand();

            if (employeeId.HasValue)
            {
                query = @"UPDATE employees SET name = @Name, surname = @Surname, role = @Role, 
                          shift = @Shift, salary = @Salary, birthday = @Birthday, phone_number = @PhoneNumber, 
                          email = @Email, address = @Address, login = @Login, password = @Password
                          WHERE id_employee = @EmployeeId";
                cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
            }
            else
            {
                query = @"INSERT INTO employees (name, surname, role, shift, salary, birthday, phone_number, email, address, login, password) 
                          VALUES (@Name, @Surname, @Role, @Shift, @Salary, @Birthday, @PhoneNumber, @Email, @Address, @Login, @Password)";
                cmd = new MySqlCommand(query, database.GetConnection());
            }

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surname", surname);
            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@Shift", shift);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Birthday", birthday);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save data.");
            }

            database.closeConnection();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitbutton(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
