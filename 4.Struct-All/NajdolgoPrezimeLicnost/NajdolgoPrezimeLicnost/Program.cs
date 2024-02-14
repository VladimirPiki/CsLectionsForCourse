using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdolgoPrezimeLicnost
{ //Metoda koj vrakja lista na structuri
    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;
        }

        static List<Licnost> VnesiLicnosti()
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
            return listLic;
        }

        static void PrikaziLicnosti(List<Licnost> licnost)
        {
            //Pristapuvanje do podatocite od strukturata
            for (int i = 0; i < licnost.Count; i++)
            {
                Console.Write(licnost[i].ime + " " + licnost[i].prezime + " " + licnost[i].godini);
                Console.WriteLine();
            }
        }

        static Licnost NajdolgoPrezimeLicnost(List<Licnost> lisLicnost)
        {

            string max = "";
            int index = 0;

            for (int i = 0; i < lisLicnost.Count; i++)
            {
                if (max.Length < lisLicnost[i].prezime.Length)
                {
                    max = "";
                    max = lisLicnost[i].prezime;
                    index = i;
                }
            }

            return lisLicnost[index];

        }


        static void Main(string[] args)
        {

            Licnost lic;
            List<Licnost> listLic = new List<Licnost>();
            //vnesuvanje na podatoci
            listLic = VnesiLicnosti();

            //Prikazuvame licnosta so najdolgo prezime
            lic = NajdolgoPrezimeLicnost(listLic);
            Console.WriteLine(lic.ime + "  " + lic.prezime + "  " + lic.godini);

        }
    }
}
