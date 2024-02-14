using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajgoleBrojNizaDesetElementi_2cas_08_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niza = new int[] { 110, 44, 33, 45, 124, 119, 222, 123, 21, 43,333,444,555 };
            
            int max=niza[0];
            int maxDeset = 10;
            for (int i = 0; i < niza.Length; i++) {
                int broj = niza[i];
           
                if(i == maxDeset)/// ako nizata ima nad 10 elementi, ke izlezi kodo i ke ispecati maximalen broj  do tie 10 elementi
                {
                    break;
                }
                else
                {
                    if (broj > max)
                    {
                        max = broj;
                    }
                }

              
            }
             Console.WriteLine("Najgolem broj vo nizata od 10 elementi e : " + max);

        }
    }
}
