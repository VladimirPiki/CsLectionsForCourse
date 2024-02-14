using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            //Ova ne gi sortira tuku gi klava kako so se
            Console.Write("1. Primer za Dictionary. Imame lista numberNames so key:int, value:string. Listata ne se podreduva");
            Console.WriteLine();
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(11, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add(0, "Threes");
            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


            Console.WriteLine();
          
        }
    }
}
