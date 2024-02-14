using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrojNaRasteckiStringovi_vo_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "abc", "abc", "cdf", "aaaa", "bca", "va", "abca" };
            bool rastecka = false;
            int rasteckiSting = 0;
            foreach (string l in lista)
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
            Console.WriteLine("Vo Listata ima: " + rasteckiSting + " rastecki stingovi");

        }
    }
}
