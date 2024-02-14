using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static int Faktoriel(int broj)
        {
            if (broj == 1)
                return 1;
            else
            {
                return broj * Faktoriel(broj - 1);
            }
        }
        static void Main(string[] args)
        {
            int broj = 5;
            Console.WriteLine(Faktoriel(broj));
        }
    }
}
