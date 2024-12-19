namespace Shop
{
    partial class customerconfirm
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
            btnSubmitOrder = new Button();
            btnUseBonus = new Button();
            btnCheckBonus = new Button();
            labelGreeting = new Label();
            txtEmail = new TextBox();
            btnBack = new Label();
            labelTotalPrice = new Label();
            dataGridViewConfirmedOrder = new DataGridView();
            exitbuttonmain = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfirmedOrder).BeginInit();
            SuspendLayout();
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Location = new Point(592, 371);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(164, 58);
            btnSubmitOrder.TabIndex = 22;
            btnSubmitOrder.Text = "Підтвердити замовлення";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnUseBonus
            // 
            btnUseBonus.Location = new Point(561, 312);
            btnUseBonus.Name = "btnUseBonus";
            btnUseBonus.Size = new Size(116, 24);
            btnUseBonus.TabIndex = 21;
            btnUseBonus.Text = "Зняти бонуси";
            btnUseBonus.UseVisualStyleBackColor = true;
            btnUseBonus.Click += btnUseBonus_Click;
            // 
            // btnCheckBonus
            // 
            btnCheckBonus.Location = new Point(490, 249);
            btnCheckBonus.Name = "btnCheckBonus";
            btnCheckBonus.Size = new Size(116, 39);
            btnCheckBonus.TabIndex = 20;
            btnCheckBonus.Text = "Перевірити баланс бонусів";
            btnCheckBonus.UseVisualStyleBackColor = true;
            btnCheckBonus.Click += btnCheckBonus_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(490, 158);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(84, 15);
            labelGreeting.TabIndex = 19;
            labelGreeting.Text = "Ввведіть email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(490, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(-1, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 15);
            btnBack.TabIndex = 17;
            btnBack.Text = "Повернутися назад";
            btnBack.Click += btnBack_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(77, 414);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(38, 15);
            labelTotalPrice.TabIndex = 16;
            labelTotalPrice.Text = "label1";
            // 
            // dataGridViewConfirmedOrder
            // 
            dataGridViewConfirmedOrder.AllowUserToAddRows = false;
            dataGridViewConfirmedOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConfirmedOrder.Location = new Point(77, 108);
            dataGridViewConfirmedOrder.Name = "dataGridViewConfirmedOrder";
            dataGridViewConfirmedOrder.ReadOnly = true;
            dataGridViewConfirmedOrder.Size = new Size(361, 275);
            dataGridViewConfirmedOrder.TabIndex = 15;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(771, -2);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 14;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(264, 21);
            label1.Name = "label1";
            label1.Size = new Size(297, 30);
            label1.TabIndex = 23;
            label1.Text = "Підтвердження замовлення";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(77, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 24;
            label2.Text = "Кошик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(490, 108);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 25;
            label3.Text = "Карта лояльності";
            // 
            // button1
            // 
            button1.Location = new Point(636, 249);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 26;
            button1.Text = "Створити карту лояльності";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customerconfirm
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
            Name = "customerconfirm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customerconfirm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfirmedOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitOrder;
        private Button btnUseBonus;
        private Button btnCheckBonus;
        private Label labelGreeting;
        private TextBox txtEmail;
        private Label btnBack;
        private Label labelTotalPrice;
        private DataGridView dataGridViewConfirmedOrder;
        private Label exitbuttonmain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}