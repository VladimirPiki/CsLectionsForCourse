namespace Z63.DataDokumenti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbPrebaruvanjeNaslov = new System.Windows.Forms.TextBox();
            this.tbPrebaruvanjeAvtor = new System.Windows.Forms.TextBox();
            this.btnPodreduvanjeGodiniMesto = new System.Windows.Forms.Button();
            this.btnPodreduvanjeNaslov = new System.Windows.Forms.Button();
            this.btnPodreduvanjeOblast = new System.Windows.Forms.Button();
            this.btnPodreduvanjeAvtor = new System.Windows.Forms.Button();
            this.btnPrebaruvanjeNaslov = new System.Windows.Forms.Button();
            this.btnPrebaruvanje = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbImePdf = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btZacuvaj = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tbSlika = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btIzberiSlika = new System.Windows.Forms.Button();
            this.cbOblast = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLokacijaZacuvaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMestoNaIzdavanje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAvtor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnOtvoriLokacija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbPrebaruvanjeNaslov
            // 
            this.tbPrebaruvanjeNaslov.Location = new System.Drawing.Point(781, 432);
            this.tbPrebaruvanjeNaslov.Name = "tbPrebaruvanjeNaslov";
            this.tbPrebaruvanjeNaslov.Size = new System.Drawing.Size(184, 20);
            this.tbPrebaruvanjeNaslov.TabIndex = 107;
            // 
            // tbPrebaruvanjeAvtor
            // 
            this.tbPrebaruvanjeAvtor.Location = new System.Drawing.Point(781, 358);
            this.tbPrebaruvanjeAvtor.Name = "tbPrebaruvanjeAvtor";
            this.tbPrebaruvanjeAvtor.Size = new System.Drawing.Size(184, 20);
            this.tbPrebaruvanjeAvtor.TabIndex = 106;
            // 
            // btnPodreduvanjeGodiniMesto
            // 
            this.btnPodreduvanjeGodiniMesto.Location = new System.Drawing.Point(1012, 529);
            this.btnPodreduvanjeGodiniMesto.Name = "btnPodreduvanjeGodiniMesto";
            this.btnPodreduvanjeGodiniMesto.Size = new System.Drawing.Size(175, 23);
            this.btnPodreduvanjeGodiniMesto.TabIndex = 105;
            this.btnPodreduvanjeGodiniMesto.Text = "Podreduvanje po godini i mesto";
            this.btnPodreduvanjeGodiniMesto.UseVisualStyleBackColor = true;
            this.btnPodreduvanjeGodiniMesto.Click += new System.EventHandler(this.btnPodreduvanjeGodiniMesto_Click);
            // 
            // btnPodreduvanjeNaslov
            // 
            this.btnPodreduvanjeNaslov.Location = new System.Drawing.Point(1012, 412);
            this.btnPodreduvanjeNaslov.Name = "btnPodreduvanjeNaslov";
            this.btnPodreduvanjeNaslov.Size = new System.Drawing.Size(184, 23);
            this.btnPodreduvanjeNaslov.TabIndex = 104;
            this.btnPodreduvanjeNaslov.Text = "Podreduvanje naslov";
            this.btnPodreduvanjeNaslov.UseVisualStyleBackColor = true;
            this.btnPodreduvanjeNaslov.Click += new System.EventHandler(this.btnPodreduvanjeNaslov_Click);
            // 
            // btnPodreduvanjeOblast
            // 
            this.btnPodreduvanjeOblast.Location = new System.Drawing.Point(1012, 471);
            this.btnPodreduvanjeOblast.Name = "btnPodreduvanjeOblast";
            this.btnPodreduvanjeOblast.Size = new System.Drawing.Size(184, 23);
            this.btnPodreduvanjeOblast.TabIndex = 103;
            this.btnPodreduvanjeOblast.Text = "Podreduvanje oblast";
            this.btnPodreduvanjeOblast.UseVisualStyleBackColor = true;
            this.btnPodreduvanjeOblast.Click += new System.EventHandler(this.btnPodreduvanjeOblast_Click);
            // 
            // btnPodreduvanjeAvtor
            // 
            this.btnPodreduvanjeAvtor.Location = new System.Drawing.Point(1012, 358);
            this.btnPodreduvanjeAvtor.Name = "btnPodreduvanjeAvtor";
            this.btnPodreduvanjeAvtor.Size = new System.Drawing.Size(184, 23);
            this.btnPodreduvanjeAvtor.TabIndex = 102;
            this.btnPodreduvanjeAvtor.Text = "Podreduvanje po avtor";
            this.btnPodreduvanjeAvtor.UseVisualStyleBackColor = true;
            this.btnPodreduvanjeAvtor.Click += new System.EventHandler(this.btnPodreduvanjeAvtor_Click);
            // 
            // btnPrebaruvanjeNaslov
            // 
            this.btnPrebaruvanjeNaslov.Location = new System.Drawing.Point(781, 458);
            this.btnPrebaruvanjeNaslov.Name = "btnPrebaruvanjeNaslov";
            this.btnPrebaruvanjeNaslov.Size = new System.Drawing.Size(184, 30);
            this.btnPrebaruvanjeNaslov.TabIndex = 101;
            this.btnPrebaruvanjeNaslov.Text = "Prebaruvanje po naslov";
            this.btnPrebaruvanjeNaslov.UseVisualStyleBackColor = true;
            this.btnPrebaruvanjeNaslov.Click += new System.EventHandler(this.btnPrebaruvanjeNaslov_Click);
            // 
            // btnPrebaruvanje
            // 
            this.btnPrebaruvanje.Location = new System.Drawing.Point(781, 379);
            this.btnPrebaruvanje.Name = "btnPrebaruvanje";
            this.btnPrebaruvanje.Size = new System.Drawing.Size(184, 23);
            this.btnPrebaruvanje.TabIndex = 100;
            this.btnPrebaruvanje.Text = "Prebaruvanje po avtor";
            this.btnPrebaruvanje.UseVisualStyleBackColor = true;
            this.btnPrebaruvanje.Click += new System.EventHandler(this.btnPrebaruvanje_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1234, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "Za da go pregledate dokumentot selektirajte od tabelata";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(1290, 332);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(162, 92);
            this.btnPrikazi.TabIndex = 98;
            this.btnPrikazi.Text = "Pregled na Dokument";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Vnesete ime na pdf dadotekata";
            this.label9.Visible = false;
            // 
            // tbImePdf
            // 
            this.tbImePdf.Location = new System.Drawing.Point(15, 542);
            this.tbImePdf.Name = "tbImePdf";
            this.tbImePdf.Size = new System.Drawing.Size(152, 20);
            this.tbImePdf.TabIndex = 96;
            this.tbImePdf.Visible = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(15, 568);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(152, 42);
            this.btnDownload.TabIndex = 95;
            this.btnDownload.Text = "Spusti listview vo pdf ";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click_1);
            // 
            // btZacuvaj
            // 
            this.btZacuvaj.Location = new System.Drawing.Point(61, 450);
            this.btZacuvaj.Name = "btZacuvaj";
            this.btZacuvaj.Size = new System.Drawing.Size(158, 38);
            this.btZacuvaj.TabIndex = 93;
            this.btZacuvaj.Text = "Zacuvaj";
            this.btZacuvaj.UseVisualStyleBackColor = true;
            this.btZacuvaj.Click += new System.EventHandler(this.btZacuvaj_Click_1);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(917, 307);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(150, 41);
            this.btDodaj.TabIndex = 92;
            this.btDodaj.Text = "Prikazi tabela";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(359, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1175, 258);
            this.listView1.TabIndex = 91;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(316, 274);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(174, 335);
            this.pictureBox.TabIndex = 90;
            this.pictureBox.TabStop = false;
            // 
            // tbSlika
            // 
            this.tbSlika.Location = new System.Drawing.Point(34, 420);
            this.tbSlika.Name = "tbSlika";
            this.tbSlika.Size = new System.Drawing.Size(245, 20);
            this.tbSlika.TabIndex = 89;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "dd-MM-yyyy";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(110, 160);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(130, 20);
            this.dtData.TabIndex = 88;
            this.dtData.Value = new System.DateTime(2023, 9, 5, 0, 0, 0, 0);
            // 
            // btIzberiSlika
            // 
            this.btIzberiSlika.Location = new System.Drawing.Point(108, 382);
            this.btIzberiSlika.Name = "btIzberiSlika";
            this.btIzberiSlika.Size = new System.Drawing.Size(114, 23);
            this.btIzberiSlika.TabIndex = 87;
            this.btIzberiSlika.Text = "Izberete Slika";
            this.btIzberiSlika.UseVisualStyleBackColor = true;
            this.btIzberiSlika.Click += new System.EventHandler(this.btIzberiSlika_Click_1);
            // 
            // cbOblast
            // 
            this.cbOblast.FormattingEnabled = true;
            this.cbOblast.Items.AddRange(new object[] {
            "matematika",
            "fizika",
            "robotika",
            "medicina"});
            this.cbOblast.Location = new System.Drawing.Point(108, 325);
            this.cbOblast.Name = "cbOblast";
            this.cbOblast.Size = new System.Drawing.Size(132, 21);
            this.cbOblast.TabIndex = 86;
            this.cbOblast.Text = "Изберете област";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "• Слика од насловната страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Област (математика, физика, роботика, медицина)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "• Локација каде се чува документот";
            // 
            // tbLokacijaZacuvaj
            // 
            this.tbLokacijaZacuvaj.Location = new System.Drawing.Point(108, 264);
            this.tbLokacijaZacuvaj.Name = "tbLokacijaZacuvaj";
            this.tbLokacijaZacuvaj.Size = new System.Drawing.Size(129, 20);
            this.tbLokacijaZacuvaj.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "• Место на издавање";
            // 
            // tbMestoNaIzdavanje
            // 
            this.tbMestoNaIzdavanje.Location = new System.Drawing.Point(108, 217);
            this.tbMestoNaIzdavanje.Name = "tbMestoNaIzdavanje";
            this.tbMestoNaIzdavanje.Size = new System.Drawing.Size(129, 20);
            this.tbMestoNaIzdavanje.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "• Автор";
            // 
            // tbAvtor
            // 
            this.tbAvtor.Location = new System.Drawing.Point(108, 106);
            this.tbAvtor.Name = "tbAvtor";
            this.tbAvtor.Size = new System.Drawing.Size(129, 20);
            this.tbAvtor.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Внесете податоци за документот";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "• Наслов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "• Дата на издавање ";
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(108, 61);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(129, 20);
            this.tbNaslov.TabIndex = 74;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(496, 274);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(279, 335);
            this.axAcroPDF1.TabIndex = 108;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnOtvoriLokacija
            // 
            this.btnOtvoriLokacija.Location = new System.Drawing.Point(71, 9);
            this.btnOtvoriLokacija.Name = "btnOtvoriLokacija";
            this.btnOtvoriLokacija.Size = new System.Drawing.Size(166, 23);
            this.btnOtvoriLokacija.TabIndex = 110;
            this.btnOtvoriLokacija.Text = "Otvori Dokument";
            this.btnOtvoriLokacija.UseVisualStyleBackColor = true;
            this.btnOtvoriLokacija.Click += new System.EventHandler(this.btnOtvoriLokacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 619);
            this.Controls.Add(this.btnOtvoriLokacija);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.tbPrebaruvanjeNaslov);
            this.Controls.Add(this.tbPrebaruvanjeAvtor);
            this.Controls.Add(this.btnPodreduvanjeGodiniMesto);
            this.Controls.Add(this.btnPodreduvanjeNaslov);
            this.Controls.Add(this.btnPodreduvanjeOblast);
            this.Controls.Add(this.btnPodreduvanjeAvtor);
            this.Controls.Add(this.btnPrebaruvanjeNaslov);
            this.Controls.Add(this.btnPrebaruvanje);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbImePdf);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btZacuvaj);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.tbSlika);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.btIzberiSlika);
            this.Controls.Add(this.cbOblast);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLokacijaZacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMestoNaIzdavanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAvtor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNaslov);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbPrebaruvanjeNaslov;
        private System.Windows.Forms.TextBox tbPrebaruvanjeAvtor;
        private System.Windows.Forms.Button btnPodreduvanjeGodiniMesto;
        private System.Windows.Forms.Button btnPodreduvanjeNaslov;
        private System.Windows.Forms.Button btnPodreduvanjeOblast;
        private System.Windows.Forms.Button btnPodreduvanjeAvtor;
        private System.Windows.Forms.Button btnPrebaruvanjeNaslov;
        private System.Windows.Forms.Button btnPrebaruvanje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbImePdf;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btZacuvaj;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tbSlika;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button btIzberiSlika;
        private System.Windows.Forms.ComboBox cbOblast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLokacijaZacuvaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMestoNaIzdavanje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAvtor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNaslov;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnOtvoriLokacija;
    }
}

