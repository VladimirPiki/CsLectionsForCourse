namespace Z75.ClientPodatoci
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbGodini = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.Label();
            this.tbPrebarajIme = new System.Windows.Forms.TextBox();
            this.tbPrebarajPrezime = new System.Windows.Forms.TextBox();
            this.tbPrebarajGodini = new System.Windows.Forms.TextBox();
            this.btnPratiPodatoci = new System.Windows.Forms.Button();
            this.btnPrikaziDadoteka = new System.Windows.Forms.Button();
            this.btnPratiOdListview = new System.Windows.Forms.Button();
            this.btnPrebarajIme = new System.Windows.Forms.Button();
            this.btnPrebarajPrezime = new System.Windows.Forms.Button();
            this.btnPrebarajGodini = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbSnimenExcel = new System.Windows.Forms.TextBox();
            this.btnPrebImeSendExcel = new System.Windows.Forms.Button();
            this.tbPrebImeSendExcel = new System.Windows.Forms.TextBox();
            this.btnIscistiListView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godini";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(110, 38);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(136, 20);
            this.tbIme.TabIndex = 4;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(110, 79);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(136, 20);
            this.tbPrezime.TabIndex = 5;
            // 
            // tbGodini
            // 
            this.tbGodini.Location = new System.Drawing.Point(110, 129);
            this.tbGodini.Name = "tbGodini";
            this.tbGodini.Size = new System.Drawing.Size(136, 20);
            this.tbGodini.TabIndex = 6;
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Location = new System.Drawing.Point(895, 9);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(33, 13);
            this.Client.TabIndex = 3;
            this.Client.Text = "Client";
            // 
            // tbPrebarajIme
            // 
            this.tbPrebarajIme.Location = new System.Drawing.Point(1232, 29);
            this.tbPrebarajIme.Name = "tbPrebarajIme";
            this.tbPrebarajIme.Size = new System.Drawing.Size(162, 20);
            this.tbPrebarajIme.TabIndex = 7;
            // 
            // tbPrebarajPrezime
            // 
            this.tbPrebarajPrezime.Location = new System.Drawing.Point(1232, 83);
            this.tbPrebarajPrezime.Name = "tbPrebarajPrezime";
            this.tbPrebarajPrezime.Size = new System.Drawing.Size(162, 20);
            this.tbPrebarajPrezime.TabIndex = 8;
            // 
            // tbPrebarajGodini
            // 
            this.tbPrebarajGodini.Location = new System.Drawing.Point(1232, 141);
            this.tbPrebarajGodini.Name = "tbPrebarajGodini";
            this.tbPrebarajGodini.Size = new System.Drawing.Size(162, 20);
            this.tbPrebarajGodini.TabIndex = 9;
            // 
            // btnPratiPodatoci
            // 
            this.btnPratiPodatoci.Location = new System.Drawing.Point(89, 182);
            this.btnPratiPodatoci.Name = "btnPratiPodatoci";
            this.btnPratiPodatoci.Size = new System.Drawing.Size(157, 23);
            this.btnPratiPodatoci.TabIndex = 10;
            this.btnPratiPodatoci.Text = "Prati Podatoci";
            this.btnPratiPodatoci.UseVisualStyleBackColor = true;
            this.btnPratiPodatoci.Click += new System.EventHandler(this.btnPratiPodatoci_Click);
            // 
            // btnPrikaziDadoteka
            // 
            this.btnPrikaziDadoteka.Location = new System.Drawing.Point(89, 232);
            this.btnPrikaziDadoteka.Name = "btnPrikaziDadoteka";
            this.btnPrikaziDadoteka.Size = new System.Drawing.Size(157, 23);
            this.btnPrikaziDadoteka.TabIndex = 11;
            this.btnPrikaziDadoteka.Text = "Prikazi Dadoteka";
            this.btnPrikaziDadoteka.UseVisualStyleBackColor = true;
            this.btnPrikaziDadoteka.Click += new System.EventHandler(this.btnPrikaziDadoteka_Click);
            // 
            // btnPratiOdListview
            // 
            this.btnPratiOdListview.Location = new System.Drawing.Point(89, 285);
            this.btnPratiOdListview.Name = "btnPratiOdListview";
            this.btnPratiOdListview.Size = new System.Drawing.Size(157, 23);
            this.btnPratiOdListview.TabIndex = 12;
            this.btnPratiOdListview.Text = "Prati od listview";
            this.btnPratiOdListview.UseVisualStyleBackColor = true;
            this.btnPratiOdListview.Click += new System.EventHandler(this.btnPratiOdListview_Click);
            // 
            // btnPrebarajIme
            // 
            this.btnPrebarajIme.Location = new System.Drawing.Point(1065, 27);
            this.btnPrebarajIme.Name = "btnPrebarajIme";
            this.btnPrebarajIme.Size = new System.Drawing.Size(122, 23);
            this.btnPrebarajIme.TabIndex = 13;
            this.btnPrebarajIme.Text = "Prebaraj Po Ime";
            this.btnPrebarajIme.UseVisualStyleBackColor = true;
            this.btnPrebarajIme.Click += new System.EventHandler(this.btnPrebarajIme_Click);
            // 
            // btnPrebarajPrezime
            // 
            this.btnPrebarajPrezime.Location = new System.Drawing.Point(1065, 83);
            this.btnPrebarajPrezime.Name = "btnPrebarajPrezime";
            this.btnPrebarajPrezime.Size = new System.Drawing.Size(122, 23);
            this.btnPrebarajPrezime.TabIndex = 14;
            this.btnPrebarajPrezime.Text = "Prebaraj po Prezime";
            this.btnPrebarajPrezime.UseVisualStyleBackColor = true;
            this.btnPrebarajPrezime.Click += new System.EventHandler(this.btnPrebarajPrezime_Click);
            // 
            // btnPrebarajGodini
            // 
            this.btnPrebarajGodini.Location = new System.Drawing.Point(1065, 141);
            this.btnPrebarajGodini.Name = "btnPrebarajGodini";
            this.btnPrebarajGodini.Size = new System.Drawing.Size(122, 23);
            this.btnPrebarajGodini.TabIndex = 15;
            this.btnPrebarajGodini.Text = "Prebaraj po godini";
            this.btnPrebarajGodini.UseVisualStyleBackColor = true;
            this.btnPrebarajGodini.Click += new System.EventHandler(this.btnPrebarajGodini_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(310, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(721, 347);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbSnimenExcel
            // 
            this.tbSnimenExcel.Location = new System.Drawing.Point(89, 342);
            this.tbSnimenExcel.Name = "tbSnimenExcel";
            this.tbSnimenExcel.Size = new System.Drawing.Size(157, 20);
            this.tbSnimenExcel.TabIndex = 17;
            this.tbSnimenExcel.Visible = false;
            this.tbSnimenExcel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPrebImeSendExcel
            // 
            this.btnPrebImeSendExcel.Location = new System.Drawing.Point(1065, 285);
            this.btnPrebImeSendExcel.Name = "btnPrebImeSendExcel";
            this.btnPrebImeSendExcel.Size = new System.Drawing.Size(122, 23);
            this.btnPrebImeSendExcel.TabIndex = 18;
            this.btnPrebImeSendExcel.Text = "Prebaraj Po Ime";
            this.btnPrebImeSendExcel.UseVisualStyleBackColor = true;
            this.btnPrebImeSendExcel.Visible = false;
            this.btnPrebImeSendExcel.Click += new System.EventHandler(this.btnPrebImeSendExcel_Click);
            // 
            // tbPrebImeSendExcel
            // 
            this.tbPrebImeSendExcel.Location = new System.Drawing.Point(1232, 288);
            this.tbPrebImeSendExcel.Name = "tbPrebImeSendExcel";
            this.tbPrebImeSendExcel.Size = new System.Drawing.Size(162, 20);
            this.tbPrebImeSendExcel.TabIndex = 19;
            this.tbPrebImeSendExcel.Visible = false;
            // 
            // btnIscistiListView
            // 
            this.btnIscistiListView.Location = new System.Drawing.Point(490, 393);
            this.btnIscistiListView.Name = "btnIscistiListView";
            this.btnIscistiListView.Size = new System.Drawing.Size(447, 55);
            this.btnIscistiListView.TabIndex = 20;
            this.btnIscistiListView.Text = "Iscisti ListView";
            this.btnIscistiListView.UseVisualStyleBackColor = true;
            this.btnIscistiListView.Click += new System.EventHandler(this.btnIscistiListView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 608);
            this.Controls.Add(this.btnIscistiListView);
            this.Controls.Add(this.tbPrebImeSendExcel);
            this.Controls.Add(this.btnPrebImeSendExcel);
            this.Controls.Add(this.tbSnimenExcel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPrebarajGodini);
            this.Controls.Add(this.btnPrebarajPrezime);
            this.Controls.Add(this.btnPrebarajIme);
            this.Controls.Add(this.btnPratiOdListview);
            this.Controls.Add(this.btnPrikaziDadoteka);
            this.Controls.Add(this.btnPratiPodatoci);
            this.Controls.Add(this.tbPrebarajGodini);
            this.Controls.Add(this.tbPrebarajPrezime);
            this.Controls.Add(this.tbPrebarajIme);
            this.Controls.Add(this.tbGodini);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbGodini;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.TextBox tbPrebarajIme;
        private System.Windows.Forms.TextBox tbPrebarajPrezime;
        private System.Windows.Forms.TextBox tbPrebarajGodini;
        private System.Windows.Forms.Button btnPratiPodatoci;
        private System.Windows.Forms.Button btnPrikaziDadoteka;
        private System.Windows.Forms.Button btnPratiOdListview;
        private System.Windows.Forms.Button btnPrebarajIme;
        private System.Windows.Forms.Button btnPrebarajPrezime;
        private System.Windows.Forms.Button btnPrebarajGodini;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbSnimenExcel;
        private System.Windows.Forms.Button btnPrebImeSendExcel;
        private System.Windows.Forms.TextBox tbPrebImeSendExcel;
        private System.Windows.Forms.Button btnIscistiListView;
    }
}

