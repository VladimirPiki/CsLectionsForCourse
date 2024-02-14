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
    public partial class ModalessProsekPredmeti : Form
    {
        public ModalessProsekPredmeti()
        {
            InitializeComponent();

            lvProsekPredmeti.View = View.Details;
            lvProsekPredmeti.GridLines = true;
            lvProsekPredmeti.FullRowSelect = true;

            lvProsekPredmeti.Columns.Add("ime na predmet", 200);
            lvProsekPredmeti.Columns.Add("prosek na predmet", 200);

            string[] arr = new string[2];
            ListViewItem itm;
            for (int i = 0; i < Form1.prosekPredmetIme.Count; i++)
            {
                arr[0] = Form1.prosekPredmetIme[i];
                for (int a = i; a < Form1.prosekPredmetProsek.Count; a++)
                {
                    arr[1] = Form1.prosekPredmetProsek[a];
                    break;
                }
                itm = new ListViewItem(arr);
                lvProsekPredmeti.Items.Add(itm);
            }
        }

        private void lvProsekPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
