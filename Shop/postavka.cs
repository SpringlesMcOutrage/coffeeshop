using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class postavka : Form
    {
        private int employeeId;

        public postavka(int employeeId)
        {
            InitializeComponent();
            LoadSuppliers();
            LoadMaterials();
            this.employeeId = employeeId;
            this.employeeId = employeeId;
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LoadSuppliers()
        {
            try
            {
                Program.Database.openConnection();
                string query = "SELECT id_supplier, supplier_name FROM suppliers";
                DataTable suppliers = Program.Database.ExecuteQuery(query);

                comboBoxSuppliers.DataSource = suppliers;
                comboBoxSuppliers.DisplayMember = "supplier_name";
                comboBoxSuppliers.ValueMember = "id_supplier";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні постачальників: {ex.Message}");
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }

        private void LoadMaterials()
        {
            try
            {
                Program.Database.openConnection();
                string query = "SELECT material_name FROM inventory";
                DataTable materials = Program.Database.ExecuteQuery(query);

                comboBoxMaterials.DataSource = materials;
                comboBoxMaterials.DisplayMember = "material_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні матеріалів: {ex.Message}");
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }

        private void buttonPostavka_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedValue == null || comboBoxSuppliers.SelectedValue == null || string.IsNullOrWhiteSpace(textBoxQuantity.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string materialName = comboBoxMaterials.Text;
            int supplierId = (int)comboBoxSuppliers.SelectedValue;
            string quantity = textBoxQuantity.Text;
            DialogResult result = MessageBox.Show(
                $"Перевірте дані поставки:\n\nМатеріал: {materialName}\nПостачальник: {comboBoxSuppliers.Text}\nКількість: {quantity}",
                "Попередній перегляд",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                SavePostavka(materialName, supplierId, quantity);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Редагування дозволено. Виправте дані та натисніть знову кнопку поставки.", "Редагування");
            }
        }

        private void SavePostavka(string materialName, int supplierId, string quantity)
        {
            try
            {
                Program.Database.openConnection();

                string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM inventory 
                    WHERE material_name = @materialName AND id_supplier = @supplierId";

                var checkCommand = new MySqlCommand(checkQuery, Program.Database.GetConnection());
                checkCommand.Parameters.AddWithValue("@materialName", materialName);
                checkCommand.Parameters.AddWithValue("@supplierId", supplierId);

                int recordExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (recordExists > 0)
                {
                    string updateQuery = @"
                        UPDATE inventory 
                        SET quantity = quantity + @quantity 
                        WHERE material_name = @materialName AND id_supplier = @supplierId";

                    var updateCommand = new MySqlCommand(updateQuery, Program.Database.GetConnection());
                    updateCommand.Parameters.AddWithValue("@quantity", quantity);
                    updateCommand.Parameters.AddWithValue("@materialName", materialName);
                    updateCommand.Parameters.AddWithValue("@supplierId", supplierId);

                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Кількість успішно оновлена!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertQuery = @"
                        INSERT INTO inventory (material_name, quantity, id_supplier) 
                        VALUES (@materialName, @quantity, @supplierId)";

                    var insertCommand = new MySqlCommand(insertQuery, Program.Database.GetConnection());
                    insertCommand.Parameters.AddWithValue("@materialName", materialName);
                    insertCommand.Parameters.AddWithValue("@quantity", quantity);
                    insertCommand.Parameters.AddWithValue("@supplierId", supplierId);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Новий запис успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні поставки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.Database.closeConnection();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Worker work = new Worker(employeeId);
            work.Show();
        }
    }
}
