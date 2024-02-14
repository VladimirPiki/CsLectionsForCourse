using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M28.Cokoladna_kocka
{
    internal class Program
    {

        static Tuple<int, int> div(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            return Tuple.Create(quotient, remainder);

        }
        static void Main(string[] args)
        {
            int n, m, r, k;
            Tuple<int, int> divresultm, divresultn;
            string[] inputs = Console.ReadLine().Split();
            n = int.Parse(inputs[0]);
            m = int.Parse(inputs[1]);
            r = int.Parse(inputs[2]);
            k = int.Parse(inputs[3]);

            int polinja = Math.Max(m - k, k - 1) + Math.Max(r - 1, n - r);

            Console.WriteLine(polinja);
            divresultm = div(m, 2);
            divresultn = div(n, 2);

            //gi opfaka primerite koga imas nearen broj na redici i koloni i pritoa 
            //elementot e na sredina vo matricata
            if (m % 2 != 0 && n % 2 != 0 && k == divresultm.Item1 + 1 && r == divresultn.Item1 + 1)
            {
                Console.WriteLine(4);
                return;
            }

            //slucaj koga matricata ima neapren broj na redici ili koloni i elementot se najduva 
            //vo neparnata redicia ili kolona
            if ((m % 2 != 0 && k == divresultm.Item1 + 1) || (n % 2 != 0 && r == divresultn.Item1 + 1))
                Console.WriteLine(2);
            else
                Console.WriteLine(1);
        }

    }
}
