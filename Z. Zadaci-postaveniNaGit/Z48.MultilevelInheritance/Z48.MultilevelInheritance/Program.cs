using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * ClassA
Одредува должина на стрингот.
Бара дали постои одреден подстринг.
ClassB
Брои колку пати се повторува одредн подстринг.
Брише одредн подстринг.
ClassC
Најдолг растечки подстринг.
Најдолг опаѓачки подстринг.
Заменува одреден подстринг со друг.
*/

namespace Z48.MultilevelInheritance
{
    class ClassA
    {

        internal string str;

        public int OdreduvaDolzinaString()
        {
            return str.Length;
        }
        public bool DaliPostojOdredenPodstring(string subString)
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
    }
    class ClassB : ClassA
    {

        public int KolkuPatiSePovtoruvaOdredenPodstring(string subString)
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

        public bool BrisiOdredenPodstring(string subString)
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
            //Console.WriteLine(prezapisigo + " PREZAPISAN");
            //Console.WriteLine(orginal + " ORGINAL");
            //    return prezapisigo;
            return daliEizbrisan;
        }
    }

    class ClassC : ClassB
    {
        public ClassC(string s)
        {
            str = s;
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

        public string ZamenuvaOdredenPodstringSoDrug(string subString, string zameni)
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
    class Program
    {
        static void Main(string[] args)
        {
            ClassC Zadaca = new ClassC("Jas sum Vladimir ( vlade ) od bitola i me vikaat vlade");

            Console.WriteLine("Dolzina na string: " + Zadaca.OdreduvaDolzinaString());
            Console.WriteLine();

            if (Zadaca.DaliPostojOdredenPodstring("imi") == true)
            {
                Console.WriteLine("Odredeniot podstring: Postoj");
            }
            else
            {
                Console.WriteLine("Odredeniot podstring: Nepostoj");
            }
            Console.WriteLine();

            Console.WriteLine("Se povtoruva odreden podstring: " + Zadaca.KolkuPatiSePovtoruvaOdredenPodstring("vlade"));
            Console.WriteLine();

            if (Zadaca.BrisiOdredenPodstring("ade"))
            {
                Console.WriteLine("Podstringot e uspeshno izbrishan !!!");
            }
            else
            {
                Console.WriteLine("Ne postoi podstringot vo stringot !!!");

            }
            Console.WriteLine();
            //   Console.WriteLine("Brisi Odreden Podstring: " + Zadaca.BrisiOdredenPodstring("ade"));

            Console.WriteLine("Najdolg Rastecki Podstring: " + Zadaca.NajdolgRasteckiPodstring());
            Console.WriteLine();

            Console.WriteLine("Najdolg Opagjacki Podstring: " + Zadaca.NajdolgOpagjackiPodstring());
            Console.WriteLine();

            Console.WriteLine("Zamenuva Odreden Podstring So Drug: " + Zadaca.ZamenuvaOdredenPodstringSoDrug("."," Piki"));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
