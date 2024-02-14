using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z38.LicnostiGodiniFIbonaciDatoteka
{
    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;

        };

        static bool pripagjaFibonaci(int godini)
        {
            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == godini || vtor == godini)
            {
                pripagja = true;
            }

            while (vtor < godini)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == godini)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }

        static void Main(string[] args)
        {
            Licnost lic = new Licnost();
            string path = @"c:\temp\Z38.LicnostiGodiniFIbonaciDatoteka.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("56");
                    sw.WriteLine("Darko");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("21");
                    sw.WriteLine("Zorica");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("55");
                    sw.WriteLine("Antimon");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("0");
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Putin");
                    sw.WriteLine("22");
                    sw.WriteLine("Darko");
                    sw.WriteLine("Joshevski");
                    sw.WriteLine("13");
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Popov");
                    sw.WriteLine("1");
                    sw.WriteLine("Zorica");
                    sw.WriteLine("Markovska");
                    sw.WriteLine("2");
                    sw.WriteLine("Eleonora");
                    sw.WriteLine("Markovska");
                    sw.WriteLine("43");
                }
            }


            // Open the file to read from.
            List<Licnost> list = new List<Licnost>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    lic.ime = s;
                    lic.prezime = sr.ReadLine();
                    bool isParsable = Int32.TryParse(sr.ReadLine(), out lic.godini);
                    if (isParsable)
                    {
                        if (pripagjaFibonaci(lic.godini))
                        {
                            list.Add(lic);
                        }
                    }
                    else
                        Console.WriteLine("Could not be parsed.");
                }

            }
            
            for(int i=0;i < list.Count; i++)
            {
                Console.WriteLine(list[i].ime+" "+ list[i].prezime+" "+ list[i].godini);
            }


        }
    }
}
