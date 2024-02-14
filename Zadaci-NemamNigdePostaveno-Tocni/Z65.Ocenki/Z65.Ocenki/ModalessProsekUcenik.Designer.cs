namespace Z65.Ocenki
{
    partial class ModalessProsekUcenik
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
            this.lvProsekUcenik = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvProsekUcenik
            // 
            this.lvProsekUcenik.HideSelection = false;
            this.lvProsekUcenik.Location = new System.Drawing.Point(47, 13);
            this.lvProsekUcenik.Name = "lvProsekUcenik";
            this.lvProsekUcenik.Size = new System.Drawing.Size(674, 359);
            this.lvProsekUcenik.TabIndex = 0;
            this.lvProsekUcenik.UseCompatibleStateImageBehavior = false;
            this.lvProsekUcenik.SelectedIndexChanged += new System.EventHandler(this.lvProsekUcenik_SelectedIndexChanged);
            // 
            // ModalessProsekUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvProsekUcenik);
            this.Name = "ModalessProsekUcenik";
            this.Text = "ModalessProsekUcenik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProsekUcenik;
    }
}