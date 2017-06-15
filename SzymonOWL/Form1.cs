using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzymonOWL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDodaj form = new FormDodaj();
            form.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Parser p = new Parser();
            //p.dodajStudenta(3, "Grzegorz", "Brzęczyszczykiewicz", "Stacjonarny", "Matematyczno-przyrodniczy");
            //p.dodajWykladowce(2, "Zbigniew", "Materna", "magister, inżynier", "Chemiczny");
            //p.dodajPrzedmiot(1, "Bazy_danych", "Matematyczno-przyrodniczy", 2017, "letni", "Wykład");
            //p.dodajStudentaDoPrzedmiotu("Student_1", "Analiza_matematyczna_1");
            p.dodajWykladowceDoPrzedmiotu("Wykładowca_1", "Bazy_danych_1");
            //p.liczniki();
            //p.liczniki("student");
        }
    }
}
