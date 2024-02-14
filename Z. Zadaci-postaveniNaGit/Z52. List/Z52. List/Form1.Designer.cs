namespace Z52.List
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNajdolgStr = new System.Windows.Forms.Button();
            this.btnFibonnaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(136, 115);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(492, 134);
            this.listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stringovi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vnesete string";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(229, 31);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(153, 20);
            this.txtBox.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(410, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Zacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNajdolgStr
            // 
            this.btnNajdolgStr.Location = new System.Drawing.Point(132, 263);
            this.btnNajdolgStr.Name = "btnNajdolgStr";
            this.btnNajdolgStr.Size = new System.Drawing.Size(125, 51);
            this.btnNajdolgStr.TabIndex = 5;
            this.btnNajdolgStr.Text = "Najdolg String";
            this.btnNajdolgStr.UseVisualStyleBackColor = true;
            this.btnNajdolgStr.Click += new System.EventHandler(this.btnNajdolgStr_Click);
            // 
            // btnFibonnaci
            // 
            this.btnFibonnaci.Location = new System.Drawing.Point(503, 263);
            this.btnFibonnaci.Name = "btnFibonnaci";
            this.btnFibonnaci.Size = new System.Drawing.Size(125, 51);
            this.btnFibonnaci.TabIndex = 6;
            this.btnFibonnaci.Text = "Stringovi Fibonnaci";
            this.btnFibonnaci.UseVisualStyleBackColor = true;
            this.btnFibonnaci.Click += new System.EventHandler(this.btnFibonnaci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFibonnaci);
            this.Controls.Add(this.btnNajdolgStr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNajdolgStr;
        private System.Windows.Forms.Button btnFibonnaci;
    }
}

