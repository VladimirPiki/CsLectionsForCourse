using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        //Ova lista Stack ima za cel da gi vadi po obraten redosled vrednostite, ako klavame 1,2,3,4 ke vadi 4,3,2,1 i se koristi Push
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1, 
        }
    }
}