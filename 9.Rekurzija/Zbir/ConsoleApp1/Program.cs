using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rekurzija
{
    class Program
    {
        static int Zbir(int broj)
        {
            if (broj == 0)
                return 0;
            else
            {
                return broj + Zbir(broj - 1);
            }
        }
        static void Main(string[] args)
        {
            int broj = 5;
            Console.WriteLine(Zbir(broj));
        }
    }
}

