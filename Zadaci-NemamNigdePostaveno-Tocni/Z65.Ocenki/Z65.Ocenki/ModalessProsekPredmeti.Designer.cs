namespace Z65.Ocenki
{
    partial class ModalessProsekPredmeti
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
            this.lvProsekPredmeti = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvProsekPredmeti
            // 
            this.lvProsekPredmeti.HideSelection = false;
            this.lvProsekPredmeti.Location = new System.Drawing.Point(46, 25);
            this.lvProsekPredmeti.Name = "lvProsekPredmeti";
            this.lvProsekPredmeti.Size = new System.Drawing.Size(695, 309);
            this.lvProsekPredmeti.TabIndex = 0;
            this.lvProsekPredmeti.UseCompatibleStateImageBehavior = false;
            this.lvProsekPredmeti.SelectedIndexChanged += new System.EventHandler(this.lvProsekPredmeti_SelectedIndexChanged);
            // 
            // ModalessProsekPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvProsekPredmeti);
            this.Name = "ModalessProsekPredmeti";
            this.Text = "ModalessProsekPredmeti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProsekPredmeti;
    }
}