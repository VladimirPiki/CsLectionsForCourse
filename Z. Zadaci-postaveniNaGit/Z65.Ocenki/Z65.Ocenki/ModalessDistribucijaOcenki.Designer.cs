namespace Z65.Ocenki
{
    partial class ModalessDistribucijaOcenki
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
            this.lvDistribucijaOcenki = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvDistribucijaOcenki
            // 
            this.lvDistribucijaOcenki.HideSelection = false;
            this.lvDistribucijaOcenki.Location = new System.Drawing.Point(12, 24);
            this.lvDistribucijaOcenki.Name = "lvDistribucijaOcenki";
            this.lvDistribucijaOcenki.Size = new System.Drawing.Size(1446, 279);
            this.lvDistribucijaOcenki.TabIndex = 0;
            this.lvDistribucijaOcenki.UseCompatibleStateImageBehavior = false;
            this.lvDistribucijaOcenki.SelectedIndexChanged += new System.EventHandler(this.lvDistribucijaOcenki_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prikazi Grafikon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadolzitelno selektiraj od listview";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ModalessDistribucijaOcenki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvDistribucijaOcenki);
            this.Name = "ModalessDistribucijaOcenki";
            this.Text = "ModalessDistribucijaOcenki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDistribucijaOcenki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}