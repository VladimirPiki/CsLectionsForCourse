using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotovi_metodi_Sort_Reverse_CompareTo_Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Gotovi funkcii za sortiranje Sort() : od najmal do najgolem, a Reverse() od najgolem kon najmal, Insert(pozicijaVoNiza,vrednosta) */
            var broevi = new List<int> { 2, 1, 8, 0, 4, 3, 5, 7, 9 };

            broevi.Sort();
            foreach (var broj in broevi)
            {
                Console.Write(broj + "  ");
            }
            Console.WriteLine();
            broevi.Reverse();
            foreach (var broj in broevi)
            {
                Console.Write(broj + "  ");
            }

            Console.WriteLine();

            //Vo slucaj koga imame memorirano podatoci od string 
            var zborovi = new List<string> { "asdfasdfnnnnn", "asdfaa", "gs", "asdssaa" };
            zborovi.Sort();
            //podreduva po dolzina na zborot
            zborovi.Sort((a, b) => a.Length.CompareTo(b.Length));
            foreach (var zbor in zborovi)
            {
                Console.Write(zbor + "  ");
            }

            Console.WriteLine();

            //Vmetnuvanje podatoci na odredena lokacija
            var broevi1 = new List<int>() { 10, 20, 30, 40 };

            broevi1.Insert(1, 11);// na lokacija 1 se vnesuva brojot 11.

            foreach (var broj in broevi1)
                Console.Write(broj + " ");
        }
    }
}
