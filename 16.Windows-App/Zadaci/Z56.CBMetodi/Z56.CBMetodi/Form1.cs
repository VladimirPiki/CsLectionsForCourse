using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Z56.CBMetodi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double broj;
            bool prvoPole = Double.TryParse(txtBox.Text, out broj);
            if (prvoPole == true)
            {
                listBox.Items.Add(broj);
            }
            else
            {
                MessageBox.Show("Dozvoleni se samo brojki");
            }

        }
        private bool pripagjaFibonaci(double broj)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == broj || vtor == broj)
            {
                pripagja = true;
            }

            while (vtor < broj)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == broj)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }
        private bool Paren(double broj)
        {
            bool paren = false;
            if (broj % 2 == 0)
            {
                paren = true;
            }
            return paren;
        }

        private bool Neparen(double broj)
        {
            bool neparen = false;
            if (broj % 2 != 0)
            {
                neparen = true;
            }
            return neparen;
        }
        private void btnIzberi_Click(object sender, EventArgs e)
        {


            if (cbParni.Checked == true)
            {
                double broj;
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    bool daliebroj = double.TryParse(listBox.Items[i].ToString(), out broj);
                    if (daliebroj)
                    {
                        if (Paren(broj)==true)
                       {
                           listBox.SetSelected(i, true);
                       }
                    }
                }
            }
   

            if (cbNeparni.Checked == true)
            {
                double broj;
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    bool daliebroj = double.TryParse(listBox.Items[i].ToString(), out broj);
                    if (daliebroj)
                    {
                        if (Neparen(broj) == true)
                        {
                            listBox.SetSelected(i, true);
                        }
                    }
                }
            }
     

            if (cbFibonaci.Checked == true)
            {
                double broj;
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    bool daliebroj = double.TryParse(listBox.Items[i].ToString(), out broj);
                    if (daliebroj)
                    {
                        if (pripagjaFibonaci(broj) == true)
                        {
                            listBox.SetSelected(i, true);
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
        }
    }
}
