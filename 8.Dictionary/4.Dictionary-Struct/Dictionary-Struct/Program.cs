using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Struct
{
    class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public string emb;
            public string godini;
        }
        static void Main(string[] args)
        {

            Dictionary<string, Licnost> Licnosti = new Dictionary<string, Licnost>();
            Licnost lic;
            lic.ime = "Vladimir";
            lic.prezime = "Krstevski";
            lic.emb = "3311777410005";
            lic.godini = "25";

            Licnosti.Add(lic.emb, lic);
        }
    }
}
