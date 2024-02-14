namespace Z75.ServerPodatoci
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
            this.tbGodini = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Server = new System.Windows.Forms.Label();
            this.btnPrebarajGodini = new System.Windows.Forms.Button();
            this.btnPrebarajPrezime = new System.Windows.Forms.Button();
            this.btnPrebarajIme = new System.Windows.Forms.Button();
            this.btnSiteZapisi = new System.Windows.Forms.Button();
            this.tbExcelZaIsprakjanje = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbGodini
            // 
            this.tbGodini.Location = new System.Drawing.Point(125, 133);
            this.tbGodini.Name = "tbGodini";
            this.tbGodini.Size = new System.Drawing.Size(136, 20);
            this.tbGodini.TabIndex = 12;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(125, 83);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(136, 20);
            this.tbPrezime.TabIndex = 11;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(125, 42);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(136, 20);
            this.tbIme.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(363, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(721, 347);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(1046, 9);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 18;
            this.Server.Text = "Server";
            // 
            // btnPrebarajGodini
            // 
            this.btnPrebarajGodini.Location = new System.Drawing.Point(125, 381);
            this.btnPrebarajGodini.Name = "btnPrebarajGodini";
            this.btnPrebarajGodini.Size = new System.Drawing.Size(122, 23);
            this.btnPrebarajGodini.TabIndex = 21;
            this.btnPrebarajGodini.Text = "Prebaraj po godini";
            this.btnPrebarajGodini.UseVisualStyleBackColor = true;
            this.btnPrebarajGodini.Click += new System.EventHandler(this.btnPrebarajGodini_Click);
            // 
            // btnPrebarajPrezime
            // 
            this.btnPrebarajPrezime.Location = new System.Drawing.Point(125, 323);
            this.btnPrebarajPrezime.Name = "btnPrebarajPrezime";
            this.btnPrebarajPrezime.Size = new System.Drawing.Size(122, 23);
            this.btnPrebarajPrezime.TabIndex = 20;
            this.btnPrebarajPrezime.Text = "Prebaraj po Prezime";
            this.btnPrebarajPrezime.UseVisualStyleBackColor = true;
            this.btnPrebarajPrezime.Click += new System.EventHandler(this.btnPrebarajPrezime_Click);
            // 
            // btnPrebarajIme
            // 
            this.btnPrebarajIme.Location = new System.Drawing.Point(125, 267);
            this.btnPrebarajIme.Name = "btnPrebarajIme";
            this.btnPrebarajIme.Size = new System.Drawing.Size(122, 23);
            this.btnPrebarajIme.TabIndex = 19;
            this.btnPrebarajIme.Text = "Prebaraj Po Ime";
            this.btnPrebarajIme.UseVisualStyleBackColor = true;
            this.btnPrebarajIme.Click += new System.EventHandler(this.btnPrebarajIme_Click);
            // 
            // btnSiteZapisi
            // 
            this.btnSiteZapisi.Location = new System.Drawing.Point(125, 210);
            this.btnSiteZapisi.Name = "btnSiteZapisi";
            this.btnSiteZapisi.Size = new System.Drawing.Size(122, 23);
            this.btnSiteZapisi.TabIndex = 22;
            this.btnSiteZapisi.Text = "Site zapisi";
            this.btnSiteZapisi.UseVisualStyleBackColor = true;
            this.btnSiteZapisi.Click += new System.EventHandler(this.btnSiteZapisi_Click);
            // 
            // tbExcelZaIsprakjanje
            // 
            this.tbExcelZaIsprakjanje.Location = new System.Drawing.Point(762, 395);
            this.tbExcelZaIsprakjanje.Name = "tbExcelZaIsprakjanje";
            this.tbExcelZaIsprakjanje.Size = new System.Drawing.Size(226, 20);
            this.tbExcelZaIsprakjanje.TabIndex = 24;
            this.tbExcelZaIsprakjanje.Visible = false;
            this.tbExcelZaIsprakjanje.TextChanged += new System.EventHandler(this.tbExcelZaIsprakjanje_TextChanged);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(486, 438);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(196, 20);
            this.tbFileName.TabIndex = 25;
            this.tbFileName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 551);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.tbExcelZaIsprakjanje);
            this.Controls.Add(this.btnSiteZapisi);
            this.Controls.Add(this.btnPrebarajGodini);
            this.Controls.Add(this.btnPrebarajPrezime);
            this.Controls.Add(this.btnPrebarajIme);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbGodini);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGodini;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Button btnPrebarajGodini;
        private System.Windows.Forms.Button btnPrebarajPrezime;
        private System.Windows.Forms.Button btnPrebarajIme;
        private System.Windows.Forms.Button btnSiteZapisi;
        private System.Windows.Forms.TextBox tbExcelZaIsprakjanje;
        private System.Windows.Forms.TextBox tbFileName;
    }
}

