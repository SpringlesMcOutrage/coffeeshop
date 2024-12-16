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
    public partial class addsuplier : Form
    {
        public addsuplier()
        {
            InitializeComponent();
        }

        private void addsuplier_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text;
            string supplierAddress = txtSupplierAddress.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(supplierAddress) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DB database = new DB();
            database.openConnection();

            string query = "INSERT INTO suppliers (supplier_name, supplier_address, email, phone_number) " +
                           "VALUES (@SupplierName, @SupplierAddress, @Email, @PhoneNumber)";

            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@SupplierName", supplierName);
            cmd.Parameters.AddWithValue("@SupplierAddress", supplierAddress);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Supplier added successfully.");

            database.closeConnection();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
