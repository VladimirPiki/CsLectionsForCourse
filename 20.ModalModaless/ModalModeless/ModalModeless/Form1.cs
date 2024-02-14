using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModeless
{

    public partial class Form1 : Form
    {
        static public string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModalDialog_Click(object sender, EventArgs e)
        {
            ModalDialog obj = new ModalDialog();
            obj.ShowDialog();
        }

        private void btnModelessDialog_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.ToString();
            ModelessDialog obj = new ModelessDialog();
            obj.Show();
        }
    }
}
