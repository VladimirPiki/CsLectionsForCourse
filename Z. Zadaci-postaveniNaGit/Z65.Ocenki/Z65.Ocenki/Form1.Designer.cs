namespace Z65.Ocenki
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
            this.cbGodinaKlas = new System.Windows.Forms.ComboBox();
            this.cbKlas = new System.Windows.Forms.ComboBox();
            this.cbTromesecie = new System.Windows.Forms.ComboBox();
            this.cbUcebnaGodina = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnPrezPodatoci = new System.Windows.Forms.Button();
            this.btnSnimiPodatoci = new System.Windows.Forms.Button();
            this.btnPrezemiPodatoci = new System.Windows.Forms.Button();
            this.btnProsekKlas = new System.Windows.Forms.Button();
            this.btnProsekUcenik = new System.Windows.Forms.Button();
            this.btnProsekPredmet = new System.Windows.Forms.Button();
            this.btnOtstapuvanjePredmet = new System.Windows.Forms.Button();
            this.btnDistribucijaOtcenki = new System.Windows.Forms.Button();
            this.btnUceniciSlabiOcenki = new System.Windows.Forms.Button();
            this.tbImeNaTabela = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbGodinaKlas
            // 
            this.cbGodinaKlas.FormattingEnabled = true;
            this.cbGodinaKlas.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cbGodinaKlas.Location = new System.Drawing.Point(28, 22);
            this.cbGodinaKlas.Name = "cbGodinaKlas";
            this.cbGodinaKlas.Size = new System.Drawing.Size(239, 21);
            this.cbGodinaKlas.TabIndex = 0;
            this.cbGodinaKlas.Text = "Godina Klas";
            this.cbGodinaKlas.SelectedIndexChanged += new System.EventHandler(this.cbGodinaKlas_SelectedIndexChanged);
            // 
            // cbKlas
            // 
            this.cbKlas.FormattingEnabled = true;
            this.cbKlas.Items.AddRange(new object[] {
            "A",
            "B",
            "V",
            "G"});
            this.cbKlas.Location = new System.Drawing.Point(28, 78);
            this.cbKlas.Name = "cbKlas";
            this.cbKlas.Size = new System.Drawing.Size(239, 21);
            this.cbKlas.TabIndex = 1;
            this.cbKlas.Text = "Klas";
            // 
            // cbTromesecie
            // 
            this.cbTromesecie.FormattingEnabled = true;
            this.cbTromesecie.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cbTromesecie.Location = new System.Drawing.Point(28, 137);
            this.cbTromesecie.Name = "cbTromesecie";
            this.cbTromesecie.Size = new System.Drawing.Size(239, 21);
            this.cbTromesecie.TabIndex = 2;
            this.cbTromesecie.Text = "Tromesecie";
            // 
            // cbUcebnaGodina
            // 
            this.cbUcebnaGodina.FormattingEnabled = true;
            this.cbUcebnaGodina.Items.AddRange(new object[] {
            "2020/2021",
            "2021/2022",
            "2022/2023",
            "2023/2024"});
            this.cbUcebnaGodina.Location = new System.Drawing.Point(28, 189);
            this.cbUcebnaGodina.Name = "cbUcebnaGodina";
            this.cbUcebnaGodina.Size = new System.Drawing.Size(239, 21);
            this.cbUcebnaGodina.TabIndex = 3;
            this.cbUcebnaGodina.Text = "Ucebna godina";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(330, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1196, 500);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnPrezPodatoci
            // 
            this.btnPrezPodatoci.Location = new System.Drawing.Point(330, 12);
            this.btnPrezPodatoci.Name = "btnPrezPodatoci";
            this.btnPrezPodatoci.Size = new System.Drawing.Size(220, 23);
            this.btnPrezPodatoci.TabIndex = 5;
            this.btnPrezPodatoci.Text = "Преземи дадотека";
            this.btnPrezPodatoci.UseVisualStyleBackColor = true;
            this.btnPrezPodatoci.Click += new System.EventHandler(this.btnPrezPodatoci_Click);
            // 
            // btnSnimiPodatoci
            // 
            this.btnSnimiPodatoci.Location = new System.Drawing.Point(50, 249);
            this.btnSnimiPodatoci.Name = "btnSnimiPodatoci";
            this.btnSnimiPodatoci.Size = new System.Drawing.Size(217, 23);
            this.btnSnimiPodatoci.TabIndex = 6;
            this.btnSnimiPodatoci.Text = "Сними податоци";
            this.btnSnimiPodatoci.UseVisualStyleBackColor = true;
            this.btnSnimiPodatoci.Click += new System.EventHandler(this.btnSnimiPodatoci_Click);
            // 
            // btnPrezemiPodatoci
            // 
            this.btnPrezemiPodatoci.Location = new System.Drawing.Point(50, 325);
            this.btnPrezemiPodatoci.Name = "btnPrezemiPodatoci";
            this.btnPrezemiPodatoci.Size = new System.Drawing.Size(223, 30);
            this.btnPrezemiPodatoci.TabIndex = 7;
            this.btnPrezemiPodatoci.Text = "Преземи податоци";
            this.btnPrezemiPodatoci.UseVisualStyleBackColor = true;
            this.btnPrezemiPodatoci.Click += new System.EventHandler(this.btnPrezemiPodatoci_Click);
            // 
            // btnProsekKlas
            // 
            this.btnProsekKlas.Location = new System.Drawing.Point(330, 575);
            this.btnProsekKlas.Name = "btnProsekKlas";
            this.btnProsekKlas.Size = new System.Drawing.Size(228, 32);
            this.btnProsekKlas.TabIndex = 8;
            this.btnProsekKlas.Text = "Просек на класот";
            this.btnProsekKlas.UseVisualStyleBackColor = true;
            this.btnProsekKlas.Click += new System.EventHandler(this.btnProsekKlas_Click);
            // 
            // btnProsekUcenik
            // 
            this.btnProsekUcenik.Location = new System.Drawing.Point(601, 575);
            this.btnProsekUcenik.Name = "btnProsekUcenik";
            this.btnProsekUcenik.Size = new System.Drawing.Size(243, 32);
            this.btnProsekUcenik.TabIndex = 9;
            this.btnProsekUcenik.Text = "Просек на ученик";
            this.btnProsekUcenik.UseVisualStyleBackColor = true;
            this.btnProsekUcenik.Click += new System.EventHandler(this.btnProsekUcenik_Click);
            // 
            // btnProsekPredmet
            // 
            this.btnProsekPredmet.Location = new System.Drawing.Point(882, 575);
            this.btnProsekPredmet.Name = "btnProsekPredmet";
            this.btnProsekPredmet.Size = new System.Drawing.Size(234, 32);
            this.btnProsekPredmet.TabIndex = 10;
            this.btnProsekPredmet.Text = "Просек на предмети";
            this.btnProsekPredmet.UseVisualStyleBackColor = true;
            this.btnProsekPredmet.Click += new System.EventHandler(this.btnProsekPredmet_Click);
            // 
            // btnOtstapuvanjePredmet
            // 
            this.btnOtstapuvanjePredmet.Location = new System.Drawing.Point(330, 647);
            this.btnOtstapuvanjePredmet.Name = "btnOtstapuvanjePredmet";
            this.btnOtstapuvanjePredmet.Size = new System.Drawing.Size(220, 41);
            this.btnOtstapuvanjePredmet.TabIndex = 11;
            this.btnOtstapuvanjePredmet.Text = "Отстапување по предмети";
            this.btnOtstapuvanjePredmet.UseVisualStyleBackColor = true;
            this.btnOtstapuvanjePredmet.Click += new System.EventHandler(this.btnOtstapuvanjePredmet_Click);
            // 
            // btnDistribucijaOtcenki
            // 
            this.btnDistribucijaOtcenki.Location = new System.Drawing.Point(601, 647);
            this.btnDistribucijaOtcenki.Name = "btnDistribucijaOtcenki";
            this.btnDistribucijaOtcenki.Size = new System.Drawing.Size(232, 41);
            this.btnDistribucijaOtcenki.TabIndex = 12;
            this.btnDistribucijaOtcenki.Text = "Дистрибуција на оценки по предмет";
            this.btnDistribucijaOtcenki.UseVisualStyleBackColor = true;
            this.btnDistribucijaOtcenki.Click += new System.EventHandler(this.btnDistribucijaOtcenki_Click);
            // 
            // btnUceniciSlabiOcenki
            // 
            this.btnUceniciSlabiOcenki.Location = new System.Drawing.Point(882, 647);
            this.btnUceniciSlabiOcenki.Name = "btnUceniciSlabiOcenki";
            this.btnUceniciSlabiOcenki.Size = new System.Drawing.Size(234, 41);
            this.btnUceniciSlabiOcenki.TabIndex = 13;
            this.btnUceniciSlabiOcenki.Text = "Ученици со слаби оценки";
            this.btnUceniciSlabiOcenki.UseVisualStyleBackColor = true;
            this.btnUceniciSlabiOcenki.Click += new System.EventHandler(this.btnUceniciSlabiOcenki_Click);
            // 
            // tbImeNaTabela
            // 
            this.tbImeNaTabela.Location = new System.Drawing.Point(614, 9);
            this.tbImeNaTabela.Name = "tbImeNaTabela";
            this.tbImeNaTabela.Size = new System.Drawing.Size(240, 20);
            this.tbImeNaTabela.TabIndex = 14;
            this.tbImeNaTabela.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 377);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 287);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 690);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbImeNaTabela);
            this.Controls.Add(this.btnUceniciSlabiOcenki);
            this.Controls.Add(this.btnDistribucijaOtcenki);
            this.Controls.Add(this.btnOtstapuvanjePredmet);
            this.Controls.Add(this.btnProsekPredmet);
            this.Controls.Add(this.btnProsekUcenik);
            this.Controls.Add(this.btnProsekKlas);
            this.Controls.Add(this.btnPrezemiPodatoci);
            this.Controls.Add(this.btnSnimiPodatoci);
            this.Controls.Add(this.btnPrezPodatoci);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbUcebnaGodina);
            this.Controls.Add(this.cbTromesecie);
            this.Controls.Add(this.cbKlas);
            this.Controls.Add(this.cbGodinaKlas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGodinaKlas;
        private System.Windows.Forms.ComboBox cbKlas;
        private System.Windows.Forms.ComboBox cbTromesecie;
        private System.Windows.Forms.ComboBox cbUcebnaGodina;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPrezPodatoci;
        private System.Windows.Forms.Button btnSnimiPodatoci;
        private System.Windows.Forms.Button btnPrezemiPodatoci;
        private System.Windows.Forms.Button btnProsekKlas;
        private System.Windows.Forms.Button btnProsekUcenik;
        private System.Windows.Forms.Button btnProsekPredmet;
        private System.Windows.Forms.Button btnOtstapuvanjePredmet;
        private System.Windows.Forms.Button btnDistribucijaOtcenki;
        private System.Windows.Forms.Button btnUceniciSlabiOcenki;
        private System.Windows.Forms.TextBox tbImeNaTabela;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

