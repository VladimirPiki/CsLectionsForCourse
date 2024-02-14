using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class Program
    {
        class Licnost
        {
            public string ime;
            public string prezime;
        }
        static void Main(string[] args)
        {
            Licnost objLic = new Licnost();

            objLic.ime = Console.ReadLine();
            objLic.prezime = Console.ReadLine();

            Console.WriteLine(objLic.ime);
            Console.WriteLine(objLic.prezime);
        }
    }
}
