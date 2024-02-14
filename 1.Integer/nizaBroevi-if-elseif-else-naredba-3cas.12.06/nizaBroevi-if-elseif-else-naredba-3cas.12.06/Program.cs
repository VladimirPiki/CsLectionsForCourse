using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nizaBroevi_if_elseif_else_naredba_3cas._12._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if elseif naredba
             * 
             * int[] nizaBroevi = new int[] { 90, 91, 92, 97, 95, 92, 100 };
             int brojacPomali92 = 0;
             int brojac92 = 0;
             int brojacPogolemi92 = 0;

             for (int i = 0; i < nizaBroevi.Length; i++)
             {
                 if (nizaBroevi[i] < 92)
                 {
                     brojacPomali92++;
                 }
                 else if (nizaBroevi[i] > 92)
                 {
                     brojacPogolemi92++;
                 }
                 else
                 {
                     brojac92++;
                 }
             }
             Console.WriteLine("Broevi pogolemi od 92  " + brojacPogolemi92);
             Console.WriteLine("Broevi pomali od 92  " + brojacPomali92);
             Console.WriteLine("Broevi ednakvi na 92  " + brojac92); */



            /* Do while naredba
             * int a = 10;

             do
             {
                 Console.WriteLine(a);
                 a = a + 1;
             }
             while (a < 20);*/

            /* foreach
            int[] nizaBroevi = new int[] { 99, 91, 92, 97, 95, 92, 100 };
            foreach (int broj in nizaBroevi)
            {
                Console.WriteLine(broj);
            }
            */


            /* Pecati gi site pomali broevi od 20, no koga ke stignis 15 break - izlezi, a ova {0} znaci pecatija i prvata vrednost, ako sakame da ja pecati i prvata vrednost povrzano so conzolata za pecatenje
            int a = 10;

            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;

                if (a > 15)
                {

                    break;
                }
            }
            */

            /*
            int a = 10;


            do
            {
                if (a == 15)
                {

                    a = a + 1;
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
            */


            /*Ova e lista , kolekcii so sopstveni metodi, se dodava so Add
             * 
            List<int> nizaBroevi = new List<int>();
            //dodavame podatoci
            nizaBroevi.Add(1); // adding elements using add() method
            nizaBroevi.Add(2);
            nizaBroevi.Add(3);
            nizaBroevi.Add(131232133);
            for (int i = 0; i < nizaBroevi.Count; i++)
            {
                Console.WriteLine("broevi :" + nizaBroevi[i]);
            }
            */
            /*
            List<int> lista = new List<int> { 3, 23, 4, 3, 5, 7, 8 };

            lista.Add(8);

            foreach (int broj in lista)
            {
                Console.WriteLine(broj);
            }
            */
        }
    }
}
