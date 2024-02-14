using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split
{
    internal class Program
    {
        static List<string> razdeli(string str)
        {
            List<string> list = new List<string>();
            string prazenStr = "";
            string split = " ";
            for (int a = 0; a < str.Length; a++)
            {
                foreach (char s in split)
                {
                    if (str[a] != s)
                    {
                        prazenStr += str[a];
                        if (a == str.Length - 1)
                        {
                            list.Add(prazenStr);
                        }
                    }
                    else
                    {
                        list.Add(prazenStr); ;
                        prazenStr = "";
                    }
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            List<string> listaZaProverka = new List<string>();
            string recenica = "Vladimir Krstevski 25 MAKEDONIJA Bitola";
            listaZaProverka = razdeli(recenica);
            foreach(string l in listaZaProverka)
            {
                Console.WriteLine(l);
            }
        }
    }
}
