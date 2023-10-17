namespace magazin
{
    partial class Ustawienia
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
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(12, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 209);
            listBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 347);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(151, 45);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "opcja 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 411);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(228, 45);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 542);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 498);
            label1.Name = "label1";
            label1.Size = new Size(345, 41);
            label1.TabIndex = 4;
            label1.Text = "Wybierz motyw aplikacji:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1482, 25);
            label2.Name = "label2";
            label2.Size = new Size(260, 41);
            label2.TabIndex = 5;
            label2.Text = "Dane użytkownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1482, 125);
            label3.Name = "label3";
            label3.Size = new Size(85, 41);
            label3.TabIndex = 6;
            label3.Text = "login";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1482, 192);
            label4.Name = "label4";
            label4.Size = new Size(265, 41);
            label4.TabIndex = 7;
            label4.Text = "pelna nazwa konta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1482, 257);
            label5.Name = "label5";
            label5.Size = new Size(229, 41);
            label5.TabIndex = 8;
            label5.Text = "systemdirectory";
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 992);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(listBox1);
            Name = "Ustawienia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ustawienia";
            Load += Ustawienia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}