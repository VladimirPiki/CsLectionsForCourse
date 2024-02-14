
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_removePair
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Hashtable 
            Hashtable myTable = new Hashtable();

            // Adding elements in Hashtable 
            myTable.Add("2", "Even & Prime");
            myTable.Add("3", "Odd & Prime");
            myTable.Add("4", "Even & non-prime");
            myTable.Add("9", "Odd & non-prime");

            // Print the number of entries in Hashtable 
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);

            // To remove the elements from Hashtable 
            // which has key as "3" 
            myTable.Remove("3");

            // Print the number of entries in Hashtable 
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);

            // To remove the elements from Hashtable 
            // which has key as "4" 
            myTable.Remove("4");

            // Print the number of entries in Hashtable 
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);

            // Adding elements in Hashtable 
            myTable.Add("g", "geeks");
            myTable.Add("c", "c++");
            myTable.Add("d", "data structures");

            // Print the number of entries in Hashtable 
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);

            // To remove the elements from Hashtable 
            // which has key as "c" 
            myTable.Remove("c");

            // Print the number of entries in Hashtable 
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);


        }
    }
}

