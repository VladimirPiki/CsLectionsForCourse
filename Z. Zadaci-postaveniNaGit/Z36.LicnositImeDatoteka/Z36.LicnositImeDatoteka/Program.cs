using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z36.LicnositImeDatoteka
{
    internal class Program
    {
        ///Najdi gi site licnosti so odredeno  ime

        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;

        };
       /* static List<Licnost> OdredenoIme(List<Licnost> list)
        {
            List<string> samoIme = new List<string>();
            List<Licnost> licnostIme = new List<Licnost>();
            for (int i = 0; i < list.Count; i++)
            {
                //Console.WriteLine(list[i].ime);
                if (!samoIme.Contains(list[i].ime))
                {
                    samoIme.Add(list[i].ime);
                    licnostIme.Add(list[i]);
                }
            }
            return licnostIme;
        }*/
        static Dictionary<string, string> SiteLicnostiSoOdredenoIme(List<Licnost> licnostIme)
        {
            var strings = new Dictionary<string, string>();
            for (int i = 0; i < licnostIme.Count; i++)
            {
                //Console.WriteLine(licnostIme[i].ime + " " + licnostIme[i].prezime + " " + licnostIme[i].godini);
                if (!strings.ContainsKey(licnostIme[i].ime))
                {
                    strings[licnostIme[i].ime] = licnostIme[i].ime + " " + licnostIme[i].prezime + " " + licnostIme[i].godini;

                }
                else if (strings.ContainsKey(licnostIme[i].ime))
                {
                    strings[licnostIme[i].ime] = strings[licnostIme[i].ime] + " " + licnostIme[i].ime + " " + licnostIme[i].prezime + " " + licnostIme[i].godini;
                }
            }
            return strings;
        }


        static void Main(string[] args)
        {
            Licnost lic = new Licnost();
            string path = @"c:\temp\Z36.LicnositImeDatoteka.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("55");
                    sw.WriteLine("Darko");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("22");
                    sw.WriteLine("Zorica");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("25");
                    sw.WriteLine("Antimon");
                    sw.WriteLine("Krstevski");
                    sw.WriteLine("25");
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Putin");
                    sw.WriteLine("22");
                    sw.WriteLine("Darko");
                    sw.WriteLine("Joshevski");
                    sw.WriteLine("24");
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Popov");
                    sw.WriteLine("33");
                    sw.WriteLine("Zorica");
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
                        list.Add(lic);
                    }
                    else
                        Console.WriteLine("Could not be parsed.");
                }

            }
            var  strings = new Dictionary<string, string>();
            strings = SiteLicnostiSoOdredenoIme(list);
            foreach (KeyValuePair<string, string> kvp in strings)
            Console.WriteLine("Ime: {0}     Site iminja:  {1}", kvp.Key, kvp.Value);


        }
    }
}
