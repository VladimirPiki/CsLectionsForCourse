using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdolgoPrezimeLicnots_STRUCT
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
            Licnost najdolgoPrezime = new Licnost();
            string path = @"c:\temp\MyTest.txt";



            // Open the file to read from.
            string maxPrezime = "";
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
                        if (maxPrezime.Length < lic.prezime.Length)
                        {
                            maxPrezime=lic.prezime;
                            najdolgoPrezime = lic;
                        }
                    }
                    else
                        Console.WriteLine("Could not be parsed.");


                }
              //  Console.WriteLine(najdolgoPrezime.godini);

            }


            Console.WriteLine(najdolgoPrezime.ime + "   " + najdolgoPrezime.prezime + "   " + najdolgoPrezime.godini);

        }
    }
}
