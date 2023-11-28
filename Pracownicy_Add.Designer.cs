namespace magazin
{
    partial class Pracownicy_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pracownicy_Add));
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(652, 30);
            label9.Name = "label9";
            label9.Size = new Size(604, 41);
            label9.TabIndex = 30;
            label9.Text = "Do dodania funkcjonalność openFileDialogu";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(645, 732);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(791, 584);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(486, 47);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(791, 492);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 47);
            textBox1.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(559, 732);
            label5.Name = "label5";
            label5.Size = new Size(80, 41);
            label5.TabIndex = 22;
            label5.Text = "Płeć:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 590);
            label3.Name = "label3";
            label3.Size = new Size(175, 41);
            label3.TabIndex = 20;
            label3.Text = "Stanowisko:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 498);
            label2.Name = "label2";
            label2.Size = new Size(226, 41);
            label2.TabIndex = 19;
            label2.Text = "Imię i nazwisko:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(549, 404);
            label1.Name = "label1";
            label1.Size = new Size(511, 62);
            label1.TabIndex = 18;
            label1.Text = "Dodawanie pracownika";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(791, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 662);
            label4.Name = "label4";
            label4.Size = new Size(226, 41);
            label4.TabIndex = 31;
            label4.Text = "Data urodzenia:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(791, 662);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(500, 47);
            dateTimePicker1.TabIndex = 32;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(740, 797);
            button2.Name = "button2";
            button2.Size = new Size(372, 114);
            button2.TabIndex = 33;
            button2.Text = "Dodaj";
            button2.UseVisualStyleBackColor = true;
            // 
            // Pracownicy_Add
            // 
            AutoScaleDimensions = new SizeF(240F, 240F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1888, 992);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pracownicy_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodawanie nowego pracownika";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}