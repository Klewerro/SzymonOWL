using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SzymonOWL
{
    public partial class Form2 : Form
    {
        XDocument doc;
        Pobierz pobierz = new Pobierz();
        

        public Form2()
        {
            string[] wydzialy = { "Matematyczno-przyrodniczy", "Chemiczny", "Zarządzania"};

            InitializeComponent();
            pobierz.studentow();
            pobierz.wykladowcow();
            pobierz.pobierzCwiczenia();
            pobierz.pobierzWyklady();

            comboBox_rodzajStudenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_rodzajStudenta.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wydzial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wydzial.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wydzial.Items.AddRange(wydzialy);
            comboBox_wWydzial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wWydzial.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wWydzial.Items.AddRange(wydzialy);
            //checkedListBox_wStopnie.Items.Add("Inżynier");
            //checkedListBox_wStopnie.Items.Add("Magister");
            //checkedListBox_wStopnie.Items.Add("Doktor");
            //checkedListBox_wStopnie.Items.Add("Profesor");
            comboBox_wydzialWykladu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wydzialWykladu.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wydzialWykladu.Items.AddRange(wydzialy);
            comboBox_wydzialWykladu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wydzialWykladu.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wydzialWykladu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wydzialWykladu.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_rokWykladu.Items.Add(2015);
            comboBox_rokWykladu.Items.Add(2016);
            comboBox_rokWykladu.Items.Add(2017);
            comboBox_rokWykladu.Items.Add(2018);
            comboBox_rokWykladu.Items.Add(2019);
            comboBox_rokWykladu.Items.Add(2020);
            comboBox_semestrWykladu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_semestrWykladu.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_semestrWykladu.Items.Add("Letni");
            comboBox_semestrWykladu.Items.Add("Zimowy");
            comboBox_wydzialCwiczen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wydzialCwiczen.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wydzialCwiczen.Items.AddRange(wydzialy);
            comboBox_wydzialCwiczen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wydzialCwiczen.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_rokCwiczen.Items.Add(2015);
            comboBox_rokCwiczen.Items.Add(2016);
            comboBox_rokCwiczen.Items.Add(2017);
            comboBox_rokCwiczen.Items.Add(2018);
            comboBox_rokCwiczen.Items.Add(2019);
            comboBox_rokCwiczen.Items.Add(2020);
            comboBox_semestrCwiczen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_semestrCwiczen.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_semestrCwiczen.Items.Add("Letni");
            comboBox_semestrCwiczen.Items.Add("Zimowy");
            foreach (var item in pobierz.wykladowcy)
            {
                comboBox_prowadzacyCwiczen.Items.Add(item.wykladowca_id);
                comboBox_prowadzacyWykladu.Items.Add(item.wykladowca_id);
            }

            //comboBox_studentWykladW.Text = "Wybierz zajęcia";
            comboBox_studentStudentW.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_studentWykladW.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_studentStudentW.Sorted = true;
            foreach (var item in pobierz.studenciStacjonarni)
            {
                comboBox_studentStudentW.Items.Add(item.student_id);
                comboBox_studentStudentC.Items.Add(item.student_id);
                comboBox_studentDelZPrzedmiotow.Items.Add(item.student_id);
            }
            foreach (var item in pobierz.studenciNiestacjonarni)
            {
                comboBox_studentStudentW.Items.Add(item.student_id);
                comboBox_studentStudentC.Items.Add(item.student_id);
                comboBox_studentDelZPrzedmiotow.Items.Add(item.student_id);
            }
            foreach (var item in pobierz.studenciITS)
            {
                comboBox_studentStudentW.Items.Add(item.student_id);
                comboBox_studentStudentC.Items.Add(item.student_id);
                comboBox_studentDelZPrzedmiotow.Items.Add(item.student_id);
            }
            foreach (var item in pobierz.wyklady)
            {
                comboBox_studentWykladW.Items.Add(item.przedmiot_id); 
            }
            foreach (var item in pobierz.cwiczenia)
            {
                comboBox_studentCwiczeniaC.Items.Add(item.przedmiot_id);
            }


            ladujTabeleStudentow();
            ladujTabeleWykladowcow();
            ladujTabelePrzedmiotow();


        }


        private void button_dodaj_Click(object sender, EventArgs e)
        {


            if (textBox_imie.Text == "" || textBox_nazwisko.Text == "" || comboBox_rodzajStudenta.SelectedItem == null || comboBox_wydzial.SelectedItem == null)
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól", "Błąd");
            }
            else
            {
                Dodaj dodaj = new Dodaj();
                dodaj.studenta(textBox_imie.Text, textBox_nazwisko.Text, comboBox_rodzajStudenta.Text, comboBox_wydzial.Text);
                pobierz.czyscPobierz(); //wyczyszczenie list, tabeli i dodanie
                ladujTabeleStudentow();

                //wyczyszczenie pól
                textBox_imie.Text = "";
                textBox_nazwisko.Text = "";
                comboBox_rodzajStudenta.SelectedItem = null;
                comboBox_wydzial.SelectedItem = null;

                new Form2();
            }
        }



        private void ladujTabeleStudentow()
        {
            listViewStacjonarni.Items.Clear();
            listViewNiestacjonarni.Items.Clear();
            listViewITS.Items.Clear();

            foreach (var item in pobierz.studenciStacjonarni)
            {
                ListViewItem lvi = new ListViewItem(item.student_id);
                lvi.SubItems.Add(item.imie);
                lvi.SubItems.Add(item.nazwisko);
                lvi.SubItems.Add(item.wydzial);

                listViewStacjonarni.Items.Add(lvi);
                
            }


            foreach (var item in pobierz.studenciNiestacjonarni)
            {
                ListViewItem lvi = new ListViewItem(item.student_id);
                lvi.SubItems.Add(item.imie);
                lvi.SubItems.Add(item.nazwisko);
                lvi.SubItems.Add(item.wydzial);

                listViewNiestacjonarni.Items.Add(lvi);
            }


            foreach (var item in pobierz.studenciITS)
            {
                ListViewItem lvi = new ListViewItem(item.student_id);
                lvi.SubItems.Add(item.imie);
                lvi.SubItems.Add(item.nazwisko);
                lvi.SubItems.Add(item.wydzial);

                listViewITS.Items.Add(lvi);
            }
        }

        void ladujTabeleWykladowcow()
        {
            listViewWykladowcy.Items.Clear();

            foreach (var item in pobierz.wykladowcy)
            {
                ListViewItem lvi = new ListViewItem(item.wykladowca_id);
                lvi.SubItems.Add(item.imie);
                lvi.SubItems.Add(item.nazwisko);
                lvi.SubItems.Add(item.wydzial);
                lvi.SubItems.Add(item.st_naukowy);

                listViewWykladowcy.Items.Add(lvi);

            }
        }



        void ladujTabelePrzedmiotow()
        {
            listView_wyklady.Items.Clear();
            listView_cwiczenia.Items.Clear();

            foreach (var item in pobierz.wyklady)
            {
                ListViewItem lvi = new ListViewItem(item.przedmiot_id);
                lvi.SubItems.Add(item.nazwa);
                lvi.SubItems.Add(item.rok);
                lvi.SubItems.Add(item.semestr);
                lvi.SubItems.Add(item.wydzial);
                lvi.SubItems.Add(item.uczona_przez);
                //lvi.SubItems.Add(item.naTekst());

                listView_wyklady.Items.Add(lvi);
            }
            foreach (var item in pobierz.cwiczenia)
            {
                ListViewItem lvi = new ListViewItem(item.przedmiot_id);
                lvi.SubItems.Add(item.nazwa);
                lvi.SubItems.Add(item.rok);
                lvi.SubItems.Add(item.semestr);
                lvi.SubItems.Add(item.wydzial);
                lvi.SubItems.Add(item.uczona_przez);

                listView_cwiczenia.Items.Add(lvi);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in pobierz.cwiczenia)
            {
                //Console.WriteLine(item.przedmiot_id + " " + item.nazwa + " " + item.uczona_przez + " " + item.studiowana_przez);
            }

            comboBox_studentStudentC.Items.Clear();
            comboBox_studentDelZPrzedmiotow.Items.Clear();
            comboBox_studentStudentW.Items.Clear();
            comboBox_prowadzacyWykladu.Items.Clear();
            comboBox_studentWykladW.Items.Clear();
            comboBox_studentCwiczeniaC.Items.Clear();

            foreach (var item in pobierz.studenciStacjonarni)
            {
                comboBox_studentStudentC.Items.Add(item.student_id);
                comboBox_studentDelZPrzedmiotow.Items.Add(item.student_id);
                comboBox_studentStudentW.Items.Add(item.student_id);
            }
            foreach (var item in pobierz.studenciNiestacjonarni)
            {
                comboBox_studentStudentC.Items.Add(item.student_id);
                comboBox_studentDelZPrzedmiotow.Items.Add(item.student_id);
                comboBox_studentStudentW.Items.Add(item.student_id);
            }
            foreach (var item in pobierz.studenciITS)
            {
                comboBox_studentStudentC.Items.Add(item.student_id);
                comboBox_studentDelZPrzedmiotow.Items.Add(item.student_id);
                comboBox_studentStudentW.Items.Add(item.student_id);
            }
            foreach (var item in pobierz.wykladowcy)
            {
                comboBox_prowadzacyWykladu.Items.Add(item.wykladowca_id);
            }
            foreach (var item in pobierz.wyklady)
            {
                comboBox_studentWykladW.Items.Add(item.przedmiot_id);
            }
            foreach (var item in pobierz.cwiczenia)
            {
                comboBox_studentCwiczeniaC.Items.Add(item.przedmiot_id);
            }

        }


        //wykładowcy

        private void button_dodajWykladowce_Click(object sender, EventArgs e)
        {
            if (textBox_wImie.Text == "" || textBox_wNazwisko.Text == "" || comboBox_wWydzial.SelectedItem == null || textBox_st.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól", "Błąd");
            }
            else
            {
                Dodaj dodaj = new Dodaj();
                dodaj.wykladowce(textBox_wImie.Text, textBox_wNazwisko.Text, textBox_st.Text, comboBox_wWydzial.Text);
                pobierz.czyscPobierz();
                ladujTabeleWykladowcow();

                //List<string> list = new List<string>();
                //foreach (var item in checkedListBox_wStopnie.CheckedItems)
                //{
                //    list.Add(item.ToString());
                //}

                textBox_wImie.Text = "";
                textBox_wNazwisko.Text = "";
                comboBox_wWydzial.SelectedItem = null;
                textBox_st.Text = "";


            }

        }

        

        void usunDataProp(string id)    //dokonczyc
        {
            // XDocument doc = XDocument.Load("Test.owl");

            doc = XDocument.Load("Test.owl");
            string i = listViewStacjonarni.SelectedItems.ToString();
            listViewStacjonarni.Items.Remove(listViewStacjonarni.FindItemWithText(id));

            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion")
                {
                    //Console.WriteLine("dupa"  + element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.NextNode.ToString().Contains(id))
                    {



                        //element.FirstNode.NextNode.NextNode.Remove();
                        //element.FirstNode.NextNode.Remove();
                        //element.FirstNode.Remove();
                        element.RemoveNodes();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }

                }
            }

            doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")
                {
                    //Console.WriteLine(element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.NextNode.ToString().Contains(id))
                    {
                        //Console.WriteLine(element.FirstNode);
                        //element.FirstNode.NextNode.Remove();
                        //element.FirstNode.Remove();
                        element.RemoveNodes();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }

            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}Declaration")
                {
                    //Console.WriteLine(element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.ToString().Contains(id))
                    {
                        element.FirstNode.Remove();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }
        }

        void usunStudenta2()
        {
            doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")
                {
                    //Console.WriteLine(element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.NextNode.ToString().Contains("Student_2"))
                    {
                        //Console.WriteLine(element.FirstNode);
                        //element.FirstNode.NextNode.Remove();
                        //element.FirstNode.Remove();
                        element.RemoveNodes();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }
            
        }

        void usunStudenta3()
        {
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}Declaration")
                {
                    //Console.WriteLine(element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.ToString().Contains("Student_2"))
                    {
                        element.FirstNode.Remove();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }


            }
        }

        void usunWykladowce(string id)
        {
            doc = XDocument.Load("Test.owl");
            //string i = listViewStacjonarni.SelectedItems.ToString();
            //listViewStacjonarni.Items.Remove(listViewStacjonarni.FindItemWithText(id));

            //foreach (var element in doc.Root.Descendants())
            //{
            //    if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}DataPropertyAssertion")
            //    {
            //        //Console.WriteLine("dupa"  + element.FirstNode.NextNode.ToString());
            //        if (element.FirstNode.NextNode.ToString().Contains(id))
            //        {



            //            //element.FirstNode.NextNode.NextNode.Remove();
            //            //element.FirstNode.NextNode.Remove();
            //            //element.FirstNode.Remove();
            //            element.RemoveNodes();
            //            element.Remove();
            //            doc.Save("Test.owl");
            //            break;
            //        }

            //    }
            //}

            

            doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ClassAssertion")
                {
                    //Console.WriteLine(element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.NextNode.ToString().Contains(id))
                    {
                        //Console.WriteLine(element.FirstNode);
                        //element.FirstNode.NextNode.Remove();
                        //element.FirstNode.Remove();
                        element.RemoveNodes();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }

            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}Declaration")
                {
                    //Console.WriteLine(element.FirstNode.NextNode.ToString());
                    if (element.FirstNode.ToString().Contains(id))
                    {
                        element.FirstNode.Remove();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }
        }

        void removeObjectProp(string id)
        {
            doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ObjectPropertyAssertion")
                {
                    if (element.FirstNode.NextNode.NextNode.ToString().Contains(id))
                    {
                        Console.WriteLine("first.next: " + element.FirstNode.NextNode);
                        element.FirstNode.NextNode.Remove();
                        Console.WriteLine("mext: " + element.NextNode);
                        element.NextNode.Remove();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }
        }

        void removeStudentaZPrzedmiotu(string student_id)
        {
            doc = XDocument.Load("Test.owl");
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ObjectPropertyAssertion")
                {
                    Console.WriteLine("XD" + element.FirstNode.NextNode.NextNode.ToString());
                    if (element.FirstNode.NextNode.NextNode.ToString().Contains(student_id) && element.FirstNode.ToString().Contains("studiowana_przez") )
                    {
                        Console.WriteLine("first.next: " + element.FirstNode.NextNode);
                        element.FirstNode.NextNode.Remove();
                        Console.WriteLine("mext: " + element.NextNode);
                        //element.NextNode.Remove();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }

            
        }

        void removeStudentaZPrzedmiotu2(string student_id)
        {
            foreach (var element in doc.Root.Descendants())
            {
                if (element.Name.ToString() == "{http://www.w3.org/2002/07/owl#}ObjectPropertyAssertion")
                {
                    Console.WriteLine("XD" + element.FirstNode.NextNode.NextNode.ToString());
                    if (element.FirstNode.NextNode.ToString().Contains(student_id) && element.FirstNode.ToString().Contains("studiuje"))
                    {
                        Console.WriteLine("first.next: " + element.FirstNode.NextNode);
                        element.FirstNode.NextNode.Remove();
                        Console.WriteLine("mext: " + element.NextNode);
                        element.FirstNode.Remove();
                        element.Remove();
                        doc.Save("Test.owl");
                        break;
                    }
                }
            }
        }
        

        private void button_usun_Click(object sender, EventArgs e)
        {
            usunDataProp(textBox2.Text);
            usunDataProp(textBox2.Text);
            usunDataProp(textBox2.Text);
        }


        private void button_usunNiestac_Click(object sender, EventArgs e)
        {
            string i = listViewNiestacjonarni.SelectedItems.ToString();
            listViewNiestacjonarni.Items.Remove(listViewNiestacjonarni.FindItemWithText(textBox2.Text));

            usunDataProp(textBox2.Text);
            usunDataProp(textBox2.Text);
            usunDataProp(textBox2.Text);
        }

        private void button_usun_ITS_Click(object sender, EventArgs e)
        {
            string i = listViewITS.SelectedItems.ToString();
            listViewITS.Items.Remove(listViewITS.FindItemWithText(textBox2.Text));

            usunDataProp(textBox2.Text);
            usunDataProp(textBox2.Text);
            usunDataProp(textBox2.Text);

        }

        private void button_usunWykladowce_Click(object sender, EventArgs e)
        {
            string i = listViewWykladowcy.SelectedItems.ToString();
            listViewWykladowcy.Items.Remove(listViewWykladowcy.FindItemWithText(textBox_usunWykladowce.Text));


            removeObjectProp(textBox_usunWykladowce.Text);
            usunDataProp(textBox_usunWykladowce.Text);
            usunDataProp(textBox_usunWykladowce.Text);
            usunDataProp(textBox_usunWykladowce.Text);
            usunDataProp(textBox_usunWykladowce.Text);
            removeObjectProp(textBox_usunWykladowce.Text);

        }


        private void button_dodajCwiczenia_Click(object sender, EventArgs e)
        {
            if (textBox_nazwaCwiczen.Text == "" || comboBox_rokCwiczen.SelectedItem == null || comboBox_semestrCwiczen.SelectedItem == null || comboBox_semestrCwiczen.SelectedItem == null || comboBox_wydzialCwiczen.SelectedItem == null)
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól", "Błąd");
            }
            else
            {
                Dodaj dodaj = new Dodaj();
                dodaj.przedmiot(textBox_nazwaCwiczen.Text, comboBox_wydzialCwiczen.Text, comboBox_rokCwiczen.Text, comboBox_semestrCwiczen.Text, "Ćwiczenia");
                pobierz.czyscPobierz();
                ladujTabelePrzedmiotow();

                dodaj.dodajWykladowceDoPrzedmiotu(comboBox_prowadzacyCwiczen.Text, textBox_nazwaCwiczen.Text, "Ćwiczenia");
            }
        }

        private void button_dodajWyklad_Click_1(object sender, EventArgs e)
        {
            if (textBox_nazwaWykladu.Text == "" || comboBox_rokWykladu.SelectedItem == null || comboBox_semestrWykladu.SelectedItem == null || comboBox_semestrWykladu.SelectedItem == null || comboBox_wydzialWykladu.SelectedItem == null)
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól", "Błąd");
            }
            else
            {
                Dodaj dodaj = new Dodaj();
                dodaj.przedmiot(textBox_nazwaWykladu.Text, comboBox_wydzialWykladu.Text, comboBox_rokWykladu.Text, comboBox_semestrWykladu.Text, "Wykład");
                pobierz.czyscPobierz();
                ladujTabelePrzedmiotow();

                dodaj.dodajWykladowceDoPrzedmiotu(comboBox_prowadzacyWykladu.Text, textBox_nazwaWykladu.Text, "Wykład");
            }
        }

        private void button_usunWyklad_Click(object sender, EventArgs e)
        {
            string i = listView_wyklady.SelectedItems.ToString();
            listView_wyklady.Items.Remove(listView_wyklady.FindItemWithText(textBox_usunWyklad.Text));


            removeObjectProp(textBox_usunWykladowce.Text);
            usunDataProp(textBox_usunWyklad.Text);
            usunDataProp(textBox_usunWyklad.Text);
            usunDataProp(textBox_usunWyklad.Text);
            usunDataProp(textBox_usunWyklad.Text);
            removeObjectProp(textBox_usunWyklad.Text);

        }

        private void button_usunCwiczenia_Click(object sender, EventArgs e)
        {
            string i = listView_cwiczenia.SelectedItems.ToString();
            listView_cwiczenia.Items.Remove(listView_cwiczenia.FindItemWithText(textBox_usunWyklad.Text));


            removeObjectProp(textBox_usunCwiczenia.Text);
            usunDataProp(textBox_usunCwiczenia.Text);
            usunDataProp(textBox_usunCwiczenia.Text);
            usunDataProp(textBox_usunCwiczenia.Text);
            usunDataProp(textBox_usunCwiczenia.Text);
            removeObjectProp(textBox_usunCwiczenia.Text);

        }

        private void button_dodajDoWykladu_Click(object sender, EventArgs e)
        {
            if (comboBox_studentStudentW.SelectedItem == null || comboBox_studentWykladW.SelectedItem == null )
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól", "Błąd");
            }
            else
            {
                Dodaj dodaj = new Dodaj();
                dodaj.dodajStudentaDoPrzedmiotu2(comboBox_studentStudentW.Text, comboBox_studentWykladW.Text);
            }
        }

        private void button_dodajStudentaDoCwiczen_Click(object sender, EventArgs e)
        {
            if (comboBox_studentStudentC.SelectedItem == null || comboBox_studentCwiczeniaC.SelectedItem == null)
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól", "Błąd");
            }
            else
            {
                Dodaj dodaj = new Dodaj();
                dodaj.dodajStudentaDoPrzedmiotu2(comboBox_studentStudentC.Text, comboBox_studentCwiczeniaC.Text);
            }
        }

        private void button_delZPrzedmiotow_Click(object sender, EventArgs e)
        {
            removeStudentaZPrzedmiotu(comboBox_studentDelZPrzedmiotow.Text);
            removeStudentaZPrzedmiotu2(comboBox_studentDelZPrzedmiotow.Text);
        }

        private void TabControl1_Click(Object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedTab.Name == "Przedmioty" ) 
            Console.WriteLine("zmieniam");
        }

    }
}

