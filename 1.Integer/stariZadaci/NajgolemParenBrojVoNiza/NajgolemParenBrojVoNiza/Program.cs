using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajgolemParenBrojVoNiza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niza = new[] { 91, 42, 33, 45, 11, 111, 222, 243, 21, 43 };
            int maxParen = 0; //Bi trebalo da stoi null, ako vo slucaj nema paren broj ke ispecatio deka najgolem paren broj e 0 (nula ke ispecati max paren broj = 0)
            int broj;

            for (int i = 0; i < niza.Length; i++)
            {
                broj = niza[i];

                if (broj % 2 == 0)
                {
                    if (broj > maxParen)
                    {
                        maxParen = broj;
                    }
                }
            }
            Console.WriteLine("Maksimalen paren broj vo nizata e :" + maxParen);
        }
    }
}
