namespace Shop
{
    partial class skladadminadd
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
            comboBoxSuppliers = new ComboBox();
            txtMaterialName = new TextBox();
            txtQuantity = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(141, 190);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(121, 23);
            comboBoxSuppliers.TabIndex = 0;
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(141, 60);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.PlaceholderText = "Назва";
            txtMaterialName.Size = new Size(492, 23);
            txtMaterialName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(141, 129);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Кількість";
            txtQuantity.Size = new Size(492, 23);
            txtQuantity.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(140, 303);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(558, 303);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // skladadminadd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtQuantity);
            Controls.Add(txtMaterialName);
            Controls.Add(comboBoxSuppliers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "skladadminadd";
            Text = "skladadminadd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSuppliers;
        private TextBox txtMaterialName;
        private TextBox txtQuantity;
        private Button btnCancel;
        private Button btnSave;
    }
}