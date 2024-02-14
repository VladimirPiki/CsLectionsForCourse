using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerNestedList
{
    internal class Program
    {
        static void Main()
        {
            // Part 1: add rows and columns to the List.
            List<List<int>> list = new List<List<int>>();
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                // Put some integers in the inner lists.
                List<int> sublist = new List<int>();
                int top = rand.Next(1, 4);
                for (int v = 0; v < top; v++)
                {
                    sublist.Add(rand.Next(1, 5));
                }
                // Add the sublist to the top-level List.
                list.Add(sublist);
            }
            // Display the List.
            Display(list);
        }

        static void Display(List<List<int>> list)
        {
            // Part 2: loop over and display everything in the List.
            Console.WriteLine("Elements:");
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            // Part 3: display element.
            Console.WriteLine("Element at 1, 0:");
            Console.WriteLine(list[1][0]);
            // Part 4: display total count.
            int count = 0;
            foreach (var sublist in list)
            {
                count += sublist.Count;
            }
            Console.WriteLine("Count:");
            Console.WriteLine(count);
        }
    }
}
