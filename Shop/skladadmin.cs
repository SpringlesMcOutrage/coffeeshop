using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop
{
    public partial class skladadmin : Form
    {
        public skladadmin()
        {
            InitializeComponent();
            LoadInventoryData();
        }

        private void LoadInventoryData()
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

                MySqlCommand cmd = new MySqlCommand(query, Program.Database.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable inventoryData = new DataTable();
                adapter.Fill(inventoryData);

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
            Admin admin = new Admin();
            admin.Show();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            skladadminadd addMaterialForm = new skladadminadd();
            addMaterialForm.FormClosed += (s, args) => LoadInventoryData();
            addMaterialForm.ShowDialog();
        }

        private void dataGridViewInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int materialId = Convert.ToInt32(dataGridViewInventory.Rows[e.RowIndex].Cells["id_material"].Value);
                skladadminadd editMaterialForm = new skladadminadd(materialId);
                editMaterialForm.FormClosed += (s, args) => LoadInventoryData();
                editMaterialForm.ShowDialog();
            }
        }
    }
}
