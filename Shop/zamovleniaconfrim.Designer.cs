namespace Shop
{
    partial class zamovleniaconfrim
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
            dataGridViewConfirmedOrder = new DataGridView();
            labelTotalPrice = new Label();
            btnBack = new Label();
            txtEmail = new TextBox();
            labelGreeting = new Label();
            btnCheckBonus = new Button();
            btnUseBonus = new Button();
            btnSubmitOrder = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfirmedOrder).BeginInit();
            SuspendLayout();
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(771, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 5;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewConfirmedOrder
            // 
            dataGridViewConfirmedOrder.AllowUserToAddRows = false;
            dataGridViewConfirmedOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConfirmedOrder.Location = new Point(77, 97);
            dataGridViewConfirmedOrder.Name = "dataGridViewConfirmedOrder";
            dataGridViewConfirmedOrder.ReadOnly = true;
            dataGridViewConfirmedOrder.Size = new Size(364, 263);
            dataGridViewConfirmedOrder.TabIndex = 6;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(77, 391);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(38, 15);
            labelTotalPrice.TabIndex = 7;
            labelTotalPrice.Text = "label1";
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(1, -1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 15);
            btnBack.TabIndex = 8;
            btnBack.Text = "Повернутися назад";
            btnBack.Click += btnBack_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(476, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 9;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(476, 140);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(133, 15);
            labelGreeting.TabIndex = 10;
            labelGreeting.Text = "Ввведіть email покупця";
            // 
            // btnCheckBonus
            // 
            btnCheckBonus.Location = new Point(619, 223);
            btnCheckBonus.Name = "btnCheckBonus";
            btnCheckBonus.Size = new Size(116, 39);
            btnCheckBonus.TabIndex = 11;
            btnCheckBonus.Text = "Перевірити баланс бонусів";
            btnCheckBonus.UseVisualStyleBackColor = true;
            btnCheckBonus.Click += btnCheckBonus_Click;
            // 
            // btnUseBonus
            // 
            btnUseBonus.Location = new Point(476, 223);
            btnUseBonus.Name = "btnUseBonus";
            btnUseBonus.Size = new Size(124, 39);
            btnUseBonus.TabIndex = 12;
            btnUseBonus.Text = "Зняти бонуси";
            btnUseBonus.UseVisualStyleBackColor = true;
            btnUseBonus.Click += btnUseBonus_Click;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Location = new Point(592, 348);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(164, 58);
            btnSubmitOrder.TabIndex = 13;
            btnSubmitOrder.Text = "Створити замовлення";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(477, 91);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 28;
            label3.Text = "Карта лояльності";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(77, 60);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 27;
            label2.Text = "Кошик";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(276, 25);
            label1.Name = "label1";
            label1.Size = new Size(297, 30);
            label1.TabIndex = 26;
            label1.Text = "Підтвердження замовлення";
            // 
            // button1
            // 
            button1.Location = new Point(555, 278);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 29;
            button1.Text = "Створити карту лояльності";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // zamovleniaconfrim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmitOrder);
            Controls.Add(btnUseBonus);
            Controls.Add(btnCheckBonus);
            Controls.Add(labelGreeting);
            Controls.Add(txtEmail);
            Controls.Add(btnBack);
            Controls.Add(labelTotalPrice);
            Controls.Add(dataGridViewConfirmedOrder);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "zamovleniaconfrim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zamovleniaconfrim";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfirmedOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private DataGridView dataGridViewConfirmedOrder;
        private Label labelTotalPrice;
        private Label btnBack;
        private TextBox txtEmail;
        private Label labelGreeting;
        private Button btnCheckBonus;
        private Button btnUseBonus;
        private Button btnSubmitOrder;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}