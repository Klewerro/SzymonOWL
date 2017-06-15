namespace SzymonOWL
{
    partial class FormDodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.label_rodzajStudenta = new System.Windows.Forms.Label();
            this.label_rodzaj = new System.Windows.Forms.Label();
            this.comboBox_rodzajStudenta = new System.Windows.Forms.ComboBox();
            this.comboBox_rodzaj = new System.Windows.Forms.ComboBox();
            this.label_imie = new System.Windows.Forms.Label();
            this.label_nazwisko = new System.Windows.Forms.Label();
            this.comboBox_wydzial = new System.Windows.Forms.ComboBox();
            this.label_wydzial = new System.Windows.Forms.Label();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.comboBox_wyborWykladowcy = new System.Windows.Forms.ComboBox();
            this.label_wyborWykladowcy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(150, 84);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(133, 20);
            this.textBox_nazwisko.TabIndex = 16;
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(15, 84);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(126, 20);
            this.textBox_imie.TabIndex = 15;
            // 
            // label_rodzajStudenta
            // 
            this.label_rodzajStudenta.AutoSize = true;
            this.label_rodzajStudenta.Location = new System.Drawing.Point(227, 23);
            this.label_rodzajStudenta.Name = "label_rodzajStudenta";
            this.label_rodzajStudenta.Size = new System.Drawing.Size(123, 13);
            this.label_rodzajStudenta.TabIndex = 14;
            this.label_rodzajStudenta.Text = "Wybierz rodzaj studenta:";
            // 
            // label_rodzaj
            // 
            this.label_rodzaj.AutoSize = true;
            this.label_rodzaj.Location = new System.Drawing.Point(12, 23);
            this.label_rodzaj.Name = "label_rodzaj";
            this.label_rodzaj.Size = new System.Drawing.Size(117, 13);
            this.label_rodzaj.TabIndex = 13;
            this.label_rodzaj.Text = "Wybierz rodzaj obiektu:";
            // 
            // comboBox_rodzajStudenta
            // 
            this.comboBox_rodzajStudenta.FormattingEnabled = true;
            this.comboBox_rodzajStudenta.Items.AddRange(new object[] {
            "Stacjonarny",
            "Niestacjonarny",
            "ITS"});
            this.comboBox_rodzajStudenta.Location = new System.Drawing.Point(230, 39);
            this.comboBox_rodzajStudenta.Name = "comboBox_rodzajStudenta";
            this.comboBox_rodzajStudenta.Size = new System.Drawing.Size(135, 21);
            this.comboBox_rodzajStudenta.TabIndex = 12;
            // 
            // comboBox_rodzaj
            // 
            this.comboBox_rodzaj.FormattingEnabled = true;
            this.comboBox_rodzaj.Items.AddRange(new object[] {
            "Student",
            "Wykładowca",
            "Przedmiot"});
            this.comboBox_rodzaj.Location = new System.Drawing.Point(15, 39);
            this.comboBox_rodzaj.Name = "comboBox_rodzaj";
            this.comboBox_rodzaj.Size = new System.Drawing.Size(178, 21);
            this.comboBox_rodzaj.TabIndex = 11;
            this.comboBox_rodzaj.SelectedIndexChanged += new System.EventHandler(this.comboBox_rodzaj_SelectedIndexChanged);
            // 
            // label_imie
            // 
            this.label_imie.AutoSize = true;
            this.label_imie.Location = new System.Drawing.Point(15, 68);
            this.label_imie.Name = "label_imie";
            this.label_imie.Size = new System.Drawing.Size(29, 13);
            this.label_imie.TabIndex = 17;
            this.label_imie.Text = "Imie:";
            // 
            // label_nazwisko
            // 
            this.label_nazwisko.AutoSize = true;
            this.label_nazwisko.Location = new System.Drawing.Point(147, 68);
            this.label_nazwisko.Name = "label_nazwisko";
            this.label_nazwisko.Size = new System.Drawing.Size(56, 13);
            this.label_nazwisko.TabIndex = 18;
            this.label_nazwisko.Text = "Nazwisko:";
            // 
            // comboBox_wydzial
            // 
            this.comboBox_wydzial.FormattingEnabled = true;
            this.comboBox_wydzial.Location = new System.Drawing.Point(15, 128);
            this.comboBox_wydzial.Name = "comboBox_wydzial";
            this.comboBox_wydzial.Size = new System.Drawing.Size(135, 21);
            this.comboBox_wydzial.TabIndex = 19;
            // 
            // label_wydzial
            // 
            this.label_wydzial.AutoSize = true;
            this.label_wydzial.Location = new System.Drawing.Point(15, 112);
            this.label_wydzial.Name = "label_wydzial";
            this.label_wydzial.Size = new System.Drawing.Size(49, 13);
            this.label_wydzial.TabIndex = 20;
            this.label_wydzial.Text = "Wydział:";
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(249, 229);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(101, 42);
            this.button_dodaj.TabIndex = 21;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            // 
            // comboBox_wyborWykladowcy
            // 
            this.comboBox_wyborWykladowcy.FormattingEnabled = true;
            this.comboBox_wyborWykladowcy.Location = new System.Drawing.Point(15, 241);
            this.comboBox_wyborWykladowcy.Name = "comboBox_wyborWykladowcy";
            this.comboBox_wyborWykladowcy.Size = new System.Drawing.Size(134, 21);
            this.comboBox_wyborWykladowcy.TabIndex = 22;
            // 
            // label_wyborWykladowcy
            // 
            this.label_wyborWykladowcy.AutoSize = true;
            this.label_wyborWykladowcy.Location = new System.Drawing.Point(15, 225);
            this.label_wyborWykladowcy.Name = "label_wyborWykladowcy";
            this.label_wyborWykladowcy.Size = new System.Drawing.Size(74, 13);
            this.label_wyborWykladowcy.TabIndex = 23;
            this.label_wyborWykladowcy.Text = "Wykładowca:";
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 354);
            this.Controls.Add(this.label_wyborWykladowcy);
            this.Controls.Add(this.comboBox_wyborWykladowcy);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.label_wydzial);
            this.Controls.Add(this.comboBox_wydzial);
            this.Controls.Add(this.label_nazwisko);
            this.Controls.Add(this.label_imie);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.label_rodzajStudenta);
            this.Controls.Add(this.label_rodzaj);
            this.Controls.Add(this.comboBox_rodzajStudenta);
            this.Controls.Add(this.comboBox_rodzaj);
            this.Name = "FormDodaj";
            this.Text = "Dodaj obiekt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Label label_rodzajStudenta;
        private System.Windows.Forms.Label label_rodzaj;
        private System.Windows.Forms.ComboBox comboBox_rodzajStudenta;
        private System.Windows.Forms.ComboBox comboBox_rodzaj;
        private System.Windows.Forms.Label label_imie;
        private System.Windows.Forms.Label label_nazwisko;
        private System.Windows.Forms.ComboBox comboBox_wydzial;
        private System.Windows.Forms.Label label_wydzial;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.ComboBox comboBox_wyborWykladowcy;
        private System.Windows.Forms.Label label_wyborWykladowcy;
    }
}