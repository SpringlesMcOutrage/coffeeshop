using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using System.Diagnostics;
using iText.IO.Font;
using iText.Kernel.Font;


namespace Shop
{
    public partial class zvit : Form
    {
        public zvit()
        {
            InitializeComponent();
            LoadEmployeeStatsLast24Hours();
            LoadEmployeeStatsLastMonth();
            LoadPopularProducts();

        }
        private void LoadEmployeeStatsLast24Hours()
        {
            DB database = new DB();
            database.openConnection();

            string query = @"
                SELECT e.name, e.surname, COUNT(o.id_order) AS orders_count
                FROM orders o
                JOIN employees e ON o.id_employee = e.id_employee
                WHERE o.created_at >= NOW() - INTERVAL 1 DAY
                GROUP BY o.id_employee";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewLast24Hours.DataSource = dataTable;
            dataGridViewLast24Hours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLast24Hours.Columns["name"].HeaderText = "Імя";
            dataGridViewLast24Hours.Columns["surname"].HeaderText = "Прізвище";
            dataGridViewLast24Hours.Columns["orders_count"].HeaderText = "Кількість замовлень виконаних";

            database.closeConnection();
        }

        private void LoadEmployeeStatsLastMonth()
        {
            DB database = new DB();
            database.openConnection();

            string query = @"
                SELECT e.name, e.surname, COUNT(o.id_order) AS orders_count
                FROM orders o
                JOIN employees e ON o.id_employee = e.id_employee
                WHERE o.created_at >= NOW() - INTERVAL 1 MONTH
                GROUP BY o.id_employee";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewLastMonth.DataSource = dataTable;
            dataGridViewLastMonth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLastMonth.Columns["name"].HeaderText = "Імя";
            dataGridViewLastMonth.Columns["surname"].HeaderText = "Прізвище";
            dataGridViewLastMonth.Columns["orders_count"].HeaderText = "Кількість замовлень виконаних";

            database.closeConnection();
        }

        private void LoadPopularProducts()
        {
            DB database = new DB();
            database.openConnection();

            string query = @"
                SELECT p.product_name, SUM(od.quantity) AS total_quantity
                FROM orderdetails od
                JOIN products p ON od.id_product = p.id_product
                GROUP BY od.id_product
                ORDER BY total_quantity DESC
                LIMIT 10";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, database.GetConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewPopularProducts.DataSource = dataTable;
            dataGridViewPopularProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPopularProducts.Columns["product_name"].HeaderText = "Імя";
            dataGridViewPopularProducts.Columns["total_quantity"].HeaderText = "Скільки продано";

            database.closeConnection();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();

        }

        private void exitbuttonmain_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Employee Stats as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var writer = new PdfWriter(filePath))
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    string fontPath = @"C:\Windows\Fonts\arial.ttf";
                    var font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                    document.SetFont(font);

                    document.Add(new Paragraph("Статистика співробітників (Останні 24 години)").SetFontSize(18));

                    AddDataGridViewToPdf(document, dataGridViewLast24Hours);

                    document.Add(new Paragraph("\n"));

                    document.Add(new Paragraph("Статистика співробітників (Останній місяць)").SetFontSize(18));

                    AddDataGridViewToPdf(document, dataGridViewLastMonth);

                    document.Add(new Paragraph("\n"));

                    document.Add(new Paragraph("Популярні продукти").SetFontSize(18));

                    AddDataGridViewToPdf(document, dataGridViewPopularProducts);

                    document.Close();
                }

                MessageBox.Show("Експорт успішно завершено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddDataGridViewToPdf(Document document, DataGridView dataGridView)
        {
            var pdfTable = new Table(dataGridView.Columns.Count);

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                pdfTable.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                    }
                }
            }
            document.Add(pdfTable);
        }



    }
}
