using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16.Stedenje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezni parametri
            int K = 19;
            int A = 8;
            int B = 9;

            int denaPominati = 0;
            int kire = K;
            int mete = 0;


            if (K < 20 && A < 10 && B < 10)//Uslov za vleznite parametri
            {
                if (A < B)
                {
                    for(int i =0; i < 20; i++)// 20 postavuvam poradi toa sto max K mozi da odi do 20 dena
                    {
                        denaPominati++;
                        kire = kire + A;
                        mete=mete+B;

                        if (kire == mete)
                        {              
                            Console.WriteLine("Posle "+denaPominati+" dena kasickite na Kire i na Mete ke bidat izednaceni");
                            break;
                        }
                        if(kire < mete) //Vo slucaj da ne mozat da bidat izednaceni bidejki Mete da ima pojke pari od Kire
                        {
                            Console.WriteLine("NE");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("NE");
                }
            }
            else
            {
                Console.WriteLine("Vleznite parametri ne se tocni");
            }
        }
    }
}
