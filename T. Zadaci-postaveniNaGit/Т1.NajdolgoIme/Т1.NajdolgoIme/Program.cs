using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т1.NajdolgoIme
{
    struct Licnost
    {
        public string ime;
        public string prezime;
        public int godini;

        static void Main(string[] args)
        {
            Licnost lic;

            List<Licnost> listLic = new List<Licnost>();
            Console.WriteLine("Vo zadacata se bara najdolgo ime");
            Console.WriteLine("Vnesete ime, prezime i godini na licnosta");
            for (int i = 0; i < 3; i++)
            {
                lic.ime = Console.ReadLine();
                lic.prezime = Console.ReadLine();
                lic.godini = Convert.ToInt32(Console.ReadLine());
                listLic.Add(lic);
            }

            //Pristapuvanje do podatocite od strukturata
            string maxIme = "";
            string najdolgoIme = "";
            for (int i = 0; i < listLic.Count; i++)
            {

                if (maxIme.Length < listLic[i].ime.Length)
                {
                    maxIme = "";
                    maxIme += listLic[i].ime;
                    najdolgoIme = "";
                    najdolgoIme += listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini;
                }
            }
            Console.WriteLine("Najdolgo ime ima : " + najdolgoIme);
            Console.WriteLine();
        }
    }
}

