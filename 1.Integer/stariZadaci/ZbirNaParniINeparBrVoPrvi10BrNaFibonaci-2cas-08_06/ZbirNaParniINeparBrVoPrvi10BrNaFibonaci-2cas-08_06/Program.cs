using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbirNaParniINeparBrVoPrvi10BrNaFibonaci_2cas_08_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviteDeset = 10;
            int prv = 0;
            int vtor = 1;
            int tret;
            int zbir = 0;
            int parni = 0;
            int neparni = 0;
            int brojac = 0;
            while (brojac < prviteDeset)
            {
                // Console.WriteLine("Tuka e prv :" + prv);
                tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                zbir = parni + neparni;
                //Console.WriteLine("Tuka e parni :" + parni);
                // Console.WriteLine("Tuka e neparni :" + neparni);
                if (prv % 2 == 0)
                {
                    //Console.WriteLine("Tuka e parni :" + parni);
                    parni = parni + prv;
                }
                else
                {
                    //Console.WriteLine("Tuka e neparni :" + neparni);
                    neparni = neparni + prv;
                }
                brojac = brojac + 1;
                //Console.WriteLine("Tuka e brojachot :" + brojac);
            }
            Console.WriteLine("Zbir na parni i neparni broevi vo prvite 10 broevi na fibonacii :" + zbir);
        }
    }
}
