using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static SortedList<char,int> KolkuZbora(string s)
        {
            SortedList<char, int> kolkuPati = new SortedList<char, int>();
            for (int i = 0; i < s.Length; i++)// listanje na sekoj element od stringo
            {
                if (!kolkuPati.ContainsKey(s[i]))// ako ja nema bukvata dodelimu vrednost 1
                {
                    kolkuPati[s[i]] = 1;
              
                }
                else if (kolkuPati.ContainsKey(s[i]))// ako ja ima bukvata zgolemi mu ja vrednosta
                {
                    kolkuPati[s[i]]++;
                }
            }
            return kolkuPati;
        }
        static void Main(string[] args)
        {

            SortedList<char, int> listaZaProverka = new SortedList<char, int>();
            string recenica = "Vladimir Krstevski 25";
            listaZaProverka = KolkuZbora(recenica);
       

            foreach (KeyValuePair<char, int> v in listaZaProverka)// gi listame dobienite rezulatati od sortiranata lista
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }



        }
    }
}
