using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z50.KlasiRazlicniDatoteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Z50.KlasiRazlicniDatoteki.StringStr obj = new StringStr();
            Z50.KlasiRazlicniDatoteki.StringChar obj2 = new StringChar();

            Console.WriteLine(obj.OdreduvaDolzinaString("Vladimir"));

            // Console.WriteLine(obj.DaliPostojOdredenPodstring("Vladimir vlade vlade","ade"));
            if (obj.DaliPostojOdredenPodstring("Vladimir vlade vlade", "ade") == true)
            {
                Console.WriteLine("Postoj");
            }
            else
            {
                Console.WriteLine("Ne e postoj");
            }

            Console.WriteLine(obj.KolkuPatiSePovtoruvaOdredenPodstring("Vladimir vlade vlade", "ade"));

            if(obj.BrisiOdredenPodstring("Vladimir vlade ade", "ade") == true)
            {
                Console.WriteLine("Izbrisano");
            }
            else
            {
                Console.WriteLine("Ne e izbrisano");
            }
            //Console.WriteLine(obj.BrisiOdredenPodstring("Vladimir vlade vlade", "vlade"));

            Console.WriteLine(obj.ZamenuvaOdredenPodstringSoDrug("Vladimir vlade vlade", "vlade","piki"));

            if (obj2.DaliPostojOdredenKarakterVoString("Vladimir", 'i') == true)
            {
                Console.WriteLine("Postoj");
            }
            else
            {
                Console.WriteLine("Ne e postoj");
            }
           // Console.WriteLine(obj2.DaliPostojOdredenKarakterVoString("Vladimir",'i'));

            Console.WriteLine(obj2.KolkuPatiSePovtoruvaOdredenKarakter("Vladimir", 'i'));

          //  Console.WriteLine(obj2.BriseKarakterPoIzbor("Vladimir", 'i'));

            if (obj2.BriseKarakterPoIzbor("Vladimir", 'i') == true)
            {
                Console.WriteLine("Izbrisano");
            }
            else
            {
                Console.WriteLine("Ne e izbrisano");
            }

            Console.WriteLine(obj2.ZamenaNaKarakter("Vladimir", 'i','e'));


        }
    }
}
