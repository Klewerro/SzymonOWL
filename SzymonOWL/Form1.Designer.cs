namespace SzymonOWL
{
    partial class Form1
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
            this.button1_dodaj = new System.Windows.Forms.Button();
            this.button2_modyfikuj = new System.Windows.Forms.Button();
            this.button3_usun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_dodaj
            // 
            this.button1_dodaj.Location = new System.Drawing.Point(12, 146);
            this.button1_dodaj.Name = "button1_dodaj";
            this.button1_dodaj.Size = new System.Drawing.Size(122, 37);
            this.button1_dodaj.TabIndex = 0;
            this.button1_dodaj.Text = "Dodaj osobę";
            this.button1_dodaj.UseVisualStyleBackColor = true;
            this.button1_dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_modyfikuj
            // 
            this.button2_modyfikuj.Location = new System.Drawing.Point(12, 189);
            this.button2_modyfikuj.Name = "button2_modyfikuj";
            this.button2_modyfikuj.Size = new System.Drawing.Size(239, 37);
            this.button2_modyfikuj.TabIndex = 1;
            this.button2_modyfikuj.Text = "Modyfikuj";
            this.button2_modyfikuj.UseVisualStyleBackColor = true;
            // 
            // button3_usun
            // 
            this.button3_usun.Location = new System.Drawing.Point(12, 232);
            this.button3_usun.Name = "button3_usun";
            this.button3_usun.Size = new System.Drawing.Size(239, 37);
            this.button3_usun.TabIndex = 2;
            this.button3_usun.Text = "Usuń";
            this.button3_usun.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dodaj przedmiot";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 305);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3_usun);
            this.Controls.Add(this.button2_modyfikuj);
            this.Controls.Add(this.button1_dodaj);
            this.Name = "Form1";
            this.Text = "OWL Quick Parser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_dodaj;
        private System.Windows.Forms.Button button2_modyfikuj;
        private System.Windows.Forms.Button button3_usun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}