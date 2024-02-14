namespace Z74.ServerWinExcelFile
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnZacuvajVoBaza = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1070, 263);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(349, 61);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(185, 20);
            this.filePath.TabIndex = 7;
            this.filePath.Visible = false;
            // 
            // btnZacuvajVoBaza
            // 
            this.btnZacuvajVoBaza.Location = new System.Drawing.Point(668, 52);
            this.btnZacuvajVoBaza.Name = "btnZacuvajVoBaza";
            this.btnZacuvajVoBaza.Size = new System.Drawing.Size(221, 56);
            this.btnZacuvajVoBaza.TabIndex = 8;
            this.btnZacuvajVoBaza.Text = "Selektiraj Listview i zacuvaj vo baza";
            this.btnZacuvajVoBaza.UseVisualStyleBackColor = true;
            this.btnZacuvajVoBaza.Click += new System.EventHandler(this.btnZacuvajVoBaza_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(73, 42);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(157, 51);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "Prikazi excel";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(354, 95);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(179, 20);
            this.tbTableName.TabIndex = 10;
            this.tbTableName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnZacuvajVoBaza);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnZacuvajVoBaza;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox tbTableName;
    }
}

