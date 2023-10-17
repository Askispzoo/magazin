namespace magazin
{
    partial class Sam_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sam_Add));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            label9 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(429, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 370);
            label1.Name = "label1";
            label1.Size = new Size(518, 62);
            label1.TabIndex = 1;
            label1.Text = "Dodawanie samochodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 458);
            label2.Name = "label2";
            label2.Size = new Size(107, 41);
            label2.TabIndex = 2;
            label2.Text = "Marka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 553);
            label3.Name = "label3";
            label3.Size = new Size(111, 41);
            label3.TabIndex = 3;
            label3.Text = "Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 656);
            label4.Name = "label4";
            label4.Size = new Size(259, 41);
            label4.TabIndex = 4;
            label4.Text = "Pojemność silnika:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 753);
            label5.Name = "label5";
            label5.Size = new Size(161, 41);
            label5.TabIndex = 5;
            label5.Text = "Typ silnika:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 849);
            label6.Name = "label6";
            label6.Size = new Size(289, 41);
            label6.TabIndex = 6;
            label6.Text = "Numer rejestracyjny:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 458);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 47);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 553);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(486, 47);
            textBox2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(299, 656);
            numericUpDown1.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(300, 47);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(605, 658);
            label7.Name = "label7";
            label7.Size = new Size(74, 41);
            label7.TabIndex = 10;
            label7.Text = "cm3";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 750);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 849);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(486, 47);
            textBox3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 931);
            label8.Name = "label8";
            label8.Size = new Size(120, 41);
            label8.TabIndex = 13;
            label8.Text = "Zdjęcie:";
            // 
            // button1
            // 
            button1.Location = new Point(31, 989);
            button1.Name = "button1";
            button1.Size = new Size(372, 114);
            button1.TabIndex = 14;
            button1.Text = "Dodaj obraz";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(429, 989);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(374, 114);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(158, 29);
            label9.Name = "label9";
            label9.Size = new Size(604, 41);
            label9.TabIndex = 16;
            label9.Text = "Do dodania funkcjonalność openFileDialogu";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(359, 1213);
            button2.Name = "button2";
            button2.Size = new Size(372, 114);
            button2.TabIndex = 17;
            button2.Text = "Dodaj";
            button2.UseVisualStyleBackColor = true;
            // 
            // Sam_Add
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1168, 1433);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Sam_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj samochód";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label8;
        private Button button1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private Label label9;
        private Button button2;
    }
}