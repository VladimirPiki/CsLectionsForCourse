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
    public partial class ModalessProsekUcenik : Form
    {
        public ModalessProsekUcenik()
        {
            InitializeComponent();
            lvProsekUcenik.View = View.Details;
            lvProsekUcenik.GridLines = true;
            lvProsekUcenik.FullRowSelect = true;

            lvProsekUcenik.Columns.Add("ime na ucenik", 200);
            lvProsekUcenik.Columns.Add("prosek na ucenik", 200);

            string[] arr = new string[2];
            ListViewItem itm;
            for (int i = 0; i < Form1.prosekUcenikIme.Count; i++)
            {
                arr[0] = Form1.prosekUcenikIme[i];
                for (int a = i; a < Form1.prosekUcenikProsek.Count; a++)
                {
                    arr[1] = Form1.prosekUcenikProsek[a];
                    break;
                }
                itm = new ListViewItem(arr);
                lvProsekUcenik.Items.Add(itm);
            }

            for (int i = 0; i < lvProsekUcenik.Items.Count; i++)
            {
                chart1.Series["Ucenici"].Points.AddXY(lvProsekUcenik.Items[i].SubItems[0].Text, lvProsekUcenik.Items[i].SubItems[1].Text);
            }
            chart1.Titles.Add("Tabela so ucenki");
        }

        private void lvProsekUcenik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
