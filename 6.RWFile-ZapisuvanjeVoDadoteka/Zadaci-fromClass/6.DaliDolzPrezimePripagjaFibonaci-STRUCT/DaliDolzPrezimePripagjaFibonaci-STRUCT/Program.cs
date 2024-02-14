using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaliDolzPrezimePripagjaFibonaci_STRUCT
{
    class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;

        };
        static bool pripagjaFibonaci(string prezime)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == prezime.Length || vtor == prezime.Length)
            {
                pripagja = true;
            }

            while (vtor < prezime.Length)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == prezime.Length)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }
        static void Main(string[] args)
        {
            Licnost lic = new Licnost();
            List <Licnost> listaSoPripagjaPrezimeFibonaci = new List<Licnost>();  
            string path = @"c:\temp\MyTest.txt";

            // Open the file to read from.
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
                        if (pripagjaFibonaci(lic.prezime))
                        {
                            listaSoPripagjaPrezimeFibonaci.Add(lic);
                        }
                    }
                    else
                        Console.WriteLine("Could not be parsed.");
                }

            }


            for (int a = 0; a < listaSoPripagjaPrezimeFibonaci.Count; a++)
            {
                Console.WriteLine(listaSoPripagjaPrezimeFibonaci[a].ime + "  " + listaSoPripagjaPrezimeFibonaci[a].prezime + "  " + listaSoPripagjaPrezimeFibonaci[a].godini);
            }

        }
    }
}
