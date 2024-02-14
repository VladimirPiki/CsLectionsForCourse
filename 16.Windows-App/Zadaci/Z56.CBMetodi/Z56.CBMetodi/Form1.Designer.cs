namespace Z56.CBMetodi
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
            this.cbParni = new System.Windows.Forms.CheckBox();
            this.cbFibonaci = new System.Windows.Forms.CheckBox();
            this.cbNeparni = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIzberi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbParni
            // 
            this.cbParni.AutoSize = true;
            this.cbParni.Location = new System.Drawing.Point(12, 68);
            this.cbParni.Name = "cbParni";
            this.cbParni.Size = new System.Drawing.Size(113, 17);
            this.cbParni.TabIndex = 0;
            this.cbParni.Text = "Broevi koj se parni";
            this.cbParni.UseVisualStyleBackColor = true;
            // 
            // cbFibonaci
            // 
            this.cbFibonaci.AutoSize = true;
            this.cbFibonaci.Location = new System.Drawing.Point(12, 147);
            this.cbFibonaci.Name = "cbFibonaci";
            this.cbFibonaci.Size = new System.Drawing.Size(228, 17);
            this.cbFibonaci.TabIndex = 2;
            this.cbFibonaci.Text = "Broevi koj pripagjaat na listata na fibonacci";
            this.cbFibonaci.UseVisualStyleBackColor = true;
            // 
            // cbNeparni
            // 
            this.cbNeparni.AutoSize = true;
            this.cbNeparni.Location = new System.Drawing.Point(12, 108);
            this.cbNeparni.Name = "cbNeparni";
            this.cbNeparni.Size = new System.Drawing.Size(125, 17);
            this.cbNeparni.TabIndex = 5;
            this.cbNeparni.Text = "Broevi koj se neparni";
            this.cbNeparni.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Izberete Metodi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(373, 40);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(415, 316);
            this.listBox.TabIndex = 8;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(373, 413);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(279, 20);
            this.txtBox.TabIndex = 9;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vnesete broevi vo lista so broevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lista so broevi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(676, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Zacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIzberi
            // 
            this.btnIzberi.Location = new System.Drawing.Point(6, 238);
            this.btnIzberi.Name = "btnIzberi";
            this.btnIzberi.Size = new System.Drawing.Size(235, 23);
            this.btnIzberi.TabIndex = 14;
            this.btnIzberi.Text = "Prikazi";
            this.btnIzberi.UseVisualStyleBackColor = true;
            this.btnIzberi.Click += new System.EventHandler(this.btnIzberi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Prikazi selektirani broevi so vasiot izbor na metodi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Izbrisigi site selektiranite broevi";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Izbrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzberi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNeparni);
            this.Controls.Add(this.cbFibonaci);
            this.Controls.Add(this.cbParni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbParni;
        private System.Windows.Forms.CheckBox cbFibonaci;
        private System.Windows.Forms.CheckBox cbNeparni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIzberi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

