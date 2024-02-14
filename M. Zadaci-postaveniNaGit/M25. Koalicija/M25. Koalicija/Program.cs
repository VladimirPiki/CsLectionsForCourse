using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M25.Koalicija
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /* int broj;
             Console.Write("Vnesi broj: ");

             broj = Convert.ToInt32(Console.ReadLine());

             double rezultat;

             rezultat = 2 * (Math.Pow(2, broj) - 1);

             Console.WriteLine(rezultat);*/

            Console.WriteLine("Vnesete broj na ministerstva: ");
            int brojMinisterstva = Convert.ToInt32(Console.ReadLine());
            int politickiPar = 2;
            int rezultat = 0;
            int stepen = 1;
            for (int i = 0; i < brojMinisterstva; i++)
            {
                rezultat = rezultat + stepen * politickiPar;
                stepen = stepen * 2;
            }

            Console.WriteLine("Vkupniot broj na kombinacii iznesuva: " + rezultat);


        }

    }
}
