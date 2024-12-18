using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class vzav : Form
    {
        private int employeeId;
        public vzav(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            LoadMaterials();
            LoadSuppliers();
        }
        private void LoadMaterials()
        {
            DB database = new DB();
            database.openConnection();

            string query = @"
        SELECT DISTINCT material_name 
        FROM inventory";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBoxMaterials.DataSource = dataTable;
            comboBoxMaterials.DisplayMember = "material_name";
            comboBoxMaterials.SelectedIndex = -1;

            database.closeConnection();
        }



        private void LoadSuppliers()
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT id_supplier, supplier_name FROM suppliers";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBoxSuppliers.DataSource = dataTable;
            comboBoxSuppliers.DisplayMember = "supplier_name";
            comboBoxSuppliers.ValueMember = "id_supplier";

            database.closeConnection();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Worker work = new Worker(employeeId);
            work.Show();
        }

        private void exitbuttonmain_Clic(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedMaterialName = (comboBoxMaterials.SelectedItem as DataRowView)?["material_name"].ToString();

            if (string.IsNullOrEmpty(selectedMaterialName))
            {
                MessageBox.Show("Будь ласка виберіть матеріал.");
                return;
            }

            int materialId = -1;
            int supplierId = Convert.ToInt32(comboBoxSuppliers.SelectedValue);
            int quantityToPick = Convert.ToInt32(txtQuantity.Text);

            if (quantityToPick <= 0)
            {
                MessageBox.Show("Кількість повинна бути більша за 0.");
                return;
            }

            DB database = new DB();
            database.openConnection();

            string query = @"
        SELECT id_material 
        FROM inventory 
        WHERE material_name = @MaterialName 
          AND id_supplier = @SupplierId 
        LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(query, database.GetConnection());
            cmd.Parameters.AddWithValue("@MaterialName", selectedMaterialName);
            cmd.Parameters.AddWithValue("@SupplierId", supplierId);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                materialId = reader.GetInt32("id_material");
            }

            database.closeConnection();

            if (materialId == -1)
            {
                MessageBox.Show("Немає такого сполучення товару та матеріалу.");
                return;
            }

            database.openConnection();

            string updateInventoryQuery = @"
        UPDATE inventory 
        SET quantity = quantity - @Quantity 
        WHERE id_material = @MaterialId 
          AND id_supplier = @SupplierId 
          AND quantity >= @Quantity";

            MySqlCommand updateCmd = new MySqlCommand(updateInventoryQuery, database.GetConnection());
            updateCmd.Parameters.AddWithValue("@Quantity", quantityToPick);
            updateCmd.Parameters.AddWithValue("@MaterialId", materialId);
            updateCmd.Parameters.AddWithValue("@SupplierId", supplierId);

            int rowsAffected = updateCmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                string insertWorkerPickQuery = @"
            INSERT INTO workerpicks (id_ingredient, id_employee, id_supplier, id_material, quantity) 
            VALUES (NULL, @EmployeeId, @SupplierId, @MaterialId, @Quantity)";

                MySqlCommand insertCmd = new MySqlCommand(insertWorkerPickQuery, database.GetConnection());
                insertCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                insertCmd.Parameters.AddWithValue("@SupplierId", supplierId);
                insertCmd.Parameters.AddWithValue("@MaterialId", materialId);
                insertCmd.Parameters.AddWithValue("@Quantity", quantityToPick);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Матеріал успішно взято зі складу!");
            }
            else
            {
                MessageBox.Show("Недостатньо матеріалу, або помилка в сполученні.");
            }

            database.closeConnection();
        }

    }
}
