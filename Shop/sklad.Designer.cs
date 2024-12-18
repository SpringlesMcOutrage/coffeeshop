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
            dataGridViewInventory.Location = new Point(114, 114);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.Size = new Size(597, 269);
            dataGridViewInventory.TabIndex = 7;
            dataGridViewInventory.CellContentClick += dataGridViewInventory_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, -1);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // sklad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dataGridViewInventory);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sklad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sklad";
            Load += sklad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private DataGridView dataGridViewInventory;
        private Label label4;
    }
}