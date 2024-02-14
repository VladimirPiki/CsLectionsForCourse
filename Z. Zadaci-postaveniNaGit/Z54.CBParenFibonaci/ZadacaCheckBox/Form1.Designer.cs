namespace ZadacaCheckBox
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
            this.cbParen = new System.Windows.Forms.CheckBox();
            this.cbFibonaci = new System.Windows.Forms.CheckBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnProveri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbParen
            // 
            this.cbParen.AutoSize = true;
            this.cbParen.Location = new System.Drawing.Point(40, 77);
            this.cbParen.Name = "cbParen";
            this.cbParen.Size = new System.Drawing.Size(92, 17);
            this.cbParen.TabIndex = 0;
            this.cbParen.Text = "Brojot e paren";
            this.cbParen.UseVisualStyleBackColor = true;
            this.cbParen.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbFibonaci
            // 
            this.cbFibonaci.AutoSize = true;
            this.cbFibonaci.Location = new System.Drawing.Point(209, 77);
            this.cbFibonaci.Name = "cbFibonaci";
            this.cbFibonaci.Size = new System.Drawing.Size(148, 17);
            this.cbFibonaci.TabIndex = 1;
            this.cbFibonaci.Text = "Brojot pripagja na fibonaci";
            this.cbFibonaci.UseVisualStyleBackColor = true;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(142, 22);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 2;
            // 
            // btnProveri
            // 
            this.btnProveri.Location = new System.Drawing.Point(142, 137);
            this.btnProveri.Name = "btnProveri";
            this.btnProveri.Size = new System.Drawing.Size(75, 23);
            this.btnProveri.TabIndex = 3;
            this.btnProveri.Text = "Proveri";
            this.btnProveri.UseVisualStyleBackColor = true;
            this.btnProveri.Click += new System.EventHandler(this.btnProveri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProveri);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.cbFibonaci);
            this.Controls.Add(this.cbParen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbParen;
        private System.Windows.Forms.CheckBox cbFibonaci;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnProveri;
    }
}

