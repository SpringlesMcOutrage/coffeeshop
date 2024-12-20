﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class menuchenge : Form
    {
        private int? productId = null;

        public menuchenge(int? productId = null)
        {
            InitializeComponent();
            this.productId = productId;

            LoadCategories();

            if (productId.HasValue)
            {
                LoadProductData(productId.Value);
                btnSave.Text = "Змінити продукт";
            }
            else
            {
                btnSave.Text = "Додати продукт";
            }
        }

        private void LoadCategories()
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT id_category, categoty_name FROM categories";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());

            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable categoriesTable = new DataTable();
            categoriesTable.Load(reader);

            comboBoxCategory.DataSource = categoriesTable;
            comboBoxCategory.DisplayMember = "categoty_name";
            comboBoxCategory.ValueMember = "id_category";

            database.closeConnection();
        }

        private void LoadProductData(int productId)
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT * FROM products WHERE id_product = @ProductId";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@ProductId", productId);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtProductName.Text = reader.GetString("product_name");
                comboBoxCategory.SelectedValue = reader.GetInt32("id_category");
                txtPrice.Text = reader.GetDecimal("price").ToString();
                txtDescription.Text = reader.GetString("description");
                txtWeight.Text = reader.GetString("weight");
            }

            database.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string description = txtDescription.Text;
            string weight = txtWeight.Text;

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            DB database = new DB();
            database.openConnection();

            string query;
            MySqlCommand cmd = new MySqlCommand();

            if (productId.HasValue)
            {
                query = @"UPDATE products 
                          SET product_name = @ProductName, id_category = @CategoryId, 
                              price = @Price, description = @Description, weight = @Weight 
                          WHERE id_product = @ProductId";
                cmd = new MySqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@ProductId", productId);
            }
            else
            {
                query = @"INSERT INTO products (product_name, id_category, price, description, weight) 
                          VALUES (@ProductName, @CategoryId, @Price, @Description, @Weight)";
                cmd = new MySqlCommand(query, database.GetConnection());
            }

            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@Weight", weight);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Продукт успішно збережено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка при збереженні продукту.");
            }

            database.closeConnection();
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}