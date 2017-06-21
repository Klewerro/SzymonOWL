using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzymonOWL.classes
{
    class Student
    {
        public string student_id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string wydzial { get; set; }
        

        public Student(string student_id)
        {
            this.student_id = student_id;
        }

        public Student(string student_id, string imie, string nazwisko, string wydzial)
        {
            this.student_id = student_id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wydzial = wydzial;
        }

    }

    
}
