namespace Z62.UceniciPredmeti
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOtvoriDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lbIminjaPredmeti = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSredenProsekKlas = new System.Windows.Forms.Button();
            this.tbSredenProsekKlas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewProsekPoPredmet = new System.Windows.Forms.ListView();
            this.btnOtstapuvanja = new System.Windows.Forms.Button();
            this.listViewProsekPoUcenici = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewDistribucija = new System.Windows.Forms.ListView();
            this.btnDistribucija = new System.Windows.Forms.Button();
            this.btnProsekPoPredmet = new System.Windows.Forms.Button();
            this.btnProsekUcenik = new System.Windows.Forms.Button();
            this.listViewOtstapvanje = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(23, 30);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(312, 128);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(85, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Izberete dadoteka";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOtvoriDialog
            // 
            this.btnOtvoriDialog.Location = new System.Drawing.Point(85, 217);
            this.btnOtvoriDialog.Name = "btnOtvoriDialog";
            this.btnOtvoriDialog.Size = new System.Drawing.Size(194, 23);
            this.btnOtvoriDialog.TabIndex = 2;
            this.btnOtvoriDialog.Text = "Procitaj podatoci od diaolog";
            this.btnOtvoriDialog.UseVisualStyleBackColor = true;
            this.btnOtvoriDialog.Click += new System.EventHandler(this.btnProcitaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selektirajte da doteka od treeView";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(341, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1208, 238);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbIminjaPredmeti
            // 
            this.lbIminjaPredmeti.FormattingEnabled = true;
            this.lbIminjaPredmeti.Location = new System.Drawing.Point(60, 282);
            this.lbIminjaPredmeti.Name = "lbIminjaPredmeti";
            this.lbIminjaPredmeti.Size = new System.Drawing.Size(214, 82);
            this.lbIminjaPredmeti.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iminja na site predmeti";
            // 
            // btnSredenProsekKlas
            // 
            this.btnSredenProsekKlas.Location = new System.Drawing.Point(383, 296);
            this.btnSredenProsekKlas.Name = "btnSredenProsekKlas";
            this.btnSredenProsekKlas.Size = new System.Drawing.Size(121, 67);
            this.btnSredenProsekKlas.TabIndex = 10;
            this.btnSredenProsekKlas.Text = "Sreden prosek na klasot";
            this.btnSredenProsekKlas.UseVisualStyleBackColor = true;
            this.btnSredenProsekKlas.Click += new System.EventHandler(this.btnSredenProsekKlas_Click);
            // 
            // tbSredenProsekKlas
            // 
            this.tbSredenProsekKlas.Location = new System.Drawing.Point(387, 376);
            this.tbSredenProsekKlas.Name = "tbSredenProsekKlas";
            this.tbSredenProsekKlas.Size = new System.Drawing.Size(117, 20);
            this.tbSredenProsekKlas.TabIndex = 11;
            this.tbSredenProsekKlas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Колку отстапува проеск по предмет од просекот на класот";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listViewProsekPoPredmet
            // 
            this.listViewProsekPoPredmet.HideSelection = false;
            this.listViewProsekPoPredmet.Location = new System.Drawing.Point(12, 417);
            this.listViewProsekPoPredmet.Name = "listViewProsekPoPredmet";
            this.listViewProsekPoPredmet.Size = new System.Drawing.Size(468, 195);
            this.listViewProsekPoPredmet.TabIndex = 15;
            this.listViewProsekPoPredmet.UseCompatibleStateImageBehavior = false;
            // 
            // btnOtstapuvanja
            // 
            this.btnOtstapuvanja.Location = new System.Drawing.Point(557, 296);
            this.btnOtstapuvanja.Name = "btnOtstapuvanja";
            this.btnOtstapuvanja.Size = new System.Drawing.Size(212, 35);
            this.btnOtstapuvanja.TabIndex = 16;
            this.btnOtstapuvanja.Text = "Колку отстапува проеск по предмет од просекот на класот";
            this.btnOtstapuvanja.UseVisualStyleBackColor = true;
            this.btnOtstapuvanja.Click += new System.EventHandler(this.btnOtstapuvanja_Click);
            // 
            // listViewProsekPoUcenici
            // 
            this.listViewProsekPoUcenici.HideSelection = false;
            this.listViewProsekPoUcenici.Location = new System.Drawing.Point(517, 417);
            this.listViewProsekPoUcenici.Name = "listViewProsekPoUcenici";
            this.listViewProsekPoUcenici.Size = new System.Drawing.Size(421, 195);
            this.listViewProsekPoUcenici.TabIndex = 17;
            this.listViewProsekPoUcenici.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Просек по предмет";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Просек по ученик";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Среден просек на класот";
            // 
            // listViewDistribucija
            // 
            this.listViewDistribucija.HideSelection = false;
            this.listViewDistribucija.Location = new System.Drawing.Point(956, 417);
            this.listViewDistribucija.Name = "listViewDistribucija";
            this.listViewDistribucija.Size = new System.Drawing.Size(570, 195);
            this.listViewDistribucija.TabIndex = 22;
            this.listViewDistribucija.UseCompatibleStateImageBehavior = false;
            // 
            // btnDistribucija
            // 
            this.btnDistribucija.Location = new System.Drawing.Point(1184, 618);
            this.btnDistribucija.Name = "btnDistribucija";
            this.btnDistribucija.Size = new System.Drawing.Size(153, 32);
            this.btnDistribucija.TabIndex = 23;
            this.btnDistribucija.Text = "Distribucija otcenki";
            this.btnDistribucija.UseVisualStyleBackColor = true;
            this.btnDistribucija.Click += new System.EventHandler(this.btnDistribucija_Click);
            // 
            // btnProsekPoPredmet
            // 
            this.btnProsekPoPredmet.Location = new System.Drawing.Point(151, 619);
            this.btnProsekPoPredmet.Name = "btnProsekPoPredmet";
            this.btnProsekPoPredmet.Size = new System.Drawing.Size(123, 23);
            this.btnProsekPoPredmet.TabIndex = 24;
            this.btnProsekPoPredmet.Text = "Prosek po predmet";
            this.btnProsekPoPredmet.UseVisualStyleBackColor = true;
            this.btnProsekPoPredmet.Click += new System.EventHandler(this.btnProsekPoPredmet_Click);
            // 
            // btnProsekUcenik
            // 
            this.btnProsekUcenik.Location = new System.Drawing.Point(651, 623);
            this.btnProsekUcenik.Name = "btnProsekUcenik";
            this.btnProsekUcenik.Size = new System.Drawing.Size(193, 23);
            this.btnProsekUcenik.TabIndex = 25;
            this.btnProsekUcenik.Text = "Prosek po ucenik";
            this.btnProsekUcenik.UseVisualStyleBackColor = true;
            this.btnProsekUcenik.Click += new System.EventHandler(this.btnProsekUcenik_Click);
            // 
            // listViewOtstapvanje
            // 
            this.listViewOtstapvanje.HideSelection = false;
            this.listViewOtstapvanje.Location = new System.Drawing.Point(850, 261);
            this.listViewOtstapvanje.Name = "listViewOtstapvanje";
            this.listViewOtstapvanje.Size = new System.Drawing.Size(676, 135);
            this.listViewOtstapvanje.TabIndex = 26;
            this.listViewOtstapvanje.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1181, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Дистрибуција на оценки";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 694);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listViewOtstapvanje);
            this.Controls.Add(this.btnProsekUcenik);
            this.Controls.Add(this.btnProsekPoPredmet);
            this.Controls.Add(this.btnDistribucija);
            this.Controls.Add(this.listViewDistribucija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewProsekPoUcenici);
            this.Controls.Add(this.btnOtstapuvanja);
            this.Controls.Add(this.listViewProsekPoPredmet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSredenProsekKlas);
            this.Controls.Add(this.btnSredenProsekKlas);
            this.Controls.Add(this.lbIminjaPredmeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtvoriDialog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOtvoriDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbIminjaPredmeti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSredenProsekKlas;
        private System.Windows.Forms.TextBox tbSredenProsekKlas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewProsekPoPredmet;
        private System.Windows.Forms.Button btnOtstapuvanja;
        private System.Windows.Forms.ListView listViewProsekPoUcenici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewDistribucija;
        private System.Windows.Forms.Button btnDistribucija;
        private System.Windows.Forms.Button btnProsekPoPredmet;
        private System.Windows.Forms.Button btnProsekUcenik;
        private System.Windows.Forms.ListView listViewOtstapvanje;
        private System.Windows.Forms.Label label7;
    }
}

