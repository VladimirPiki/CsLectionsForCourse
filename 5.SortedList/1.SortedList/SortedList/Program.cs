using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ako vo sortiranata lista ima ist key nemozi da se vnesi, ako ima isti value mozi da se vnesi
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);// prazno
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");
            numberNames.Add(9, "");// prazno
            numberNames.Add(8, "Five");// isti value pak go zapisva Five

            foreach (KeyValuePair<int, string> v in numberNames)//Defines a key/value pair that can be set or retrieved.
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }
        }
    }
}
