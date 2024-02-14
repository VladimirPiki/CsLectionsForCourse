using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z35.KarakterPovtoruvanjaDatoteka
{
    internal class Program
    {
        static SortedList<char, int> KolkuZbora(string s)
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
            string path = @"c:\temp\ZborPovtoruvanjaDatoteka.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Vladimir Krstevski 25 Bitola MAKEDONIJA Vladimir Krstevski vo Bitola Republika MAKEDONIJA zivej 25 godini.");
                    //////////////2553
                }
            }


            SortedList<char, int> listaOdTextZborovi = new SortedList<char, int>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    listaOdTextZborovi = KolkuZbora(s);
                }
            }

            Console.WriteLine("Resenie");

            foreach (KeyValuePair<char, int> v in listaOdTextZborovi)// gi listame dobienite rezulatati od sortiranata lista
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }


        }
    }
}