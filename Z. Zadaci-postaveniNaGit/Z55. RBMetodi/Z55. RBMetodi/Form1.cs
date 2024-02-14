using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z55.RBMetodi
{
    public partial class Form1 : Form
    {
        public int OdreduvaDolzinaString(string str)
        {
            return str.Length;
        }
        public bool DaliPostojOdredenPodstring(string str, string subString)
        {
            bool daliPostoj = false;
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
                    daliPostoj = true;
                    break;
                }
            }
            return daliPostoj;
        }
        public int KolkuPatiSePovtoruvaOdredenPodstring(string str, string subString)
        {
            int kolkuPati = 0;
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
                    kolkuPati++;

                }
            }
            return kolkuPati;
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
        public string NajdolgRasteckiPodstring(string str)
        {
            List<string> listaRastecki = new List<string>();
            string polniLista = "";
            string najdolgRasteckiSubstr = "";
            int rasteckiPodsting = 0;
            int brojac = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] > str[i - 1])
                {
                    brojac++;
                    polniLista += str[i];
                    if (i == str.Length - 1)
                    {
                        rasteckiPodsting++;
                        listaRastecki.Add(polniLista);
                        break;
                    }

                }
                else
                {
                    if (brojac > 1)
                    {
                        rasteckiPodsting++;
                        brojac = 1;
                        listaRastecki.Add(polniLista);
                        polniLista = "";
                    }
                }
            }
            for (int i = 0; i < listaRastecki.Count; i++)
            {
                if (najdolgRasteckiSubstr.Length < listaRastecki[i].Length)
                {
                    najdolgRasteckiSubstr = listaRastecki[i];
                }
            } 
            return najdolgRasteckiSubstr;
        }

        public string NajdolgOpagjackiPodstring(string str)
        {
            List<string> listaOpagjacki = new List<string>();
            string polniLista = "";
            string najdolgOpagjackiSubstr = "";
            int opagjackiPodsting = 0;
            int brojac = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] < str[i - 1])
                {
                    brojac++;
                    polniLista += str[i];
                    if (i == str.Length - 1)
                    {
                        listaOpagjacki.Add(polniLista);
                        opagjackiPodsting++;
                        break;
                    }
                }
                else
                {
                    if (brojac > 1)
                    {
                        opagjackiPodsting++;
                        brojac = 1;
                        listaOpagjacki.Add(polniLista);
                        polniLista = "";
                    }
                }
            }

            for (int i = 0; i < listaOpagjacki.Count; i++)
            {
                if (najdolgOpagjackiSubstr.Length < listaOpagjacki[i].Length)
                {
                    najdolgOpagjackiSubstr = listaOpagjacki[i];
                }
            }
            return najdolgOpagjackiSubstr;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (rbDolzinaString.Checked == true)
            {
                if (txtStr.Text != "")
                {
                    int dolzina = OdreduvaDolzinaString(txtStr.Text);
                    MessageBox.Show(dolzina.ToString());
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String ");
                }

            }
            if (rbDaliPostojPodstring.Checked == true)
            {
                if (txtStr.Text != "" && txtSubstr.Text != "")
                {
                    if (DaliPostojOdredenPodstring(txtStr.Text, txtSubstr.Text))
                    {
                        MessageBox.Show("Substringot sto go vnesivte: " + txtSubstr.Text + " postoi vo stringot: " + txtStr.Text);
                    }
                    else
                    {
                        MessageBox.Show("Substringot sto go vnesivte: " + txtSubstr.Text + " nepostoi vo stringot: " + txtStr.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String i podstring koj sakate da go izbrisite");
                }
               
           
            }
            if (rbPovtoruvanjeOdredenPodstring.Checked == true)
            {
                if (txtStr.Text != "" && txtSubstr.Text != "")
                {
                    int povtorvanjaPodstring = KolkuPatiSePovtoruvaOdredenPodstring(txtStr.Text, txtSubstr.Text);
                    MessageBox.Show(povtorvanjaPodstring.ToString());
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String i podstring koj sakate da go izbrisite");
                }

            }
            if (rbBrisiPodstring.Checked == true)
            {
                if (txtStr.Text != "" && txtSubstr.Text != "")
                {
                    string izbrisanString = BrisiOdredenPodstring(txtStr.Text, txtSubstr.Text);
                    MessageBox.Show(izbrisanString);
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String i podstring koj sakate da go izbrisite");
                }

            }

            if (rbNajdolgRastPodstr.Checked == true)
            {
                if(txtStr.Text != "")
                {
                    MessageBox.Show(NajdolgRasteckiPodstring(txtStr.Text));
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String");
                }

            }

            if (rbNajdolgOpagjPodstr.Checked == true)
            {
                if (txtStr.Text != "")
                {
                    MessageBox.Show(NajdolgOpagjackiPodstring(txtStr.Text));
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete zbor vo poleto za String");
                }
            }
        }
    }
}
