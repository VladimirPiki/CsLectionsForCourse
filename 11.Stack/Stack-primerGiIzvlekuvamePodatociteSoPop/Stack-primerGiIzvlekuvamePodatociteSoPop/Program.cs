using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_primerGiIzvlekuvamePodatociteSoPop
{
    class Program
    {
        //GI IZVLEKUVAME PODATOCITE OD KOLEKCIJATA PO OBRATEN REDOSLED SO Pop,
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.WriteLine(" ");

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
        }
    }
}