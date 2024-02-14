using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opagjackiNizi_fromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   List<int> lista = new List<int> { 7,6,5,3,3,1,10};
              bool rastecka = true;
              bool opagjacka = true;

              for (int i = 1; i < lista.Count; i++)
              {
                  if (lista[i] > lista[i - 1])
                  {
                      opagjacka = false;
                      // Console.WriteLine(lista[i]);
                  } else
                  {
                      rastecka = false;

                  }

              }

              if (rastecka)
              {
                  Console.WriteLine("listata e rastecka");
              }else if (opagjacka)
              {
                  Console.WriteLine("listata e opgjacka");
              }
              else
              {
                  Console.WriteLine("listata ne ni rastecka ni opagjacka");
              }*/

            //Kolku opagjacki nizi ima vo listata         1                     2               3                   
            List<int> lista = new List<int> { 4, 55, 44, 10, 7, 18, 55, 40, 39, 12, 13, 14, 9, 8, 7, 8, 10, };

            int opagjackiNizi = 0;
            int brojac = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[i - 1])
                {

                    if (brojac > 1)
                    {
                        opagjackiNizi++;
                        brojac = 1;
                    }

                }
                else
                {
                    brojac++;
                    if (i == lista.Count - 1)
                    {
                        opagjackiNizi++;
                        break;
                    }

                }

            }
            Console.WriteLine(opagjackiNizi);
        }
    }
}
