using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.cas_21._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<string> lisString = new List<string>() { "Prilep", "Skopje" };
             lisString.Add("Prilep");
             lisString.Add("Bitola");
             lisString.Add("Ohrid");

             for (int i = 0; i < lisString.Count; i++)
             {
                 Console.WriteLine(lisString[i]);
             }*/

            //Grad so najmnogu karakteri
            /*  List<string> lisString = new List<string>() { "Prilep", "Skopje" };
              lisString.Add("Prileppp");
              lisString.Add("Bitolaa");
              lisString.Add("Ohrida");

              int max = 0;

              for (int i = 0; i < lisString.Count; i++)
              {

                  if (max < lisString[i].Length)
                  {
                      max = lisString[i].Length;
                  }

              }
              Console.WriteLine(max);*/

            /* List<string> lisString = new List<string>() { "abc", "absa" };
             lisString.Add("aaa");
             lisString.Add("cba");
             lisString.Add("abcd");
             lisString.Add("abcd");
             int vkupnoRastecki = 0;
             for (int i = 0; i < lisString.Count; i++)
             {

                 int rasteckiNizi = 0;
                 int brojac = 0;
                 bool rastecka = false;
                 for (int a = 1; a < lisString[i].Length; a++)
                 {
                     //int broj = str[i];
                     if (lisString[i][a] > lisString[i][a - 1])
                     {
                         brojac++;
                         //Console.WriteLine((int)subString[i] + " > " + (int)subString[i - 1]);
                         if (lisString[i][a] == lisString[i].Length - 1)
                         {
                             rastecka = false;
                             rasteckiNizi++;
                             break;
                         }
                         rastecka = true;
                     }
                     else
                     {
                         //Console.WriteLine((int)subString[i] + " < " + (int)subString[i - 1]);
                         if (brojac > 1)
                         {
                             rastecka = false;
                             rasteckiNizi++;
                             brojac = 1;
                         }

                     }


                 }
                 if (rastecka)
                 {
                     rasteckiNizi++;
                     vkupnoRastecki = vkupnoRastecki +rasteckiNizi;
                    // Console.WriteLine("Substringot e rastecki");
                 }
                 //Console.WriteLine("Substringot sozdrzi : " + rasteckiNizi + " elementi");

             }
             Console.WriteLine(vkupnoRastecki);*/

            List<string> lisString = new List<string>() { "abc", "absa" };
            lisString.Add("aaaaa");
            lisString.Add("cba");
            lisString.Add("abcd");

            List<string> rastecki = new List<string>();
            List<string> novaLista = new List<string>();
            foreach (string str in lisString)
            {
                bool rasti = true;

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] >= str[i + 1])
                    {
                        rasti = false;
                        novaLista.Add(str);
                        break;
                    }
           
                }

                if (rasti)
                {
                    rastecki.Add(str);
                }
            }
            Console.WriteLine(rastecki.Count);
            foreach (string rasteckiStringoj in rastecki)
            {
                Console.WriteLine(rasteckiStringoj);
            }
           
                
            foreach(string n in novaLista)
            {
                Console.WriteLine(n);
            }
        }

    }
    }

