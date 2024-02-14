using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.ListViewInternn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ime", 70);
            listView1.Columns.Add("prezime", 120);
            listView1.Columns.Add("godini", 50);

        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPodatoci_Click(object sender, EventArgs e)
        {
            //Add items in the listview

            string[] arr = new string[3];
            ListViewItem itm;

            arr[0] = tbIme.Text;
            arr[1] = tbPrezime.Text;
            arr[2] = tbGodini.Text;

            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

        }
    }
}
