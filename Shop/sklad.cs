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
    public partial class sklad : Form
    {
        public sklad()
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

                DataTable inventoryData = Program.Database.ExecuteQuery(query);
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

        private void sklad_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Worker work = new Worker();
            work.Show();
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
