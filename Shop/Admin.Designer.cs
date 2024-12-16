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
            exitbuttonmain = new Label();
            label1 = new Label();
            sklad = new Label();
            suppliers = new Label();
            orderhistory = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
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
            label1.Location = new Point(374, 41);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "ADMIN";
            label1.Click += label1_Click;
            // 
            // sklad
            // 
            sklad.AutoSize = true;
            sklad.Location = new Point(141, 136);
            sklad.Name = "sklad";
            sklad.Size = new Size(40, 15);
            sklad.TabIndex = 7;
            sklad.Text = "Склад";
            sklad.Click += sklad_Click;
            // 
            // suppliers
            // 
            suppliers.AutoSize = true;
            suppliers.Location = new Point(141, 208);
            suppliers.Name = "suppliers";
            suppliers.Size = new Size(93, 15);
            suppliers.TabIndex = 8;
            suppliers.Text = "Постачальники";
            suppliers.Click += suppliers_Click;
            // 
            // orderhistory
            // 
            orderhistory.AutoSize = true;
            orderhistory.Location = new Point(141, 294);
            orderhistory.Name = "orderhistory";
            orderhistory.Size = new Size(108, 15);
            orderhistory.TabIndex = 9;
            orderhistory.Text = "Історія Замовлень";
            orderhistory.Click += orderhistory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 136);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Працівники";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 208);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "Меню";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 294);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Звітність";
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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            StartPosition = FormStartPosition.Manual;
            Text = "Admin";
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
    }
}