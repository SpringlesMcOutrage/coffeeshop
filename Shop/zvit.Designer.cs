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
            ((System.ComponentModel.ISupportInitialize)dataGridViewLast24Hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLastMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPopularProducts).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Назад";
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
            dataGridViewLast24Hours.Location = new Point(44, 66);
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
            dataGridViewLastMonth.Location = new Point(444, 66);
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
            dataGridViewPopularProducts.Location = new Point(444, 237);
            dataGridViewPopularProducts.Name = "dataGridViewPopularProducts";
            dataGridViewPopularProducts.ReadOnly = true;
            dataGridViewPopularProducts.Size = new Size(315, 127);
            dataGridViewPopularProducts.TabIndex = 18;
            // 
            // zvit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}