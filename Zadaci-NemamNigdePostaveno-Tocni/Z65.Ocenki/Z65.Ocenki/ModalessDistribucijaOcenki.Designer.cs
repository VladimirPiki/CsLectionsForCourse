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
            this.SuspendLayout();
            // 
            // lvDistribucijaOcenki
            // 
            this.lvDistribucijaOcenki.HideSelection = false;
            this.lvDistribucijaOcenki.Location = new System.Drawing.Point(12, 24);
            this.lvDistribucijaOcenki.Name = "lvDistribucijaOcenki";
            this.lvDistribucijaOcenki.Size = new System.Drawing.Size(950, 365);
            this.lvDistribucijaOcenki.TabIndex = 0;
            this.lvDistribucijaOcenki.UseCompatibleStateImageBehavior = false;
            this.lvDistribucijaOcenki.SelectedIndexChanged += new System.EventHandler(this.lvDistribucijaOcenki_SelectedIndexChanged);
            // 
            // ModalessDistribucijaOcenki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.lvDistribucijaOcenki);
            this.Name = "ModalessDistribucijaOcenki";
            this.Text = "ModalessDistribucijaOcenki";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDistribucijaOcenki;
    }
}