using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    //kako se postavuva item list box na internet
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //1 primer  MessageBox.Show(tbPromenlivaA.Text);

            //2 primer int a = int.Parse(tbPromenlivaA.Text);
            //a++;
            //MessageBox.Show(a.ToString());

            //3 primer
            listBox1.Items.Add(tbPromenlivaA.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
