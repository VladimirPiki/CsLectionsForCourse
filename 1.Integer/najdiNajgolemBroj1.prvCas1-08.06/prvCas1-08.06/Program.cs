using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvCas1_08._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
              int a = 33; int b = 4;
                //Dva razlicnio broevi
            if (a > b)
            {
                Console.WriteLine("a e pogolemo od b");
            }
            else {
                Console.WriteLine("B e pogolemo od a");
                }
            

            //definirame niza broevi i sakame da go najdime najgolemiot broj

             int[] nizaBroevi = new int[] { 99, 98, 92, 97, 95 };
             int max = nizaBroevi[0];

             for(int i=1;i < nizaBroevi.Length; i++)// metoda length
             {

                 if(max < nizaBroevi[i])
                 {
                     max = nizaBroevi[i];
                 }

             }
             Console.WriteLine(max);

            int brojac = 0;
            while(brojac < 5)
            {
                Console.WriteLine("brojacot ima vrednost " + brojac);
                brojac++;
            }

             
        }


       

    }
}
