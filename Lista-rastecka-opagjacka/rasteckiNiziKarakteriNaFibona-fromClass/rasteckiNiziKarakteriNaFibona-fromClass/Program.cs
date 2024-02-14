using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rasteckiNiziKarakteriNaFibona_fromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kolku od rasteckite nizi vo lista imaat karakteri koi pripagjaat na nizata od fibonaci
            //////////////////////////////////////1                   1                1                                                    1                                                       
             List<int> lista = new List<int> { 4, 55,56,57,44, 10, 7, 18, 55, 40, 39, 12, 13, 14, 9, 8, 7, 8, 10, 12, 5, 4, 6, 9, 10, 9, 8,144,145,155,166 };
             int count = 0;
             int brojacRastecka = 1;
             int brojac = 0;

             for (int i = 1; i < lista.Count; i++)
             {
                 if (lista[i] > lista[i - 1])
                 {
                     brojacRastecka = brojacRastecka + 1;
                     if (i == lista.Count - 1)
                     {

                         int prv = 0;
                         int vtor = 1;
                         int tret = 2;

                         while (tret < brojacRastecka + 1)
                         {
                             tret = vtor + prv;
                             prv = vtor;
                             vtor = tret;
                             if (brojacRastecka == tret)
                             {
                                 count++;
                                 //Console.WriteLine(tret);
                             }
                         }

                         break;
                     }

                 }
                 else
                 {

                     if (brojacRastecka > 1)
                     {

                         int prv = 0;
                         int vtor = 1;
                         int tret = 2;

                         while (tret < brojacRastecka+1)
                         {
                             tret = vtor + prv;
                             prv = vtor;
                             vtor = tret;
                             if (brojacRastecka == tret)
                             {
                                 count++;
                                 //Console.WriteLine(tret);
                             }
                         }

                         brojacRastecka = 1;
                     }
                 }
             }

             Console.WriteLine(count);
        }
    }
}
