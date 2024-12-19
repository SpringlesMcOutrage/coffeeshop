namespace Shop
{
    partial class menuchenge
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
            label4 = new Label();
            exitbuttonmain = new Label();
            btnSave = new Button();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtWeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxCategory = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(1, -1);
            label4.Name = "label4";
            label4.Size = new Size(170, 21);
            label4.TabIndex = 22;
            label4.Text = "Повернутися до меню";
            label4.Click += label4_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(773, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 21;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(293, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 47);
            btnSave.TabIndex = 23;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(197, 54);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Введіть імя товару";
            txtProductName.Size = new Size(481, 23);
            txtProductName.TabIndex = 24;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(197, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Введіть ціну";
            txtPrice.Size = new Size(481, 23);
            txtPrice.TabIndex = 26;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(197, 243);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Введіть опис товару";
            txtDescription.Size = new Size(481, 23);
            txtDescription.TabIndex = 27;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(197, 299);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Введіть вагу товару";
            txtWeight.Size = new Size(481, 23);
            txtWeight.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(69, 52);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 29;
            label1.Text = "Імя товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(69, 121);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 30;
            label2.Text = "Категорія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(69, 182);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 31;
            label3.Text = "Ціна товару";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(69, 241);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 32;
            label5.Text = "Опис товару";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(69, 301);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 33;
            label6.Text = "Вага товару";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(197, 119);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(481, 23);
            comboBoxCategory.TabIndex = 34;
            // 
            // menuchenge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWeight);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menuchenge";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuchenge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label exitbuttonmain;
        private Button btnSave;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtWeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxCategory;
    }
}