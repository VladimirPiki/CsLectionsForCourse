using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.MetodaRasteckiStringovi
{
    internal class Program
    {

        List<string> brojNaRasteckiStringovi(string paramString)
        {
            List<string> listaRastecki = new List<string>();
            int brojac = 1;
            string rastecki = "";
            for (int i = 1; i < paramString.Length; i++)
            {

                if (paramString[i] > paramString[i - 1])
                {
                    if (rastecki.Length < 1)
                    {
                        rastecki += paramString[i - 1];
                    }
                    brojac++;
                    rastecki += paramString[i];
                    if (i == paramString.Length - 1)
                    {

                        rastecki += paramString[i];
                        listaRastecki.Add(rastecki);
                    }

                }
                else
                {
                    if (brojac > 0)
                    {

                        listaRastecki.Add(rastecki);

                    }
                    rastecki = "";
                    brojac = 0;
                }


            }
            return listaRastecki;
        }

        static void Main(string[] args)
        {

            string provervajString = "abcdeacdhabacdfaaew";
            List<string> listaRastecki = new List<string>();

            Program obj = new Program();
            listaRastecki = obj.brojNaRasteckiStringovi(provervajString);
            foreach (string l in listaRastecki)
            {
                Console.WriteLine(l);
            }
        }
    }
}
