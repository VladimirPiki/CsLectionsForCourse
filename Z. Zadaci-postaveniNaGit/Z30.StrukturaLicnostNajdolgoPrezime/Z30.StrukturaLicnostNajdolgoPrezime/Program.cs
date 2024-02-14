using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z30.StrukturaLicnostNajdolgoPrezime
{
    internal class Program
    {
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
            string maxPrezime = "";
            string najdolgoPrezime = "";
            for (int i = 0; i < listLic.Count; i++)
            {

                if (maxPrezime.Length < listLic[i].prezime.Length)
                {
                    maxPrezime = "";
                    maxPrezime += listLic[i].prezime;
                    najdolgoPrezime = "";
                    najdolgoPrezime += listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini;
                }
            }
            Console.WriteLine("Najdolgo prezime ima : " + najdolgoPrezime);
            Console.WriteLine();
        }
    }
}
