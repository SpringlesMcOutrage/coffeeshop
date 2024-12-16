namespace Shop
{
    partial class zamovlenia
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
            exitbuttonmain = new Label();
            dataGridViewProducts = new DataGridView();
            dataGridViewCart = new DataGridView();
            labelTotalPrice = new Label();
            btnConfirmOrder = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, 0);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 6;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(26, 44);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(439, 360);
            dataGridViewProducts.TabIndex = 7;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(501, 44);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.Size = new Size(287, 238);
            dataGridViewCart.TabIndex = 8;
            dataGridViewCart.CellClick += dataGridViewCart_CellClick;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(501, 314);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(38, 15);
            labelTotalPrice.TabIndex = 9;
            labelTotalPrice.Text = "label1";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(627, 381);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(136, 23);
            btnConfirmOrder.TabIndex = 10;
            btnConfirmOrder.Text = "Підтвердити";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // zamovlenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnConfirmOrder);
            Controls.Add(labelTotalPrice);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewProducts);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "zamovlenia";
            Text = "zamovlenia";
            Load += zamovlenia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCart;
        private Label labelTotalPrice;
        private Button btnConfirmOrder;
        private Label label4;
    }
}