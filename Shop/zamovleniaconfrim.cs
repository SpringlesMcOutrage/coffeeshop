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
using static Shop.zamovlenia;

namespace Shop
{

    public partial class zamovleniaconfrim : Form
    {
        private int employeeId;

        private List<OrderItem> cart;
        private Form previousForm;
        private decimal bonusBalance = 0;
        private decimal bonusUsed = 0;

        public zamovleniaconfrim(List<OrderItem> cart, Form previousForm, int employeeId)
        {
            InitializeComponent();
            this.cart = cart;
            this.previousForm = previousForm;
            this.employeeId = employeeId;
            LoadCartData();
        }

        private void LoadCartData()
        {
            dataGridViewConfirmedOrder.DataSource = null;
            dataGridViewConfirmedOrder.DataSource = cart;

            dataGridViewConfirmedOrder.Columns["ProductId"].Visible = false;
            dataGridViewConfirmedOrder.Columns["ProductName"].HeaderText = "Назва товару";
            dataGridViewConfirmedOrder.Columns["Price"].HeaderText = "Ціна";
            dataGridViewConfirmedOrder.Columns["Quantity"].HeaderText = "Кількість";

            dataGridViewConfirmedOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            decimal total = 0;
            foreach (var item in cart)
            {
                total += item.Price * item.Quantity;
            }

            labelTotalPrice.Text = $"Загальна вартість: {total:C2}";
        }
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Будь ласка, введіть електронну пошту.");
                return;
            }

            DB database = new DB();
            database.openConnection();
            string query = "SELECT id_customers FROM customers WHERE email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = cmd.ExecuteReader();
            int customerId = 0;

            if (reader.Read())
            {
                customerId = reader.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Користувача з такою електронною поштою не знайдено.");
                return;
            }
            reader.Close();

            string insertOrderQuery = "INSERT INTO orders (wishes, created_at, status, payment_amount, tip_amount, id_customer, id_employee) " +
                                      "VALUES (@Wishes, @CreatedAt, @Status, @PaymentAmount, @TipAmount, @CustomerId, @EmployeeId)";

            MySqlCommand insertOrderCmd = new MySqlCommand(insertOrderQuery, database.GetConnection());
            insertOrderCmd.Parameters.AddWithValue("@Wishes", "");
            insertOrderCmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            insertOrderCmd.Parameters.AddWithValue("@Status", "Виконано");
            insertOrderCmd.Parameters.AddWithValue("@PaymentAmount", cart.Sum(item => item.Price * item.Quantity) - bonusUsed);
            insertOrderCmd.Parameters.AddWithValue("@TipAmount", 0);
            insertOrderCmd.Parameters.AddWithValue("@CustomerId", customerId);
            insertOrderCmd.Parameters.AddWithValue("@EmployeeId", employeeId);

            insertOrderCmd.ExecuteNonQuery();
            int orderId = (int)insertOrderCmd.LastInsertedId;

            foreach (var item in cart)
            {
                string insertOrderDetailQuery = "INSERT INTO orderdetails (id_order, id_product, quantity) VALUES (@OrderId, @ProductId, @Quantity)";
                MySqlCommand insertOrderDetailCmd = new MySqlCommand(insertOrderDetailQuery, database.GetConnection());
                insertOrderDetailCmd.Parameters.AddWithValue("@OrderId", orderId);
                insertOrderDetailCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                insertOrderDetailCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                insertOrderDetailCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Замовлення підтверджено. Дякуємо за покупку!");
            database.closeConnection();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCheckBonus_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Будь ласка, введіть електронну пошту.");
                return;
            }

            DB database = new DB();
            database.openConnection();
            string query = "SELECT bonus_balance, name FROM customers WHERE email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@Email", email);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                bonusBalance = reader.GetDecimal(0);
                string name = reader.GetString(1);
                labelGreeting.Text = $"Привіт, {name}! Ваш бонусний баланс: {bonusBalance} грн.";
            }
            else
            {
                MessageBox.Show("Користувача з такою електронною поштою не знайдено.");
                labelGreeting.Text = "Користувача не знайдено!";
            }

            database.closeConnection();
        }

        private void btnUseBonus_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Будь ласка, введіть електронну пошту.");
                return;
            }

            decimal totalPrice = cart.Sum(item => item.Price * item.Quantity);
            if (bonusBalance > 0)
            {
                decimal bonusToUse = Math.Min(bonusBalance, totalPrice);

                bonusUsed = bonusToUse;
                bonusBalance -= bonusUsed;
                labelGreeting.Text = $"Ваш бонусний баланс: {bonusBalance} грн. Знято бонусів: {bonusUsed} грн.";

                decimal newTotal = totalPrice - bonusUsed;
                labelTotalPrice.Text = $"Загальна вартість після зняття бонусів: {newTotal:C2}";

            }
            else
            {
                MessageBox.Show("У вас немає бонусів для використання.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcustomer loyaltyCardForm = new addcustomer(this);
            loyaltyCardForm.Show();
            this.Hide();
        }
    }
}
