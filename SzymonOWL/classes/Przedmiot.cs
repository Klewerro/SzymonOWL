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
        public string rok { get; set; }
        public string wydzial { get; set; }
        public string przedmiot_id { get; set; }

        public List<string> studiowana_przez { get; set; }
        public string uczona_przez {get; set;}

        public Przedmiot(string przedmiot_id)
        {
            this.przedmiot_id = przedmiot_id;
        }

        public Przedmiot(string nazwa, string semestr, string rok, string wydzial, string uczona_przez, List<string> studiowana_przez)
        {
            this.nazwa = nazwa;
            this.semestr = semestr;
            this.rok = rok;
            this.wydzial = wydzial;
            this.uczona_przez = uczona_przez;
            this.studiowana_przez = studiowana_przez;
        }

       
    }
}
