using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{

    namespace MyClass
    {
        class Program
        {
            class Licnost
            {

                public string mIme;
                public string mPrezime;

                public Licnost(string ime, string prezime)
                {
                    mIme = ime;
                    mPrezime = prezime;
                }

            }
            static void Main(string[] args)
            {
                Licnost objLic = new Licnost("Goran", "Mitreski");

                Console.WriteLine(objLic.mIme + "  " + objLic.mPrezime);

            }
        }
    }

}
