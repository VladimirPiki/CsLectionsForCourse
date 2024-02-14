
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_onlyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Hashtable 
            Hashtable myTable = new Hashtable();

            // Adding elements in Hashtable 
            myTable.Add("g", "geeks");
            myTable.Add("c", "c++");
            myTable.Add("d", "data structures");
            myTable.Add("q", "quiz");

            // Get a collection of the values 
            ICollection c = myTable.Values;

            // Displaying the contents 
            foreach (string str in c)
                Console.WriteLine(str);


        }
    }
}
