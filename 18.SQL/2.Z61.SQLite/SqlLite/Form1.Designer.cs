namespace SqlLite
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbGodini = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikaziPodatoci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(222, 46);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(214, 20);
            this.tbId.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(222, 104);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(214, 20);
            this.tbIme.TabIndex = 2;
            // 
            // tbGodini
            // 
            this.tbGodini.Location = new System.Drawing.Point(222, 226);
            this.tbGodini.Name = "tbGodini";
            this.tbGodini.Size = new System.Drawing.Size(214, 20);
            this.tbGodini.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(222, 164);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(214, 20);
            this.tbPrezime.TabIndex = 4;
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(281, 281);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 5;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(475, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 258);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Godini";
            // 
            // btnPrikaziPodatoci
            // 
            this.btnPrikaziPodatoci.Location = new System.Drawing.Point(222, 330);
            this.btnPrikaziPodatoci.Name = "btnPrikaziPodatoci";
            this.btnPrikaziPodatoci.Size = new System.Drawing.Size(214, 68);
            this.btnPrikaziPodatoci.TabIndex = 11;
            this.btnPrikaziPodatoci.Text = "Prikazi Podatoci";
            this.btnPrikaziPodatoci.UseVisualStyleBackColor = true;
            this.btnPrikaziPodatoci.Click += new System.EventHandler(this.btnPrikaziPodatoci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikaziPodatoci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbGodini);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbGodini;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaziPodatoci;
    }
}

