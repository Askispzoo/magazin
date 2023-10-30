using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin
{
    internal class Pracownik
    {
        [Key]
        public int ID_Pracownika
        {
            get; set;
        }

        public required string Imie_Pracownika
        {
            get; set;
        }

        public required string Nazwisko_Pracownika
        {
            get; set;
        }

        public required string Stanowisko_Pracownika
        {
            get; set;
        }
    }
}
