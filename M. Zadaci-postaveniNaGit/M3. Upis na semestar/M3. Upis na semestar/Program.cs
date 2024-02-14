using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3.Upis_na_semestar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> studenti = new List<int> { 50, 30, 40 };
            int minDen=1;
            int minStudenti = studenti[0];

            for (int i = 0; i < studenti.Count; i++)
            {

                if (studenti[i] < minStudenti)
                {
                    minStudenti = studenti[i];
                   
                    minDen = minDen + i;
                    
                }
            }


            Console.WriteLine(minDen);
            Console.WriteLine(minStudenti);


        }
    }
}
