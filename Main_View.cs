﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazin
{
    public partial class Main_View : Form
    {
        public Main_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form pracownicy_view = new Pracownicy();
            pracownicy_view.Show();
        }
    }
}
