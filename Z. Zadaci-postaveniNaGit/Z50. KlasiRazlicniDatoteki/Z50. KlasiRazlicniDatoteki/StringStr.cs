using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z50.KlasiRazlicniDatoteki
{
    internal class StringStr
    {
        /* 
         Одредува должина на стрингот.
	• Бара дали постои одреден подстринг.
	• Брои колку пати се повторува одредн подстринг.
	• Брише одредн подстринг.
	• Заменува одреден подстринг со друг.
        */

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

        public bool BrisiOdredenPodstring(string str, string subString)
        {
            bool daliEizbrisan = false;
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
                daliEizbrisan = false;
            }
            else
            {
                daliEizbrisan = true;
            }
            //PROVERKA DALI E IZBRISAN
            //Console.WriteLine(daliEizbrisan+" izbrisan");
            Console.WriteLine(prezapisigo + " PREZAPISAN");
            Console.WriteLine(orginal + " ORGINAL");
            //    return prezapisigo;
            return daliEizbrisan;
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

    }
}
