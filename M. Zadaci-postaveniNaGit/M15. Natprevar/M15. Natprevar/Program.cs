using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15.Natprevar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vlezen parametar
            int N = 13;

            int kroasan = 7;
            int sok = 4;

            if(N <= 20)
            {
                //Kombinaciite
                if (N == kroasan)
                {
                    Console.WriteLine("DA");
                }
                else if (N == sok)
                {
                    Console.WriteLine("DA");
                }
                else if (N == (kroasan + sok))
                {
                    Console.WriteLine("DA");
                }
                else if (N == (kroasan + sok) + kroasan)
                {
                    Console.WriteLine("DA");
                }
                else if (N == (kroasan + sok) + sok)
                {
                    Console.WriteLine("DA");
                }
                else if (N == kroasan + kroasan)
                {
                    Console.WriteLine("DA");
                }
                else if (N == (sok + sok))
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NE");
                }
            }
           
        }
        }
}
