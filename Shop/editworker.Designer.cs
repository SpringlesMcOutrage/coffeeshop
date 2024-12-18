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
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 71);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Імя";
            txtName.Size = new Size(296, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(51, 118);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Прізвище";
            txtSurname.Size = new Size(296, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(51, 167);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = "Роль";
            txtRole.Size = new Size(296, 23);
            txtRole.TabIndex = 2;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(51, 219);
            txtShift.Name = "txtShift";
            txtShift.PlaceholderText = "Зміна(1,2,3)";
            txtShift.Size = new Size(296, 23);
            txtShift.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(51, 275);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Заробітьня плата";
            txtSalary.Size = new Size(296, 23);
            txtSalary.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(51, 328);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.PlaceholderText = "День народження";
            dtpBirthday.Size = new Size(296, 23);
            dtpBirthday.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(450, 71);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Номер телефону";
            txtPhoneNumber.Size = new Size(296, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(450, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(296, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(450, 167);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Адреса";
            txtAddress.Size = new Size(296, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(450, 219);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логін";
            txtLogin.Size = new Size(296, 23);
            txtLogin.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(450, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(296, 23);
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
            // editworker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}