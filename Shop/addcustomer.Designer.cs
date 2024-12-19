namespace Shop
{
    partial class addcustomer
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
            btnBack = new Label();
            exitbuttonmain = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            btnCreateCard = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(0, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 15);
            btnBack.TabIndex = 19;
            btnBack.Text = "Повернутися назад";
            btnBack.Click += btnBack_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, 0);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 18;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(225, 125);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Введіть ваше імя";
            txtName.Size = new Size(495, 23);
            txtName.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(225, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Введіть ваш email";
            txtEmail.Size = new Size(495, 23);
            txtEmail.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(225, 271);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Введіть ваш номер телефону";
            txtPhoneNumber.Size = new Size(495, 23);
            txtPhoneNumber.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(282, 37);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 23;
            label1.Text = "Створення карти лояльності";
            // 
            // btnCreateCard
            // 
            btnCreateCard.Location = new Point(519, 353);
            btnCreateCard.Name = "btnCreateCard";
            btnCreateCard.Size = new Size(225, 51);
            btnCreateCard.TabIndex = 24;
            btnCreateCard.Text = "Створити карту лояльності";
            btnCreateCard.UseVisualStyleBackColor = true;
            btnCreateCard.Click += btnCreateCard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(171, 123);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 25;
            label2.Text = "Імя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(156, 199);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 26;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(74, 273);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 27;
            label4.Text = "Номер телефону";
            // 
            // addcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreateCard);
            Controls.Add(label1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnBack);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addcustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addcustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnBack;
        private Label exitbuttonmain;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label1;
        private Button btnCreateCard;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}