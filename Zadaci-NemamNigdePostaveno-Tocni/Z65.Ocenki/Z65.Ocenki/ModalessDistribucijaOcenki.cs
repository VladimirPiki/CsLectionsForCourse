using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Z65.Ocenki
{
    public partial class ModalessDistribucijaOcenki : Form
    {
        public ModalessDistribucijaOcenki()
        {
            InitializeComponent();
            lvDistribucijaOcenki.View = View.Details;
            lvDistribucijaOcenki.GridLines = true;
            lvDistribucijaOcenki.FullRowSelect = true;

            lvDistribucijaOcenki.Columns.Add("ime na ucenik", 200);
            lvDistribucijaOcenki.Columns.Add("Ocenka 1", 100);
            lvDistribucijaOcenki.Columns.Add("Ocenka 2", 100);
            lvDistribucijaOcenki.Columns.Add("Ocenka 3", 100);
            lvDistribucijaOcenki.Columns.Add("Ocenka 4", 100);
            lvDistribucijaOcenki.Columns.Add("Ocenka 5", 100);

            foreach (string[] arr in Form1.distribucijaOcenkiLista)
            {
                ListViewItem itm = new ListViewItem(arr[0]); // Predmet

                // ocenka
                for (int i = 1; i < arr.Length; i++)
                {
                    itm.SubItems.Add(arr[i]);
                }

                lvDistribucijaOcenki.Items.Add(itm);
            }



        }

        private void lvDistribucijaOcenki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
