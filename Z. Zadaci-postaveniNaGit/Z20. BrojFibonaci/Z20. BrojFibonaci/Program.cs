using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z20.BrojFibonaci
{
    internal class Program
    {
        static bool proveriDaliBrojoteFibonaci(int broj)
        {
            bool pripagja=false;
            int prv = 0;
            int vtor = 1;

            if (prv == broj || vtor == broj)
            {
                pripagja= true;
            }

            while (vtor < broj)
            {
              int  tret = vtor + prv;
                prv = vtor;
                vtor = tret;
              
                if (vtor == broj)
                {
                    pripagja = true;
                }

            }
       
            return pripagja;
        }
        static void Main(string[] args)
        {
           int broj = 8;


            if (proveriDaliBrojoteFibonaci(broj))
            {
                Console.WriteLine("Brojot "+ broj+" pripagja na fibonaci");
            }
            else
            {
                Console.WriteLine("Brojot ne pripgja na fibonaci");
            }


        }
    }
}
