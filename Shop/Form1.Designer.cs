namespace Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            loginfield = new TextBox();
            passfield = new TextBox();
            exitbuttonmain = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(464, 368);
            button1.Name = "button1";
            button1.Size = new Size(161, 25);
            button1.TabIndex = 0;
            button1.Text = "Продовжити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(70, 261);
            label1.Name = "label1";
            label1.Size = new Size(198, 74);
            label1.TabIndex = 1;
            label1.Text = "Авторизація \r\nдля персоналу";
            label1.Click += label1_Click;
            // 
            // loginfield
            // 
            loginfield.Location = new Point(350, 243);
            loginfield.Name = "loginfield";
            loginfield.PlaceholderText = "Логін";
            loginfield.Size = new Size(385, 23);
            loginfield.TabIndex = 2;
            loginfield.TextChanged += textBox1_TextChanged;
            // 
            // passfield
            // 
            passfield.Location = new Point(350, 312);
            passfield.Name = "passfield";
            passfield.PlaceholderText = "Пароль";
            passfield.Size = new Size(385, 23);
            passfield.TabIndex = 3;
            passfield.UseSystemPasswordChar = true;
            passfield.TextChanged += textBox2_TextChanged;
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(771, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 4;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(-1, -1);
            label2.Name = "label2";
            label2.Size = new Size(234, 50);
            label2.TabIndex = 16;
            label2.Text = "Перейти до оформлення \r\nзамовлення";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(350, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(exitbuttonmain);
            Controls.Add(passfield);
            Controls.Add(loginfield);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox loginfield;
        private TextBox passfield;
        private Label exitbuttonmain;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
