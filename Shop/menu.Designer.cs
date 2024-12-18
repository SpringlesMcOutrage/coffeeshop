namespace Shop
{
    partial class menu
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
            label4 = new Label();
            exitbuttonmain = new Label();
            dataGridViewProducts = new DataGridView();
            btnAddProduct = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, -1);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 20;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 19;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToOrderColumns = true;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(39, 79);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.Size = new Size(734, 310);
            dataGridViewProducts.TabIndex = 21;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(308, 405);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(221, 23);
            btnAddProduct.TabIndex = 22;
            btnAddProduct.Text = "Додати";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(39, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Пошук";
            txtSearch.Size = new Size(562, 23);
            txtSearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(631, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 23);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(label4);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label exitbuttonmain;
        private DataGridView dataGridViewProducts;
        private Button btnAddProduct;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}