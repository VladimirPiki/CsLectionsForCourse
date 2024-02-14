using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5_najdobar
{
    class Program
    {
        class Licnost
        {

            string mIme;
            string mPrezime;

            public Licnost()
            {

            }
            public Licnost(string ime, string prezime)
            {
                mIme = ime;
                mPrezime = prezime;
            }
            public string GetIme()
            {
                return mIme;
            }
            public string GetPrezime()
            {
                return mPrezime;
            }

        }
        static void Main(string[] args)
        {
            Licnost objLic = new Licnost("Goran", "Mitreski");
            Licnost objLic2 = new Licnost();
            Console.WriteLine(objLic.GetIme() + "  " + objLic.GetPrezime());



        }
    }
}
