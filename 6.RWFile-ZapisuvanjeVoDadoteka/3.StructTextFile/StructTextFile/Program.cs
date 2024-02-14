using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTextFile
{
    //Ke citame struktura
    //Imame lista so stktura go ootvarame fajlot gi citame podatocite i zemam podatoci za site, bool isParasable dali zemeniot podatok e broj akoe e zapisigo ako ne e nemozi da se parsira
    class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;

        };
        static void Main(string[] args)
        {
            Licnost lic;
            List<Licnost> licList = new List<Licnost>();
            string path = @"c:\temp\MyTest.txt";

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null) // gi cita liniite
                {
                    lic.ime = s; //prvata redica e ime
                    lic.prezime = sr.ReadLine(); // prezime
                    bool isParsable = Int32.TryParse(sr.ReadLine(), out lic.godini);// baraj godini
                    if (isParsable)
                        Console.WriteLine("Uspesno parsiranje od string vo Int32 "+lic.godini);
                    else
                        Console.WriteLine("Could not be parsed. ");// ovde ke vrati 0

                    licList.Add(lic);// instancata na lic zapisi ja vo inizijaliziranata licList
                }
            }

            foreach (var obj in licList)
            {
                Console.WriteLine(obj.ime + "   " + obj.prezime + "   " + obj.godini);
            }
        }
    }
}
