using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.MetodaUnikatiKarakteri
{
    internal class Program
    {
        static string MetodaUnikatiKarakteri(string str)
        {
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
            return unikat;
        }

        static string MetodaUnikatiKarakteriVtoroResenie(string str)
        {
            string unique = "";

            foreach (char ch in str)
            {
                bool razlikuva = true;

                for (int i = 0; i < unique.Length; i++)
                {
                    if (ch == unique[i])// provervam unikatnite dali gi ima vo stringot ako gi ima false 
                    {
                        razlikuva = false;
                        break;
                    }
                }

                if (razlikuva)// ako ja nema vo unikatnata vo proverkata go polnam stringot so char od unikatnata
                {
                    unique += ch;
                }
            }
            return unique;
        }
        static void Main(string[] args)
        {
            string str = "vladimirkrstevski";// prvo ja provervam [0] i ako ja najdis ne ja zapisvaj kako unikatna, ako ne zapisija

            Console.WriteLine(MetodaUnikatiKarakteri(str));

            Console.WriteLine(MetodaUnikatiKarakteriVtoroResenie(str));
        }
    }
}
