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
        public string wykladowca_id { get; set; }
        public string st_naukowy { get; set; }

        public Wykladowca(string wykladowca_id)
        {
            this.wykladowca_id = wykladowca_id;
        } 

        public Wykladowca(string imie, string nazwisko, string wydzial, string wykladowca_id, string st_naukowy)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wydzial = wydzial;
            this.wykladowca_id = wykladowca_id;
            this.st_naukowy = st_naukowy;
        }
    }
}
