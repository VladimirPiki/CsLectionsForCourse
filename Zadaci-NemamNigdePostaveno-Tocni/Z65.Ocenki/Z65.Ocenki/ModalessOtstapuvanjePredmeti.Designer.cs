namespace Z65.Ocenki
{
    partial class ModalessOtstapuvanjePredmeti
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
            this.lvOtstapuvanjePredmeti = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvOtstapuvanjePredmeti
            // 
            this.lvOtstapuvanjePredmeti.HideSelection = false;
            this.lvOtstapuvanjePredmeti.Location = new System.Drawing.Point(54, 27);
            this.lvOtstapuvanjePredmeti.Name = "lvOtstapuvanjePredmeti";
            this.lvOtstapuvanjePredmeti.Size = new System.Drawing.Size(718, 354);
            this.lvOtstapuvanjePredmeti.TabIndex = 0;
            this.lvOtstapuvanjePredmeti.UseCompatibleStateImageBehavior = false;
            this.lvOtstapuvanjePredmeti.SelectedIndexChanged += new System.EventHandler(this.lvOtstapuvanjePredmeti_SelectedIndexChanged);
            // 
            // ModalessOtstapuvanjePredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvOtstapuvanjePredmeti);
            this.Name = "ModalessOtstapuvanjePredmeti";
            this.Text = "ModalessOtstapuvanjePredmeti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOtstapuvanjePredmeti;
    }
}