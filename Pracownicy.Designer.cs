namespace magazin
{
    partial class Pracownicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pracownicy));
            groupBox1 = new GroupBox();
            label4 = new Label();
            treeView1 = new TreeView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(treeView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(1445, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 763);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Właściwości";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 280);
            label4.Name = "label4";
            label4.Size = new Size(164, 41);
            label4.TabIndex = 5;
            label4.Text = "Powiązania";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(19, 322);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(302, 242);
            treeView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 168);
            label3.Name = "label3";
            label3.Size = new Size(196, 41);
            label3.TabIndex = 3;
            label3.Text = "Adam Nowak";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(249, 41);
            label2.TabIndex = 2;
            label2.Text = "Dane personalne:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 111);
            label1.Name = "label1";
            label1.Size = new Size(226, 41);
            label1.TabIndex = 1;
            label1.Text = "Imię i nazwisko:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 45);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Pracuje";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 56);
            button1.Name = "button1";
            button1.Size = new Size(220, 70);
            button1.TabIndex = 2;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(250, 56);
            button2.Name = "button2";
            button2.Size = new Size(210, 70);
            button2.TabIndex = 3;
            button2.Text = "Usuń";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(479, 56);
            button3.Name = "button3";
            button3.Size = new Size(216, 70);
            button3.TabIndex = 4;
            button3.Text = "Edytuj";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(845, 79);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Wyszukaj...";
            textBox1.Size = new Size(563, 47);
            textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new Size(1396, 820);
            dataGridView1.TabIndex = 6;
            // 
            // Pracownicy
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 992);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Pracownicy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pracownicy";
            Load += Pracownicy_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private TreeView treeView1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}