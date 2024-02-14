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
    public partial class ModalessOtstapuvanjePredmeti : Form
    {
        public ModalessOtstapuvanjePredmeti()
        {
            InitializeComponent();
            lvOtstapuvanjePredmeti.View = View.Details;
            lvOtstapuvanjePredmeti.GridLines = true;
            lvOtstapuvanjePredmeti.FullRowSelect = true;

            lvOtstapuvanjePredmeti.Columns.Add("ime na predmet", 200);
            lvOtstapuvanjePredmeti.Columns.Add("otstapuvanje", 200);

            foreach (string[] arr in Form1.otstapvanjeOcenkiLista)
            {
                ListViewItem itm = new ListViewItem(arr[0]); 

               
                for (int i = 1; i < arr.Length; i++)
                {
                    itm.SubItems.Add(arr[i]);
                }

                lvOtstapuvanjePredmeti.Items.Add(itm);
            }
        }

        private void lvOtstapuvanjePredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
