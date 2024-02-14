namespace Z55.RBMetodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtSubstr = new System.Windows.Forms.TextBox();
            this.rbDolzinaString = new System.Windows.Forms.RadioButton();
            this.rbDaliPostojPodstring = new System.Windows.Forms.RadioButton();
            this.rbPovtoruvanjeOdredenPodstring = new System.Windows.Forms.RadioButton();
            this.rbBrisiPodstring = new System.Windows.Forms.RadioButton();
            this.rbNajdolgRastPodstr = new System.Windows.Forms.RadioButton();
            this.rbNajdolgOpagjPodstr = new System.Windows.Forms.RadioButton();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesete String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vnesete Substring";
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(68, 61);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(131, 20);
            this.txtStr.TabIndex = 2;
            // 
            // txtSubstr
            // 
            this.txtSubstr.Location = new System.Drawing.Point(288, 61);
            this.txtSubstr.Name = "txtSubstr";
            this.txtSubstr.Size = new System.Drawing.Size(131, 20);
            this.txtSubstr.TabIndex = 3;
            // 
            // rbDolzinaString
            // 
            this.rbDolzinaString.AutoSize = true;
            this.rbDolzinaString.Location = new System.Drawing.Point(68, 119);
            this.rbDolzinaString.Name = "rbDolzinaString";
            this.rbDolzinaString.Size = new System.Drawing.Size(103, 17);
            this.rbDolzinaString.TabIndex = 4;
            this.rbDolzinaString.TabStop = true;
            this.rbDolzinaString.Text = "Dolzina na string";
            this.rbDolzinaString.UseVisualStyleBackColor = true;
            // 
            // rbDaliPostojPodstring
            // 
            this.rbDaliPostojPodstring.AutoSize = true;
            this.rbDaliPostojPodstring.Location = new System.Drawing.Point(68, 162);
            this.rbDaliPostojPodstring.Name = "rbDaliPostojPodstring";
            this.rbDaliPostojPodstring.Size = new System.Drawing.Size(144, 17);
            this.rbDaliPostojPodstring.TabIndex = 5;
            this.rbDaliPostojPodstring.TabStop = true;
            this.rbDaliPostojPodstring.Text = "Dali postoj odreden string";
            this.rbDaliPostojPodstring.UseVisualStyleBackColor = true;
            // 
            // rbPovtoruvanjeOdredenPodstring
            // 
            this.rbPovtoruvanjeOdredenPodstring.AutoSize = true;
            this.rbPovtoruvanjeOdredenPodstring.Location = new System.Drawing.Point(68, 201);
            this.rbPovtoruvanjeOdredenPodstring.Name = "rbPovtoruvanjeOdredenPodstring";
            this.rbPovtoruvanjeOdredenPodstring.Size = new System.Drawing.Size(225, 17);
            this.rbPovtoruvanjeOdredenPodstring.TabIndex = 6;
            this.rbPovtoruvanjeOdredenPodstring.TabStop = true;
            this.rbPovtoruvanjeOdredenPodstring.Text = "Kolku pati se povtoruva odreden podstring";
            this.rbPovtoruvanjeOdredenPodstring.UseVisualStyleBackColor = true;
            // 
            // rbBrisiPodstring
            // 
            this.rbBrisiPodstring.AutoSize = true;
            this.rbBrisiPodstring.Location = new System.Drawing.Point(68, 237);
            this.rbBrisiPodstring.Name = "rbBrisiPodstring";
            this.rbBrisiPodstring.Size = new System.Drawing.Size(136, 17);
            this.rbBrisiPodstring.TabIndex = 7;
            this.rbBrisiPodstring.TabStop = true;
            this.rbBrisiPodstring.Text = "Brise odreden podstring";
            this.rbBrisiPodstring.UseVisualStyleBackColor = true;
            // 
            // rbNajdolgRastPodstr
            // 
            this.rbNajdolgRastPodstr.AutoSize = true;
            this.rbNajdolgRastPodstr.Location = new System.Drawing.Point(68, 272);
            this.rbNajdolgRastPodstr.Name = "rbNajdolgRastPodstr";
            this.rbNajdolgRastPodstr.Size = new System.Drawing.Size(147, 17);
            this.rbNajdolgRastPodstr.TabIndex = 9;
            this.rbNajdolgRastPodstr.TabStop = true;
            this.rbNajdolgRastPodstr.Text = "Najdolg rastecki podstring";
            this.rbNajdolgRastPodstr.UseVisualStyleBackColor = true;
            // 
            // rbNajdolgOpagjPodstr
            // 
            this.rbNajdolgOpagjPodstr.AutoSize = true;
            this.rbNajdolgOpagjPodstr.Location = new System.Drawing.Point(68, 306);
            this.rbNajdolgOpagjPodstr.Name = "rbNajdolgOpagjPodstr";
            this.rbNajdolgOpagjPodstr.Size = new System.Drawing.Size(156, 17);
            this.rbNajdolgOpagjPodstr.TabIndex = 10;
            this.rbNajdolgOpagjPodstr.TabStop = true;
            this.rbNajdolgOpagjPodstr.Text = "Najdolg opagjacki podstring";
            this.rbNajdolgOpagjPodstr.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(68, 358);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(395, 23);
            this.btnPrikazi.TabIndex = 11;
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
            this.Controls.Add(this.rbNajdolgOpagjPodstr);
            this.Controls.Add(this.rbNajdolgRastPodstr);
            this.Controls.Add(this.rbBrisiPodstring);
            this.Controls.Add(this.rbPovtoruvanjeOdredenPodstring);
            this.Controls.Add(this.rbDaliPostojPodstring);
            this.Controls.Add(this.rbDolzinaString);
            this.Controls.Add(this.txtSubstr);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtSubstr;
        private System.Windows.Forms.RadioButton rbDolzinaString;
        private System.Windows.Forms.RadioButton rbDaliPostojPodstring;
        private System.Windows.Forms.RadioButton rbPovtoruvanjeOdredenPodstring;
        private System.Windows.Forms.RadioButton rbBrisiPodstring;
        private System.Windows.Forms.RadioButton rbNajdolgRastPodstr;
        private System.Windows.Forms.RadioButton rbNajdolgOpagjPodstr;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

