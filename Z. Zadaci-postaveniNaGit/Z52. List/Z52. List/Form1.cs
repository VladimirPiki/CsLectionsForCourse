using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z52.List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(txtBox.Text);
        }

        private void btnNajdolgStr_Click(object sender, EventArgs e)
        {
            var listItem = listBox.Items;
            string max = "";
            foreach (string item in listItem) {
                if(max.Length < item.Length)
                {
                    max = item; 
                }
              //  MessageBox.Show(item);
            }
            MessageBox.Show(max);
        }

        private bool pripagjaFibonaci(string zbor)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == zbor.Length || vtor == zbor.Length)
            {
                pripagja = true;
            }

            while (vtor < zbor.Length)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == zbor.Length)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }

        private void btnFibonnaci_Click(object sender, EventArgs e)
        {
            var listItem = listBox.Items;
            List<string> list = new List<string>(); 
            foreach (string item in listItem)
            {
                if (pripagjaFibonaci(item))
                {
                    list.Add(item);
                }
                // 
            }

            MessageBox.Show(string.Join(Environment.NewLine, list));
        }
    }
}
