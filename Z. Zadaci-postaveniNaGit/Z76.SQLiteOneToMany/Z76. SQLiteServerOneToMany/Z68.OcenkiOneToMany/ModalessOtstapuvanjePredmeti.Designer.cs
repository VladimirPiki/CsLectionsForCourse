namespace Z68.OcenkiOneToMany
{
    partial class ModalessOtstapuvanjePredmeti
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvOtstapuvanjePredmeti = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 199);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ucenici";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1450, 410);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lvOtstapuvanjePredmeti
            // 
            this.lvOtstapuvanjePredmeti.HideSelection = false;
            this.lvOtstapuvanjePredmeti.Location = new System.Drawing.Point(3, 3);
            this.lvOtstapuvanjePredmeti.Name = "lvOtstapuvanjePredmeti";
            this.lvOtstapuvanjePredmeti.Size = new System.Drawing.Size(1440, 190);
            this.lvOtstapuvanjePredmeti.TabIndex = 2;
            this.lvOtstapuvanjePredmeti.UseCompatibleStateImageBehavior = false;
            this.lvOtstapuvanjePredmeti.SelectedIndexChanged += new System.EventHandler(this.lvOtstapuvanjePredmeti_SelectedIndexChanged);
            // 
            // ModalessOtstapuvanjePredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 608);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lvOtstapuvanjePredmeti);
            this.Name = "ModalessOtstapuvanjePredmeti";
            this.Text = "ModalessOtstapuvanjePredmeti";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView lvOtstapuvanjePredmeti;
    }
}