namespace magazin
{
    partial class Samochody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Samochody));
            sfScrollFrame1 = new Syncfusion.WinForms.Controls.SfScrollFrame();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).BeginInit();
            tabControlAdv1.SuspendLayout();
            tabPageAdv1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 25);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(238, 25);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 2;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(455, 25);
            button3.Name = "button3";
            button3.Size = new Size(188, 58);
            button3.TabIndex = 3;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabControlAdv1
            // 
            tabControlAdv1.BeforeTouchSize = new Size(1704, 799);
            tabControlAdv1.Controls.Add(tabPageAdv1);
            tabControlAdv1.Controls.Add(tabPageAdv2);
            tabControlAdv1.Controls.Add(tabPageAdv3);
            tabControlAdv1.Location = new Point(21, 103);
            tabControlAdv1.Name = "tabControlAdv1";
            tabControlAdv1.Size = new Size(1704, 799);
            tabControlAdv1.TabIndex = 4;
            tabControlAdv1.SelectedIndexChanged += tabControlAdv1_SelectedIndexChanged;
            // 
            // tabPageAdv1
            // 
            tabPageAdv1.Controls.Add(button7);
            tabPageAdv1.Controls.Add(button6);
            tabPageAdv1.Controls.Add(button5);
            tabPageAdv1.Controls.Add(button4);
            tabPageAdv1.Image = null;
            tabPageAdv1.ImageSize = new Size(40, 40);
            tabPageAdv1.Location = new Point(1, 56);
            tabPageAdv1.Name = "tabPageAdv1";
            tabPageAdv1.ShowCloseButton = true;
            tabPageAdv1.Size = new Size(1701, 741);
            tabPageAdv1.TabIndex = 1;
            tabPageAdv1.Text = "Osobowe";
            tabPageAdv1.ThemesEnabled = false;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(15, 223);
            button7.Name = "button7";
            button7.Size = new Size(457, 193);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(952, 15);
            button6.Name = "button6";
            button6.Size = new Size(448, 193);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(487, 15);
            button5.Name = "button5";
            button5.Size = new Size(448, 193);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(15, 15);
            button4.Name = "button4";
            button4.Size = new Size(457, 193);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            // 
            // tabPageAdv2
            // 
            tabPageAdv2.Image = null;
            tabPageAdv2.ImageSize = new Size(40, 40);
            tabPageAdv2.Location = new Point(1, 56);
            tabPageAdv2.Name = "tabPageAdv2";
            tabPageAdv2.ShowCloseButton = true;
            tabPageAdv2.Size = new Size(1701, 741);
            tabPageAdv2.TabIndex = 2;
            tabPageAdv2.Text = "Małe dostawcze";
            tabPageAdv2.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            tabPageAdv3.Image = null;
            tabPageAdv3.ImageSize = new Size(40, 40);
            tabPageAdv3.Location = new Point(1, 56);
            tabPageAdv3.Name = "tabPageAdv3";
            tabPageAdv3.ShowCloseButton = true;
            tabPageAdv3.Size = new Size(1701, 741);
            tabPageAdv3.TabIndex = 3;
            tabPageAdv3.Text = "Dostawcze";
            tabPageAdv3.ThemesEnabled = false;
            // 
            // Samochody
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1737, 914);
            Controls.Add(tabControlAdv1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Samochody";
            Text = "Samochody";
            Load += Samochody_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).EndInit();
            tabControlAdv1.ResumeLayout(false);
            tabPageAdv1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button6;
    }
}