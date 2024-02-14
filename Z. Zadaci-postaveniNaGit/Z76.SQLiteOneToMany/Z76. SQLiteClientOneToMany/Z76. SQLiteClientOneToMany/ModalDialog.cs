using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z76.SQLiteClientOneToMany
{
    public partial class ModalDialog : Form
    {
        public ModalDialog(Dictionary<string, string> chartData)
        {
            InitializeComponent();
            PrikaziChart(chartData);
        }

        private void ModalDialog_Load(object sender, EventArgs e)
        {

        }
        private void PrikaziChart(Dictionary<string, string> chartData)
        {
            foreach (var kvp in chartData)
            {
                chart1.Series["Ucenici"].Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
