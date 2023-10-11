using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.Windows.Forms;

namespace magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logintextBox.Text == "aski" && password_textBox.Text == "Aski2023!")
            {
                Form main_view = new Main_View();
                main_view.Show();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania!", "Błąd!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



            }
            Form logowanie = new Form1();
            logowanie.Visible = false;
        }
    }
}
