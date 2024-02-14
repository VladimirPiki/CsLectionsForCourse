using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvite8BroeviOdNizataNaFibonaci_2cas_08._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBrojki = 8;
            int prv = 0;
            int vtor = 1;
       
            int brojac = 0;
            while (brojac < prviBrojki) {
                Console.WriteLine("Fibonaci lista : " + prv);
                int tret;
                tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                brojac = brojac + 1;
            }
        }
    }
}
