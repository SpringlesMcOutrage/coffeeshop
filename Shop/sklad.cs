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
    public partial class sklad : Form
    {
        private int employeeId;

        public sklad(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            LoadSuppliers();
            LoadInventoryData();
        }

        private void LoadSuppliers()
        {
            try
            {
                Program.Database.openConnection();

                string query = "SELECT id_supplier, supplier_name FROM suppliers";
                DataTable suppliersData = Program.Database.ExecuteQuery(query);

                comboBoxSuppliers.DataSource = suppliersData;
                comboBoxSuppliers.DisplayMember = "supplier_name";
                comboBoxSuppliers.ValueMember = "id_supplier";

                Program.Database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void LoadInventoryData(int? supplierId = null)
        {
            try
            {
                Program.Database.openConnection();

                string query = @"
                    SELECT 
                        i.id_material,
                        i.material_name AS 'Назва',
                        i.quantity AS 'Кількість',
                        s.supplier_name AS 'Постачальник'
                    FROM inventory i
                    JOIN suppliers s ON i.id_supplier = s.id_supplier";

                if (supplierId.HasValue)
                {
                    query += " WHERE i.id_supplier = @SupplierId";
                }

                MySqlCommand command = new MySqlCommand(query, Program.Database.GetConnection());
                if (supplierId.HasValue)
                {
                    command.Parameters.AddWithValue("@SupplierId", supplierId.Value);
                }

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable inventoryData = new DataTable();
                dataAdapter.Fill(inventoryData);

                dataGridViewInventory.DataSource = inventoryData;
                dataGridViewInventory.Columns["id_material"].Visible = false;
                dataGridViewInventory.AllowUserToAddRows = false;
                dataGridViewInventory.ReadOnly = true;
                dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Worker work = new Worker(employeeId);
            work.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int? selectedSupplierId = comboBoxSuppliers.SelectedValue as int?;

            LoadInventoryData(selectedSupplierId);
        }
    }
}
