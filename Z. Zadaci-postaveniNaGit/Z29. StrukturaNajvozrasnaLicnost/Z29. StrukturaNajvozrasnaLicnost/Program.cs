using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z29.StrukturaNajvozrasnaLicnost
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
            int maxGodini = 0;
            string najgolemVoGodini = "";
            for (int i = 0; i < listLic.Count; i++)
            {
         
                if (maxGodini < listLic[i].godini)
                {
                    maxGodini += listLic[i].godini;
                    najgolemVoGodini = "";
                    najgolemVoGodini += listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini;

                    /* Console.Write("Najgolem vo godini e : " + listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini);
                     Console.WriteLine();*/
                }
            }
            Console.WriteLine("Najgolem vo godini e : " + najgolemVoGodini);
            Console.WriteLine();
        }
    }
}

