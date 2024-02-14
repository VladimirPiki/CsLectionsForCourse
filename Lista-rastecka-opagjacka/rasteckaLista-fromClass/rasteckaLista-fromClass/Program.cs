using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rasteckaLista_fromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proveruvame dali odredena lista e rastecka ili ne e rastecka
            List<int> list = new List<int> { 3, 4, 1, 8 };
              int rastecka = 0;
              int opagjacka = 0;
              for (int i = 0; i < list.Count; i++)
              {
                  int pocetenBroj = list[i];
                  i++;

                  if (pocetenBroj < list[i])
                  {
                      rastecka = 1;
                      break;
                  }
                  if (pocetenBroj > list[i])
                  {
                      opagjacka = 1;

                      break;
                  };
              }
              if (rastecka == 1)
              {
                  Console.WriteLine("rastecka");
              }
              else
              {
                  Console.WriteLine("opagjacka");
              }
           


            
                        List<int> lista = new List<int> { 8, 9,10 ,4, 8 };

                        bool rastecka1 = true;

                        for (int i = 1; i < lista.Count; i++)
                        {
                            if (lista[i] > lista[i - 1])
                            {
                              // Console.WriteLine(lista[i]);
                            }
                            else
                            {
                                rastecka1 = false;
                                break;
                            }
                        }

                        if (rastecka1)
                        {
                            Console.WriteLine("listata e rastecka");
                        }
                        else
                        {
                            Console.WriteLine("listata ne e rastecka");
                        }
                        

           /*Ista zadaca kako i so mojot kod
             
             * */
            List<int> lista1 = new List<int> { 4, 55, 44, 10, 17, 18, 55, 40, 39,12,13,14,9,8,7,8,10,12,5,4,6,9,10 };

            int count = 0;
            int brojacRastecka = 1;

            bool rastecka2 = true;

            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[i - 1])
                {
                    brojacRastecka = brojacRastecka + 1;
                    if (i == lista.Count - 1)
                    {
                        count++;
                        break;
                    }

                }
                else
                {
                    rastecka2 = false;
                    if (brojacRastecka > 1)
                    {
                        count = count + 1;
                        brojacRastecka = 1;
                    }
                }
            }

            if (rastecka2)
            {
                Console.WriteLine("listata e rastecka");
            }
            else
            {
                Console.WriteLine(count);
            }
             

            /// Moj kod
            List<int> lista3 = new List<int> { 3, 4, 55, 44, 10,17,18,55,40,39,12,13,14,9,8,10,11,12,10,11,12 };
             bool rastecka3 = true;
             int rasteckiNizi = 0;
             int brojac = 1;
             for (int i = 1; i < lista.Count; i++)
             {
                 if (lista[i] > lista[i - 1])
                 {
                     brojac++;
                     if (i == lista.Count-1)
                     {
                         rasteckiNizi++;
                         break;
                     }
                 }
                 else
                 {
                     rastecka3 = false;
                   if(brojac > 1)
                     {
                         rasteckiNizi++;
                         brojac = 1;
                     }

                 }

             }
             Console.WriteLine(rasteckiNizi);

            //Kolku elementi ima najdolgata rastecka niza
            List<int> lista4 = new List<int> { 4, 55, 44, 10, 17, 18, 55, 40, 39, 12, 13, 14, 9, 8, 7, 8, 10, 12, 5, 4, 6, 9, 10 };

             int count4 = 0;
             int brojacRastecka4 = 1;
             int brojac4 = 0;

             for (int i = 1; i < lista.Count; i++)
             {
                 if (lista[i] > lista[i - 1])
                 {
                     brojacRastecka = brojacRastecka + 1;
                     if (i == lista.Count - 1)
                     {
                         count++;
                         break;
                     }

                 }
                 else
                 {

                     if (brojacRastecka > 1)
                     {
                         count = count + 1;
                         //Proverka na najdolga niza
                         if(brojac < brojacRastecka)
                         {
                             brojac = brojacRastecka;
                         }
                         brojacRastecka = 1;
                     }
                 }
             }

             Console.WriteLine(brojac4);
            

        }
    }
}
