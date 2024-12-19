namespace Shop
{
    partial class editworker
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtRole = new TextBox();
            txtShift = new TextBox();
            txtSalary = new TextBox();
            dtpBirthday = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            label4 = new Label();
            exitbuttonmain = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 72);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Введіть імя";
            txtName.Size = new Size(196, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(178, 118);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Введіть прізвище";
            txtSurname.Size = new Size(196, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(178, 167);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = "Введіть роль";
            txtRole.Size = new Size(196, 23);
            txtRole.TabIndex = 2;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(178, 219);
            txtShift.Name = "txtShift";
            txtShift.PlaceholderText = "Введіть зміну";
            txtShift.Size = new Size(196, 23);
            txtShift.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(178, 275);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Введіть заробітьню плату";
            txtSalary.Size = new Size(196, 23);
            txtSalary.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(178, 328);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.PlaceholderText = "Введіть день народження";
            dtpBirthday.Size = new Size(196, 23);
            dtpBirthday.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(538, 68);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Введіть номер телефону";
            txtPhoneNumber.Size = new Size(208, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(538, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Введіть email";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(538, 165);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Введіть адресу";
            txtAddress.Size = new Size(208, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(538, 219);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Введіть логін";
            txtLogin.Size = new Size(208, 23);
            txtLogin.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(538, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Введіть пароль";
            txtPassword.Size = new Size(208, 23);
            txtPassword.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(499, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 47);
            btnSave.TabIndex = 11;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, 0);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 17;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbutton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 30);
            label1.TabIndex = 19;
            label1.Text = "Зміна данних працівників";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(125, 70);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 20;
            label2.Text = "Імя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(79, 120);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 21;
            label3.Text = "Прізвище";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(114, 167);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 22;
            label5.Text = "Роль";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(107, 221);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 23;
            label6.Text = "Зміна";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(32, 277);
            label7.Name = "label7";
            label7.Size = new Size(126, 21);
            label7.TabIndex = 24;
            label7.Text = "Заробітня плата";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(18, 330);
            label8.Name = "label8";
            label8.Size = new Size(140, 21);
            label8.TabIndex = 25;
            label8.Text = "День народження";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(390, 70);
            label9.Name = "label9";
            label9.Size = new Size(130, 21);
            label9.TabIndex = 26;
            label9.Text = "Номер телефону";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(472, 116);
            label10.Name = "label10";
            label10.Size = new Size(48, 21);
            label10.TabIndex = 27;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(460, 165);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 28;
            label11.Text = "Адреса";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(472, 221);
            label12.Name = "label12";
            label12.Size = new Size(49, 21);
            label12.TabIndex = 29;
            label12.Text = "Логін";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(457, 277);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 30;
            label13.Text = "Пароль";
            // 
            // editworker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(exitbuttonmain);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(dtpBirthday);
            Controls.Add(txtSalary);
            Controls.Add(txtShift);
            Controls.Add(txtRole);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editworker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editworker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtRole;
        private TextBox txtShift;
        private TextBox txtSalary;
        private TextBox dtpBirthday;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnSave;
        private Label label4;
        private Label exitbuttonmain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}