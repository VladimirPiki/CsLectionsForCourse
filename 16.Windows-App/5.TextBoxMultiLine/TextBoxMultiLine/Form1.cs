using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxMultiLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGetText_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Clear();
            textBox1.Text = str + "gdfhjklhgfh";
        }
    }
}
