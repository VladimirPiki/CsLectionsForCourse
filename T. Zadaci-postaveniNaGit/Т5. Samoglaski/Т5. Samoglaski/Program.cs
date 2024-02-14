using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т5.Samoglaski
{
    internal class Program
    {
        static void Samoglaski()
        {
            string str = "Vladimiro e u Makedonija";
            SortedDictionary<char, int> KrajnaLista = new SortedDictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 'a' || str[i] == 'u' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o')
                {
                    if (!KrajnaLista.ContainsKey(str[i]))
                    {
                        KrajnaLista[str[i]] = 1;
                    }
                    else if (KrajnaLista.ContainsKey(str[i]))
                    {
                        KrajnaLista[str[i]]++;
                    }
                }



            }
            foreach (KeyValuePair<char, int> v in KrajnaLista)
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }
        }
        static void Main(string[] args)
        {
            Samoglaski();
        }
    }
}
