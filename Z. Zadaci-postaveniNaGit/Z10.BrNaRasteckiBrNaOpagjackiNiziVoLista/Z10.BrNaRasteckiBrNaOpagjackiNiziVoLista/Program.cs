using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z10.BrNaRasteckiBrNaOpagjackiNiziVoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///         List<int> lista = new List<int> { 3, 4,5,6,5,4,3,4,5,6,4,2,1 };
            ///////////RASTECKA///////              1                2                    3                4            5           6
            List<int> lista = new List<int> { 3, 4, 55, 44, 10, 17, 18, 55, 40, 39, 12, 13, 14, 9, 8, 10, 11, 12, 10, 11, 12, 11, 23, 45, 56 };
            ///////OPAGJACKA//////////                     1              2                      3               4           5 


           /* int rasteckiNizi = 0;
            int brojac = 0;
            int opagjackiNizi = 0;
            int brojacOpagjacki = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[i - 1])
                {
                    brojac++;
                    if (i == lista.Count - 1)
                    {
                        rasteckiNizi++;
                        
                    }
                    if (brojacOpagjacki > 1)
                    {
                        opagjackiNizi++;
                        brojacOpagjacki = 1;
                    }

                }
                else
                {
                    brojacOpagjacki++;
                    if (brojac > 1)
                    {
                        rasteckiNizi++;
                        brojac = 1;
                    }
                    if (i == lista.Count - 1)
                    {
                        opagjackiNizi++;
             
                    }

                }

            }
            Console.WriteLine("Brojot na rastecki nizi e : "+rasteckiNizi);
            Console.WriteLine("Brojot na opagjacki nizi e : " + opagjackiNizi);*/
           List<List<int>> redici = new List<List<int>>();
             {
                 List<int> koloni = new List<int>();
               //  koloni.Add(3);
                // koloni.Add(4);
                koloni.Add(1);
                koloni.Add(2);
                 redici.Add(koloni);

             }

             {
                 List<int> koloni = new List<int>();
                koloni.Add(4);
                koloni.Add(55);
                 koloni.Add(10);
                koloni.Add(11);
                 koloni.Add(12);
                 redici.Add(koloni);
             }



             for (int i = 0; i < redici.Count; i++)
             {
                 for (int j = 0; j < redici[i].Count; j++)
                 {
                     Console.Write(redici[i][j] + "  ");
                 }
                 Console.WriteLine();
             }

          /*  List<List<int>> redici = new List<List<int>>();
            {
                List<int> koloni = new List<int>();
                koloni.Add(rasteckiNizi);
                redici.Add(koloni);

            }

            {
                List<int> koloni = new List<int>();
                koloni.Add(lista[i]);
                redici.Add(koloni);
            }
            for (int a = 0; a < redici.Count; a++)
            {
                for (int j = 0; j < redici[a].Count; j++)
                {
                    Console.Write(redici[a][j] + "  ");
                }
                Console.WriteLine();
            }*/

        }
    }
}
