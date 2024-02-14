using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z65.Ocenki
{
    public partial class ModalessSlabiOcenki : Form
    {
        public ModalessSlabiOcenki()
        {
            InitializeComponent();
            lvSlabiOcenki.View = View.Details;
            lvSlabiOcenki.GridLines = true;
            lvSlabiOcenki.FullRowSelect = true;

            lvSlabiOcenki.Columns.Add("ime na ucenik", 200);
            lvSlabiOcenki.Columns.Add("broj na slabi ocenki", 200);

            foreach (string[] arr in Form1.slabiOcenkiLista)
            {
                ListViewItem itm = new ListViewItem(arr[0]);


                for (int i = 1; i < arr.Length; i++)
                {
                    itm.SubItems.Add(arr[i]);
                }

                lvSlabiOcenki.Items.Add(itm);
            }
              for(int i =0; i < lvSlabiOcenki.Items.Count; i++)
            {
                chart1.Series["Ucenici"].Points.AddXY(lvSlabiOcenki.Items[i].SubItems[0].Text, lvSlabiOcenki.Items[i].SubItems[1].Text);
            }
            chart1.Titles.Add("Tabela so ucenki");
        }

        private void lvSlabiOcenki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
