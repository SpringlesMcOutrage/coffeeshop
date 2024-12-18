namespace Shop
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            exitbuttonmain = new Label();
            label1 = new Label();
            sklad = new Label();
            suppliers = new Label();
            orderhistory = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(769, -2);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 5;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(423, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 6;
            label1.Text = "Панель Адміністрації";
            label1.Click += label1_Click;
            // 
            // sklad
            // 
            sklad.AutoSize = true;
            sklad.Font = new Font("Segoe UI", 14F);
            sklad.Location = new Point(76, 138);
            sklad.Name = "sklad";
            sklad.Size = new Size(176, 25);
            sklad.TabIndex = 7;
            sklad.Text = "Переглянути склад";
            sklad.Click += sklad_Click;
            // 
            // suppliers
            // 
            suppliers.AutoSize = true;
            suppliers.Font = new Font("Segoe UI", 14F);
            suppliers.Location = new Point(76, 211);
            suppliers.Name = "suppliers";
            suppliers.Size = new Size(186, 50);
            suppliers.TabIndex = 8;
            suppliers.Text = "Переглянути дані \r\nпро постачальників";
            suppliers.Click += suppliers_Click;
            // 
            // orderhistory
            // 
            orderhistory.AutoSize = true;
            orderhistory.Font = new Font("Segoe UI", 14F);
            orderhistory.Location = new Point(75, 318);
            orderhistory.Name = "orderhistory";
            orderhistory.Size = new Size(197, 50);
            orderhistory.TabIndex = 9;
            orderhistory.Text = "Переглянути історію \r\nзамовлень";
            orderhistory.Click += orderhistory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(317, 318);
            label3.Name = "label3";
            label3.Size = new Size(207, 50);
            label3.TabIndex = 10;
            label3.Text = "Переглянути дані про \r\nпрацівників";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(75, 60);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 11;
            label4.Text = "Переглянути меню";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(572, 318);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 12;
            label5.Text = "Переглянути звітність";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, -2);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Назад";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(317, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(orderhistory);
            Controls.Add(suppliers);
            Controls.Add(sklad);
            Controls.Add(label1);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private Label label1;
        private Label sklad;
        private Label suppliers;
        private Label orderhistory;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox1;
    }
}