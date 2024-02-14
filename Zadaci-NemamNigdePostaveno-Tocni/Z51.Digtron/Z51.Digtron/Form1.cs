using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z51.Digtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBox.Text);
            //int a = int.Parse(txtBox.Text);
            //a++;
       //     MessageBox.Show(a.ToString());
            //  listBoxPrikazi.Items.Add(btn1.Text);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(btn1.Text);
            listBoxPrikazi.Items.Add(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(btn1.Text);
            listBoxPrikazi.Items.Add(btn3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdnakvo_Click(object sender, EventArgs e)
        {

        }

        private void listBoxPrikazi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
