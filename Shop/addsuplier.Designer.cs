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
            SuspendLayout();
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(164, 66);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Імя";
            txtSupplierName.Size = new Size(452, 23);
            txtSupplierName.TabIndex = 0;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(164, 138);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.PlaceholderText = "Адреса";
            txtSupplierAddress.Size = new Size(452, 23);
            txtSupplierAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email ";
            txtEmail.Size = new Size(452, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(164, 275);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Телефон";
            txtPhoneNumber.Size = new Size(452, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(541, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Додати";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(164, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // addsuplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addsuplier";
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
    }
}