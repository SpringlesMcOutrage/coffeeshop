namespace Shop
{
    partial class vzav
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
            comboBoxMaterials = new ComboBox();
            comboBoxSuppliers = new ComboBox();
            txtQuantity = new TextBox();
            btnSubmit = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, -1);
            label4.Name = "label4";
            label4.Size = new Size(173, 42);
            label4.TabIndex = 12;
            label4.Text = "Повернутись у панель \r\nпрацівника";
            label4.Click += label4_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(771, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 11;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Clic;
            // 
            // comboBoxMaterials
            // 
            comboBoxMaterials.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterials.FormattingEnabled = true;
            comboBoxMaterials.Location = new Point(257, 92);
            comboBoxMaterials.Name = "comboBoxMaterials";
            comboBoxMaterials.Size = new Size(393, 23);
            comboBoxMaterials.TabIndex = 13;
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(253, 149);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(397, 23);
            comboBoxSuppliers.TabIndex = 14;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(253, 217);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Введіть кількість матеріалу";
            txtQuantity.Size = new Size(397, 23);
            txtQuantity.TabIndex = 15;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.Location = new Point(288, 296);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(244, 44);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Підтвердити взяття";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(153, 215);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 20;
            label5.Text = "Кількість";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(141, 149);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 19;
            label3.Text = "Матеріали";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(115, 92);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 18;
            label2.Text = "Постачальник";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(257, 26);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 17;
            label1.Text = "Взяття матеріалу зі складу";
            // 
            // vzav
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(txtQuantity);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(comboBoxMaterials);
            Controls.Add(label4);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "vzav";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vzav";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label exitbuttonmain;
        private ComboBox comboBoxMaterials;
        private ComboBox comboBoxSuppliers;
        private TextBox txtQuantity;
        private Button btnSubmit;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}