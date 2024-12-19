using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts(string searchQuery = "")
        {
            DB database = new DB();
            database.openConnection();

            string query = @"SELECT 
                                p.id_product AS 'ID продукту', 
                                p.product_name AS 'Назва товару', 
                                c.categoty_name AS 'Категорія', 
                                p.price AS 'Ціна', 
                                p.description AS 'Опис', 
                                p.weight AS 'Вага' 
                             FROM products p
                             JOIN categories c ON p.id_category = c.id_category";

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE p.product_name LIKE @SearchQuery";
            }

            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            if (!string.IsNullOrEmpty(searchQuery))
            {
                command.Parameters.AddWithValue("@SearchQuery", $"%{searchQuery}%");
            }

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewProducts.DataSource = dataTable;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            menuchenge editProductForm = new menuchenge();
            editProductForm.ShowDialog();
            LoadProducts();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["ID продукту"].Value);
                menuchenge editProductForm = new menuchenge(productId);
                editProductForm.ShowDialog();
                LoadProducts();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            LoadProducts(searchQuery);
        }
    }
}
