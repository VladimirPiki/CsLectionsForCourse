namespace Z68.SQLServer
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxGodini = new System.Windows.Forms.TextBox();
            this.btnBaza = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btIme = new System.Windows.Forms.Button();
            this.btnPrezime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(125, 58);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(295, 20);
            this.txtBoxIme.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(233, 213);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(568, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 331);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(125, 113);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(295, 20);
            this.txtBoxPrezime.TabIndex = 3;
            // 
            // txtBoxGodini
            // 
            this.txtBoxGodini.Location = new System.Drawing.Point(125, 159);
            this.txtBoxGodini.Name = "txtBoxGodini";
            this.txtBoxGodini.Size = new System.Drawing.Size(295, 20);
            this.txtBoxGodini.TabIndex = 4;
            // 
            // btnBaza
            // 
            this.btnBaza.Location = new System.Drawing.Point(379, 231);
            this.btnBaza.Name = "btnBaza";
            this.btnBaza.Size = new System.Drawing.Size(166, 66);
            this.btnBaza.TabIndex = 5;
            this.btnBaza.Text = "Prikazi Sostojba na Baza";
            this.btnBaza.UseVisualStyleBackColor = true;
            this.btnBaza.Click += new System.EventHandler(this.btnBaza_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(12, 318);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(135, 44);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Godini";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godini";
            // 
            // btIme
            // 
            this.btIme.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btIme.Location = new System.Drawing.Point(198, 318);
            this.btIme.Name = "btIme";
            this.btIme.Size = new System.Drawing.Size(110, 44);
            this.btIme.TabIndex = 10;
            this.btIme.Text = "Ime";
            this.btIme.UseVisualStyleBackColor = true;
            this.btIme.Click += new System.EventHandler(this.btIme_Click);
            // 
            // btnPrezime
            // 
            this.btnPrezime.Location = new System.Drawing.Point(338, 318);
            this.btnPrezime.Name = "btnPrezime";
            this.btnPrezime.Size = new System.Drawing.Size(110, 44);
            this.btnPrezime.TabIndex = 11;
            this.btnPrezime.Text = "Ime i Prezime";
            this.btnPrezime.UseVisualStyleBackColor = true;
            this.btnPrezime.Click += new System.EventHandler(this.btnPrezime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.btnPrezime);
            this.Controls.Add(this.btIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnBaza);
            this.Controls.Add(this.txtBoxGodini);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtBoxIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxGodini;
        private System.Windows.Forms.Button btnBaza;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btIme;
        private System.Windows.Forms.Button btnPrezime;
    }
}

