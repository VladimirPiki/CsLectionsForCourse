using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*   Дефинирајте класа која меморира string и ги има следниве можности:
Namesapce1
Одредува должина на стрингот.
Бара дали постои одреден подстринг.
Брои колку пати се повторува одредн подстринг.
Брише одредн подстринг.

Namespace2
Најдолг растечки подстринг.
Најдолг опаѓачки подстринг.
Заменува одреден подстринг со друг.*/

namespace first_space
{

    class NamespaceString
    {

        string str;

        public NamespaceString(string str)
        {
            this.str = str;
        }

        public int DolzinaString()
        {
            int lenght = str.Length;
            return lenght;
        }

        public bool DaliPostoiOdredenPodstring(string subString)
        {
            bool pronajdeno = false;
            for (int i = 0; i <= str.Length - subString.Length; i++)
            {
                pronajdeno = true;

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
                    pronajdeno = true;
                    break;
                }

            }
            return pronajdeno;

        }


        public int BrojPovtoruvanjaOdredenPodstring(string subString)
        {
            int kolkuPatiSePovtoruva = 0;
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
                    kolkuPatiSePovtoruva++;
                }

            }
            return kolkuPatiSePovtoruva;
        }

        public bool BrisenjePodstring(string subString)
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
                if(i>= str.Length)
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
          //  Console.WriteLine(daliEizbrisan+" izbrisan");
         //   Console.WriteLine(prezapisigo + " PREZAPISAN");
           // Console.WriteLine(orginal + " ORGINAL");
            //    return prezapisigo;
            return daliEizbrisan;
        }

    }
}

namespace second_space
{

    class NamespaceString
    {
        string str;

        public NamespaceString(string str)
        {
            this.str = str;
        }

        public string NajdolgRasteckiPodstring()
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
            //     Console.WriteLine(rasteckiPodsting);
            for (int i = 0; i < listaRastecki.Count; i++)
            {
                //   Console.WriteLine(listaRastecki[i]);
                if (najdolgRasteckiSubstr.Length < listaRastecki[i].Length)
                {
                    najdolgRasteckiSubstr = listaRastecki[i];
                }
            }
            //  Console.WriteLine();    
            return najdolgRasteckiSubstr;
        }

        public string NajdolgOpagjackiPodstring()
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
            //   Console.WriteLine(opagjackiPodsting);
            foreach (string lR in listaOpagjacki)
            {
                // Console.WriteLine(lR);
                if (najdolgOpagjackiSubstr.Length < lR.Length)
                {
                    najdolgOpagjackiSubstr = lR;
                }
            }
            //Console.WriteLine();
            return najdolgOpagjackiSubstr;
        }

        public string ZamenuvaPodstring(string subString, string zameni)
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
namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            first_space.NamespaceString Prv = new first_space.NamespaceString("Jas sum Vladimir ( vlade ) od bitola i me vikaat vladewfg");

            
            Console.WriteLine(Prv.DolzinaString());

            string subString = "wfg";
            Console.WriteLine(Prv.DaliPostoiOdredenPodstring(subString));

            Console.WriteLine(Prv.BrojPovtoruvanjaOdredenPodstring(subString));

            if (Prv.BrisenjePodstring(subString) == true)
            {
                Console.WriteLine("Podstringot e uspeshno izbrishan !!!");
            }
            else
            {
                Console.WriteLine("Ne postoi podstringot vo stringot !!!");

            }

            Console.WriteLine();


            second_space.NamespaceString Vtor = new second_space.NamespaceString("abcabcabc"); //za rastecka
            Console.WriteLine(Vtor.NajdolgRasteckiPodstring());

            Vtor = new second_space.NamespaceString("dcbahdcbaponmlzgfwwa");//za opagjacka
            Console.WriteLine(Vtor.NajdolgOpagjackiPodstring());

            Vtor = new second_space.NamespaceString("Jas sum Vladimir ( vlade ) od bitola i me vikaat vlade.");
            string baram = ".";
            string zamenvam = "piki";
            Console.WriteLine(Vtor.ZamenuvaPodstring(baram, zamenvam));

        }
    }
}