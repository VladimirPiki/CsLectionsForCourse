using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    class Program
    {
        class Licnost
        {

            public string ime;
            public string prezime;

            public Licnost()
            {
                ime = "Goran";
                prezime = "Mitreski";
            }

        }
        static void Main(string[] args)
        {
            Licnost objLic = new Licnost();
            Console.WriteLine(objLic.ime);
            Console.WriteLine(objLic.prezime);
        }
    }
}

