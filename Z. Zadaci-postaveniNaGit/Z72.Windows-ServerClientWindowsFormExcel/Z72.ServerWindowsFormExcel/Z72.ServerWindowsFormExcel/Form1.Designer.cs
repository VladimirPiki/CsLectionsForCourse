namespace Z72.ServerWindowsFormExcel
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
            this.btnPrimiClient = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnVnesiBaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrimiClient
            // 
            this.btnPrimiClient.Location = new System.Drawing.Point(144, 144);
            this.btnPrimiClient.Name = "btnPrimiClient";
            this.btnPrimiClient.Size = new System.Drawing.Size(421, 78);
            this.btnPrimiClient.TabIndex = 1;
            this.btnPrimiClient.Text = "Primi excel";
            this.btnPrimiClient.UseVisualStyleBackColor = true;
            this.btnPrimiClient.Click += new System.EventHandler(this.btnPrimiClient_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(248, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(252, 20);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Visible = false;
            this.txtFileName.WordWrap = false;
            // 
            // btnVnesiBaza
            // 
            this.btnVnesiBaza.Location = new System.Drawing.Point(23, 12);
            this.btnVnesiBaza.Name = "btnVnesiBaza";
            this.btnVnesiBaza.Size = new System.Drawing.Size(188, 47);
            this.btnVnesiBaza.TabIndex = 4;
            this.btnVnesiBaza.Text = "Dodaj Vo Baza";
            this.btnVnesiBaza.UseVisualStyleBackColor = true;
            this.btnVnesiBaza.Visible = false;
            this.btnVnesiBaza.Click += new System.EventHandler(this.btnVnesiBaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 378);
            this.Controls.Add(this.btnVnesiBaza);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnPrimiClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrimiClient;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnVnesiBaza;
    }
}

