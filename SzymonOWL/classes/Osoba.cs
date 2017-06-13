using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzymonOWL.classes
{
    class Osoba
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string wydzial { get; set; }

        public Osoba(string imie, string nazwisko, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wydzial = wydzial;
        }
    }
}
