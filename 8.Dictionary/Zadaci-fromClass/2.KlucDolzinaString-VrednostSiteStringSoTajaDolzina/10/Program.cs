using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>() { "UK", "London", "Ukraina", "dad", "USA", "Chicago", "New York", "Bombaj", "Bitola", "tetovo" };
            var strings = new Dictionary<int, string>();

            for (int i = 0; i < str.Count; i++)
            {
               
                if (!strings.ContainsKey(str[i].Length))
                {
                    strings[str[i].Length] = str[i];

                }
                else if (strings.ContainsKey(str[i].Length))
                {
                    strings[str[i].Length] = strings[str[i].Length] + " " + str[i];
                }
            }
            foreach (KeyValuePair<int, string> kvp in strings)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        
    }
    }
}
