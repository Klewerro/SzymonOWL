using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SzymonOWL
{
    class Parser
    {
        int licznikStudent = 0;
        int licznikWykladowca = 0;
        int licznikPrzedmiot = 0;


        public void dodajStudenta(int id, string imie, string nazwisko, string rodzaj, string wydzial)
        {
            liczniki();
            liczniki("student");
            XDocument xml = XDocument.Load("Test.owl");

            //powiazanie z klasa
            xml.Root.Add(
                new XComment("Dodanie nowego studenta"),
                new XElement("ClassAssertion",
                new XElement("Class", new XAttribute("IRI", "#" + rodzaj)),
                new XElement("NamedIndividual", new XAttribute("IRI", "#Student_" + id))
                ),
                //student_id
                new XElement("DataPropertyAssertion",
                new XElement("DataProperty", new XAttribute("IRI", "#student_id")),
                new XElement("NamedIndividual", new XAttribute("IRI", "#Student_" + id)),
                new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#integer"), id)
                ),
                //imie
                new XElement("DataPropertyAssertion",
                new XElement("DataProperty", new XAttribute("IRI", "#imie")),
                new XElement("NamedIndividual", new XAttribute("IRI", "#Student_" + id)),
                new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), imie)
                ),
                //nazwisko
                new XElement("DataPropertyAssertion",
                new XElement("DataProperty", new XAttribute("IRI", "#nazwisko")),
                new XElement("NamedIndividual", new XAttribute("IRI", "#Student_" + id)),
                new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), nazwisko)
                ), 
                //wydzial 
                new XElement("DataPropertyAssertion",
                new XElement("DataProperty", new XAttribute("IRI", "#wydział")),
                new XElement("NamedIndividual", new XAttribute("IRI", "#Student_" + id)),
                new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), wydzial)
                )
            );
            xml.Save("Test.owl");
            pirate("Test.owl");
        }

        public void dodajWykladowce(int id, string imie, string nazwisko, string st_naukowy, string wydzial)
        {
            liczniki();
            liczniki("wykladowca");
            XDocument xml = XDocument.Load("Test.owl");

            //powiazanie z klasa
            xml.Root.Add(
                new XComment("Dodanie nowego wykladowcy"),
                    new XElement("ClassAssertion",
                    new XElement("Class", new XAttribute("IRI", "#Wykładowca")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#Wykładowca_" + id))
                ),
                //wykladowca_id
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#wykładowca_id")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#Wykładowca_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#integer"), id)
                ),
                //imie
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#imie")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#Wykładowca_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), imie)
                ),
                //nazwisko
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#nazwisko")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#Wykładowca_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), nazwisko)
                ),
                //wydzial 
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#wydział")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#Wykładowca_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), wydzial)
                ),
                //st. naukowy
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#st_naukowy")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#Wykładowca_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#string"), st_naukowy)
                )
            );
            xml.Save("Test.owl");
            pirate("Test.owl");
        }

        public void dodajPrzedmiot(int id, string nazwa, string wydzial, int rok, string semestr, string rodzaj_zajec)
        {
            liczniki();
            liczniki("przedmiot");
            XDocument xml = XDocument.Load("moja_ontologia.owl");

            //powiazanie z klasa
            xml.Root.Add(
                new XComment("Dodanie nowego przedmiotu"),
                new XElement("Declaration",
                    new XElement("NamedIndividual", new XAttribute("IRI", "#" + nazwa + "_" + id))
                ),

                new XElement("ClassAssertion",
                    new XElement("Class", new XAttribute("IRI", "#" + rodzaj_zajec)),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#" + nazwa +"_" + id))
                ),

                //new XElement("ClassAssertion",
                //new XElement("Class", new XAttribute("IRI", "#" + nazwa)),
                //new XElement("NamedIndividual", new XAttribute("IRI", "#"+nazwa+"_" + id))
                //),

                //nazwa
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#przedmiot_nazwa")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#" + nazwa + "_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#integer"), nazwa.Replace("_", " "))
                ),
                //rok
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#przedmiot_rok")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#"+nazwa+"_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#integer"), rok)
                ),
                //semestr
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#przedmiot_semestr")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#" + nazwa + "_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#integer"), semestr)
                ),
                //wydzial
                new XElement("DataPropertyAssertion",
                    new XElement("DataProperty", new XAttribute("IRI", "#wydział")),
                    new XElement("NamedIndividual", new XAttribute("IRI", "#" + nazwa + "_" + id)),
                    new XElement("Literal", new XAttribute("datatypeIRI", "http://www.w3.org/2001/XMLSchema#integer"), wydzial)
                )

            );
            xml.Save("Test.owl");
            pirate("Test.owl");
        }

        public void dodajStudentaDoPrzedmiotu(string student, string przedmiot)
        {
            XDocument xml = XDocument.Load("Test.owl");

            //powiazanie z klasa
            xml.Root.Add(
                new XComment("Dodanie studenta "+ student + "do przedmiotu " + przedmiot),
                //studiowana przez
                new XElement("ObjectPropertyAssertion", 
                    new XElement("ObjectProperty", new XAttribute("IRI", "#studiowana_przez")),
                    new XElement("NamedIndividual", new XAttribute("IRI", przedmiot)),
                    new XElement("NamedIndividual", new XAttribute("IRI", student))
                ),
                //studiuje
                new XElement("ObjectPropertyAssertion",
                    new XElement("ObjectProperty", new XAttribute("IRI", "#studiuje")),
                    new XElement("NamedIndividual", new XAttribute("IRI", student)),
                    new XElement("NamedIndividual", new XAttribute("IRI", przedmiot))
                )  
            );
            xml.Save("Test.owl");
            pirate("Test.owl");
        }

        public void dodajWykladowceDoPrzedmiotu(string wykladowca, string przedmiot)
        {
            XDocument xml = XDocument.Load("Test.owl");

            //powiazanie z klasa
            xml.Root.Add(
                new XComment("Dodanie wykladowcy " + wykladowca + " do przedmiotu " + przedmiot),
                //uczona przez
                new XElement("ObjectPropertyAssertion",
                    new XElement("ObjectProperty", new XAttribute("IRI", "#uczona_przez")),
                    new XElement("NamedIndividual", new XAttribute("IRI", przedmiot)),
                    new XElement("NamedIndividual", new XAttribute("IRI", wykladowca))
                ),
                //uczy
                new XElement("ObjectPropertyAssertion",
                    new XElement("ObjectProperty", new XAttribute("IRI", "#uczy")),
                    new XElement("NamedIndividual", new XAttribute("IRI", wykladowca)),
                    new XElement("NamedIndividual", new XAttribute("IRI", przedmiot))
                )
            );
            xml.Save("Test.owl");
            pirate("Test.owl");
        }



        
        public void pirate(string file) //usuwanie atrybutow xmlns
        {
            XDocument doc = XDocument.Load(file);
            // All elements with an empty namespace...
            foreach (var node in doc.Root.Descendants()
                                    .Where(n => n.Name.NamespaceName == ""))
            {

                node.Attributes("xmlns").Remove();
                node.Name = node.Parent.Name.Namespace + node.Name.LocalName;
            }
            //Console.WriteLine(doc);
            doc.Save(file);
        }


        public void liczniki()
        {
            XDocument xml = XDocument.Load("liczniki.xml");
            licznikStudent = int.Parse(xml.Root.Element("student").Value);
            licznikWykladowca = int.Parse(xml.Root.Element("wykladowca").Value);
            licznikPrzedmiot = int.Parse(xml.Root.Element("przedmiot").Value);
        }

        public void liczniki(string nazwa)
        {
            XDocument xml = XDocument.Load("liczniki.xml");

            if(nazwa.Equals("student"))
                xml.Element("liczniki").Element("student").SetValue(licznikStudent + 1);
            if (nazwa.Equals("wykladowca"))
                xml.Element("liczniki").Element("wykladowca").SetValue(licznikWykladowca + 1);
            if (nazwa.Equals("przedmiot"))
                xml.Element("liczniki").Element("przedmiot").SetValue(licznikPrzedmiot + 1);

            xml.Save("liczniki.xml");
        }

        public void licznikiSet(int studenci, int wykladowcy, int przedmioty)
        {
            XDocument xml = XDocument.Load("liczniki.xml");

            xml.Element("liczniki").Element("student").SetValue(studenci);
            xml.Element("liczniki").Element("wykladowca").SetValue(wykladowcy);
            xml.Element("liczniki").Element("przedmiot").SetValue(przedmioty);

            xml.Save("liczniki.xml");
        }

        
        

    }


}
