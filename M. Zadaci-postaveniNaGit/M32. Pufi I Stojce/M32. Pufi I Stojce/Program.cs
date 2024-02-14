using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M32.Pufi_I_Stojce
{
    internal class Program
    {
         static int Snolki(List<int> snolki)
         {
            int vkupno = 0;
            int tablica = 0;
            for (int i = 0; i < snolki.Count; i++)
            {
                vkupno += snolki[i];
            }
            for (int a = 1; a < vkupno; a++)
            {
                tablica = a * 3;
                if (vkupno < tablica)
                {
                    tablica = tablica - vkupno;

                    break;
                }
                else if (vkupno == tablica)
                {
                    tablica = tablica - vkupno;
                    break;
                }
            }
            return tablica;
         }
        static void Main(string[] args)
        {
            //List<int> snolki = new List<int>() { 2, 2, 2 };
            //List<int> snolki = new List<int>() { 2, 3, 5 };
            //List<int> snolki = new List<int>() { 0, 2, 0 };
            List<int> snolki = new List<int>() { 7, 7, 7 };

            int reshenie= Snolki(snolki);
            Console.WriteLine(reshenie);    
          

        }
    }
}
