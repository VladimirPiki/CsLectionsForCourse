using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7.Iminjadatoteka
{
    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;

        };
        static List<Licnost> SiteLicnosti(string path)
        {
            Licnost lic;
            List<Licnost> licList = new List<Licnost>();
            using (StreamReader sr = File.OpenText(path))
            {

                string s;
                while ((s = sr.ReadLine()) != null) // gi cita liniite
                {
                    lic.ime = s; //prvata redica e ime
                    lic.prezime = sr.ReadLine(); // prezime
                    bool isParsable = Int32.TryParse(sr.ReadLine(), out lic.godini);// baraj godini
                    if (isParsable)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Could not be parsed. ");// ovde ke vrati 0
                    }


                    licList.Add(lic);// instancata na lic zapisi ja vo inizijaliziranata licList
                }
            }
            return licList;
        }

        //static SortedList<char, string> SortiraniIminja(List<Licnost> licList)
        //{
        //    SortedList<char, string> sortiranaLIsta = new SortedList<char, string>();
        //    int broj = 1;
        //    foreach (var obj in licList)
        //    {
        //        if (broj < 6)
        //        {
        //            // Console.WriteLine(obj.ime + "   " + obj.prezime + "   " + obj.godini);
        //            sortiranaLIsta.Add(obj.ime[0], obj.ime);
        //        }

        //        broj++;
        //    }
        //    return sortiranaLIsta;
        //}


        static SortedList<string, string> SortiraniIminja(List<Licnost> licList)
        {
            SortedList<string, string> sortiranaLIsta = new SortedList<string, string>();
            int broj = 1;
            foreach (var obj in licList)
            {
                if (broj < 6)
                {
                    if (sortiranaLIsta.ContainsKey(obj.ime+" "+obj.prezime+ " "+obj.godini))
                    {
                        sortiranaLIsta.Add(obj.ime + " " + obj.prezime + " " + obj.godini, obj.ime);
                    }else if (!sortiranaLIsta.ContainsKey(obj.ime + " " + obj.prezime + " " + obj.godini))
                    {
                        sortiranaLIsta.Add(obj.ime + " " + obj.prezime + " " + obj.godini, obj.ime);
                    }

                }

                broj++;
            }
            return sortiranaLIsta;
        }


        static void Iminjadatoteka()
        {
            string path = @"c:\temp\T7.Iminjadatoteka.txt";
            List<Licnost> licList = new List<Licnost>();
            licList = SiteLicnosti(path);
            //     SortedList<char, string> sortiranaLIsta = new SortedList<char, string>();
            SortedList<string, string> sortiranaLIsta = new SortedList<string, string>();
            sortiranaLIsta = SortiraniIminja(licList);
            foreach (var obj in sortiranaLIsta)
            {
                Console.WriteLine(obj.Value);
            }
        }

        static void Main(string[] args)
        {
            Iminjadatoteka();
        }
    }
}