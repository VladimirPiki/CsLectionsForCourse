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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ZadacaCheckBox
{// da defnirate dva cek boksa, prv cekbox se vika Brojot e paren, 2 cek box Brojot pripagja na fibonaci, ponatamu treba da postavite eden text box d vensuavate broj, ako e cekiran dali e paren, dokolku se 2ta dali e paren i dali e fibonaci
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool pripagjaFibonaci(double zbor)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == zbor || vtor == zbor)
            {
                pripagja = true;
            }

            while (vtor < zbor)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == zbor)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }

        private void btnProveri_Click(object sender, EventArgs e)
        {
            bool paren=false;
            bool fibonaci=false;
            string msg = "";
            double a;
            bool prvoPole = Double.TryParse(txtB.Text, out a);
            if (prvoPole == true)
            {
                if (cbParen.Checked == true)
                {
                    if(a % 2 == 0)
                    {
                        paren = true;   
                      //  msg = "Brojot sto go vnesivte "+a+" e Paren";
                    }
                    else
                    {
                        paren=false;
                    }
                
                }

                if (cbFibonaci.Checked == true)
                {
                    if (pripagjaFibonaci(a))
                    {
                        fibonaci = true;    
                       // msg = "Brojot sto go vnesivte " + a + " Pripagja na listata fibonaci";
                    }
                    else
                    {
                        fibonaci = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Dozvoleni se samo brojki");
            }
       
            if(paren && fibonaci)
            {
                msg = "Brojot sto go vnesivte " + a + " e Paren i fibonaci";
            }else if(paren && fibonaci == false)
            {
                msg = "Brojot sto go vnesivte " + a + " e Paren";
            }else if(fibonaci && paren == false)
            {
                msg = "Brojot sto go vnesivte " + a + " Pripagja na listata fibonaci";
            }
            else
            {
                msg = "Brojot sto go vnesivte "+a+" ne e paren i ne pripagja na listata na fibonaci";
            }

          
            MessageBox.Show(msg);
        }
    }
}
