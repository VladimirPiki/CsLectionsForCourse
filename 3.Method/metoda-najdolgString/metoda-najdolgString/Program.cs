using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoda_najdolgString
{
    internal class Program
    {
        string najdolgString(List<string> lisString)
        {
         
            int max = 0;
            string najdolgString = "";
            for (int i = 0; i < lisString.Count; i++)
            {

                if (max < lisString[i].Length)
                {
                    max = lisString[i].Length;
                    najdolgString = lisString[i];  
                }

            }
            
            return najdolgString;
        }


        static void Main(string[] args)
        {
            List<string> lisString = new List<string>() { "Prilep", "Prilepaaaa", "Bitolaaaaaaaaaaaaa", "tetovo", "gostivar" };
            Program obj = new Program();

            Console.WriteLine("Najdolg string vo nizata e  " + obj.najdolgString(lisString));
        }
    }
}
