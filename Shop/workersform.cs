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
    public partial class workersform : Form
    {
        public workersform()
        {
            InitializeComponent();
            LoadWorkers();

        }
        private void LoadWorkers()
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT id_employee, name, surname, role, shift, salary, birthday, phone_number, email, address FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewWorkers.DataSource = dataTable;
            dataGridViewWorkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewWorkers.Columns["id_employee"].HeaderText = "ID працівника";
            dataGridViewWorkers.Columns["name"].HeaderText = "Ім'я";
            dataGridViewWorkers.Columns["surname"].HeaderText = "Прізвище";
            dataGridViewWorkers.Columns["role"].HeaderText = "Посада";
            dataGridViewWorkers.Columns["shift"].HeaderText = "Зміна";
            dataGridViewWorkers.Columns["salary"].HeaderText = "Зарплата";
            dataGridViewWorkers.Columns["birthday"].HeaderText = "Дата народження";
            dataGridViewWorkers.Columns["phone_number"].HeaderText = "Номер телефону";
            dataGridViewWorkers.Columns["email"].HeaderText = "Електронна пошта";
            dataGridViewWorkers.Columns["address"].HeaderText = "Адреса";


            database.closeConnection();
        }


        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            editworker editWorkerForm = new editworker();
            editWorkerForm.ShowDialog();
            LoadWorkers();
        }

        private void dataGridViewWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int employeeId = Convert.ToInt32(dataGridViewWorkers.Rows[e.RowIndex].Cells["id_employee"].Value);
                editworker editWorkerForm = new editworker(employeeId);
                editWorkerForm.ShowDialog();
                LoadWorkers();
            }
        }
    }
}
