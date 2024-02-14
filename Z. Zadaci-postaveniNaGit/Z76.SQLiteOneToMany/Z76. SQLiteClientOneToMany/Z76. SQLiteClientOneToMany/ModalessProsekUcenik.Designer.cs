namespace Z76.SQLiteClientOneToMany
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvProsekUcenik = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(46, 369);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ucenici";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1496, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // lvProsekUcenik
            // 
            this.lvProsekUcenik.HideSelection = false;
            this.lvProsekUcenik.Location = new System.Drawing.Point(46, 28);
            this.lvProsekUcenik.Name = "lvProsekUcenik";
            this.lvProsekUcenik.Size = new System.Drawing.Size(1446, 291);
            this.lvProsekUcenik.TabIndex = 3;
            this.lvProsekUcenik.UseCompatibleStateImageBehavior = false;
            this.lvProsekUcenik.SelectedIndexChanged += new System.EventHandler(this.lvProsekUcenik_SelectedIndexChanged);
            // 
            // ModalessProsekUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 849);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lvProsekUcenik);
            this.Name = "ModalessProsekUcenik";
            this.Text = "ModalessProsekUcenik";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView lvProsekUcenik;
    }
}