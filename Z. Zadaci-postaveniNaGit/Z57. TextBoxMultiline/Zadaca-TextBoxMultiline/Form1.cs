using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_TextBoxMultiline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string BrisiOdredenPodstring(string str, string subString)
        {
            //  bool daliEizbrisan = false;
            string prezapisigo = "";

            for (int i = 0; i <= str.Length - subString.Length; i++)
            {

                bool pronajdeno = true;

                for (int a = 0; a < subString.Length; a++)
                {
                    if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                    {
                        pronajdeno = false;
                        break;
                    }
                }

                if (pronajdeno)
                {
                    i += subString.Length;
                }
                if (i >= str.Length)
                {
                    break;
                }
                prezapisigo += str[i];
            }

            string orginal = "";

            for (int i = 0; i <= str.Length - subString.Length; i++)
            {
                orginal += str[i];
            }

            if (orginal == prezapisigo)
            {
                prezapisigo = str;
                //   daliEizbrisan = false;
            }
            else
            {
                //  daliEizbrisan = true;
            }

            return prezapisigo;
        }

        public string ZamenuvaOdredenPodstringSoDrug(string str, string subString, string zameni)
        {
            string prezapisigo = "";
            bool ifSmenato = false;
            for (int i = 0; i <= str.Length - subString.Length; i++)
            {
                bool pronajdeno = true;

                for (int a = 0; a < subString.Length; a++)
                {
                    if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                    {
                        pronajdeno = false;
                        break;
                    }
                }


                if (pronajdeno)
                {
                    i += subString.Length;
                    for (int a = 0; a < zameni.Length; a++)
                    {
                        prezapisigo += zameni[a];
                    }
                    ifSmenato = true;
                }
                if (i >= str.Length)
                {
                    break;
                }
                prezapisigo += str[i];


            }
            //Console.WriteLine(str);
            if (ifSmenato)
            {
                str = prezapisigo;
            }


            return str;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            //string path = @"c:\temp\Zadaca_TextBoxMultiline.txt";
            //string polniTekst="";
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    s = sr.ReadLine();
            //    polniTekst = s; 
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        polniTekst += s;    
            //      /*  MessageBox.Show(s);*/
              
            //    }

            //}
            //txtBcitanje.Text = polniTekst;
            if (rBizbrisi.Checked == true)
            {
                if (txtBbrisiPodstring.Text != "" && txtBcitanje.Text != "")
                {
                    string izbrisanString = BrisiOdredenPodstring(txtBcitanje.Text, txtBbrisiPodstring.Text);
                    txtBprikazvanje.Text=izbrisanString;
                  //  MessageBox.Show(izbrisanString);
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String i podstring koj sakate da go izbrisite");
                }
            }

            if (rBzamena.Checked == true)
            {
                if (txtBcitanje.Text != "" && txtBzameniPodstr.Text != "" && txtBzameniZbor.Text !="")
                {
                    string zamenetStr = ZamenuvaOdredenPodstringSoDrug(txtBcitanje.Text, txtBzameniPodstr.Text, txtBzameniZbor.Text);
                    txtBprikazvanje.Text = zamenetStr;
                    //  MessageBox.Show(izbrisanString);
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String i podstring koj sakate da go zamenite i podstringot koj sakate da go implementirate");
                }
            }

        }

        private void txtBzameniPodstr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVcitvanje_Click(object sender, EventArgs e)
        {
            string path = @"c:\temp\Zadaca_TextBoxMultiline.txt";
            string polniTekst = "";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                s = sr.ReadLine();
                polniTekst = s;
                while ((s = sr.ReadLine()) != null)
                {
                    polniTekst += s;
                    /*  MessageBox.Show(s);*/

                }

            }
            txtBcitanje.Text = polniTekst;
        }
    }
}
