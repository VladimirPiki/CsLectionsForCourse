

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_PrikazuvamePosledenElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);// prints 4

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); // prints 4
                Console.WriteLine(myStack.Peek()); // prints 4
            }

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);// prints 4
        }
    }
}

