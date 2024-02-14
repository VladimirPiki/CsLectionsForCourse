namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbPromenlivaA = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbSoberi = new System.Windows.Forms.RadioButton();
            this.rbOdzemi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPromenlivaA
            // 
            this.tbPromenlivaA.Location = new System.Drawing.Point(573, 51);
            this.tbPromenlivaA.Name = "tbPromenlivaA";
            this.tbPromenlivaA.Size = new System.Drawing.Size(100, 20);
            this.tbPromenlivaA.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "asdasdasdasd"});
            this.listBox1.Location = new System.Drawing.Point(127, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rbSoberi
            // 
            this.rbSoberi.AutoSize = true;
            this.rbSoberi.Location = new System.Drawing.Point(345, 143);
            this.rbSoberi.Name = "rbSoberi";
            this.rbSoberi.Size = new System.Drawing.Size(55, 17);
            this.rbSoberi.TabIndex = 3;
            this.rbSoberi.TabStop = true;
            this.rbSoberi.Text = "Soberi";
            this.rbSoberi.UseVisualStyleBackColor = true;
            this.rbSoberi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbOdzemi
            // 
            this.rbOdzemi.AutoSize = true;
            this.rbOdzemi.Location = new System.Drawing.Point(486, 143);
            this.rbOdzemi.Name = "rbOdzemi";
            this.rbOdzemi.Size = new System.Drawing.Size(60, 17);
            this.rbOdzemi.TabIndex = 4;
            this.rbOdzemi.TabStop = true;
            this.rbOdzemi.Text = "Odzemi";
            this.rbOdzemi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbOdzemi);
            this.Controls.Add(this.rbSoberi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbPromenlivaA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPromenlivaA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbSoberi;
        private System.Windows.Forms.RadioButton rbOdzemi;
    }
}

