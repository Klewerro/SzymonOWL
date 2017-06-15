using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzymonOWL.classes
{
    class Przedmiot
    {
        public string nazwa { get; set; }
        public string semestr { get; set; }
        public int rok { get; set; }
        public string wykladana_przez { get; set; }
        public List<string> studiowana_przez { get; set; }

        public Przedmiot(string nazwa, string semestr, int rok, string wykladana_przez, List<string> studiowana_przez)
        {
            this.nazwa = nazwa;
            this.semestr = semestr;
            this.rok = rok;
            this.wykladana_przez = wykladana_przez;
            this.studiowana_przez = studiowana_przez;
        }
    }
}
