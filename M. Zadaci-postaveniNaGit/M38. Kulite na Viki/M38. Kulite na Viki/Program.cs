using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M38.Kulite_na_Viki
{
    internal class Program
    {
        static void VisiniNaKulite()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int X = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //int A = 2;
            //int B = 1;
            //int C = 4;
            //int X = 2;//Visina
            //int N = 2;//Kocki

            //int A = 2;
            //int B = 3;
            //int C = 2;
            //int X = 3;//Visina
            //int N = 1;//Kocki

            List<int> list = new List<int>();
            list.Add(A);
            list.Add(B);
            list.Add(C);

            list.Sort();
            int kocki = 0;
            while (kocki < N)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                    {
                        list[i] = list[i] + X;
                        list.Sort();
                        break;
                    }

                }
                kocki++;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {
         VisiniNaKulite();  
        }
    }
}
