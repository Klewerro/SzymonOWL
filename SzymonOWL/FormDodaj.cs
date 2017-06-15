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
    public partial class FormDodaj : Form
    {
        public FormDodaj()
        {
            InitializeComponent();
            comboBox_rodzajStudenta.Visible = false;
            label_rodzajStudenta.Visible = false;
            comboBox_rodzaj.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_rodzajStudenta.DropDownStyle = ComboBoxStyle.DropDownList; //blokada edycji
            comboBox_wydzial.Items.Add("Matematyczno przyrodniczy");
            comboBox_wydzial.Items.Add("Chemiczny");
            comboBox_wydzial.Items.Add("Zarządzania");
            comboBox_wyborWykladowcy.Visible = false;
            label_wyborWykladowcy.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_rodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_rodzaj.SelectedItem.Equals("Student"))
            {
                comboBox_rodzajStudenta.Visible = true;
                label_rodzajStudenta.Visible = true;
            }
            if (!comboBox_rodzaj.SelectedItem.Equals("Student"))
            {
                comboBox_rodzajStudenta.Visible = false;
                label_rodzajStudenta.Visible = false;
            }
                
            if (comboBox_rodzaj.SelectedItem.Equals("Przedmiot"))
            {
                comboBox_wyborWykladowcy.Visible = true;
                label_wyborWykladowcy.Visible = true;
            }
            if (!comboBox_rodzaj.SelectedItem.Equals("Przedmiot"))
            {
                comboBox_wyborWykladowcy.Visible = false;
                label_wyborWykladowcy.Visible = false;
            }
                
        }
    }
}
