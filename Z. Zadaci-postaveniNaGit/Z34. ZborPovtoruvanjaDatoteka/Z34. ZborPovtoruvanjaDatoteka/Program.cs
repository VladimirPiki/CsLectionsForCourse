using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z34.ZborPovtoruvanjaDatoteka
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

        static SortedList<string, int> IzborZboroviVoRecenica(List<string> listaZaProverka)
        {
            SortedList<string, int> kolkuPati = new SortedList<string, int>();
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
            return kolkuPati;
        }

        static void Main(string[] args)
        {
            string path = @"c:\temp\ZborPovtoruvanjaDatoteka.txt";
             if (!File.Exists(path))
              {
                  using (StreamWriter sw = File.CreateText(path))
                  {
                          sw.WriteLine("Vladimir Krstevski 25 Bitola MAKEDONIJA Vladimir Krstevski vo Bitola Republika MAKEDONIJA zivej 25 godini.");
                  }
              }

            List<string> listaOdTextZborovi = new List<string>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    listaOdTextZborovi = razdeli(s);
                }
            }

            Console.WriteLine("Resenie");
            SortedList<string, int> listaIzbroeni = new SortedList<string, int>();
            listaIzbroeni = IzborZboroviVoRecenica(listaOdTextZborovi);
            foreach (KeyValuePair<string, int> v in listaIzbroeni)// gi listame dobienite rezulatati od sortiranata lista
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }


        }
    }
}
