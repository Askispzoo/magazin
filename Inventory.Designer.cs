namespace magazin
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(682, 283);
            button1.TabIndex = 0;
            button1.Text = "Środki trwałe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(700, 12);
            button2.Name = "button2";
            button2.Size = new Size(682, 283);
            button2.TabIndex = 1;
            button2.Text = "Skrzynki pracownicze";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 301);
            button3.Name = "button3";
            button3.Size = new Size(682, 283);
            button3.TabIndex = 2;
            button3.Text = "Certyfikacje oraz legalizacje";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 992);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inwentaryzacja";
            Load += Inventory_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}