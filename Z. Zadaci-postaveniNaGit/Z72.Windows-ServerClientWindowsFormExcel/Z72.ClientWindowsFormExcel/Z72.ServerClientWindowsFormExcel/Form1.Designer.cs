namespace Z72.ServerClientWindowsFormExcel
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
            this.btnIzberiExcel = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtImeNaFajlot = new System.Windows.Forms.TextBox();
            this.btnIspratiNaServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIspratiExcel
            // 
            this.btnIspratiExcel.Location = new System.Drawing.Point(301, 80);
            this.btnIspratiExcel.Name = "btnIspratiExcel";
            this.btnIspratiExcel.Size = new System.Drawing.Size(210, 55);
            this.btnIspratiExcel.TabIndex = 5;
            this.btnIspratiExcel.Text = "Zacuuvaj  Excel";
            this.btnIspratiExcel.UseVisualStyleBackColor = true;
            this.btnIspratiExcel.Click += new System.EventHandler(this.btnIspratiExcel_Click_1);
            // 
            // btnIzberiExcel
            // 
            this.btnIzberiExcel.Location = new System.Drawing.Point(110, 80);
            this.btnIzberiExcel.Name = "btnIzberiExcel";
            this.btnIzberiExcel.Size = new System.Drawing.Size(167, 55);
            this.btnIzberiExcel.TabIndex = 4;
            this.btnIzberiExcel.Text = "Izberi excel dadoteka";
            this.btnIzberiExcel.UseVisualStyleBackColor = true;
            this.btnIzberiExcel.Click += new System.EventHandler(this.btnIzberiExcel_Click_1);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(142, 37);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(248, 20);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtImeNaFajlot
            // 
            this.txtImeNaFajlot.Location = new System.Drawing.Point(471, 37);
            this.txtImeNaFajlot.Name = "txtImeNaFajlot";
            this.txtImeNaFajlot.Size = new System.Drawing.Size(180, 20);
            this.txtImeNaFajlot.TabIndex = 6;
            this.txtImeNaFajlot.Visible = false;
            // 
            // btnIspratiNaServer
            // 
            this.btnIspratiNaServer.Location = new System.Drawing.Point(168, 174);
            this.btnIspratiNaServer.Name = "btnIspratiNaServer";
            this.btnIspratiNaServer.Size = new System.Drawing.Size(263, 55);
            this.btnIspratiNaServer.TabIndex = 7;
            this.btnIspratiNaServer.Text = "Isprati na server";
            this.btnIspratiNaServer.UseVisualStyleBackColor = true;
            this.btnIspratiNaServer.Click += new System.EventHandler(this.btnIspratiNaServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 354);
            this.Controls.Add(this.btnIspratiNaServer);
            this.Controls.Add(this.txtImeNaFajlot);
            this.Controls.Add(this.btnIspratiExcel);
            this.Controls.Add(this.btnIzberiExcel);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIspratiExcel;
        private System.Windows.Forms.Button btnIzberiExcel;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtImeNaFajlot;
        private System.Windows.Forms.Button btnIspratiNaServer;
    }
}

