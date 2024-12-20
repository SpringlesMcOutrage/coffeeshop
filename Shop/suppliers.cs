﻿using System;
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
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void LoadSuppliers()
        {
            DB database = new DB();
            database.openConnection();

            string query = "SELECT id_supplier, supplier_name, supplier_address, email, phone_number FROM suppliers";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewSuppliers.DataSource = dataTable;
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Зміна назв колонок на українську
            dataGridViewSuppliers.Columns["id_supplier"].HeaderText = "ID постачальника";
            dataGridViewSuppliers.Columns["supplier_name"].HeaderText = "Назва постачальника";
            dataGridViewSuppliers.Columns["supplier_address"].HeaderText = "Адреса постачальника";
            dataGridViewSuppliers.Columns["email"].HeaderText = "Електронна пошта";
            dataGridViewSuppliers.Columns["phone_number"].HeaderText = "Номер телефону";

            database.closeConnection();
        }

        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewSuppliers.Rows.Count)
            {
                int supplierId = Convert.ToInt32(dataGridViewSuppliers.Rows[e.RowIndex].Cells["id_supplier"].Value);

                EditSupplierForm editForm = new EditSupplierForm(supplierId);
                editForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsuplier addSupplierForm = new addsuplier();
            addSupplierForm.Show();
        }
    }
}
