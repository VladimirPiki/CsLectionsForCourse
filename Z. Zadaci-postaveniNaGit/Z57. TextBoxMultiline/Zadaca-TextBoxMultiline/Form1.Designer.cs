namespace Zadaca_TextBoxMultiline
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
            this.txtBcitanje = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBprikazvanje = new System.Windows.Forms.TextBox();
            this.txtBzameniPodstr = new System.Windows.Forms.TextBox();
            this.txtBbrisiPodstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBzameniZbor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rBzamena = new System.Windows.Forms.RadioButton();
            this.rBizbrisi = new System.Windows.Forms.RadioButton();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnVcitvanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBcitanje
            // 
            this.txtBcitanje.Location = new System.Drawing.Point(12, 33);
            this.txtBcitanje.Multiline = true;
            this.txtBcitanje.Name = "txtBcitanje";
            this.txtBcitanje.Size = new System.Drawing.Size(250, 335);
            this.txtBcitanje.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBprikazvanje
            // 
            this.txtBprikazvanje.Location = new System.Drawing.Point(716, 33);
            this.txtBprikazvanje.Multiline = true;
            this.txtBprikazvanje.Name = "txtBprikazvanje";
            this.txtBprikazvanje.Size = new System.Drawing.Size(296, 377);
            this.txtBprikazvanje.TabIndex = 2;
            // 
            // txtBzameniPodstr
            // 
            this.txtBzameniPodstr.Location = new System.Drawing.Point(274, 48);
            this.txtBzameniPodstr.Name = "txtBzameniPodstr";
            this.txtBzameniPodstr.Size = new System.Drawing.Size(135, 20);
            this.txtBzameniPodstr.TabIndex = 3;
            this.txtBzameniPodstr.TextChanged += new System.EventHandler(this.txtBzameniPodstr_TextChanged);
            // 
            // txtBbrisiPodstring
            // 
            this.txtBbrisiPodstring.Location = new System.Drawing.Point(274, 172);
            this.txtBbrisiPodstring.Name = "txtBbrisiPodstring";
            this.txtBbrisiPodstring.Size = new System.Drawing.Size(119, 20);
            this.txtBbrisiPodstring.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekst za vcituvanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tekst za prikazvanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vnesete zbor koj sakate da go zamenite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vnesete zbor za brisenje";
            // 
            // txtBzameniZbor
            // 
            this.txtBzameniZbor.Location = new System.Drawing.Point(553, 48);
            this.txtBzameniZbor.Name = "txtBzameniZbor";
            this.txtBzameniZbor.Size = new System.Drawing.Size(135, 20);
            this.txtBzameniZbor.TabIndex = 9;
            this.txtBzameniZbor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vnesete zbor koj sakate da go zamenite so:";
            // 
            // rBzamena
            // 
            this.rBzamena.AutoSize = true;
            this.rBzamena.Location = new System.Drawing.Point(455, 99);
            this.rBzamena.Name = "rBzamena";
            this.rBzamena.Size = new System.Drawing.Size(85, 17);
            this.rBzamena.TabIndex = 11;
            this.rBzamena.TabStop = true;
            this.rBzamena.Text = "Zameni Zbor";
            this.rBzamena.UseVisualStyleBackColor = true;
            // 
            // rBizbrisi
            // 
            this.rBizbrisi.AutoSize = true;
            this.rBizbrisi.Location = new System.Drawing.Point(455, 200);
            this.rBizbrisi.Name = "rBizbrisi";
            this.rBizbrisi.Size = new System.Drawing.Size(74, 17);
            this.rBizbrisi.TabIndex = 12;
            this.rBizbrisi.TabStop = true;
            this.rBizbrisi.Text = "Izbrisi zbor";
            this.rBizbrisi.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(454, 282);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnVcitvanje
            // 
            this.btnVcitvanje.Location = new System.Drawing.Point(83, 387);
            this.btnVcitvanje.Name = "btnVcitvanje";
            this.btnVcitvanje.Size = new System.Drawing.Size(75, 23);
            this.btnVcitvanje.TabIndex = 14;
            this.btnVcitvanje.Text = "Vcitaj";
            this.btnVcitvanje.UseVisualStyleBackColor = true;
            this.btnVcitvanje.Click += new System.EventHandler(this.btnVcitvanje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.btnVcitvanje);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.rBizbrisi);
            this.Controls.Add(this.rBzamena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBzameniZbor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBbrisiPodstring);
            this.Controls.Add(this.txtBzameniPodstr);
            this.Controls.Add(this.txtBprikazvanje);
            this.Controls.Add(this.txtBcitanje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBcitanje;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBprikazvanje;
        private System.Windows.Forms.TextBox txtBzameniPodstr;
        private System.Windows.Forms.TextBox txtBbrisiPodstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBzameniZbor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBzamena;
        private System.Windows.Forms.RadioButton rBizbrisi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnVcitvanje;
    }
}

