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
    public partial class EditSupplierForm : Form
    {
        private int supplierId;

        public EditSupplierForm(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            LoadSupplierData(supplierId);
        }

        private void LoadSupplierData(int supplierId)
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT supplier_name, supplier_address, email, phone_number FROM suppliers WHERE id_supplier = @SupplierId";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@SupplierId", supplierId);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtSupplierName.Text = reader.GetString("supplier_name");
                txtSupplierAddress.Text = reader.GetString("supplier_address");
                txtEmail.Text = reader.GetString("email");
                txtPhoneNumber.Text = reader.GetString("phone_number");
            }

            database.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text;
            string supplierAddress = txtSupplierAddress.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(supplierAddress) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            DB database = new DB();
            database.openConnection();

            string query = "UPDATE suppliers SET supplier_name = @SupplierName, supplier_address = @SupplierAddress, email = @Email, phone_number = @PhoneNumber WHERE id_supplier = @SupplierId";
            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@SupplierName", supplierName);
            cmd.Parameters.AddWithValue("@SupplierAddress", supplierAddress);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@SupplierId", supplierId);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Supplier details updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update supplier details.");
            }

            database.closeConnection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
