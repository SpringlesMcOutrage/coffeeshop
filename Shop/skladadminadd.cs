using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class skladadminadd : Form
    {
        public skladadminadd()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            try
            {
                Program.Database.openConnection();

                string query = "SELECT id_supplier, supplier_name FROM suppliers";
                DataTable supplierData = Program.Database.ExecuteQuery(query);

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

                string query = "INSERT INTO inventory (material_name, quantity, id_supplier) " +
                               "VALUES (@MaterialName, @Quantity, @SupplierId)";

                var parameters = new Dictionary<string, object>
                {
                    { "@MaterialName", materialName },
                    { "@Quantity", quantity },
                    { "@SupplierId", supplierId }
                };

                Program.Database.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Матеріал успішно додано.");
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
