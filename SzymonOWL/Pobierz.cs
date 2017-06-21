using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SzymonOWL
{
    class Pobierz
    {
        
        public List<classes.Student> studenciStacjonarni = new List<classes.Student>();
        public List<classes.Student> studenciNiestacjonarni = new List<classes.Student>();
        public List<classes.Student> studenciITS = new List<classes.Student>();
        public List<classes.Wykladowca> wykladowcy = new List<classes.Wykladowca>();
        public List<classes.Przedmiot> wyklady = new List<classes.Przedmiot>();
        public List<classes.Przedmiot> cwiczenia = new List<classes.Przedmiot>();

        public void studentow()
        {
            XDocument doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")//tworzenie nowych obiektów i nadawanie im id 
                {
                    //Stacjonarni
                    if (element.FirstNode.ToString().Contains("Stacjonarny"))
                    {
                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);


                        studenciStacjonarni.Add(new classes.Student(substrings[1]));
                    }
                    //Niestacjonarni
                    if (element.FirstNode.ToString().Contains("Niestacjonarny"))//Routery)

                    {
                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);


                        studenciNiestacjonarni.Add(new classes.Student(substrings[1]));
                    }
                    //ITS
                    if (element.FirstNode.ToString().Contains("ITS"))//Routery)
                    {
                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);


                        studenciITS.Add(new classes.Student(substrings[1]));
                    }

                } //koniec classAssertion



                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion") //nadawanie wartośći obiektom po id
                {

                    if (element.FirstNode.NextNode.ToString().Contains("Student"))//dla przystanków
                    {

                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);
                        for (int i = 0; i < studenciStacjonarni.Count; i++)
                        {
                            if (element.FirstNode.NextNode.ToString().Contains(studenciStacjonarni[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {

                                if (element.FirstNode.ToString().Contains("imie"))
                                    studenciStacjonarni[i].imie = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(studenciStacjonarni[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("nazwisko"))
                                    studenciStacjonarni[i].nazwisko = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(studenciStacjonarni[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("wydział"))
                                    studenciStacjonarni[i].wydzial = element.Value;
                                //studenciStacjonarni[i].rodzaj = "Stacjonarny";
                            }
                            
                        }

                    }

                }

                //Niestacjonarni
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion") //nadawanie wartośći obiektom po id
                {

                    if (element.FirstNode.NextNode.ToString().Contains("Student"))//dla przystanków
                    {

                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);
                        for (int i = 0; i < studenciNiestacjonarni.Count; i++)
                        {
                            if (element.FirstNode.NextNode.ToString().Contains(studenciNiestacjonarni[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {

                                if (element.FirstNode.ToString().Contains("imie"))
                                    studenciNiestacjonarni[i].imie = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(studenciNiestacjonarni[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("nazwisko"))
                                    studenciNiestacjonarni[i].nazwisko = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(studenciNiestacjonarni[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("wydział"))
                                    studenciNiestacjonarni[i].wydzial = element.Value;
                                //studenciStacjonarni[i].rodzaj = "Niestacjonarny";

                            }

                        }

                    }

                }

                //ITS
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion") //nadawanie wartośći obiektom po id
                {

                    if (element.FirstNode.NextNode.ToString().Contains("Student"))//dla przystanków
                    {

                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);
                        for (int i = 0; i < studenciITS.Count; i++)
                        {
                            if (element.FirstNode.NextNode.ToString().Contains(studenciITS[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {

                                if (element.FirstNode.ToString().Contains("imie"))
                                    studenciITS[i].imie = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(studenciITS[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("nazwisko"))
                                    studenciITS[i].nazwisko = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(studenciITS[i].student_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("wydział"))
                                    studenciITS[i].wydzial = element.Value;
                                //studenciStacjonarni[i].rodzaj = "ITS";

                            }

                        }

                    }

                }

            }//KONIEC DUZEJ PETLI


            
        }   //koniec metody dodawania studentow do list



        public void wykladowcow()
        {
            XDocument doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")//tworzenie nowych obiektów i nadawanie im id 
                {
                    //Stacjonarni
                    if (element.FirstNode.ToString().Contains("Wykładowca"))//Routery)
                    {
                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);


                        wykladowcy.Add(new classes.Wykladowca(substrings[1]));
                    }
                } //koniec classAssertion


                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion") //nadawanie wartośći obiektom po id
                {

                    if (element.FirstNode.NextNode.ToString().Contains("Wykładowca"))//dla przystanków
                    {

                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);
                        for (int i = 0; i < wykladowcy.Count; i++)
                        {
                            if (element.FirstNode.NextNode.ToString().Contains(wykladowcy[i].wykladowca_id))//sprawdzanie czy to linijka z dobrym id
                            {

                                if (element.FirstNode.ToString().Contains("imie"))
                                    wykladowcy[i].imie = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(wykladowcy[i].wykladowca_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("nazwisko"))
                                    wykladowcy[i].nazwisko = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(wykladowcy[i].wykladowca_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("wydział"))
                                    wykladowcy[i].wydzial = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(wykladowcy[i].wykladowca_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("st_naukowy"))
                                    wykladowcy[i].st_naukowy = element.Value;

                            }

                        }

                    }

                }


            }


        }   //koniec metody dodajacej wykładowców

        public void pobierzWyklady()
        {
            XDocument doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")//tworzenie nowych obiektów i nadawanie im id 
                {
                    //Stacjonarni
                    if (element.FirstNode.ToString().Contains("Wykład") && !element.FirstNode.NextNode.ToString().Contains("Wykładowca") )//Routery)
                    {
                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);


                        wyklady.Add(new classes.Przedmiot(substrings[1]));
                    }
                } //koniec classAssertion


                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion") //nadawanie wartośći obiektom po id
                {

                    if (element.FirstNode.NextNode.ToString().Contains("Wykład") && !element.FirstNode.NextNode.ToString().Contains("Wykładowca"))
                    {

                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);
                        for (int i = 0; i < wyklady.Count; i++)
                        {
                            if (element.FirstNode.NextNode.ToString().Contains(wyklady[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {

                                if (element.FirstNode.ToString().Contains("przedmiot_nazwa"))
                                    wyklady[i].nazwa = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(wyklady[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("przedmiot_rok"))
                                    wyklady[i].rok = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(wyklady[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("przedmiot_semestr"))
                                    wyklady[i].semestr = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(wyklady[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("przedmiot_wydział"))
                                    wyklady[i].wydzial = element.Value;

                            }

                        }

                    }

                }


            }


        }

        public void pobierzCwiczenia()
        {
            XDocument doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")//tworzenie nowych obiektów i nadawanie im id 
                {
                    //Stacjonarni
                    if (element.FirstNode.ToString().Contains("Ćwiczenia"))//Routery)
                    {
                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);


                        cwiczenia.Add(new classes.Przedmiot(substrings[1]));
                    }
                } //koniec classAssertion

                // if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion" ) //nadawanie wartośći obiektom po id
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion" || element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ObjectPropertyAssertion") //nadawanie wartośći obiektom po id
                {

                    if (element.FirstNode.NextNode.ToString().Contains("Ćwiczenia"))//dla przystanków
                    {

                        String text = element.FirstNode.NextNode.ToString();

                        String[] substrings = text.Split('"');
                        substrings[1] = substrings[1].Remove(0, 1);
                        for (int i = 0; i < cwiczenia.Count; i++)
                        {
                            if (element.FirstNode.NextNode.ToString().Contains(cwiczenia[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {

                                if (element.FirstNode.ToString().Contains("przedmiot_nazwa"))
                                    cwiczenia[i].nazwa = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(cwiczenia[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("przedmiot_rok"))
                                    cwiczenia[i].rok = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(cwiczenia[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("przedmiot_semestr"))
                                    cwiczenia[i].semestr = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(cwiczenia[i].przedmiot_id))//sprawdzanie czy to linijka z dobrym id
                            {
                                if (element.FirstNode.ToString().Contains("przedmiot_wydział"))
                                    cwiczenia[i].wydzial = element.Value;

                            }
                            if (element.FirstNode.NextNode.ToString().Contains(cwiczenia[i].przedmiot_id))
                            {
                                if (element.FirstNode.ToString().Contains("uczona_przez"))
                                {
                                    Console.WriteLine(cwiczenia[i].uczona_przez);
                                    
                                }
                            }

                        }

                    }

                }
               


            }


        }   //koniec Przedmiotow

        public void wykladowceDoWykladu(string s1, string s2)
        {
            XDocument doc = XDocument.Load("Test.owl");

            String id_wykladowcy = wykladowcy.Find(x => x.wykladowca_id == s2.ToString()).wykladowca_id;

            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ObjectPropertyAssertion")
                {

                    for (int i = 0; i < wyklady.Count; i++)
                    {
                        if (element.FirstNode.NextNode.ToString().Contains(id_wykladowcy))//sprawdzanie czy to linijka z dobrym id
                        {

                            if (element.FirstNode.ToString().Contains("uczona_przez"))
                                Console.WriteLine(element.FirstNode.ToString());
                                //wyklady[i].uczona_przez = element.Value;

                        }
                    }
                }
            }
        }
       


        public void czyscPobierz()
        {
            studenciITS.Clear();
            studenciStacjonarni.Clear();
            studenciNiestacjonarni.Clear();
            wykladowcy.Clear();
            wyklady.Clear();
            cwiczenia.Clear();

            studentow();
            wykladowcow();
            pobierzWyklady();
            pobierzCwiczenia();
            
        }




        public void printStudenci()
        {
            Console.WriteLine("Studenci stacjonarni");
            foreach (var s in studenciStacjonarni)
            {
                Console.WriteLine("\t" + s.student_id + " " + s.imie + " " + s.nazwisko + " " + s.wydzial);
            }
            Console.WriteLine("Studenci niestacjonarni");
            foreach (var s in studenciNiestacjonarni)
            {
                Console.WriteLine("\t" + s.student_id + " " + s.imie + " " + s.nazwisko + " " + s.wydzial);
            }
            Console.WriteLine("Studenci ITS");
            foreach (var s in studenciITS)
            {
                Console.WriteLine("\t" + s.student_id + " " + s.imie + " " + s.nazwisko + " " + s.wydzial);
            }
        }

        public void printWykladowcy()
        {
            Console.WriteLine("Wykładowcy");
            foreach (var w in wykladowcy)
            {
                Console.WriteLine("\t" + w.wykladowca_id + " " + w.imie + " " + w.nazwisko + " " + w.wydzial + " " + w.st_naukowy);
            }
        }
    }
}
