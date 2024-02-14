namespace Z66.TwoTables
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaticen = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbKlas = new System.Windows.Forms.ComboBox();
            this.cbSmer = new System.Windows.Forms.ComboBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.cbMakedonski = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnPrikaziTabeli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Klas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Smer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Makedonski";
            // 
            // tbMaticen
            // 
            this.tbMaticen.Location = new System.Drawing.Point(124, 54);
            this.tbMaticen.Name = "tbMaticen";
            this.tbMaticen.Size = new System.Drawing.Size(100, 20);
            this.tbMaticen.TabIndex = 8;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(124, 86);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 9;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(124, 122);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 10;
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(124, 154);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(100, 20);
            this.tbMesto.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Vnesi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbKlas
            // 
            this.cbKlas.FormattingEnabled = true;
            this.cbKlas.Items.AddRange(new object[] {
            "A",
            "B",
            "V",
            "G",
            "D"});
            this.cbKlas.Location = new System.Drawing.Point(124, 196);
            this.cbKlas.Name = "cbKlas";
            this.cbKlas.Size = new System.Drawing.Size(121, 21);
            this.cbKlas.TabIndex = 18;
            // 
            // cbSmer
            // 
            this.cbSmer.FormattingEnabled = true;
            this.cbSmer.Items.AddRange(new object[] {
            "Programiranje",
            "Mashinski",
            "Tehnicki"});
            this.cbSmer.Location = new System.Drawing.Point(120, 234);
            this.cbSmer.Name = "cbSmer";
            this.cbSmer.Size = new System.Drawing.Size(121, 21);
            this.cbSmer.TabIndex = 19;
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbPeriod.Location = new System.Drawing.Point(120, 273);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cbPeriod.TabIndex = 20;
            // 
            // cbMakedonski
            // 
            this.cbMakedonski.FormattingEnabled = true;
            this.cbMakedonski.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbMakedonski.Location = new System.Drawing.Point(125, 316);
            this.cbMakedonski.Name = "cbMakedonski";
            this.cbMakedonski.Size = new System.Drawing.Size(121, 21);
            this.cbMakedonski.TabIndex = 21;
            this.cbMakedonski.SelectedIndexChanged += new System.EventHandler(this.cbMakedonski_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(277, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 357);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(887, 44);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(563, 357);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnPrikaziTabeli
            // 
            this.btnPrikaziTabeli.Location = new System.Drawing.Point(701, 420);
            this.btnPrikaziTabeli.Name = "btnPrikaziTabeli";
            this.btnPrikaziTabeli.Size = new System.Drawing.Size(364, 65);
            this.btnPrikaziTabeli.TabIndex = 24;
            this.btnPrikaziTabeli.Text = "Prikazi gi podatocite od bazata";
            this.btnPrikaziTabeli.UseVisualStyleBackColor = true;
            this.btnPrikaziTabeli.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 566);
            this.Controls.Add(this.btnPrikaziTabeli);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbMakedonski);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.cbSmer);
            this.Controls.Add(this.cbKlas);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMesto);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbMaticen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaticen;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbKlas;
        private System.Windows.Forms.ComboBox cbSmer;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.ComboBox cbMakedonski;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnPrikaziTabeli;
    }
}

