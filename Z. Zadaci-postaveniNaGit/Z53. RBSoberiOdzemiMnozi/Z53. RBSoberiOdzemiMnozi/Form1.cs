using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z53.RBSoberiOdzemiMnozi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Mnozenje(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public double Odzemanje(double a, double b)
        {
            double c = a - b;
            return c;
        }
        public double Sobiranje(double a, double b)
        {
            double c = a + b;
            return c;
        }
        private void btnPrikazi_Click(object sender, EventArgs e)
        {

            if (rbSoberi.Checked == true)
            {

                double a;
                double b;
                bool prvoPole = Double.TryParse(textBox1.Text, out a);
                bool vtoroPole = Double.TryParse(textBox2.Text, out b);
                if (prvoPole == true && vtoroPole == true)
                {
                    double c = Sobiranje(a, b);
                    MessageBox.Show(c.ToString());
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Dozvoleni se samo brojki");
                }
            }
            if (rbOdzemi.Checked == true)
            {
                double a;
                double b;
                bool prvoPole = Double.TryParse(textBox1.Text, out a);
                bool vtoroPole = Double.TryParse(textBox2.Text, out b);
                if (prvoPole == true && vtoroPole == true)
                {
                    double c = Odzemanje(a, b);
                    MessageBox.Show(c.ToString());
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Dozvoleni se samo brojki");
                }
            }
            if (rbMnozi.Checked == true)
            {
                double a;
                double b;
                bool prvoPole = Double.TryParse(textBox1.Text, out a);
                bool vtoroPole = Double.TryParse(textBox2.Text, out b);
                if (prvoPole == true && vtoroPole == true)
                {
                    double c = Mnozenje(a, b);
                    MessageBox.Show(c.ToString());
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Dozvoleni se samo brojki");
                }
            }
        }
    }
}
