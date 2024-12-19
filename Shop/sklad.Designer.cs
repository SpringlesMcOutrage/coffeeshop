namespace Shop
{
    partial class sklad
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
            exitbuttonmain = new Label();
            dataGridViewInventory = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            comboBoxSuppliers = new ComboBox();
            label2 = new Label();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 6;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AllowUserToDeleteRows = false;
            dataGridViewInventory.AllowUserToOrderColumns = true;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(33, 82);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.Size = new Size(578, 344);
            dataGridViewInventory.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(0, -1);
            label4.Name = "label4";
            label4.Size = new Size(173, 42);
            label4.TabIndex = 11;
            label4.Text = "Повернутись у панель \r\nпрацівника";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(336, 25);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 12;
            label1.Text = "Склад закладу";
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(633, 125);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(121, 23);
            comboBoxSuppliers.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(633, 82);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 14;
            label2.Text = "Постачальник";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(633, 172);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(121, 23);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Фільтрувати";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // sklad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dataGridViewInventory);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sklad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sklad";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private DataGridView dataGridViewInventory;
        private Label label4;
        private Label label1;
        private ComboBox comboBoxSuppliers;
        private Label label2;
        private Button btnFilter;
    }
}