namespace Z65.Ocenki
{
    partial class ModalessSlabiOcenki
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
            this.lvSlabiOcenki = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvSlabiOcenki
            // 
            this.lvSlabiOcenki.HideSelection = false;
            this.lvSlabiOcenki.Location = new System.Drawing.Point(40, 36);
            this.lvSlabiOcenki.Name = "lvSlabiOcenki";
            this.lvSlabiOcenki.Size = new System.Drawing.Size(693, 288);
            this.lvSlabiOcenki.TabIndex = 0;
            this.lvSlabiOcenki.UseCompatibleStateImageBehavior = false;
            this.lvSlabiOcenki.SelectedIndexChanged += new System.EventHandler(this.lvSlabiOcenki_SelectedIndexChanged);
            // 
            // ModalessSlabiOcenki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSlabiOcenki);
            this.Name = "ModalessSlabiOcenki";
            this.Text = "ModalessSlabiOcenki";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSlabiOcenki;
    }
}