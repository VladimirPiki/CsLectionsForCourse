namespace Z58.ListView
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
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbGodini = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.btnVnesiFile = new System.Windows.Forms.Button();
            this.btnNajvozrasnaLicnost = new System.Windows.Forms.Button();
            this.btnBrisiSelektiranaLic = new System.Windows.Forms.Button();
            this.txtBoxOd = new System.Windows.Forms.TextBox();
            this.txtBoxDo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIntervalGodini = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOdredenBrojGodini = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxOdredenBrGod = new System.Windows.Forms.TextBox();
            this.btnPrezimeUnikati = new System.Windows.Forms.Button();
            this.btnZameni = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBzameniPrezime = new System.Windows.Forms.TextBox();
            this.txtBzameniGodini = new System.Windows.Forms.TextBox();
            this.txtBzameniIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(14, 34);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 0;
            this.Ime.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "godini";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(95, 34);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 3;
            // 
            // tbGodini
            // 
            this.tbGodini.Location = new System.Drawing.Point(95, 122);
            this.tbGodini.Name = "tbGodini";
            this.tbGodini.Size = new System.Drawing.Size(100, 20);
            this.tbGodini.TabIndex = 4;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(95, 75);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 5;
            this.tbPrezime.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(214, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 202);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnVnesi
            // 
            this.btnVnesi.Location = new System.Drawing.Point(62, 157);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(75, 23);
            this.btnVnesi.TabIndex = 7;
            this.btnVnesi.Text = "Vnesi";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // btnVnesiFile
            // 
            this.btnVnesiFile.Location = new System.Drawing.Point(214, 225);
            this.btnVnesiFile.Name = "btnVnesiFile";
            this.btnVnesiFile.Size = new System.Drawing.Size(276, 23);
            this.btnVnesiFile.TabIndex = 8;
            this.btnVnesiFile.Text = "Vnesi od dadoteka";
            this.btnVnesiFile.UseVisualStyleBackColor = true;
            this.btnVnesiFile.Click += new System.EventHandler(this.btnVnesiFile_Click);
            // 
            // btnNajvozrasnaLicnost
            // 
            this.btnNajvozrasnaLicnost.Location = new System.Drawing.Point(214, 274);
            this.btnNajvozrasnaLicnost.Name = "btnNajvozrasnaLicnost";
            this.btnNajvozrasnaLicnost.Size = new System.Drawing.Size(276, 23);
            this.btnNajvozrasnaLicnost.TabIndex = 9;
            this.btnNajvozrasnaLicnost.Text = "Najvozrasna licnost";
            this.btnNajvozrasnaLicnost.UseVisualStyleBackColor = true;
            this.btnNajvozrasnaLicnost.Click += new System.EventHandler(this.btnNajvozrasnaLicnost_Click);
            // 
            // btnBrisiSelektiranaLic
            // 
            this.btnBrisiSelektiranaLic.Location = new System.Drawing.Point(214, 320);
            this.btnBrisiSelektiranaLic.Name = "btnBrisiSelektiranaLic";
            this.btnBrisiSelektiranaLic.Size = new System.Drawing.Size(276, 23);
            this.btnBrisiSelektiranaLic.TabIndex = 10;
            this.btnBrisiSelektiranaLic.Text = "Brisi selektirana licnost";
            this.btnBrisiSelektiranaLic.UseVisualStyleBackColor = true;
            this.btnBrisiSelektiranaLic.Click += new System.EventHandler(this.btnBrisiSelektiranaLic_Click);
            // 
            // txtBoxOd
            // 
            this.txtBoxOd.Location = new System.Drawing.Point(517, 59);
            this.txtBoxOd.Name = "txtBoxOd";
            this.txtBoxOd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOd.TabIndex = 11;
            // 
            // txtBoxDo
            // 
            this.txtBoxDo.Location = new System.Drawing.Point(669, 59);
            this.txtBoxDo.Name = "txtBoxDo";
            this.txtBoxDo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Godini od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Godini do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vnesi interval";
            // 
            // btnIntervalGodini
            // 
            this.btnIntervalGodini.Location = new System.Drawing.Point(533, 118);
            this.btnIntervalGodini.Name = "btnIntervalGodini";
            this.btnIntervalGodini.Size = new System.Drawing.Size(209, 23);
            this.btnIntervalGodini.TabIndex = 17;
            this.btnIntervalGodini.Text = "Interval na godini";
            this.btnIntervalGodini.UseVisualStyleBackColor = true;
            this.btnIntervalGodini.Click += new System.EventHandler(this.btnIntervalGodini_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dodadi licnost";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnOdredenBrojGodini
            // 
            this.btnOdredenBrojGodini.Location = new System.Drawing.Point(533, 225);
            this.btnOdredenBrojGodini.Name = "btnOdredenBrojGodini";
            this.btnOdredenBrojGodini.Size = new System.Drawing.Size(209, 23);
            this.btnOdredenBrojGodini.TabIndex = 27;
            this.btnOdredenBrojGodini.Text = "Vnesi";
            this.btnOdredenBrojGodini.UseVisualStyleBackColor = true;
            this.btnOdredenBrojGodini.Click += new System.EventHandler(this.btnOdredenBrojGodini_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vnesi odreden broj na godini";
            // 
            // txtBoxOdredenBrGod
            // 
            this.txtBoxOdredenBrGod.Location = new System.Drawing.Point(533, 192);
            this.txtBoxOdredenBrGod.Name = "txtBoxOdredenBrGod";
            this.txtBoxOdredenBrGod.Size = new System.Drawing.Size(200, 20);
            this.txtBoxOdredenBrGod.TabIndex = 23;
            // 
            // btnPrezimeUnikati
            // 
            this.btnPrezimeUnikati.Location = new System.Drawing.Point(214, 362);
            this.btnPrezimeUnikati.Name = "btnPrezimeUnikati";
            this.btnPrezimeUnikati.Size = new System.Drawing.Size(276, 23);
            this.btnPrezimeUnikati.TabIndex = 28;
            this.btnPrezimeUnikati.Text = "Licnost so prezime najmnogu razlicni karakteri";
            this.btnPrezimeUnikati.UseVisualStyleBackColor = true;
            this.btnPrezimeUnikati.Click += new System.EventHandler(this.btnPrezimeUnikati_Click);
            // 
            // btnZameni
            // 
            this.btnZameni.Location = new System.Drawing.Point(579, 401);
            this.btnZameni.Name = "btnZameni";
            this.btnZameni.Size = new System.Drawing.Size(142, 23);
            this.btnZameni.TabIndex = 29;
            this.btnZameni.Text = "Selektiraj Izbrisi Dodadi";
            this.btnZameni.UseVisualStyleBackColor = true;
            this.btnZameni.Click += new System.EventHandler(this.btnZameni_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Selektirajte licnost i na nejzino mesto dodate nova licnost\r\n";
            // 
            // txtBzameniPrezime
            // 
            this.txtBzameniPrezime.Location = new System.Drawing.Point(633, 329);
            this.txtBzameniPrezime.Name = "txtBzameniPrezime";
            this.txtBzameniPrezime.Size = new System.Drawing.Size(136, 20);
            this.txtBzameniPrezime.TabIndex = 36;
            // 
            // txtBzameniGodini
            // 
            this.txtBzameniGodini.Location = new System.Drawing.Point(633, 362);
            this.txtBzameniGodini.Name = "txtBzameniGodini";
            this.txtBzameniGodini.Size = new System.Drawing.Size(136, 20);
            this.txtBzameniGodini.TabIndex = 35;
            // 
            // txtBzameniIme
            // 
            this.txtBzameniIme.Location = new System.Drawing.Point(633, 292);
            this.txtBzameniIme.Name = "txtBzameniIme";
            this.txtBzameniIme.Size = new System.Drawing.Size(136, 20);
            this.txtBzameniIme.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Godini na nova licnost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Prezime na nova licnost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ime na nova licnost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.txtBzameniPrezime);
            this.Controls.Add(this.txtBzameniGodini);
            this.Controls.Add(this.txtBzameniIme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnZameni);
            this.Controls.Add(this.btnPrezimeUnikati);
            this.Controls.Add(this.btnOdredenBrojGodini);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxOdredenBrGod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIntervalGodini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxDo);
            this.Controls.Add(this.txtBoxOd);
            this.Controls.Add(this.btnBrisiSelektiranaLic);
            this.Controls.Add(this.btnNajvozrasnaLicnost);
            this.Controls.Add(this.btnVnesiFile);
            this.Controls.Add(this.btnVnesi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbGodini);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbGodini;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.Button btnVnesiFile;
        private System.Windows.Forms.Button btnNajvozrasnaLicnost;
        private System.Windows.Forms.Button btnBrisiSelektiranaLic;
        private System.Windows.Forms.TextBox txtBoxOd;
        private System.Windows.Forms.TextBox txtBoxDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIntervalGodini;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOdredenBrojGodini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxOdredenBrGod;
        private System.Windows.Forms.Button btnPrezimeUnikati;
        private System.Windows.Forms.Button btnZameni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBzameniPrezime;
        private System.Windows.Forms.TextBox txtBzameniGodini;
        private System.Windows.Forms.TextBox txtBzameniIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

