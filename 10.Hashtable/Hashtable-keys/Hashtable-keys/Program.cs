using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Hashtable 
            Hashtable myTable = new Hashtable();

            // Adding elements in Hashtable 
            myTable.Add("4", "Even");
            myTable.Add("9", "Odd");
            myTable.Add("4", "Odd and Prime");
            myTable.Add("2", "Even and Prime");

            // Get a collection of the keys. 
            ICollection c = myTable.Keys;

            // Displaying the contents 
            foreach (string str in c)
                Console.WriteLine(str + ": " + myTable[str]);
        }
    }
}
