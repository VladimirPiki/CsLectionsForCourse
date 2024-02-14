namespace ModalModeless
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
            this.btnModalDialog = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModelessDialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModalDialog
            // 
            this.btnModalDialog.Location = new System.Drawing.Point(163, 54);
            this.btnModalDialog.Name = "btnModalDialog";
            this.btnModalDialog.Size = new System.Drawing.Size(159, 81);
            this.btnModalDialog.TabIndex = 0;
            this.btnModalDialog.Text = "Modal Dialog";
            this.btnModalDialog.UseVisualStyleBackColor = true;
            this.btnModalDialog.Click += new System.EventHandler(this.btnModalDialog_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnModelessDialog
            // 
            this.btnModelessDialog.Location = new System.Drawing.Point(157, 170);
            this.btnModelessDialog.Name = "btnModelessDialog";
            this.btnModelessDialog.Size = new System.Drawing.Size(165, 127);
            this.btnModelessDialog.TabIndex = 2;
            this.btnModelessDialog.Text = "Modeless Dialog";
            this.btnModelessDialog.UseVisualStyleBackColor = true;
            this.btnModelessDialog.Click += new System.EventHandler(this.btnModelessDialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModelessDialog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModalDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModalDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModelessDialog;
        private System.Windows.Forms.TextBox textBox1;
    }
}

