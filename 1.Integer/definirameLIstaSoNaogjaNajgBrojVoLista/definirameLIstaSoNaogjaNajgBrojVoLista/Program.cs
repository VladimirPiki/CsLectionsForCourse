using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definirameLIstaSoNaogjaNajgBrojVoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  List<int> lista = new List<int> { 3333, 23, 4, 3, 5, 7, 8 };*/

            /* int max = lista[0];

             for (int i = 0; i < lista.Count; i++)
             {
                 int broj = lista[i];

                     if (broj > max)
                     {
                         max = broj;
                     }


             }
             Console.WriteLine("Najgolem broj vo listata elementi e : " + max);*/

            //Vtora nacin so foreach
            /* int max = 0;
             foreach (int broj in lista)
             {

                 if (broj > max)
                 {
                     max = broj;
                 }

             }
             Console.WriteLine("Najgolem broj vo listata e : "+max);*/

            //Megju koj 2broevi, ima najgolema razlika
            /*  int max = lista[0];

             foreach (int broj in lista) {
                  if (broj > max)
                  {
                      max = broj;
                  }
              }
              Console.WriteLine("max e : " + max);
              int min = lista[0];
              foreach (int broj in lista)
              {
                  if (min > broj)
                  {
                      min = broj;
                  }
              }
              Console.WriteLine("min e : " + min);
              int raz = max - min;
              Console.WriteLine("Razlikata e : " + raz);*/

            /*Najdobro reshenie 
             * int max = lista[0];
            int min = lista[0];
            foreach (int broj in lista)
            {
              if (broj > max)
                  {
                      max = broj;
                  }
                if (min > broj)
                {
                    min = broj;
                }
            }
   
            int raz = max - min;
            Console.WriteLine("Razlikata e : " + raz); */


            //Maksimalen paren broj vo niza

            /*Ova e moe reshenie
             * int max = 0;
              foreach (int broj in lista)
              {
                  if (broj % 2 == 0)
                  {
                      if(broj > max)
                      {
                          max = broj;
                      }

                  }

              }
              Console.WriteLine("najgolem paren broj e : " + max); */

        }
    }
}
   
