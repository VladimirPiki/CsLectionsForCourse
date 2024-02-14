using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4
{
    class Program
    {
        class Licnost
        {

            public string mIme;
            public string mPrezime;

            public Licnost()
            {

            }
            public Licnost(string ime, string prezime)
            {
                mIme = ime;
                mPrezime = prezime;
            }

        }
        static void Main(string[] args)
        {
            Licnost objLic = new Licnost("Goran", "Mitreski");
            Licnost objLic2 = new Licnost();
            Console.WriteLine(objLic.mIme + "  " + objLic.mPrezime);
            objLic2 = objLic;
            Console.WriteLine(objLic2.mIme + "  " + objLic2.mPrezime);

        }
    }
}
