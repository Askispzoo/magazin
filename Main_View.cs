using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form sprzet_view = new Sprzet();
            sprzet_view.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ustawienia_view = new Ustawienia();
            ustawienia_view.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form samochody_view = new Samochody();
            samochody_view.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form inventory_view = new Inventory();
            inventory_view.Show();
        }
    }
}
