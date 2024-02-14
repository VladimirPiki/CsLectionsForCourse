using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15.KarakteriUnikati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vo zadacata sekoja bukva ja provervam dali ja ima vo ostanatite ako ja ima ne ja zapisvaj ako ja nema zapisija vo unikatni i taka sekoja sledna 
            string str = "vladimirkrstevski";// prvo ja provervam [0] i ako ja najdis ne ja zapisvaj kako unikatna, ako ne zapisija
            string unikat = "";

            for (int i = 0; i < str.Length; i++)// Ovdee pocnuva vo prvata pozicija od stringot i ja baram dali ja ima vo ostanatite
            {
                bool duplikat = true;//zadavam promenliva dali e duplikat
                for (int j = i + 1; j < str.Length; j++)// tuka sekoja sledna pozicija od stringo ja sporedvam so zemenata pozcija  i vrednostite gi sporedvam od stringot
                {
                    if (str[i] == str[j])// Ako vrednostite se isti imame duplikat vo stringot i ne odi ponatamu prodolzi da baras druga bukva od stringot
                    {
                        duplikat = false;
                        break;
                    }
                }
                if (duplikat)
                {
                    unikat += str[i];
                    //Console.WriteLine(str[i]);
                }
            }
            Console.WriteLine(unikat);
        }
    }
}
