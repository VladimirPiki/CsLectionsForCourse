using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split2
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
            string path = @"c:\temp\split2.txt";
            /*  if (!File.Exists(path))
              {

                  // Create a file to write to.
                  using (StreamWriter sw = File.CreateText(path))
                  {

                          sw.WriteLine("Vladimir Krstevski 25 Bitola MAKEDONIJA");

                  }
              }*/

            List<string> listaZaProverka = new List<string>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                   
                    listaZaProverka = razdeli(s);
                }
            }

            Console.WriteLine("Resenie na vtor nacin preku citanje na dadoteka");
            foreach (string l in listaZaProverka)
            {

                Console.WriteLine(l);
            }


        }
    }
}
