using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.RasteckaOpagjackaLista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = new List<int> { 7, 6, 5, 3, 3, 1 };
            bool rastecka = true;
            bool opagjacka = true;

            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[i - 1])
                {
                    opagjacka = false;
                    // Console.WriteLine(lista[i]);
                }
                else
                {
                    rastecka = false;

                }

            }

            if (rastecka)
            {
                Console.WriteLine("listata e rastecka");
            }
            else if (opagjacka)
            {
                Console.WriteLine("listata e opgjacka");
            }
            else
            {
                Console.WriteLine("listata ne ni rastecka ni opagjacka");
            }

        }
    }
}
