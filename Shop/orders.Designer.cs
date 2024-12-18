namespace Shop
{
    partial class orders
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
            dataGridViewOrders = new DataGridView();
            label1 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            comboBoxEmployees = new ComboBox();
            label4 = new Label();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(777, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 6;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(12, 45);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.Size = new Size(591, 363);
            dataGridViewOrders.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, -1);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Назад";
            label1.Click += label1_Click;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(630, 66);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(127, 23);
            dateTimePickerFrom.TabIndex = 9;
            dateTimePickerFrom.Value = new DateTime(2024, 12, 1, 3, 13, 0, 0);
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(630, 126);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(127, 23);
            dateTimePickerTo.TabIndex = 10;
            dateTimePickerTo.Value = new DateTime(2024, 12, 30, 3, 13, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(630, 45);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 11;
            label2.Text = "З";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(630, 108);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 12;
            label3.Text = "До";
            // 
            // comboBoxEmployees
            // 
            comboBoxEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployees.FormattingEnabled = true;
            comboBoxEmployees.Location = new Point(630, 179);
            comboBoxEmployees.Name = "comboBoxEmployees";
            comboBoxEmployees.Size = new Size(127, 23);
            comboBoxEmployees.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 161);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 14;
            label4.Text = "Співробітник";
            label4.Click += label4_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(630, 233);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(127, 23);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Фільтрувати";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFilter);
            Controls.Add(label4);
            Controls.Add(comboBoxEmployees);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label1);
            Controls.Add(dataGridViewOrders);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "orders";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private DataGridView dataGridViewOrders;
        private Label label1;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxEmployees;
        private Label label4;
        private Button btnFilter;
    }
}