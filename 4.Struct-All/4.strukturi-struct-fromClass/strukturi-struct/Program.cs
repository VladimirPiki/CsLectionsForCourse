using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strukturi_struct
{
    internal class Program
    {
        // Predhodnici na metodite
        // inicijalizirame objekt izveden vid na podatok, kreirame objekt ja mozime memoriame vo kolekcii
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;
        }
        static void Main(string[] args)
        {
            Licnost lic;

            List<Licnost> listLic = new List<Licnost>();

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
                Console.Write(listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini);
                Console.WriteLine();
            }

        }
    }
}

