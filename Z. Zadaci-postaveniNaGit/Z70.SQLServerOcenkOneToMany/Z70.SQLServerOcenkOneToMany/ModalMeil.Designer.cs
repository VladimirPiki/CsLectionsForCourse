namespace Z70.SQLServerOcenkOneToMany
{
    partial class ModalMeil
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tbPathOfExcel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMeilTo = new System.Windows.Forms.TextBox();
            this.btnSendMeil = new System.Windows.Forms.Button();
            this.btnOpenFileForAttach = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMeilMessage = new System.Windows.Forms.RichTextBox();
            this.tbMelSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // tbPathOfExcel
            // 
            this.tbPathOfExcel.Location = new System.Drawing.Point(633, 426);
            this.tbPathOfExcel.Name = "tbPathOfExcel";
            this.tbPathOfExcel.Size = new System.Drawing.Size(201, 20);
            this.tbPathOfExcel.TabIndex = 65;
            this.tbPathOfExcel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(625, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Vnesete email na koj sakate da go ispratite";
            // 
            // tbMeilTo
            // 
            this.tbMeilTo.Location = new System.Drawing.Point(628, 98);
            this.tbMeilTo.Name = "tbMeilTo";
            this.tbMeilTo.Size = new System.Drawing.Size(206, 20);
            this.tbMeilTo.TabIndex = 63;
            // 
            // btnSendMeil
            // 
            this.btnSendMeil.Location = new System.Drawing.Point(633, 463);
            this.btnSendMeil.Name = "btnSendMeil";
            this.btnSendMeil.Size = new System.Drawing.Size(189, 108);
            this.btnSendMeil.TabIndex = 62;
            this.btnSendMeil.Text = "Ispratete nov meil so izbiranje na dadotekata";
            this.btnSendMeil.UseVisualStyleBackColor = true;
            this.btnSendMeil.Click += new System.EventHandler(this.btnSendMeil_Click);
            // 
            // btnOpenFileForAttach
            // 
            this.btnOpenFileForAttach.Location = new System.Drawing.Point(647, 391);
            this.btnOpenFileForAttach.Name = "btnOpenFileForAttach";
            this.btnOpenFileForAttach.Size = new System.Drawing.Size(160, 23);
            this.btnOpenFileForAttach.TabIndex = 61;
            this.btnOpenFileForAttach.Text = "Izberete dadoteka";
            this.btnOpenFileForAttach.UseVisualStyleBackColor = true;
            this.btnOpenFileForAttach.Click += new System.EventHandler(this.btnOpenFileForAttach_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Message";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(699, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Subject";
            // 
            // tbMeilMessage
            // 
            this.tbMeilMessage.Location = new System.Drawing.Point(618, 226);
            this.tbMeilMessage.Name = "tbMeilMessage";
            this.tbMeilMessage.Size = new System.Drawing.Size(205, 150);
            this.tbMeilMessage.TabIndex = 58;
            this.tbMeilMessage.Text = "";
            // 
            // tbMelSubject
            // 
            this.tbMelSubject.Location = new System.Drawing.Point(628, 165);
            this.tbMelSubject.Name = "tbMelSubject";
            this.tbMelSubject.Size = new System.Drawing.Size(206, 20);
            this.tbMelSubject.TabIndex = 57;
            // 
            // ModalMeil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 647);
            this.Controls.Add(this.tbPathOfExcel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbMeilTo);
            this.Controls.Add(this.btnSendMeil);
            this.Controls.Add(this.btnOpenFileForAttach);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbMeilMessage);
            this.Controls.Add(this.tbMelSubject);
            this.Name = "ModalMeil";
            this.Text = "ModalMeil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox tbPathOfExcel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMeilTo;
        private System.Windows.Forms.Button btnSendMeil;
        private System.Windows.Forms.Button btnOpenFileForAttach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox tbMeilMessage;
        private System.Windows.Forms.TextBox tbMelSubject;
    }
}