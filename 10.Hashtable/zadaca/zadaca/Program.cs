
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca
{
    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;

        };

        static Hashtable SiteLicnostiSoOdredenaBukvaOdIme(List<Licnost> licnostIme)
        {
            var strings = new Hashtable();
            for (int i = 0; i < licnostIme.Count; i++)
            {
                if (!strings.ContainsKey(licnostIme[i].ime[0]))
                {
                    strings[licnostIme[i].ime[0]] = licnostIme[i].ime + " " + licnostIme[i].prezime + " " + licnostIme[i].godini;

                }
                else if (strings.ContainsKey(licnostIme[i].ime[0]))
                {
                    strings[licnostIme[i].ime[0]] = strings[licnostIme[i].ime[0]] + " " + licnostIme[i].ime + " " + licnostIme[i].prezime + " " + licnostIme[i].godini;
                }
            }
            return strings;
        }


        static void Main(string[] args)
        {
            Licnost lic = new Licnost();
            string path = @"c:\temp\hashtable.txt";
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

                    sw.WriteLine("Eleonora");
                    sw.WriteLine("Markovska");
                    sw.WriteLine("33");
                    sw.WriteLine("Goran");
                    sw.WriteLine("Markovski");
                    sw.WriteLine("23");

                    sw.WriteLine("Gjorgi");
                    sw.WriteLine("Markovski");
                    sw.WriteLine("44");
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
            var strings = new Hashtable();
            strings = SiteLicnostiSoOdredenaBukvaOdIme(list);

            foreach (DictionaryEntry element in strings)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }


        }
    }
}
