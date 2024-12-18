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
            txtCategoryId = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtWeight = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, -1);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 22;
            label4.Text = "Назад";
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
            btnSave.Location = new Point(342, 387);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(100, 62);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Імя";
            txtProductName.Size = new Size(578, 23);
            txtProductName.TabIndex = 24;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(100, 119);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.PlaceholderText = "Категорія";
            txtCategoryId.Size = new Size(578, 23);
            txtCategoryId.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(100, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Ціна";
            txtPrice.Size = new Size(578, 23);
            txtPrice.TabIndex = 26;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 243);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Опис";
            txtDescription.Size = new Size(578, 23);
            txtDescription.TabIndex = 27;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(100, 299);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Вага";
            txtWeight.Size = new Size(578, 23);
            txtWeight.TabIndex = 28;
            // 
            // menuchenge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtWeight);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtCategoryId);
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
        private TextBox txtCategoryId;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtWeight;
    }
}