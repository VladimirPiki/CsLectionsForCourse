using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    internal class Program
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
            Console.WriteLine("Збир на парни и непарни броеви во првите 10 броеви од фибоначи листата :" + zbir);
        }
    }
}
