namespace ClientPrimer
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
            this.C = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnTextFile = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnKomunikacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(618, 92);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(33, 13);
            this.C.TabIndex = 9;
            this.C.Text = "Client";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(150, 322);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(168, 37);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "ExcelFile";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTextFile
            // 
            this.btnTextFile.Location = new System.Drawing.Point(150, 255);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(168, 37);
            this.btnTextFile.TabIndex = 7;
            this.btnTextFile.Text = "TextFile";
            this.btnTextFile.UseVisualStyleBackColor = true;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(150, 204);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(168, 20);
            this.txtBox.TabIndex = 6;
            // 
            // btnKomunikacija
            // 
            this.btnKomunikacija.Location = new System.Drawing.Point(150, 118);
            this.btnKomunikacija.Name = "btnKomunikacija";
            this.btnKomunikacija.Size = new System.Drawing.Size(145, 55);
            this.btnKomunikacija.TabIndex = 5;
            this.btnKomunikacija.Text = "Komunikacija";
            this.btnKomunikacija.UseVisualStyleBackColor = true;
            this.btnKomunikacija.Click += new System.EventHandler(this.btnKomunikacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.C);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTextFile);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnKomunikacija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnTextFile;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnKomunikacija;
    }
}

