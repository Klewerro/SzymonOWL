using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzymonOWL.classes
{
    class Wykladowca
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string wydzial { get; set; }
        public int wykladowca_id { get; set; }

        public Wykladowca(string imie, string nazwisko, string wydzial, int wykladowca_id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wydzial = wydzial;
            this.wykladowca_id = wykladowca_id;
        }
    }
}
