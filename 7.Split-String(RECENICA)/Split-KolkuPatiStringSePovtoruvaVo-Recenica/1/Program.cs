using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    //edna recenica da najdime koj zbor kolku pati se povtoruva
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
            SortedList<string, int> kolkuPati = new SortedList<string, int>();
            List<string> listaZaProverka = new List<string>();
            string recenica = "Vladimir Krstevski 25 MAKEDONIJA Bitola i se naogja vo Bitola Vladimir Krstevski ";
            listaZaProverka = razdeli(recenica);
            for (int i = 0; i < listaZaProverka.Count; i++)// Gi vadime site stringoj od listata stringoj
            {
                if (!kolkuPati.ContainsKey(listaZaProverka[i]))//Ako go nema stringo mu dodelvame vrednost 1
                {
                    kolkuPati[listaZaProverka[i]] = 1;

                }
                else if (kolkuPati.ContainsKey(listaZaProverka[i]))//Ako go ima stringo ja zgolevame vrednosta
                {
                    kolkuPati[listaZaProverka[i]]++;
                }
            }

            foreach (KeyValuePair<string, int> v in kolkuPati)// gi listame dobienite rezulatati od sortiranata lista
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }


            
        }
    }
}
