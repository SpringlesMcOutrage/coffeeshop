namespace Shop
{
    partial class addsuplier
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
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(232, 91);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Введіть імя поставчальника";
            txtSupplierName.Size = new Size(452, 23);
            txtSupplierName.TabIndex = 0;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(232, 166);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.PlaceholderText = "Введіть адресу постачальника";
            txtSupplierAddress.Size = new Size(452, 23);
            txtSupplierAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(232, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Введіть Email постачальника";
            txtEmail.Size = new Size(452, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(232, 303);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Введіть номер телефону постачальника";
            txtPhoneNumber.Size = new Size(452, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F);
            btnSave.Location = new Point(535, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 54);
            btnSave.TabIndex = 4;
            btnSave.Text = "Додати";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.Location = new Point(167, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 54);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(167, 93);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 6;
            label1.Text = "Імя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(139, 164);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 7;
            label2.Text = "Адреса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(152, 234);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(70, 303);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 9;
            label4.Text = "Номер телефону";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(259, 9);
            label5.Name = "label5";
            label5.Size = new Size(257, 30);
            label5.TabIndex = 10;
            label5.Text = "Додання постачальника";
            // 
            // addsuplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addsuplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addsuplier";
            Load += addsuplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}