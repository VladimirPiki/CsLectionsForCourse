namespace Z74.ClientWinExcelFile
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
            this.btnIspratiExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIspratiExcel
            // 
            this.btnIspratiExcel.Location = new System.Drawing.Point(280, 120);
            this.btnIspratiExcel.Name = "btnIspratiExcel";
            this.btnIspratiExcel.Size = new System.Drawing.Size(175, 86);
            this.btnIspratiExcel.TabIndex = 0;
            this.btnIspratiExcel.Text = "Isprati excel";
            this.btnIspratiExcel.UseVisualStyleBackColor = true;
            this.btnIspratiExcel.Click += new System.EventHandler(this.btnIspratiExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIspratiExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIspratiExcel;
    }
}

