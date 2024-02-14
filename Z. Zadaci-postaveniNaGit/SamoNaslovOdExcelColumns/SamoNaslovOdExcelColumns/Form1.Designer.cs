namespace SamoNaslovOdExcelColumns
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
            this.btnProcitajPodatoci = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPrikaziBaza = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnProcitajPodatoci
            // 
            this.btnProcitajPodatoci.Location = new System.Drawing.Point(54, 48);
            this.btnProcitajPodatoci.Name = "btnProcitajPodatoci";
            this.btnProcitajPodatoci.Size = new System.Drawing.Size(194, 23);
            this.btnProcitajPodatoci.TabIndex = 3;
            this.btnProcitajPodatoci.Text = "Procitaj podatoci od excel";
            this.btnProcitajPodatoci.UseVisualStyleBackColor = true;
            this.btnProcitajPodatoci.Click += new System.EventHandler(this.btnProcitajPodatoci_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPrikaziBaza
            // 
            this.btnPrikaziBaza.Location = new System.Drawing.Point(426, 48);
            this.btnPrikaziBaza.Name = "btnPrikaziBaza";
            this.btnPrikaziBaza.Size = new System.Drawing.Size(243, 23);
            this.btnPrikaziBaza.TabIndex = 4;
            this.btnPrikaziBaza.Text = "Prikazi ja Bazata";
            this.btnPrikaziBaza.UseVisualStyleBackColor = true;
            this.btnPrikaziBaza.Click += new System.EventHandler(this.btnPrikaziBaza_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1408, 397);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 700);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPrikaziBaza);
            this.Controls.Add(this.btnProcitajPodatoci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcitajPodatoci;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPrikaziBaza;
        private System.Windows.Forms.ListView listView1;
    }
}

