namespace Shop
{
    partial class suppliers
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
            label2 = new Label();
            exitbuttonmain = new Label();
            dataGridViewSuppliers = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, -1);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Назад";
            label2.Click += label2_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(774, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 15;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AllowUserToAddRows = false;
            dataGridViewSuppliers.AllowUserToOrderColumns = true;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(24, 59);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.ReadOnly = true;
            dataGridViewSuppliers.Size = new Size(764, 330);
            dataGridViewSuppliers.TabIndex = 16;
            dataGridViewSuppliers.CellClick += dataGridViewSuppliers_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(302, 405);
            button1.Name = "button1";
            button1.Size = new Size(210, 23);
            button1.TabIndex = 17;
            button1.Text = "Додати ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(exitbuttonmain);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "suppliers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "suppliers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label exitbuttonmain;
        private DataGridView dataGridViewSuppliers;
        private Button button1;
    }
}