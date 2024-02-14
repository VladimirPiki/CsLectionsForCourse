using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a dictionary using collection-initializer syntax
            List<string> str = new List<string>() { "UK","London", "Ukraina", "Birmingham","USA","Chicago","New York","Bombaj", "Bitola","10" };
            var strings=new Dictionary<char,string>();

            for (int i = 0; i < str.Count; i++)
            {
                if (!strings.ContainsKey(str[i][0]))
                {
                    strings[str[i][0]] = str[i];

                }
                else if (strings.ContainsKey(str[i][0]))
                {
                    strings[str[i][0]] = strings[str[i][0]] + " " + str[i];
                }
            }
            foreach (KeyValuePair<char, string> kvp in strings)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
