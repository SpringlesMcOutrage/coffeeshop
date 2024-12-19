using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class skladadminadd : Form
    {
        private int? materialId = null;

        public skladadminadd(int? materialId = null)
        {
            InitializeComponent();
            this.materialId = materialId;

            LoadSuppliers();

            if (materialId.HasValue)
            {
                LoadMaterialData(materialId.Value);
                btnSave.Text = "Зберегти зміни";
            }
            else
            {
                btnSave.Text = "Додати матеріал";
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                Program.Database.openConnection();

                string query = "SELECT id_supplier, supplier_name FROM suppliers";
                MySqlCommand cmd = new MySqlCommand(query, Program.Database.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable supplierData = new DataTable();
                adapter.Fill(supplierData);

                comboBoxSuppliers.DataSource = supplierData;
                comboBoxSuppliers.DisplayMember = "supplier_name";
                comboBoxSuppliers.ValueMember = "id_supplier";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }

        private void LoadMaterialData(int materialId)
        {
            try
            {
                Program.Database.openConnection();

                string query = "SELECT material_name, quantity, id_supplier FROM inventory WHERE id_material = @MaterialId";
                MySqlCommand cmd = new MySqlCommand(query, Program.Database.GetConnection());
                cmd.Parameters.AddWithValue("@MaterialId", materialId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMaterialName.Text = reader["material_name"].ToString();
                    txtQuantity.Text = reader["quantity"].ToString();
                    comboBoxSuppliers.SelectedValue = reader["id_supplier"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string materialName = txtMaterialName.Text;
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Будь ласка, введіть правильну кількість.");
                return;
            }

            int supplierId = Convert.ToInt32(comboBoxSuppliers.SelectedValue);

            if (string.IsNullOrEmpty(materialName))
            {
                MessageBox.Show("Назва матеріалу не може бути порожньою.");
                return;
            }

            try
            {
                Program.Database.openConnection();

                string query;
                MySqlCommand cmd = new MySqlCommand();

                if (materialId.HasValue)
                {
                    query = @"UPDATE inventory 
                              SET material_name = @MaterialName, 
                                  quantity = @Quantity, 
                                  id_supplier = @SupplierId 
                              WHERE id_material = @MaterialId";
                    cmd.Parameters.AddWithValue("@MaterialId", materialId.Value);
                }
                else
                {
                    query = @"INSERT INTO inventory (material_name, quantity, id_supplier) 
                              VALUES (@MaterialName, @Quantity, @SupplierId)";
                }

                cmd.Parameters.AddWithValue("@MaterialName", materialName);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                cmd.CommandText = query;
                cmd.Connection = Program.Database.GetConnection();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Дані успішно збережено!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
