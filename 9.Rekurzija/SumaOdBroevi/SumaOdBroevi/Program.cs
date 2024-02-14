using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaOdBroevi
{
    internal class Program
    {
        static int SumaOdBroevi(int broj)
        {
            if (broj == 0)
                return 0;
            else
            {
                return broj % 10 + SumaOdBroevi(broj / 10);
            }
        }
        static void Main(string[] args)
        {
            int broj = 54323;
            Console.WriteLine(SumaOdBroevi(broj));
        }
    }
}
