using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Shop
{
    public partial class zamovlenia : Form
    {
        public List<OrderItem> cart = new List<OrderItem>();

        public zamovlenia()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                Program.Database.openConnection();
                string query = "SELECT id_product, product_name AS 'Імя', price AS 'Ціна' FROM products;";
                DataTable products = Program.Database.ExecuteQuery(query);

                dataGridViewProducts.DataSource = products;
                dataGridViewProducts.Columns["id_product"].Visible = false;
                dataGridViewProducts.AllowUserToAddRows = false;
                dataGridViewProducts.ReadOnly = true;
                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні товарів: {ex.Message}");
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }
        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class OrderItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewProducts.Rows[e.RowIndex];
                int productId = (int)row.Cells["id_product"].Value;
                string productName = (string)row.Cells["Імя"].Value;
                decimal price = (decimal)row.Cells["Ціна"].Value;

                AddToCart(productId, productName, price);
            }
        }
        private void AddToCart(int productId, string productName, decimal price)
        {
            var existingItem = cart.Find(item => item.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new OrderItem
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = 1
                });
            }

            UpdateCart();
        }
        private void UpdateCart()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cart;

            dataGridViewCart.Columns["ProductId"].Visible = false;
            dataGridViewCart.Columns["ProductName"].HeaderText = "Назва товару";
            dataGridViewCart.Columns["Price"].HeaderText = "Ціна";
            dataGridViewCart.Columns["Quantity"].HeaderText = "Кількість";

            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            decimal total = 0;
            foreach (var item in cart)
            {
                total += item.Price * item.Quantity;
            }

            labelTotalPrice.Text = $"Загальна вартість: {total:C2}";
        }


        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewCart.Rows[e.RowIndex];
                int productId = (int)row.Cells["ProductId"].Value;
                int currentQuantity = (int)row.Cells["Quantity"].Value;

                if (currentQuantity > 1)
                {
                    var result = MessageBox.Show(
                        $"Ви хочете зменшити кількість товару: {row.Cells["ProductName"].Value} на 1?",
                        "Підтвердження зменшення",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        UpdateQuantity(productId, currentQuantity - 1);
                    }
                }
                else
                {
                    var result = MessageBox.Show(
                        $"Ви дійсно хочете видалити товар: {row.Cells["ProductName"].Value}?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        RemoveFromCart(productId);
                    }
                }
            }
        }
        private void UpdateQuantity(int productId, int newQuantity)
        {
            var itemToUpdate = cart.FirstOrDefault(item => item.ProductId == productId);

            if (itemToUpdate != null)
            {
                itemToUpdate.Quantity = newQuantity;
                UpdateCart();
            }
            else
            {
                MessageBox.Show("Товар не знайдено в кошику.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RemoveFromCart(int productId)
        {
            var itemToRemove = cart.FirstOrDefault(item => item.ProductId == productId);

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                UpdateCart();
            }
            else
            {
                MessageBox.Show("Товар не знайдено в кошику.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0)
            {
                zamovleniaconfrim confirmForm = new zamovleniaconfrim(cart, this);

                this.Hide();
                confirmForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Кошик порожній. Будь ласка, додайте товари до кошика.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Worker work = new Worker();
            work.Show();
        }

        private void zamovlenia_Load(object sender, EventArgs e)
        {

        }
    }
}
