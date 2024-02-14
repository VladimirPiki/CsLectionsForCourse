using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SobiranjeOdzemanje;
using SobiranjeOdzemanje.Mnozenje;

namespace SobiranjeOdzemanje
{
    class SobiranjeOdzemanjeClass
    {
        public int Sobiranje(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int Odzemanje(int a, int b)
        {
            int c = a - b;
            return c;
        }
    }

    namespace Mnozenje
    {
        class Mnozenje
        {
            public int MnozenjeMetoda(int a, int b)
            {
                int c = a * b;
                return c;
            }
        }


    }

}



namespace Aritmetika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 4;
            SobiranjeOdzemanjeClass sobiranjeOdzemanje = new SobiranjeOdzemanjeClass();
            Mnozenje mnozenje = new Mnozenje();
            Console.WriteLine(sobiranjeOdzemanje.Sobiranje(a, b));
            Console.WriteLine(sobiranjeOdzemanje.Odzemanje(a, b));
            Console.WriteLine(mnozenje.MnozenjeMetoda(a, b));

        }
    }
}
