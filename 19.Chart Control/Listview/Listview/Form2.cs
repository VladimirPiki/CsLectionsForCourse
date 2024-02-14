using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Listview
{
    public partial class Form2 : Form
    {
        public Form2(List<List<string>> data)
        {
            InitializeComponent();
            SetChartData(data);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void SetChartData(List<List<string>> data)
        {
            // Assuming chart1 is the name of your chart control
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "X Axis";
            chart1.ChartAreas[0].AxisY.Title = "Y Axis";

            foreach (List<string> rowData in data)
            {
                string seriesName = rowData[0]; // Assuming the first item is the series name
                Series series = new Series(seriesName);

                // Assuming the other items are numeric values
                for (int i = 1; i < rowData.Count; i++)
                {
                    double value;
                    if (double.TryParse(rowData[i], out value))
                    {
                        series.Points.AddY(value);
                    }
                }

                chart1.Series.Add(series);
            }
        }
    }
}
