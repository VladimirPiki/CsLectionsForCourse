namespace Z68.OcenkiOneToMany
{
    partial class ModalessProsekUcenik
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
            this.lvProsekUcenik = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProsekUcenik
            // 
            this.lvProsekUcenik.HideSelection = false;
            this.lvProsekUcenik.Location = new System.Drawing.Point(58, 21);
            this.lvProsekUcenik.Name = "lvProsekUcenik";
            this.lvProsekUcenik.Size = new System.Drawing.Size(1446, 291);
            this.lvProsekUcenik.TabIndex = 1;
            this.lvProsekUcenik.UseCompatibleStateImageBehavior = false;
            this.lvProsekUcenik.SelectedIndexChanged += new System.EventHandler(this.lvProsekUcenik_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 345);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ucenici";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1496, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // ModalessProsekUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 739);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lvProsekUcenik);
            this.Name = "ModalessProsekUcenik";
            this.Text = "ModalessProsekUcenik";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProsekUcenik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}