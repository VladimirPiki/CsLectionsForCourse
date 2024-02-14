namespace Z73.ServerWinTextFile
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
            this.btnKomunikacija = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnVnesiListview = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnKomunikacija
            // 
            this.btnKomunikacija.Location = new System.Drawing.Point(222, 21);
            this.btnKomunikacija.Name = "btnKomunikacija";
            this.btnKomunikacija.Size = new System.Drawing.Size(149, 46);
            this.btnKomunikacija.TabIndex = 5;
            this.btnKomunikacija.Text = "Komunikacija";
            this.btnKomunikacija.UseVisualStyleBackColor = true;
            this.btnKomunikacija.Click += new System.EventHandler(this.btnKomunikacija_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 6;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(528, 114);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(176, 20);
            this.tbPath.TabIndex = 11;
            this.tbPath.Visible = false;
            // 
            // btnVnesiListview
            // 
            this.btnVnesiListview.Location = new System.Drawing.Point(814, 21);
            this.btnVnesiListview.Name = "btnVnesiListview";
            this.btnVnesiListview.Size = new System.Drawing.Size(183, 23);
            this.btnVnesiListview.TabIndex = 10;
            this.btnVnesiListview.Text = "Vnesi Vo Listview";
            this.btnVnesiListview.UseVisualStyleBackColor = true;
            this.btnVnesiListview.Click += new System.EventHandler(this.btnVnesiListview_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(126, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1137, 284);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 450);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnVnesiListview);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKomunikacija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKomunikacija;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnVnesiListview;
        private System.Windows.Forms.ListView listView1;
    }
}

