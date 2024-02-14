using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProveri_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (checkBox1.Checked == true)
            {
                msg = msg + checkBox1.Name;
            }
            if (checkBox2.Checked == true)
            {
                msg = msg + checkBox2.Name;
            }
            if (checkBox3.Checked == true)
            {
                msg = msg + checkBox3.Name;
            }
            if (checkBox4.Checked == true)
            {
                msg = msg + checkBox4.Name;
            }
            MessageBox.Show(msg);   
        }
    }
}
