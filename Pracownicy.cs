using System;
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
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

        public object Pracownik { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Form pracownicy_add_view = new Pracownicy_Add();
            pracownicy_add_view.Show();
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            using (var context = new Magazin())
            {
                context.Database.EnsureCreated();
                var pracownicy = new List<Pracownik>
            {
                new Pracownik { Imie_Pracownika="Kacper", Nazwisko_Pracownika="Dudkowski", Stanowisko_Pracownika = "Specjalista systemów komputerowych"},
                new Pracownik { Imie_Pracownika="Piotr", Nazwisko_Pracownika="Radka", Stanowisko_Pracownika = "Prezes zarządu"},
                new Pracownik { Imie_Pracownika="Natalia", Nazwisko_Pracownika="Radka", Stanowisko_Pracownika = "Wiceprezes zarządu"},
                new Pracownik { Imie_Pracownika="Mariusz", Nazwisko_Pracownika="Radka", Stanowisko_Pracownika = "Wiceprezes zarządu"},
                new Pracownik { Imie_Pracownika="Ireneusz", Nazwisko_Pracownika="Marczak", Stanowisko_Pracownika = "Elektromonter"},
            };

                context.Pracownicy.AddRange((IEnumerable<Pracownicy>)pracownicy);
                context.SaveChanges();

                dataGridView1.DataSource = pracownicy;
            }
        }

        private void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
