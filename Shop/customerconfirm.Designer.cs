﻿namespace Shop
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfirmedOrder).BeginInit();
            SuspendLayout();
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Location = new Point(592, 371);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(164, 58);
            btnSubmitOrder.TabIndex = 22;
            btnSubmitOrder.Text = "Створити замовлення";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnUseBonus
            // 
            btnUseBonus.Location = new Point(408, 208);
            btnUseBonus.Name = "btnUseBonus";
            btnUseBonus.Size = new Size(116, 24);
            btnUseBonus.TabIndex = 21;
            btnUseBonus.Text = "Зняти баланс";
            btnUseBonus.UseVisualStyleBackColor = true;
            btnUseBonus.Click += btnUseBonus_Click;
            // 
            // btnCheckBonus
            // 
            btnCheckBonus.Location = new Point(408, 153);
            btnCheckBonus.Name = "btnCheckBonus";
            btnCheckBonus.Size = new Size(116, 39);
            btnCheckBonus.TabIndex = 20;
            btnCheckBonus.Text = "Перевірити баланс";
            btnCheckBonus.UseVisualStyleBackColor = true;
            btnCheckBonus.Click += btnCheckBonus_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(408, 59);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(84, 15);
            labelGreeting.TabIndex = 19;
            labelGreeting.Text = "Ввведіть email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(408, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(2, -2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(39, 15);
            btnBack.TabIndex = 17;
            btnBack.Text = "Назад";
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
            dataGridViewConfirmedOrder.Location = new Point(77, 35);
            dataGridViewConfirmedOrder.Name = "dataGridViewConfirmedOrder";
            dataGridViewConfirmedOrder.ReadOnly = true;
            dataGridViewConfirmedOrder.Size = new Size(240, 348);
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
            // customerconfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}