namespace ListBoxSelect
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnListBox = new System.Windows.Forms.Button();
            this.btnListBoxSelect = new System.Windows.Forms.Button();
            this.lbParni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(31, 60);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(31, 95);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(100, 23);
            this.btnListBox.TabIndex = 2;
            this.btnListBox.Text = "ListBox";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.btnListBox_Click);
            // 
            // btnListBoxSelect
            // 
            this.btnListBoxSelect.Location = new System.Drawing.Point(31, 142);
            this.btnListBoxSelect.Name = "btnListBoxSelect";
            this.btnListBoxSelect.Size = new System.Drawing.Size(100, 23);
            this.btnListBoxSelect.TabIndex = 3;
            this.btnListBoxSelect.Text = "ListBoxSelect";
            this.btnListBoxSelect.UseVisualStyleBackColor = true;
            this.btnListBoxSelect.Click += new System.EventHandler(this.btnListBoxSelect_Click);
            // 
            // lbParni
            // 
            this.lbParni.FormattingEnabled = true;
            this.lbParni.Location = new System.Drawing.Point(539, 74);
            this.lbParni.Name = "lbParni";
            this.lbParni.Size = new System.Drawing.Size(120, 95);
            this.lbParni.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbParni);
            this.Controls.Add(this.btnListBoxSelect);
            this.Controls.Add(this.btnListBox);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnListBox;
        private System.Windows.Forms.Button btnListBoxSelect;
        private System.Windows.Forms.ListBox lbParni;
    }
}

