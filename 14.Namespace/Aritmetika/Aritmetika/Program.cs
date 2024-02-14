using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobiranjeOdzemanje 
{
    class SobiranjeOdzemanje
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

namespace Aritmetika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 4;  
            SobiranjeOdzemanje.SobiranjeOdzemanje sobiranjeOdzemanje = new SobiranjeOdzemanje.SobiranjeOdzemanje();
            Mnozenje.Mnozenje mnozenje = new Mnozenje.Mnozenje();
            Console.WriteLine(sobiranjeOdzemanje.Sobiranje(a,b));
            Console.WriteLine(sobiranjeOdzemanje.Odzemanje(a, b));
            Console.WriteLine(mnozenje.MnozenjeMetoda(a, b));

        }
    }
}
