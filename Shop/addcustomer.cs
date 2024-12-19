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
    public partial class addcustomer : Form
    {
        private Form previousForm;

        public addcustomer(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;

        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            try
            {
                DB database = new DB();
                database.openConnection();

                string checkQuery = "SELECT COUNT(*) FROM customers WHERE email = @Email";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, database.GetConnection());
                checkCmd.Parameters.AddWithValue("@Email", email);

                int existingUsers = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (existingUsers > 0)
                {
                    MessageBox.Show("Користувач із таким email вже існує.");
                    return;
                }

                string insertQuery = @"
                    INSERT INTO customers (name, email, phone_number, membership_level, bonus_balance) 
                    VALUES (@Name, @Email, @PhoneNumber, @MembershipLevel, @BonusBalance)";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, database.GetConnection());
                insertCmd.Parameters.AddWithValue("@Name", name);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                insertCmd.Parameters.AddWithValue("@MembershipLevel", 1);
                insertCmd.Parameters.AddWithValue("@BonusBalance", 0);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Карта лояльності успішно створена!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }


        }
        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();

        }
    }
}
