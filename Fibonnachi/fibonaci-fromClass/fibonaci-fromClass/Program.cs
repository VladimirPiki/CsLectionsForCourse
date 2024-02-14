using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaci_fromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kolku od broevite pripagjaat na listata fibonaci
            /*  List<int> lista = new List<int> { 3, 23, 4, 3, 5, 7, 8 };
              int pripagja = 0;
              foreach(int i in lista)
              {
                  int prviBrojki = 100;
                  int prv = 0;
                  int vtor = 1;

                  int brojac = 0;
                  while (brojac < i+1)
                  {
                      //Console.WriteLine("Fibonaci lista : " + prv);

                       int tret;
                      tret = vtor + prv;
                      prv = vtor;
                      vtor = tret;
                      if (i == tret)
                      {

                          pripagja++;
                          break;
                      }
                      brojac = brojac + 1;
                  }

              }
              Console.WriteLine("Pripagjaat : " + pripagja +" broevi");*/

            //Dali daden broj pripagja na listata na fibonaci
            bool pripagja = false;
            int broj = 1;

            int prv = 0;
            int vtor = 1;
            //int tret = 2;//
            int tret = 1;//

            while (tret < broj)
            {
                tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (broj == tret)
                {
                    pripagja = true;
                }
            }
            if (pripagja)
            {
                Console.WriteLine("brojot pripaja na fibonaci " + broj);
            }
            else
            {
                Console.WriteLine("brojot NE pripaja na fibonaci");
            }

            /*   List<int> lista = new List<int> { 3, 23, 4, 3, 5, 7, 8 };
               int maxPripagjat = 0;
               foreach (int i in lista)
               {
                   bool pripagja = false;
                   int broj=i;

                   int prv = 0;
                   int vtor = 1;
                   int tret = 2;

                   while (tret < broj)
                   {
                       tret = vtor + prv;
                       prv = vtor;
                       vtor = tret;
                       if (broj == tret)
                       {
                           maxPripagjat++;
                           pripagja = true;
                       }
                   }
                   if (pripagja)
                   {

                       //Console.WriteLine("brojot pripaja na fibonaci " + broj);
                   }
                   else
                   {
                      // Console.WriteLine("brojot NE pripaja na fibonaci");
                   }
               }
               Console.WriteLine("Pripaagjaat:  " + maxPripagjat+" broevi");*/

        }
    }
}
