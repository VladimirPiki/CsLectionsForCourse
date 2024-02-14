using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaci_notFromClass
{
    internal class Program
    {
        public static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;
            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == number;
        }
        static void Main(string[] args)
        {
            int number = 1346269;
            if (IsFibonacci(number))
            {
                Console.WriteLine("Brojot " + number + " pripagja na fibonaci");
            }
            else
            {
                Console.WriteLine("Brojot ne pripgja na fibonaci");
            }
        }
    }
}
