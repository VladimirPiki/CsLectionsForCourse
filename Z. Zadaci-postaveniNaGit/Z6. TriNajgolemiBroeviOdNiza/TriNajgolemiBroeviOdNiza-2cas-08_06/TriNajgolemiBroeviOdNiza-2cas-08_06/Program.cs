using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriNajgolemiBroeviOdNiza_2cas_08_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niza = new[] { 90, 44, 33, 45, 10, 119, 222, 122, 21, 43 };
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            for (int i = 0; i < niza.Length; i++)
            {
                int broj;
                broj = niza[i];
                if (broj > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = broj;
                }
                else
                {
                    if (broj > max2)
                    {
                        max3 = max2;
                        max2 = broj;
                    }
                    else
                    {
                        if (broj > max3)
                        {
                            max3 = broj;
                        }
                    }
                }
            }

            Console.WriteLine("Najgolem prv broj vo nizata e : " + max1);

            Console.WriteLine("Najgolem vtor broj vo nizata e : " + max2);

            Console.WriteLine("Najgolem tret broj vo nizata e : " + max3);
        }
    }
}
