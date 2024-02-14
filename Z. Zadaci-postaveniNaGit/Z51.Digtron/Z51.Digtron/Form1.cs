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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            bool prvoPole = Double.TryParse(textBox1.Text, out a);
            bool vtoroPole=Double.TryParse(textBox2.Text, out b);
            if (prvoPole==true && vtoroPole==true)
            {
                double c = Delenje(a, b);
                MessageBox.Show(c.ToString());
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Dozvoleni se samo brojki");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMnozenje_Click(object sender, EventArgs e)
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

        private void btnOdzemanje_Click(object sender, EventArgs e)
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

        private void btnSobiranje_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            bool prvoPole = Double.TryParse(textBox1.Text, out  a);
            bool vtoroPole = Double.TryParse(textBox2.Text, out  b);
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text+="+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//EDMAKVOO OD VTORIOT KALKULATOR RESHENIE
        {
            List<string> broevi = new List<string>();
            List<double> broevii = new List<double>();
            List<string> operacii= new List<string>();
            double vkupno = 0;
            double resehenie=0;
            double vkupnoReshenie = 0;
            double broj = 0;
            string vrednost = "";
            string operacija="";
            bool napusti=false;
            string cuvajTextBox=txtBox.Text;

            double brojche = 0;
            
            for(int i = 0; i < cuvajTextBox.Length; i++)
            {
      
                if (cuvajTextBox[i] == ('0')|| cuvajTextBox[i] == ('1') || cuvajTextBox[i] == ('2') || cuvajTextBox[i] == ('3') || cuvajTextBox[i] == ('4') || cuvajTextBox[i] == ('5') || cuvajTextBox[i] == ('6') || cuvajTextBox[i] == ('7') || cuvajTextBox[i] == ('8') || cuvajTextBox[i] == ('9')  || cuvajTextBox[i] == (',') || cuvajTextBox[i] == ('/') || cuvajTextBox[i] == ('*') || cuvajTextBox[i] == ('-') || cuvajTextBox[i] == ('+'))
                {
                    if(cuvajTextBox[i] == ('/') || cuvajTextBox[i] == ('*') || cuvajTextBox[i] == ('-') || cuvajTextBox[i] == ('+'))
                    {
                        operacija += cuvajTextBox[i];
                        // break;
     
                        operacii.Add(operacija);
                        broevi.Add(vrednost);
                        operacija = "";
                        vrednost = "";
       
                    }
                    else
                    { 
                         vrednost += cuvajTextBox[i];
                        if (i == cuvajTextBox.Length - 1)
                        {
                            broevi.Add(vrednost);
                        }
                    }
           

                }
                else
                {
                    MessageBox.Show("Vnesete pravilno");
                    txtBox.Clear();
                    napusti = true;
                    break;
                }
             
            }
            if (napusti == false)
            {
                for (int b = 0; b < broevi.Count; b++)
                {
                    bool daliEbroj = Double.TryParse(broevi[b], out broj);
                    if (daliEbroj)
                    {
                        broevii.Add(broj);

                    }
                }
                for (int a = 0; a < broevii.Count; a++)
                {
                    if (a == 0)
                    {
                        vkupnoReshenie = broevii[a];
                    }else if (a == broevii.Count - 1)
                    {
                       for(int j=0;j < operacii.Count; j++)
                        {
                            if (j == operacii.Count - 1)
                            {
                                if (operacii[j] == "/")
                                {
                                    vkupnoReshenie = vkupnoReshenie / broevii[a];

                                }
                                else if (operacii[j] == "*")
                                {
                                    vkupnoReshenie = vkupnoReshenie * broevii[a];

                                }
                                else if (operacii[j] == "-")
                                {
                                    vkupnoReshenie = vkupnoReshenie - broevii[a];

                                }
                                else if (operacii[j] == "+")
                                {
                                    vkupnoReshenie = vkupnoReshenie + broevii[a];

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = a-1; k < operacii.Count; k++)
                        {
                            if (operacii[k] == "/")
                            {
                                vkupnoReshenie = vkupnoReshenie / broevii[a];

                            }
                            else if (operacii[k] == "*")
                            {
                                vkupnoReshenie = vkupnoReshenie * broevii[a];

                            }
                            else if (operacii[k] == "-")
                            {
                                vkupnoReshenie = vkupnoReshenie - broevii[a];

                            }
                            else if (operacii[k] == "+")
                            {
                                vkupnoReshenie = vkupnoReshenie + broevii[a];

                            }

                            break;
                        }
                    }
                  
  
         
                }
            }
            MessageBox.Show(vkupnoReshenie.ToString());



        }

        private void buttonDelenje_Click(object sender, EventArgs e)
        {
            txtBox.Text += "/";
        }

        private void buttonDva_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void buttonEden_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void buttonTri_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void buttonCetiri_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void buttonSest_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void buttonSedum_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void buttonOsum_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void buttonDevet_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void buttonMnozenje_Click(object sender, EventArgs e)
        {
            txtBox.Text += "*";
        }

        private void buttonOdzemanje_Click(object sender, EventArgs e)
        {
            txtBox.Text += "-";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
