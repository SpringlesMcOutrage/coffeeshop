namespace Shop
{
    partial class customer
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
            btnConfirmOrder = new Button();
            labelTotalPrice = new Label();
            dataGridViewCart = new DataGridView();
            dataGridViewProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, -1);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 15;
            label2.Text = "Вхід для персоналу";
            label2.Click += label2_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(770, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 14;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(620, 382);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(136, 23);
            btnConfirmOrder.TabIndex = 19;
            btnConfirmOrder.Text = "Підтвердити";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(494, 315);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(104, 15);
            labelTotalPrice.TabIndex = 18;
            labelTotalPrice.Text = "Загальна вартість";
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(494, 45);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.Size = new Size(287, 238);
            dataGridViewCart.TabIndex = 17;
            dataGridViewCart.CellClick += dataGridViewCart_CellClick;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(19, 45);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(439, 360);
            dataGridViewProducts.TabIndex = 16;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmOrder);
            Controls.Add(labelTotalPrice);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewProducts);
            Controls.Add(label2);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label exitbuttonmain;
        private Button btnConfirmOrder;
        private Label labelTotalPrice;
        private DataGridView dataGridViewCart;
        private DataGridView dataGridViewProducts;
    }
}