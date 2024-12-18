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
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, -1);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Назад";
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
            comboBoxMaterials.Location = new Point(103, 59);
            comboBoxMaterials.Name = "comboBoxMaterials";
            comboBoxMaterials.Size = new Size(547, 23);
            comboBoxMaterials.TabIndex = 13;
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(103, 110);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(547, 23);
            comboBoxSuppliers.TabIndex = 14;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(103, 176);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Кількість";
            txtQuantity.Size = new Size(547, 23);
            txtQuantity.TabIndex = 15;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(288, 296);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(196, 23);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Підтвердити";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // vzav
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}