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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(243, 275);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(493, 23);
            comboBoxSuppliers.TabIndex = 0;
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(243, 114);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.PlaceholderText = "Назва";
            txtMaterialName.Size = new Size(493, 23);
            txtMaterialName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(243, 199);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Кількість";
            txtQuantity.Size = new Size(493, 23);
            txtQuantity.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(102, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 52);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(489, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 52);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти матеріал";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(45, 112);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 5;
            label1.Text = "Назва матеріалу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(45, 201);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 6;
            label2.Text = "Кількість матеріалу";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(45, 275);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 7;
            label3.Text = "Поставщик";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(331, 43);
            label4.Name = "label4";
            label4.Size = new Size(142, 30);
            label4.TabIndex = 8;
            label4.Text = "Зміна складу";
            // 
            // skladadminadd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtQuantity);
            Controls.Add(txtMaterialName);
            Controls.Add(comboBoxSuppliers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "skladadminadd";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}