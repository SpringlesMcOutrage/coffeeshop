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
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AllowUserToDeleteRows = false;
            dataGridViewInventory.AllowUserToOrderColumns = true;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(109, 53);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.Size = new Size(597, 328);
            dataGridViewInventory.TabIndex = 13;
            dataGridViewInventory.CellContentClick += dataGridViewInventory_CellContentClick;
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
            // skladadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddMaterial);
            Controls.Add(label4);
            Controls.Add(dataGridViewInventory);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "skladadmin";
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
    }
}