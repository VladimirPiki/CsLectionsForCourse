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

            lvSlabiOcenki.Columns.Add("ime na predmet", 200);
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
        }

        private void lvSlabiOcenki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
