using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т2.PrezimeFibonaci
{
    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;
        }
        static bool pripagjaFibonaci(string prezime)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == prezime.Length || vtor == prezime.Length)
            {
                pripagja = true;
            }

            while (vtor < prezime.Length)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == prezime.Length)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }
        static void Main(string[] args)
        {
            Licnost lic;

            List<Licnost> listLic = new List<Licnost>();
            Console.WriteLine("Vo zadacata da se najdi dali prezimeto vo dolzina pripagja na fibonaci listata");
            Console.WriteLine("Vnesete ime, prezime i godini na licnosta");
            for (int i = 0; i < 3; i++)
            {
                lic.ime = Console.ReadLine();
                lic.prezime = Console.ReadLine();
                lic.godini = Convert.ToInt32(Console.ReadLine());
                listLic.Add(lic);
            }

            //Pristapuvanje do podatocite od strukturata

            for (int i = 0; i < listLic.Count; i++)
            {
                if (pripagjaFibonaci(listLic[i].prezime) == true)
                {      
                    Console.WriteLine("");
                    Console.WriteLine("Licnost so prezime sto pripagja so prezime na fibonaci listata : " + listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini);
                    Console.WriteLine();
                }
            }

        }
    }
}
