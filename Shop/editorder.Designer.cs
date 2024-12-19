namespace Shop
{
    partial class editorder
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
            dateTimePickerCreatedAt = new DateTimePicker();
            comboBoxCustomer = new ComboBox();
            comboBoxEmployee = new ComboBox();
            lblOrderId = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtPaymentAmount = new TextBox();
            txtStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // dateTimePickerCreatedAt
            // 
            dateTimePickerCreatedAt.Location = new Point(354, 126);
            dateTimePickerCreatedAt.Name = "dateTimePickerCreatedAt";
            dateTimePickerCreatedAt.Size = new Size(200, 23);
            dateTimePickerCreatedAt.TabIndex = 1;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(354, 285);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(365, 23);
            comboBoxCustomer.TabIndex = 4;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(354, 334);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(365, 23);
            comboBoxEmployee.TabIndex = 5;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(354, 78);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(38, 15);
            lblOrderId.TabIndex = 6;
            lblOrderId.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(556, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 61);
            btnSave.TabIndex = 7;
            btnSave.Text = "Зберегти запис";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(157, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 61);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(354, 229);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.PlaceholderText = "Введіть суму платежу";
            txtPaymentAmount.Size = new Size(365, 23);
            txtPaymentAmount.TabIndex = 9;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(354, 179);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Введіть статус замовлення";
            txtStatus.Size = new Size(365, 23);
            txtStatus.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(254, 20);
            label1.Name = "label1";
            label1.Size = new Size(320, 30);
            label1.TabIndex = 11;
            label1.Text = "Зміна данних про замовлення";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(205, 73);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 12;
            label2.Text = "ID Замовлення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(188, 127);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 13;
            label3.Text = "Дата замовлення";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(175, 181);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 14;
            label4.Text = "Статус замовлення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(210, 231);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 15;
            label5.Text = "Сума платежу";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(229, 287);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 16;
            label6.Text = "Ім'я клієнта";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(235, 334);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 17;
            label7.Text = "Працівник";
            // 
            // editorder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStatus);
            Controls.Add(txtPaymentAmount);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblOrderId);
            Controls.Add(comboBoxEmployee);
            Controls.Add(comboBoxCustomer);
            Controls.Add(dateTimePickerCreatedAt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editorder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editorder";
            Load += editorder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerCreatedAt;
        private ComboBox comboBoxCustomer;
        private ComboBox comboBoxEmployee;
        private Label lblOrderId;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtPaymentAmount;
        private TextBox txtStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}