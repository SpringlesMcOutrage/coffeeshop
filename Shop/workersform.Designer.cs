namespace Shop
{
    partial class workersform
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
            dataGridViewWorkers = new DataGridView();
            btnAddWorker = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkers).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, -2);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, -2);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 15;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // dataGridViewWorkers
            // 
            dataGridViewWorkers.AllowUserToAddRows = false;
            dataGridViewWorkers.AllowUserToDeleteRows = false;
            dataGridViewWorkers.AllowUserToOrderColumns = true;
            dataGridViewWorkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkers.Location = new Point(57, 55);
            dataGridViewWorkers.Name = "dataGridViewWorkers";
            dataGridViewWorkers.ReadOnly = true;
            dataGridViewWorkers.Size = new Size(692, 321);
            dataGridViewWorkers.TabIndex = 17;
            dataGridViewWorkers.CellClick += dataGridViewWorkers_CellClick;
            // 
            // btnAddWorker
            // 
            btnAddWorker.Location = new Point(352, 403);
            btnAddWorker.Name = "btnAddWorker";
            btnAddWorker.Size = new Size(144, 23);
            btnAddWorker.TabIndex = 18;
            btnAddWorker.Text = "Додати працівника";
            btnAddWorker.UseVisualStyleBackColor = true;
            btnAddWorker.Click += btnAddWorker_Click;
            // 
            // workersform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddWorker);
            Controls.Add(dataGridViewWorkers);
            Controls.Add(label4);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "workersform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "workersform";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label exitbuttonmain;
        private DataGridView dataGridViewWorkers;
        private Button btnAddWorker;
    }
}