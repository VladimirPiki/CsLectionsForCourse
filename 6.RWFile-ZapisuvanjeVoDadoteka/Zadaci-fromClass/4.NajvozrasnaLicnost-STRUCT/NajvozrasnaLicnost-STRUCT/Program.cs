using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajvozrasnaLicnost_STRUCT
{
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
            Licnost lic = new Licnost();
            Licnost najvozrasnaLicnost = new Licnost();// inicijalizirame nova instanca
            string path = @"c:\temp\MyTest1.txt";

            // Open the file to read from.

            int maxGodini = 0;
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
                        if (maxGodini < lic.godini)
                        {
                            maxGodini = lic.godini;
                            najvozrasnaLicnost = lic;// tuka gi dodavame kako od for so dodavame samo tuka ja inicijalizirame vo nova
                        }
                    }
                    else
                        Console.WriteLine("Could not be parsed.");


                }
               // Console.WriteLine(najvozrasnaLicnost.godini);

            }


            Console.WriteLine("Najvozrasna licnost vo tekstot e : "+najvozrasnaLicnost.ime + "   " + najvozrasnaLicnost.prezime + "   " + najvozrasnaLicnost.godini);

        }
    }

}
