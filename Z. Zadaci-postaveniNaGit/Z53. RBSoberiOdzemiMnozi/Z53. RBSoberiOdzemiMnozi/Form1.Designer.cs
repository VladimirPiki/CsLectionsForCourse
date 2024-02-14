namespace Z53.RBSoberiOdzemiMnozi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbSoberi = new System.Windows.Forms.RadioButton();
            this.rbOdzemi = new System.Windows.Forms.RadioButton();
            this.rbMnozi = new System.Windows.Forms.RadioButton();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // rbSoberi
            // 
            this.rbSoberi.AutoSize = true;
            this.rbSoberi.Location = new System.Drawing.Point(254, 127);
            this.rbSoberi.Name = "rbSoberi";
            this.rbSoberi.Size = new System.Drawing.Size(55, 17);
            this.rbSoberi.TabIndex = 2;
            this.rbSoberi.TabStop = true;
            this.rbSoberi.Text = "Soberi";
            this.rbSoberi.UseVisualStyleBackColor = true;
            // 
            // rbOdzemi
            // 
            this.rbOdzemi.AutoSize = true;
            this.rbOdzemi.Location = new System.Drawing.Point(357, 127);
            this.rbOdzemi.Name = "rbOdzemi";
            this.rbOdzemi.Size = new System.Drawing.Size(60, 17);
            this.rbOdzemi.TabIndex = 3;
            this.rbOdzemi.TabStop = true;
            this.rbOdzemi.Text = "Odzemi";
            this.rbOdzemi.UseVisualStyleBackColor = true;
            // 
            // rbMnozi
            // 
            this.rbMnozi.AutoSize = true;
            this.rbMnozi.Location = new System.Drawing.Point(475, 127);
            this.rbMnozi.Name = "rbMnozi";
            this.rbMnozi.Size = new System.Drawing.Size(53, 17);
            this.rbMnozi.TabIndex = 4;
            this.rbMnozi.TabStop = true;
            this.rbMnozi.Text = "Mnozi";
            this.rbMnozi.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(367, 193);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.rbMnozi);
            this.Controls.Add(this.rbOdzemi);
            this.Controls.Add(this.rbSoberi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbSoberi;
        private System.Windows.Forms.RadioButton rbOdzemi;
        private System.Windows.Forms.RadioButton rbMnozi;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

