
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_remove_funkcijata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadaca kako da gi izbrisime site 10 ki od listata
            /*  var broevi = new List<int>() { 10, 20, 10, 10, 30, 40, 10 };

              foreach (var broj in broevi)
              {
                  if (broj == 10)
                  {
                      broevi.Remove(broj);
                  }
                 // Console.WriteLine(broj)
              }*/

            //Da gi otstranime site broevi koj pripagjaat na nizata
            var broevi = new List<int>() { 0, 1, 11, 2, 3, 8, 10, 1, };

            for (int i = 0; i < broevi.Count; i++)
            {

                // bool pripagja = false;
                int prv = 0;
                int vtor = 1;


                while (vtor < broevi[i])
                {
                    Console.WriteLine(broevi[i]);
                    if (broevi[i] == prv)
                    {
                        broevi.Remove(i);
                    }
                    if (broevi[i] == vtor)
                    {
                        broevi.Remove(i);
                    }
                    int tret = vtor + prv;
                    prv = vtor;
                    vtor = tret;
                    if (broevi[i] == vtor)
                    {
                        broevi.RemoveAt(i);
                        // pripagja = true;
                    }
                }
                /*if (pripagja)
                {
                    bool ima = broevi.Remove(broevi[i]);
                    if (ima==true)
                    {
                        //Console.WriteLine("izbrisan e " + i);
                    }
                    else
                    {
                        //Console.WriteLine("ne postoi baranata vrednost");
                    }
                    // Console.WriteLine("brojot pripaja na fibonaci " + i);
                }*/
                // Console.WriteLine(i);
            }
            foreach (int a in broevi)
            {
                Console.WriteLine(a);
            }
        }
    }
}
