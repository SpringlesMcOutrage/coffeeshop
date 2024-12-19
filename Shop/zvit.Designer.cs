namespace Shop
{
    partial class zvit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            exitbuttonmain = new Label();
            dataGridViewLast24Hours = new DataGridView();
            dataGridViewLastMonth = new DataGridView();
            dataGridViewPopularProducts = new DataGridView();
            exportButton = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLast24Hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLastMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPopularProducts).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 42);
            label2.TabIndex = 15;
            label2.Text = "Повернутися до панелі\r\nадміністрації";
            label2.Click += label2_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(770, 0);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 14;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewLast24Hours
            // 
            dataGridViewLast24Hours.AllowUserToAddRows = false;
            dataGridViewLast24Hours.AllowUserToDeleteRows = false;
            dataGridViewLast24Hours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLast24Hours.Location = new Point(32, 129);
            dataGridViewLast24Hours.Name = "dataGridViewLast24Hours";
            dataGridViewLast24Hours.ReadOnly = true;
            dataGridViewLast24Hours.Size = new Size(315, 127);
            dataGridViewLast24Hours.TabIndex = 16;
            // 
            // dataGridViewLastMonth
            // 
            dataGridViewLastMonth.AllowUserToAddRows = false;
            dataGridViewLastMonth.AllowUserToDeleteRows = false;
            dataGridViewLastMonth.AllowUserToOrderColumns = true;
            dataGridViewLastMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLastMonth.Location = new Point(444, 129);
            dataGridViewLastMonth.Name = "dataGridViewLastMonth";
            dataGridViewLastMonth.ReadOnly = true;
            dataGridViewLastMonth.Size = new Size(315, 127);
            dataGridViewLastMonth.TabIndex = 17;
            // 
            // dataGridViewPopularProducts
            // 
            dataGridViewPopularProducts.AllowUserToAddRows = false;
            dataGridViewPopularProducts.AllowUserToDeleteRows = false;
            dataGridViewPopularProducts.AllowUserToOrderColumns = true;
            dataGridViewPopularProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPopularProducts.Location = new Point(444, 311);
            dataGridViewPopularProducts.Name = "dataGridViewPopularProducts";
            dataGridViewPopularProducts.ReadOnly = true;
            dataGridViewPopularProducts.Size = new Size(315, 127);
            dataGridViewPopularProducts.TabIndex = 18;
            // 
            // exportButton
            // 
            exportButton.Font = new Font("Segoe UI", 14F);
            exportButton.Location = new Point(170, 311);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(177, 79);
            exportButton.TabIndex = 19;
            exportButton.Text = "Експорт у PDF";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(145, 66);
            label1.Name = "label1";
            label1.Size = new Size(202, 42);
            label1.TabIndex = 20;
            label1.Text = "Статистика співробітників \r\n(Останні 24 години)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(444, 66);
            label3.Name = "label3";
            label3.Size = new Size(202, 42);
            label3.TabIndex = 21;
            label3.Text = "Статистика співробітників \r\n(Останній місяць)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(444, 278);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 22;
            label4.Text = "Популярні продукти";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(308, 22);
            label5.Name = "label5";
            label5.Size = new Size(184, 30);
            label5.TabIndex = 23;
            label5.Text = "Таблиці звітності";
            // 
            // zvit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(exportButton);
            Controls.Add(dataGridViewPopularProducts);
            Controls.Add(dataGridViewLastMonth);
            Controls.Add(dataGridViewLast24Hours);
            Controls.Add(label2);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "zvit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zvit";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLast24Hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLastMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPopularProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label exitbuttonmain;
        private DataGridView dataGridViewLast24Hours;
        private DataGridView dataGridViewLastMonth;
        private DataGridView dataGridViewPopularProducts;
        private Button exportButton;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}