using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspredelvanjeVoRazlicniDadoteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            RaspredelvanjeVoRazlicniDadoteki.Class1 obj = new RaspredelvanjeVoRazlicniDadoteki.Class1();
            RaspredelvanjeVoRazlicniDadoteki.Class2 obj2 = new RaspredelvanjeVoRazlicniDadoteki.Class2();

            Console.WriteLine(obj.Soberi(3, 4));
            Console.WriteLine(obj2.Odzemi(3, 4));

        }
    }
}
