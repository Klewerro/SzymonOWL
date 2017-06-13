using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzymonOWL.classes
{
    class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string wydzial { get; set; }
        public int student_id { get; set; }

        public Student(string imie, string nazwisko, string wydzial, int student_id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wydzial = wydzial;
            this.student_id = student_id;
        }
    }
}
