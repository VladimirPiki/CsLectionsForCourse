using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.Otvoranje_na_zgrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vlezni parametri
            int L = 100;
            int X = 50;
  
            int celBroj = X * L;
            celBroj = celBroj / 100;
            double decimalanBroj = X * L;
            decimalanBroj = decimalanBroj / 100;
/*          Console.WriteLine("celBroj: " + celBroj);
            Console.WriteLine("decimalanBroj " + decimalanBroj);*/
            int maxBrojGosti=celBroj;

            if (decimalanBroj > celBroj)
            {
                Console.WriteLine("Maksimalen broj na gosti vo salata e : "+maxBrojGosti);// Cout
            }else
            {
                maxBrojGosti = maxBrojGosti - 1;
                Console.WriteLine("Maksimalen broj na gosti vo salata e : " + maxBrojGosti);
            };
            
        }
    }
}
