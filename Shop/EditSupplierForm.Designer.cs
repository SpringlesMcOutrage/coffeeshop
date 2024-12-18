namespace Shop
{
    partial class EditSupplierForm
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
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(116, 59);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(514, 23);
            txtSupplierName.TabIndex = 0;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(116, 140);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(514, 23);
            txtSupplierAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(514, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(116, 295);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(514, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(518, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Підтвердити";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(116, 362);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 40);
            btnBack.TabIndex = 5;
            btnBack.Text = "Скасувати";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // EditSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditSupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditSupplierForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnSave;
        private Button btnBack;
    }
}