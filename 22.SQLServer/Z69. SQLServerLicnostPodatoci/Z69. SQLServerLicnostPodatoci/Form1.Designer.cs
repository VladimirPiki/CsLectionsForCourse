namespace Z69.SQLServerLicnostPodatoci
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
            this.dtDatumRag = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.rbTatkovoIme = new System.Windows.Forms.RadioButton();
            this.rbDatum = new System.Windows.Forms.RadioButton();
            this.rbPrezime = new System.Windows.Forms.RadioButton();
            this.rbIme = new System.Windows.Forms.RadioButton();
            this.rbMaticenBroj = new System.Windows.Forms.RadioButton();
            this.btnBarajPodatoci = new System.Windows.Forms.Button();
            this.btnBaza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMestoZiveenje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTatkovoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaticenBr = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbAdresa = new System.Windows.Forms.RadioButton();
            this.rbMestoZiveenje = new System.Windows.Forms.RadioButton();
            this.btnPrikaziSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtDatumRag
            // 
            this.dtDatumRag.CustomFormat = "dd-MM-yyyy";
            this.dtDatumRag.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatumRag.Location = new System.Drawing.Point(142, 161);
            this.dtDatumRag.Name = "dtDatumRag";
            this.dtDatumRag.Size = new System.Drawing.Size(142, 20);
            this.dtDatumRag.TabIndex = 59;
            this.dtDatumRag.Value = new System.DateTime(2023, 9, 8, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Datum na raganje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(142, 199);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(142, 20);
            this.tbAdresa.TabIndex = 56;
            // 
            // rbTatkovoIme
            // 
            this.rbTatkovoIme.AutoSize = true;
            this.rbTatkovoIme.Location = new System.Drawing.Point(58, 491);
            this.rbTatkovoIme.Name = "rbTatkovoIme";
            this.rbTatkovoIme.Size = new System.Drawing.Size(85, 17);
            this.rbTatkovoIme.TabIndex = 55;
            this.rbTatkovoIme.TabStop = true;
            this.rbTatkovoIme.Text = "Tatkovo Ime";
            this.rbTatkovoIme.UseVisualStyleBackColor = true;
            // 
            // rbDatum
            // 
            this.rbDatum.AutoSize = true;
            this.rbDatum.Location = new System.Drawing.Point(58, 562);
            this.rbDatum.Name = "rbDatum";
            this.rbDatum.Size = new System.Drawing.Size(56, 17);
            this.rbDatum.TabIndex = 54;
            this.rbDatum.TabStop = true;
            this.rbDatum.Text = "Datum";
            this.rbDatum.UseVisualStyleBackColor = true;
            // 
            // rbPrezime
            // 
            this.rbPrezime.AutoSize = true;
            this.rbPrezime.Location = new System.Drawing.Point(58, 528);
            this.rbPrezime.Name = "rbPrezime";
            this.rbPrezime.Size = new System.Drawing.Size(62, 17);
            this.rbPrezime.TabIndex = 53;
            this.rbPrezime.TabStop = true;
            this.rbPrezime.Text = "Prezime";
            this.rbPrezime.UseVisualStyleBackColor = true;
            // 
            // rbIme
            // 
            this.rbIme.AutoSize = true;
            this.rbIme.Location = new System.Drawing.Point(58, 452);
            this.rbIme.Name = "rbIme";
            this.rbIme.Size = new System.Drawing.Size(42, 17);
            this.rbIme.TabIndex = 52;
            this.rbIme.TabStop = true;
            this.rbIme.Text = "Ime";
            this.rbIme.UseVisualStyleBackColor = true;
            // 
            // rbMaticenBroj
            // 
            this.rbMaticenBroj.AutoSize = true;
            this.rbMaticenBroj.Location = new System.Drawing.Point(55, 420);
            this.rbMaticenBroj.Name = "rbMaticenBroj";
            this.rbMaticenBroj.Size = new System.Drawing.Size(83, 17);
            this.rbMaticenBroj.TabIndex = 51;
            this.rbMaticenBroj.TabStop = true;
            this.rbMaticenBroj.Text = "Maticen broj";
            this.rbMaticenBroj.UseVisualStyleBackColor = true;
            // 
            // btnBarajPodatoci
            // 
            this.btnBarajPodatoci.Location = new System.Drawing.Point(211, 462);
            this.btnBarajPodatoci.Name = "btnBarajPodatoci";
            this.btnBarajPodatoci.Size = new System.Drawing.Size(125, 46);
            this.btnBarajPodatoci.TabIndex = 50;
            this.btnBarajPodatoci.Text = "Baraj Podatoci";
            this.btnBarajPodatoci.UseVisualStyleBackColor = true;
            this.btnBarajPodatoci.Click += new System.EventHandler(this.btnBarajPodatoci_Click);
            // 
            // btnBaza
            // 
            this.btnBaza.Location = new System.Drawing.Point(92, 295);
            this.btnBaza.Name = "btnBaza";
            this.btnBaza.Size = new System.Drawing.Size(125, 46);
            this.btnBaza.TabIndex = 49;
            this.btnBaza.Text = "Dodaj vo Baza";
            this.btnBaza.UseVisualStyleBackColor = true;
            this.btnBaza.Click += new System.EventHandler(this.btnBaza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mesto na ziveenje";
            // 
            // tbMestoZiveenje
            // 
            this.tbMestoZiveenje.Location = new System.Drawing.Point(142, 236);
            this.tbMestoZiveenje.Name = "tbMestoZiveenje";
            this.tbMestoZiveenje.Size = new System.Drawing.Size(142, 20);
            this.tbMestoZiveenje.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Prezime";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(142, 125);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(142, 20);
            this.tbPrezime.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tatkovo ime";
            // 
            // tbTatkovoIme
            // 
            this.tbTatkovoIme.Location = new System.Drawing.Point(142, 80);
            this.tbTatkovoIme.Name = "tbTatkovoIme";
            this.tbTatkovoIme.Size = new System.Drawing.Size(142, 20);
            this.tbTatkovoIme.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ime";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(142, 44);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(142, 20);
            this.tbIme.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Maticen broj";
            // 
            // tbMaticenBr
            // 
            this.tbMaticenBr.Location = new System.Drawing.Point(142, 6);
            this.tbMaticenBr.Name = "tbMaticenBr";
            this.tbMaticenBr.Size = new System.Drawing.Size(142, 20);
            this.tbMaticenBr.TabIndex = 36;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(366, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(981, 569);
            this.listView1.TabIndex = 60;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // rbAdresa
            // 
            this.rbAdresa.AutoSize = true;
            this.rbAdresa.Location = new System.Drawing.Point(58, 599);
            this.rbAdresa.Name = "rbAdresa";
            this.rbAdresa.Size = new System.Drawing.Size(58, 17);
            this.rbAdresa.TabIndex = 61;
            this.rbAdresa.TabStop = true;
            this.rbAdresa.Text = "Adresa";
            this.rbAdresa.UseVisualStyleBackColor = true;
            // 
            // rbMestoZiveenje
            // 
            this.rbMestoZiveenje.AutoSize = true;
            this.rbMestoZiveenje.Location = new System.Drawing.Point(58, 639);
            this.rbMestoZiveenje.Name = "rbMestoZiveenje";
            this.rbMestoZiveenje.Size = new System.Drawing.Size(111, 17);
            this.rbMestoZiveenje.TabIndex = 62;
            this.rbMestoZiveenje.TabStop = true;
            this.rbMestoZiveenje.Text = "Mesto na ziveenje";
            this.rbMestoZiveenje.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziSite
            // 
            this.btnPrikaziSite.Location = new System.Drawing.Point(741, 608);
            this.btnPrikaziSite.Name = "btnPrikaziSite";
            this.btnPrikaziSite.Size = new System.Drawing.Size(240, 78);
            this.btnPrikaziSite.TabIndex = 64;
            this.btnPrikaziSite.Text = "Prikazi gi site od baza";
            this.btnPrikaziSite.UseVisualStyleBackColor = true;
            this.btnPrikaziSite.Click += new System.EventHandler(this.btnPrikaziSite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 752);
            this.Controls.Add(this.btnPrikaziSite);
            this.Controls.Add(this.rbMestoZiveenje);
            this.Controls.Add(this.rbAdresa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtDatumRag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.rbTatkovoIme);
            this.Controls.Add(this.rbDatum);
            this.Controls.Add(this.rbPrezime);
            this.Controls.Add(this.rbIme);
            this.Controls.Add(this.rbMaticenBroj);
            this.Controls.Add(this.btnBarajPodatoci);
            this.Controls.Add(this.btnBaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMestoZiveenje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTatkovoIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaticenBr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtDatumRag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.RadioButton rbTatkovoIme;
        private System.Windows.Forms.RadioButton rbDatum;
        private System.Windows.Forms.RadioButton rbPrezime;
        private System.Windows.Forms.RadioButton rbIme;
        private System.Windows.Forms.RadioButton rbMaticenBroj;
        private System.Windows.Forms.Button btnBarajPodatoci;
        private System.Windows.Forms.Button btnBaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMestoZiveenje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTatkovoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaticenBr;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbAdresa;
        private System.Windows.Forms.RadioButton rbMestoZiveenje;
        private System.Windows.Forms.Button btnPrikaziSite;
    }
}

