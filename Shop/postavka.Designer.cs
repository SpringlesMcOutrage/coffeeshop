namespace Shop
{
    partial class postavka
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
            components = new System.ComponentModel.Container();
            exitbuttonmain = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            fadasdaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            wToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem = new ToolStripMenuItem();
            comboBoxSuppliers = new ComboBox();
            comboBoxMaterials = new ComboBox();
            textBoxQuantity = new TextBox();
            buttonPostavka = new Button();
            label4 = new Label();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // exitbuttonmain
            // 
            exitbuttonmain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitbuttonmain.AutoSize = true;
            exitbuttonmain.Font = new Font("Segoe UI", 20F);
            exitbuttonmain.Location = new Point(772, -1);
            exitbuttonmain.Name = "exitbuttonmain";
            exitbuttonmain.Size = new Size(29, 37);
            exitbuttonmain.TabIndex = 5;
            exitbuttonmain.Text = "х";
            exitbuttonmain.Click += exitbuttonmain_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { fadasdaToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(116, 26);
            // 
            // fadasdaToolStripMenuItem
            // 
            fadasdaToolStripMenuItem.Name = "fadasdaToolStripMenuItem";
            fadasdaToolStripMenuItem.Size = new Size(115, 22);
            fadasdaToolStripMenuItem.Text = "fadasda";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { wToolStripMenuItem, eToolStripMenuItem, rToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(86, 70);
            // 
            // wToolStripMenuItem
            // 
            wToolStripMenuItem.Name = "wToolStripMenuItem";
            wToolStripMenuItem.Size = new Size(85, 22);
            wToolStripMenuItem.Text = "W";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(85, 22);
            eToolStripMenuItem.Text = "E";
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(85, 22);
            rToolStripMenuItem.Text = "R";
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(129, 104);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(561, 23);
            comboBoxSuppliers.TabIndex = 6;
            // 
            // comboBoxMaterials
            // 
            comboBoxMaterials.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterials.FormattingEnabled = true;
            comboBoxMaterials.Location = new Point(129, 168);
            comboBoxMaterials.Name = "comboBoxMaterials";
            comboBoxMaterials.Size = new Size(561, 23);
            comboBoxMaterials.TabIndex = 7;
            comboBoxMaterials.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(129, 246);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(561, 23);
            textBoxQuantity.TabIndex = 8;
            // 
            // buttonPostavka
            // 
            buttonPostavka.Location = new Point(615, 340);
            buttonPostavka.Name = "buttonPostavka";
            buttonPostavka.Size = new Size(75, 23);
            buttonPostavka.TabIndex = 9;
            buttonPostavka.Text = "Поставка";
            buttonPostavka.UseVisualStyleBackColor = true;
            buttonPostavka.Click += buttonPostavka_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, -1);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Назад";
            label4.Click += label4_Click;
            // 
            // postavka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(buttonPostavka);
            Controls.Add(textBoxQuantity);
            Controls.Add(comboBoxMaterials);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(exitbuttonmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "postavka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "postavka";
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitbuttonmain;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem fadasdaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem wToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private ComboBox comboBoxSuppliers;
        private ComboBox comboBoxMaterials;
        private TextBox textBoxQuantity;
        private Button buttonPostavka;
        private Label label4;
    }
}