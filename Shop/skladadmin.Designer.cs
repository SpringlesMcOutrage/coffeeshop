namespace Shop
{
    partial class skladadmin
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
            dataGridViewInventory = new DataGridView();
            exitbuttonmain = new Label();
            btnAddMaterial = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(175, 42);
            label4.TabIndex = 14;
            label4.Text = "Повернутися до панелі\r\nадміністрації\r\n";
            label4.Click += label4_Click;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AllowUserToDeleteRows = false;
            dataGridViewInventory.AllowUserToOrderColumns = true;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(44, 79);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.Size = new Size(717, 302);
            dataGridViewInventory.TabIndex = 13;
            dataGridViewInventory.CellClick += dataGridViewInventory_CellClick;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(771, 0);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 12;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.Location = new Point(316, 405);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(190, 23);
            btnAddMaterial.TabIndex = 15;
            btnAddMaterial.Text = "Добавити матеріал";
            btnAddMaterial.UseVisualStyleBackColor = true;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(343, 33);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 16;
            label1.Text = "Склад закладу";
            // 
            // skladadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAddMaterial);
            Controls.Add(label4);
            Controls.Add(dataGridViewInventory);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "skladadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "skladadmin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridViewInventory;
        private Label exitbuttonmain;
        private Button btnAddMaterial;
        private Label label1;
    }
}