using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the SelectionMode to select multiple items.
            lbParni.SelectionMode = SelectionMode.MultiExtended;

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(listBox1.SelectedItem.ToString());
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBox.Text.ToString());
            lbParni.Items.Add(txtBox.Text);
        }

        private void btnListBoxSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbParni.Items.Count; i++)
            {
                if (i % 2 == 0)
                    lbParni.SetSelected(i, true);
            }
        }
    }
}
