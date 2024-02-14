using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8.NajgolemParenBroj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 3, 23, 4, 3, 5, 7, 8 };
            int max = 0;
            foreach (int broj in lista)
            {
                if (broj % 2 == 0)
                {
                    if (broj > max)
                    {
                        max = broj;
                    }

                }

            }
            Console.WriteLine("najgolem paren broj e : " + max);
        }
    }
}
