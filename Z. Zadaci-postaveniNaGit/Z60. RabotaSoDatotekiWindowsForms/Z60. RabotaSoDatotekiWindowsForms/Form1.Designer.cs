namespace Z60.RabotaSoDatotekiWindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNajdiDadoteka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOdredenaGolemina = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rbNajdiDadoteka = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbIzbrisi = new System.Windows.Forms.RadioButton();
            this.rbPremestiDadoteka = new System.Windows.Forms.RadioButton();
            this.rbOdredenaGolemina = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnPocni = new System.Windows.Forms.Button();
            this.btnPremestiSave = new System.Windows.Forms.Button();
            this.tbdadotekaZaPremestuvanje = new System.Windows.Forms.TextBox();
            this.rbNajdeteDuplikati = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDodadiDir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rbPremestiDir = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.tbZacuvajDirPateka = new System.Windows.Forms.TextBox();
            this.btnZacuvajIzborDir = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.rbNajdiEkstenzija = new System.Windows.Forms.RadioButton();
            this.tbEkstenzija = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "• Најдете датотека во даден директориум.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime na dadoteka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBNajdiDadoteka
            // 
            this.tBNajdiDadoteka.Location = new System.Drawing.Point(145, 135);
            this.tBNajdiDadoteka.Name = "tBNajdiDadoteka";
            this.tBNajdiDadoteka.Size = new System.Drawing.Size(175, 20);
            this.tBNajdiDadoteka.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "• Избришете даототека по желба на корисникот.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(392, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "• Преместете датотека од една на друга локација по желба на корисникот.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbOdredenaGolemina
            // 
            this.tbOdredenaGolemina.Location = new System.Drawing.Point(145, 422);
            this.tbOdredenaGolemina.Name = "tbOdredenaGolemina";
            this.tbOdredenaGolemina.Size = new System.Drawing.Size(175, 20);
            this.tbOdredenaGolemina.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Vneste golemina";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "• Пребарување на датотеки со одредена големина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Se naogjate vo direktoriumot temp\\Z60. RabotaSoDatotekiWindowsForms";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Dadoteka";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1289, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Direktoriumi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(618, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Zadaca Z60. RabotaSoDatotekiWindowsForms";
            // 
            // rbNajdiDadoteka
            // 
            this.rbNajdiDadoteka.AutoSize = true;
            this.rbNajdiDadoteka.Location = new System.Drawing.Point(12, 138);
            this.rbNajdiDadoteka.Name = "rbNajdiDadoteka";
            this.rbNajdiDadoteka.Size = new System.Drawing.Size(14, 13);
            this.rbNajdiDadoteka.TabIndex = 28;
            this.rbNajdiDadoteka.TabStop = true;
            this.rbNajdiDadoteka.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(265, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Prvo cekirajte ja zadacata koja sakate da ja izvrsuvate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Selektirajte ja dadotekata koja sakate da ja izbrisite";
            // 
            // rbIzbrisi
            // 
            this.rbIzbrisi.AutoSize = true;
            this.rbIzbrisi.Location = new System.Drawing.Point(12, 217);
            this.rbIzbrisi.Name = "rbIzbrisi";
            this.rbIzbrisi.Size = new System.Drawing.Size(14, 13);
            this.rbIzbrisi.TabIndex = 31;
            this.rbIzbrisi.TabStop = true;
            this.rbIzbrisi.UseVisualStyleBackColor = true;
            // 
            // rbPremestiDadoteka
            // 
            this.rbPremestiDadoteka.AutoSize = true;
            this.rbPremestiDadoteka.Location = new System.Drawing.Point(12, 293);
            this.rbPremestiDadoteka.Name = "rbPremestiDadoteka";
            this.rbPremestiDadoteka.Size = new System.Drawing.Size(14, 13);
            this.rbPremestiDadoteka.TabIndex = 32;
            this.rbPremestiDadoteka.TabStop = true;
            this.rbPremestiDadoteka.UseVisualStyleBackColor = true;
            // 
            // rbOdredenaGolemina
            // 
            this.rbOdredenaGolemina.AutoSize = true;
            this.rbOdredenaGolemina.Location = new System.Drawing.Point(12, 394);
            this.rbOdredenaGolemina.Name = "rbOdredenaGolemina";
            this.rbOdredenaGolemina.Size = new System.Drawing.Size(14, 13);
            this.rbOdredenaGolemina.TabIndex = 33;
            this.rbOdredenaGolemina.TabStop = true;
            this.rbOdredenaGolemina.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Selektirajte ja dadotekata pred da ja premesitite i zacuvajte go izborot";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(621, 595);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(265, 23);
            this.btnStart.TabIndex = 35;
            this.btnStart.Text = "Prikazi ja papkata";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(533, 62);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(432, 514);
            this.treeView.TabIndex = 36;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // btnPocni
            // 
            this.btnPocni.Location = new System.Drawing.Point(621, 661);
            this.btnPocni.Name = "btnPocni";
            this.btnPocni.Size = new System.Drawing.Size(265, 23);
            this.btnPocni.TabIndex = 37;
            this.btnPocni.Text = "Startovaj ja zadacata";
            this.btnPocni.UseVisualStyleBackColor = true;
            this.btnPocni.Click += new System.EventHandler(this.btnPocni_Click);
            // 
            // btnPremestiSave
            // 
            this.btnPremestiSave.Location = new System.Drawing.Point(200, 330);
            this.btnPremestiSave.Name = "btnPremestiSave";
            this.btnPremestiSave.Size = new System.Drawing.Size(327, 22);
            this.btnPremestiSave.TabIndex = 38;
            this.btnPremestiSave.Text = "Zacuvaj izbor";
            this.btnPremestiSave.UseVisualStyleBackColor = true;
            this.btnPremestiSave.Click += new System.EventHandler(this.btnPremestiSave_Click);
            // 
            // tbdadotekaZaPremestuvanje
            // 
            this.tbdadotekaZaPremestuvanje.Location = new System.Drawing.Point(50, 332);
            this.tbdadotekaZaPremestuvanje.Name = "tbdadotekaZaPremestuvanje";
            this.tbdadotekaZaPremestuvanje.Size = new System.Drawing.Size(100, 20);
            this.tbdadotekaZaPremestuvanje.TabIndex = 39;
            this.tbdadotekaZaPremestuvanje.Visible = false;
            // 
            // rbNajdeteDuplikati
            // 
            this.rbNajdeteDuplikati.AutoSize = true;
            this.rbNajdeteDuplikati.Location = new System.Drawing.Point(998, 85);
            this.rbNajdeteDuplikati.Name = "rbNajdeteDuplikati";
            this.rbNajdeteDuplikati.Size = new System.Drawing.Size(14, 13);
            this.rbNajdeteDuplikati.TabIndex = 40;
            this.rbNajdeteDuplikati.TabStop = true;
            this.rbNajdeteDuplikati.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1275, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1169, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(265, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Prvo cekirajte ja zadacata koja sakate da ja izvrsuvate";
            // 
            // btnDodadiDir
            // 
            this.btnDodadiDir.Location = new System.Drawing.Point(1137, 160);
            this.btnDodadiDir.Name = "btnDodadiDir";
            this.btnDodadiDir.Size = new System.Drawing.Size(177, 23);
            this.btnDodadiDir.TabIndex = 43;
            this.btnDodadiDir.Text = "Dodadate";
            this.btnDodadiDir.UseVisualStyleBackColor = true;
            this.btnDodadiDir.Click += new System.EventHandler(this.btnDodadiDir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1041, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(414, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = " Најдете дупликати датотеки во еден директориум или во повеќе директориуми\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1086, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(321, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "избришете ги дупликатите датотеки по желба на корисникот.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1041, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(391, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Dodadate Direktoriumi so selektiranje od treeview i klikanje na kopceto Dodadete";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(998, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(453, 286);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1031, 487);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(401, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Selektirajte gi duplikatite izbrisetegi so kliknuvanje na kopceto Startovaj ja za" +
    "dacata";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(47, 364);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(302, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Premestete ja so kliknuvanje na kopceto Startovaj ja zadacata";
            // 
            // rbPremestiDir
            // 
            this.rbPremestiDir.AutoSize = true;
            this.rbPremestiDir.Location = new System.Drawing.Point(998, 548);
            this.rbPremestiDir.Name = "rbPremestiDir";
            this.rbPremestiDir.Size = new System.Drawing.Size(14, 13);
            this.rbPremestiDir.TabIndex = 51;
            this.rbPremestiDir.TabStop = true;
            this.rbPremestiDir.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1031, 548);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(276, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Преместете директориум од една на друга локација.";
            // 
            // tbZacuvajDirPateka
            // 
            this.tbZacuvajDirPateka.Location = new System.Drawing.Point(1292, 611);
            this.tbZacuvajDirPateka.Name = "tbZacuvajDirPateka";
            this.tbZacuvajDirPateka.Size = new System.Drawing.Size(100, 20);
            this.tbZacuvajDirPateka.TabIndex = 53;
            this.tbZacuvajDirPateka.Visible = false;
            // 
            // btnZacuvajIzborDir
            // 
            this.btnZacuvajIzborDir.Location = new System.Drawing.Point(986, 609);
            this.btnZacuvajIzborDir.Name = "btnZacuvajIzborDir";
            this.btnZacuvajIzborDir.Size = new System.Drawing.Size(289, 22);
            this.btnZacuvajIzborDir.TabIndex = 54;
            this.btnZacuvajIzborDir.Text = "Zacuvaj izbor";
            this.btnZacuvajIzborDir.UseVisualStyleBackColor = true;
            this.btnZacuvajIzborDir.Click += new System.EventHandler(this.btnZacuvajIzborDir_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(985, 579);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(470, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Selektirajte direktorium od treeView i zacuvajte go izborot so kliknuvanje na kop" +
    "ceto Zacuvaj izbor";
            // 
            // rbNajdiEkstenzija
            // 
            this.rbNajdiEkstenzija.AutoSize = true;
            this.rbNajdiEkstenzija.Location = new System.Drawing.Point(986, 661);
            this.rbNajdiEkstenzija.Name = "rbNajdiEkstenzija";
            this.rbNajdiEkstenzija.Size = new System.Drawing.Size(449, 17);
            this.rbNajdiEkstenzija.TabIndex = 56;
            this.rbNajdiEkstenzija.TabStop = true;
            this.rbNajdiEkstenzija.Text = " Најди ги сите датотеки со одредена екстензија во еден или повеќе директориуми.";
            this.rbNajdiEkstenzija.UseVisualStyleBackColor = true;
            // 
            // tbEkstenzija
            // 
            this.tbEkstenzija.Location = new System.Drawing.Point(998, 728);
            this.tbEkstenzija.Name = "tbEkstenzija";
            this.tbEkstenzija.Size = new System.Drawing.Size(394, 20);
            this.tbEkstenzija.TabIndex = 57;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1011, 692);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(421, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "Selektirajte od treeView vnesete ekstenzija koja ja sakate i kliknete na Startova" +
    "j zadaca";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 782);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbEkstenzija);
            this.Controls.Add(this.rbNajdiEkstenzija);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnZacuvajIzborDir);
            this.Controls.Add(this.tbZacuvajDirPateka);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rbPremestiDir);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDodadiDir);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbNajdeteDuplikati);
            this.Controls.Add(this.tbdadotekaZaPremestuvanje);
            this.Controls.Add(this.btnPremestiSave);
            this.Controls.Add(this.btnPocni);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbOdredenaGolemina);
            this.Controls.Add(this.rbPremestiDadoteka);
            this.Controls.Add(this.rbIzbrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rbNajdiDadoteka);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOdredenaGolemina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBNajdiDadoteka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNajdiDadoteka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOdredenaGolemina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbNajdiDadoteka;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbIzbrisi;
        private System.Windows.Forms.RadioButton rbPremestiDadoteka;
        private System.Windows.Forms.RadioButton rbOdredenaGolemina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnPocni;
        private System.Windows.Forms.Button btnPremestiSave;
        private System.Windows.Forms.TextBox tbdadotekaZaPremestuvanje;
        private System.Windows.Forms.RadioButton rbNajdeteDuplikati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnDodadiDir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton rbPremestiDir;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbZacuvajDirPateka;
        private System.Windows.Forms.Button btnZacuvajIzborDir;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rbNajdiEkstenzija;
        private System.Windows.Forms.TextBox tbEkstenzija;
        private System.Windows.Forms.Label label23;
    }
}

