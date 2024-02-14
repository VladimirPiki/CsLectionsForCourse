using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prezimeFibonaci
{
    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;
        }

        static List<Licnost> VnesiLicnosti()
        {
            Licnost lic;
            List<Licnost> listLic = new List<Licnost>();

            Console.WriteLine("Vnesete ime, prezime i godini na licnosta");
            for (int i = 0; i < 3; i++)
            {
                lic.ime = Console.ReadLine();
                lic.prezime = Console.ReadLine();
                lic.godini = Convert.ToInt32(Console.ReadLine());
                listLic.Add(lic);
            }
            return listLic;
        }

        static void PrikaziLicnosti(List<Licnost> licnost)
        {
            //Pristapuvanje do podatocite od strukturata
            for (int i = 0; i < licnost.Count; i++)
            {
                Console.Write(licnost[i].ime + " " + licnost[i].prezime + " " + licnost[i].godini);
                Console.WriteLine();
            }
        }

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


        static List<Licnost> DolzinaNaPrezimeKoePripagjaFibonaci(List<Licnost> lisLicnost)
          {
            List<Licnost> lista = new List<Licnost>();
 
            for (int i = 0; i < lisLicnost.Count; i++)
            {
                if (pripagjaFibonaci(lisLicnost[i].prezime) == true)
                { 
                     lista.Add(lisLicnost[i]);
                }
  
            }
              return lista;
        }


        static void Main(string[] args)
        {

            Licnost lic;
            List<Licnost> listLic = new List<Licnost>();
            listLic = VnesiLicnosti();
            listLic = DolzinaNaPrezimeKoePripagjaFibonaci(listLic);

            for (int a=0;a <  listLic.Count;a++)
            {
                Console.WriteLine(listLic[a].ime + "  " + listLic[a].prezime + "  " + listLic[a].godini);
            }

        }
    }
}
