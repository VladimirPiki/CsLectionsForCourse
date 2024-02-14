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
    public partial class ModalessDistribucijaOcenki : Form
    {
        public ModalessDistribucijaOcenki()
        {
            InitializeComponent();

            lvDistribucijaOcenki.Items.Clear();

            lvDistribucijaOcenki.View = View.Details;
            lvDistribucijaOcenki.GridLines = true;
            lvDistribucijaOcenki.FullRowSelect = true;

            lvDistribucijaOcenki.Columns.Add("ime na predmet", 200);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvDistribucijaOcenki.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDistribucijaOcenki.SelectedItems[0];
                List<string> listView = new List<string>();
                foreach (ColumnHeader item in lvDistribucijaOcenki.Columns)
                {
                    listView.Add(item.Text);
                }

                Dictionary<string, string> chartData = new Dictionary<string, string>();

                for (int i = 1; i < selectedItem.SubItems.Count; i++)
                {
                    for (int a = i; a < listView.Count; a++)
                    {
                        chartData[listView[a]] = selectedItem.SubItems[i].Text;
                        break;
                    }
                }
                ModalDialog objChartDialog = new ModalDialog(chartData);
                objChartDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selektirajte koj predmet sakate da go vidite od listview ");
            }
        }
    }
}
