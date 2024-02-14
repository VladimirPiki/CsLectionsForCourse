using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т6.Licnosti
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

        static void Main(string[] args)
        {
            string path = @"c:\temp\Т6.Licnosti.txt";
            List<Licnost> licList = new List<Licnost>();
            licList = SiteLicnosti(path);

            foreach (var obj in licList)
            {
                Console.WriteLine(obj.ime + "   " + obj.prezime + "   " + obj.godini);
            }

        }
    }
}
