using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static int MetodaUnikatiKarakteriVtoroResenie(string str)
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
            int izbroj =unique.Length;
            return izbroj;
        }
        static void Main(string[] args)
        {
            List<string> str = new List<string>() { "UK", "London", "Ukraina", "dad", "USA", "Chicago", "New York", "Bombaj", "Bitola", "tetovo","dadada","nenene" };
            var strings = new Dictionary<int, string>();
          //  int kolkuRazKarakteri = 0;
            for (int i = 0; i < str.Count; i++)
            {
              int  kolkuRazKarakteri = MetodaUnikatiKarakteriVtoroResenie(str[i]);
              //Console.WriteLine(kolkuRazKarakteri);
                if (!strings.ContainsKey(kolkuRazKarakteri))
                {
                    strings[kolkuRazKarakteri] = str[i];
                }
                else if (strings.ContainsKey(kolkuRazKarakteri))
                {
                    strings[kolkuRazKarakteri] = strings[kolkuRazKarakteri] + " " + str[i];
                }
            }
            foreach (KeyValuePair<int, string> kvp in strings)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
