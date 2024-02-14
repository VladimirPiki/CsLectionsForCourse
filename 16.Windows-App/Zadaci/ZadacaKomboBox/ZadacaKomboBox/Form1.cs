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

namespace ZadacaKomboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Delenje(double a, double b)
        {
            double c = a / b;
            return c;
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


        private void button1_Click(object sender, EventArgs e)
        {
            string izbor = comboBox1.Text;
            double a;
            double b;
            double c;
            bool prvoPole = Double.TryParse(textBox1.Text, out a);
            bool vtoroPole = Double.TryParse(textBox2.Text, out b);
            if (prvoPole == true && vtoroPole == true)
            {
                if (izbor == "Delenje")
                {
                    c = Delenje(a, b);
                    MessageBox.Show(c.ToString());
                }
                else if(izbor == "Mnozenje")
                {
                   c = Mnozenje(a, b);
                    MessageBox.Show(c.ToString());
                }
                else if (izbor == "Sobiranje")
                {
                     c = Sobiranje(a, b);
                    MessageBox.Show(c.ToString());
                }
                else if (izbor == "Odzemanje")
                {
                     c = Odzemanje(a, b);
                    MessageBox.Show(c.ToString());
                }
                
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
