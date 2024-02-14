namespace Z76.SQLiteClientOneToMany
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
            this.tbPatekaZaBaza = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnIspratiMeil = new System.Windows.Forms.Button();
            this.btnNapraviExcel = new System.Windows.Forms.Button();
            this.cbTromesecie = new System.Windows.Forms.ComboBox();
            this.cbUcebnaGodina = new System.Windows.Forms.ComboBox();
            this.cbSmer = new System.Windows.Forms.ComboBox();
            this.cbKlas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaticenBr = new System.Windows.Forms.TextBox();
            this.btnUceniciSlabiOcenki = new System.Windows.Forms.Button();
            this.btnDistribucijaOtcenki = new System.Windows.Forms.Button();
            this.btnOtstapuvanjePredmet = new System.Windows.Forms.Button();
            this.btnProsekPredmet = new System.Windows.Forms.Button();
            this.btnProsekUcenik = new System.Windows.Forms.Button();
            this.btnProsekKlas = new System.Windows.Forms.Button();
            this.btnPrezemiPodatoci = new System.Windows.Forms.Button();
            this.btnSnimiPodatoci = new System.Windows.Forms.Button();
            this.btnPrezPodatoci = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Client = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPatekaZaBaza
            // 
            this.tbPatekaZaBaza.Location = new System.Drawing.Point(1103, 28);
            this.tbPatekaZaBaza.Name = "tbPatekaZaBaza";
            this.tbPatekaZaBaza.Size = new System.Drawing.Size(217, 20);
            this.tbPatekaZaBaza.TabIndex = 69;
            this.tbPatekaZaBaza.Visible = false;
            this.tbPatekaZaBaza.TextChanged += new System.EventHandler(this.tbPatekaZaBaza_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 489);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 199);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.richTextBox1.WordWrap = false;
            // 
            // btnIspratiMeil
            // 
            this.btnIspratiMeil.Location = new System.Drawing.Point(871, 14);
            this.btnIspratiMeil.Name = "btnIspratiMeil";
            this.btnIspratiMeil.Size = new System.Drawing.Size(203, 46);
            this.btnIspratiMeil.TabIndex = 67;
            this.btnIspratiMeil.Text = "Прати mail";
            this.btnIspratiMeil.UseVisualStyleBackColor = true;
            this.btnIspratiMeil.Click += new System.EventHandler(this.btnIspratiMeil_Click);
            // 
            // btnNapraviExcel
            // 
            this.btnNapraviExcel.Location = new System.Drawing.Point(606, 12);
            this.btnNapraviExcel.Name = "btnNapraviExcel";
            this.btnNapraviExcel.Size = new System.Drawing.Size(215, 46);
            this.btnNapraviExcel.TabIndex = 66;
            this.btnNapraviExcel.Text = "Креирај Excel дадотека ";
            this.btnNapraviExcel.UseVisualStyleBackColor = true;
            this.btnNapraviExcel.Click += new System.EventHandler(this.btnNapraviExcel_Click);
            // 
            // cbTromesecie
            // 
            this.cbTromesecie.FormattingEnabled = true;
            this.cbTromesecie.Items.AddRange(new object[] {
            "prvo",
            "vtoro",
            "treto",
            "cetrvto"});
            this.cbTromesecie.Location = new System.Drawing.Point(114, 253);
            this.cbTromesecie.Name = "cbTromesecie";
            this.cbTromesecie.Size = new System.Drawing.Size(171, 21);
            this.cbTromesecie.TabIndex = 65;
            this.cbTromesecie.Text = "Изберете тромесечие";
            // 
            // cbUcebnaGodina
            // 
            this.cbUcebnaGodina.FormattingEnabled = true;
            this.cbUcebnaGodina.Items.AddRange(new object[] {
            "2021/2022",
            "2022/2023",
            "2023/2024"});
            this.cbUcebnaGodina.Location = new System.Drawing.Point(114, 211);
            this.cbUcebnaGodina.Name = "cbUcebnaGodina";
            this.cbUcebnaGodina.Size = new System.Drawing.Size(171, 21);
            this.cbUcebnaGodina.TabIndex = 64;
            this.cbUcebnaGodina.Text = "Изберете учебна година";
            // 
            // cbSmer
            // 
            this.cbSmer.FormattingEnabled = true;
            this.cbSmer.Items.AddRange(new object[] {
            "EKT",
            "EET",
            "TIM"});
            this.cbSmer.Location = new System.Drawing.Point(114, 172);
            this.cbSmer.Name = "cbSmer";
            this.cbSmer.Size = new System.Drawing.Size(171, 21);
            this.cbSmer.TabIndex = 63;
            this.cbSmer.Text = "Изберете смер";
            // 
            // cbKlas
            // 
            this.cbKlas.FormattingEnabled = true;
            this.cbKlas.Items.AddRange(new object[] {
            "III_1",
            "III_2",
            "III_3"});
            this.cbKlas.Location = new System.Drawing.Point(114, 133);
            this.cbKlas.Name = "cbKlas";
            this.cbKlas.Size = new System.Drawing.Size(171, 21);
            this.cbKlas.TabIndex = 62;
            this.cbKlas.Text = "Изберете клас";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Тромесечие";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Учебна година";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Смер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Клас";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "ЕМБ";
            // 
            // tbMaticenBr
            // 
            this.tbMaticenBr.Location = new System.Drawing.Point(114, 89);
            this.tbMaticenBr.Name = "tbMaticenBr";
            this.tbMaticenBr.Size = new System.Drawing.Size(171, 20);
            this.tbMaticenBr.TabIndex = 56;
            // 
            // btnUceniciSlabiOcenki
            // 
            this.btnUceniciSlabiOcenki.Location = new System.Drawing.Point(887, 647);
            this.btnUceniciSlabiOcenki.Name = "btnUceniciSlabiOcenki";
            this.btnUceniciSlabiOcenki.Size = new System.Drawing.Size(234, 41);
            this.btnUceniciSlabiOcenki.TabIndex = 55;
            this.btnUceniciSlabiOcenki.Text = "Ученици со слаби оценки";
            this.btnUceniciSlabiOcenki.UseVisualStyleBackColor = true;
            this.btnUceniciSlabiOcenki.Click += new System.EventHandler(this.btnUceniciSlabiOcenki_Click);
            // 
            // btnDistribucijaOtcenki
            // 
            this.btnDistribucijaOtcenki.Location = new System.Drawing.Point(606, 647);
            this.btnDistribucijaOtcenki.Name = "btnDistribucijaOtcenki";
            this.btnDistribucijaOtcenki.Size = new System.Drawing.Size(232, 41);
            this.btnDistribucijaOtcenki.TabIndex = 54;
            this.btnDistribucijaOtcenki.Text = "Дистрибуција на оценки по предмет";
            this.btnDistribucijaOtcenki.UseVisualStyleBackColor = true;
            this.btnDistribucijaOtcenki.Click += new System.EventHandler(this.btnDistribucijaOtcenki_Click);
            // 
            // btnOtstapuvanjePredmet
            // 
            this.btnOtstapuvanjePredmet.Location = new System.Drawing.Point(335, 647);
            this.btnOtstapuvanjePredmet.Name = "btnOtstapuvanjePredmet";
            this.btnOtstapuvanjePredmet.Size = new System.Drawing.Size(228, 41);
            this.btnOtstapuvanjePredmet.TabIndex = 53;
            this.btnOtstapuvanjePredmet.Text = "Отстапување по предмети";
            this.btnOtstapuvanjePredmet.UseVisualStyleBackColor = true;
            this.btnOtstapuvanjePredmet.Click += new System.EventHandler(this.btnOtstapuvanjePredmet_Click);
            // 
            // btnProsekPredmet
            // 
            this.btnProsekPredmet.Location = new System.Drawing.Point(887, 575);
            this.btnProsekPredmet.Name = "btnProsekPredmet";
            this.btnProsekPredmet.Size = new System.Drawing.Size(234, 41);
            this.btnProsekPredmet.TabIndex = 52;
            this.btnProsekPredmet.Text = "Просек на предмети";
            this.btnProsekPredmet.UseVisualStyleBackColor = true;
            this.btnProsekPredmet.Click += new System.EventHandler(this.btnProsekPredmet_Click);
            // 
            // btnProsekUcenik
            // 
            this.btnProsekUcenik.Location = new System.Drawing.Point(606, 575);
            this.btnProsekUcenik.Name = "btnProsekUcenik";
            this.btnProsekUcenik.Size = new System.Drawing.Size(243, 41);
            this.btnProsekUcenik.TabIndex = 51;
            this.btnProsekUcenik.Text = "Просек на ученик";
            this.btnProsekUcenik.UseVisualStyleBackColor = true;
            this.btnProsekUcenik.Click += new System.EventHandler(this.btnProsekUcenik_Click);
            // 
            // btnProsekKlas
            // 
            this.btnProsekKlas.Location = new System.Drawing.Point(335, 575);
            this.btnProsekKlas.Name = "btnProsekKlas";
            this.btnProsekKlas.Size = new System.Drawing.Size(228, 41);
            this.btnProsekKlas.TabIndex = 50;
            this.btnProsekKlas.Text = "Просек на класот";
            this.btnProsekKlas.UseVisualStyleBackColor = true;
            this.btnProsekKlas.Click += new System.EventHandler(this.btnProsekKlas_Click);
            // 
            // btnPrezemiPodatoci
            // 
            this.btnPrezemiPodatoci.Location = new System.Drawing.Point(66, 418);
            this.btnPrezemiPodatoci.Name = "btnPrezemiPodatoci";
            this.btnPrezemiPodatoci.Size = new System.Drawing.Size(210, 42);
            this.btnPrezemiPodatoci.TabIndex = 49;
            this.btnPrezemiPodatoci.Text = "Преземи од база";
            this.btnPrezemiPodatoci.UseVisualStyleBackColor = true;
            this.btnPrezemiPodatoci.Click += new System.EventHandler(this.btnPrezemiPodatoci_Click);
            // 
            // btnSnimiPodatoci
            // 
            this.btnSnimiPodatoci.Location = new System.Drawing.Point(66, 362);
            this.btnSnimiPodatoci.Name = "btnSnimiPodatoci";
            this.btnSnimiPodatoci.Size = new System.Drawing.Size(204, 35);
            this.btnSnimiPodatoci.TabIndex = 48;
            this.btnSnimiPodatoci.Text = "Сними во база";
            this.btnSnimiPodatoci.UseVisualStyleBackColor = true;
            this.btnSnimiPodatoci.Click += new System.EventHandler(this.btnSnimiPodatoci_Click);
            // 
            // btnPrezPodatoci
            // 
            this.btnPrezPodatoci.Location = new System.Drawing.Point(335, 12);
            this.btnPrezPodatoci.Name = "btnPrezPodatoci";
            this.btnPrezPodatoci.Size = new System.Drawing.Size(220, 47);
            this.btnPrezPodatoci.TabIndex = 47;
            this.btnPrezPodatoci.Text = "Преземи дадотека";
            this.btnPrezPodatoci.UseVisualStyleBackColor = true;
            this.btnPrezPodatoci.Click += new System.EventHandler(this.btnPrezPodatoci_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(291, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1382, 487);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.Location = new System.Drawing.Point(118, 14);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(146, 55);
            this.Client.TabIndex = 71;
            this.Client.Text = "Client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 33);
            this.button1.TabIndex = 72;
            this.button1.Text = "Iscisti Listview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.tbPatekaZaBaza);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnIspratiMeil);
            this.Controls.Add(this.btnNapraviExcel);
            this.Controls.Add(this.cbTromesecie);
            this.Controls.Add(this.cbUcebnaGodina);
            this.Controls.Add(this.cbSmer);
            this.Controls.Add(this.cbKlas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaticenBr);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPatekaZaBaza;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnIspratiMeil;
        private System.Windows.Forms.Button btnNapraviExcel;
        private System.Windows.Forms.ComboBox cbTromesecie;
        private System.Windows.Forms.ComboBox cbUcebnaGodina;
        private System.Windows.Forms.ComboBox cbSmer;
        private System.Windows.Forms.ComboBox cbKlas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaticenBr;
        private System.Windows.Forms.Button btnUceniciSlabiOcenki;
        private System.Windows.Forms.Button btnDistribucijaOtcenki;
        private System.Windows.Forms.Button btnOtstapuvanjePredmet;
        private System.Windows.Forms.Button btnProsekPredmet;
        private System.Windows.Forms.Button btnProsekUcenik;
        private System.Windows.Forms.Button btnProsekKlas;
        private System.Windows.Forms.Button btnPrezemiPodatoci;
        private System.Windows.Forms.Button btnSnimiPodatoci;
        private System.Windows.Forms.Button btnPrezPodatoci;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.Button button1;
    }
}

