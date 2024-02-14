using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview
{
    public partial class Form1 : Form
    {
        public List<List<string>> list;
        public Form1()
        {
            InitializeComponent();

            list = new List<List<string>>();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Plc", 100);
            listView1.Columns.Add("X", 100);
            listView1.Columns.Add("Y", 100);
            listView1.Columns.Add("Z", 100);


            string[] arr = new string[4];
            ListViewItem itm;

            arr[0] = "test1";
            arr[1] = "2";
            arr[2] = "1";
            arr[3] = "3";

            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            ListViewItem itm;

            arr[0] = "test2";
            arr[1] = "4";
            arr[2] = "4";
            arr[3] = "1";

            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            string[] arr1 = new string[4];
            ListViewItem itm1;

            arr1[0] = "test3";
            arr1[1] = "3";
            arr1[2] = "3";
            arr1[3] = "5";

            itm1 = new ListViewItem(arr1);
            listView1.Items.Add(itm1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                List<string> rowData = new List<string>();

                // Extract data from each sub-item in the row
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    rowData.Add(subItem.Text);
                }

                // Add the row data list to the main list
                list.Add(rowData);
            }

            // Print the result to the console (for testing purposes)
            foreach (List<string> rowDataList in list)
            {
                
                MessageBox.Show(string.Join(", ", rowDataList));
            }
            Form2 obj = new Form2(list);    
            obj.ShowDialog();
        }
    }
}
