using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z22.BrojNaRasteckiStringovi
{
    internal class Program
    {

        static int brojNaRasteckiStringovi(string paramString)
        {
            int brojac = 1;
            int rasteckiSting = 0;
            for (int i = 1; i < paramString.Length; i++)
            {

                if (paramString[i] > paramString[i - 1])
                {
                    brojac++;
                    if (i == paramString.Length - 1)
                    {
                        rasteckiSting++;
                    }

                }
                else
                {
                    if (brojac > 0)
                    {
                        rasteckiSting++;

                    }
                    brojac = 0;
                }


            }
            return rasteckiSting;
        }

        static int brojNaRasteckiStringoviVoLista(List<string> lista)
        {
            bool rastecka= false;
            int rasteckiSting = 0;
            foreach(string l in lista)
            {
                for (int i = 1; i < l.Length; i++)
                {

                    if (l[i] > l[i - 1])
                    {
                        rastecka = true;
                    }
                    else
                    {
                        rastecka = false;
                        break;
                    }

                }
                if (rastecka)
                {
                    rasteckiSting++;
                }
            }
           
            return rasteckiSting;
        }

        static void Main(string[] args)
        {
            /////////////////////////   1    2  3   4   5
            string provervajString = "abcdeacdhabacdfaaew";

            Console.WriteLine("Vo stringot ima: "+ brojNaRasteckiStringovi(provervajString)+" rastecki stingovi");

            List<string> lista =new List<string>() { "abc", "abc", "cdf", "aaaa", "bca", "va","abca"};

            Console.WriteLine("Vo Listata ima: " + brojNaRasteckiStringoviVoLista(lista) + " rastecki stingovi");


        }
    }
}
