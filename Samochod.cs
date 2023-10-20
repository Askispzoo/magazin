using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin
{
    internal class Samochod
    {
        public int ID_Samochodu { get; set; }

        public string Model { get; set; }

        public string Marka { get; set; }

        public string Numer_Rejestracyjny { get; set; }

        public int Pojemnosc_Silnika { get; set; }

        public int Dni_Do_Przegladu { get; set; }

    }
}
