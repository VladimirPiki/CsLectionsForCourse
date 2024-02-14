using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9.BrojNaRasteckiNiziVoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////     1                2                    3                4            5           6
            List<int> lista = new List<int> { 3, 4, 55, 44, 10, 17, 18, 55, 40, 39, 12, 13, 14, 9, 8, 10, 11, 12, 10, 11, 12,11,23,45,56 };
            int rasteckiNizi = 0;
            int brojac = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[i - 1])
                {
                    brojac++;
                    if (i == lista.Count - 1)
                    {
                        rasteckiNizi++;
                        break;
                    }
                }
                else
                {
           
                    if (brojac > 1)
                    {
                        rasteckiNizi++;
                        brojac = 1;
                    }

                }

            }
            Console.WriteLine(rasteckiNizi);
        }
    }
}
