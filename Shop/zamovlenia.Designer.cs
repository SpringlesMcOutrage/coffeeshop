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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            dataGridViewProducts.Location = new Point(26, 90);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(439, 314);
            dataGridViewProducts.TabIndex = 7;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(501, 90);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.Size = new Size(287, 192);
            dataGridViewCart.TabIndex = 8;
            dataGridViewCart.CellClick += dataGridViewCart_CellClick;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(501, 314);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(104, 15);
            labelTotalPrice.TabIndex = 9;
            labelTotalPrice.Text = "Загальна вартість";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Font = new Font("Segoe UI", 12F);
            btnConfirmOrder.Location = new Point(604, 349);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(159, 55);
            btnConfirmOrder.TabIndex = 10;
            btnConfirmOrder.Text = "Підтвердити";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(1, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 42);
            label4.TabIndex = 13;
            label4.Text = "Повернутись у панель \r\nпрацівника";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(501, 66);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 25;
            label1.Text = "Кошик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(26, 66);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 24;
            label3.Text = "Меню продуктів";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(276, 6);
            label2.Name = "label2";
            label2.Size = new Size(275, 30);
            label2.TabIndex = 23;
            label2.Text = "Оформлення замовлення";
            // 
            // zamovlenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnConfirmOrder);
            Controls.Add(labelTotalPrice);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewProducts);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "zamovlenia";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label label3;
        private Label label2;
    }
}