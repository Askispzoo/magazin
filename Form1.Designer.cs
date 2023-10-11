namespace magazin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            logintextBox = new TextBox();
            password_textBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(503, 389);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // logintextBox
            // 
            logintextBox.Location = new Point(439, 237);
            logintextBox.Name = "logintextBox";
            logintextBox.PlaceholderText = "Nazwa użytkownika";
            logintextBox.Size = new Size(343, 47);
            logintextBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(439, 311);
            password_textBox.Name = "password_textBox";
            password_textBox.PlaceholderText = "Hasło";
            password_textBox.Size = new Size(343, 47);
            password_textBox.TabIndex = 2;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1117, 476);
            label1.Name = "label1";
            label1.Size = new Size(79, 41);
            label1.TabIndex = 4;
            label1.Text = "v 1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 526);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(password_textBox);
            Controls.Add(logintextBox);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASKI MAGAZYN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        public TextBox logintextBox;
        public TextBox password_textBox;
    }
}

