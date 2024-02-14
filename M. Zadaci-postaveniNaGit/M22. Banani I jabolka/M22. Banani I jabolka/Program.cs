using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M22.Banani_I_jabolka
{
    internal class Program
    {
        static int IzbrojZaednickiDelitel(int B,int J)
        {
      
            int i = 1;
            int izlez = 0;
            while (i <= B)
            {
                if ((B % i == 0) && (J % i == 0))
                {
                    izlez++;
                    //     Console.WriteLine(i);
                }
                i++;
            }
            return izlez;
        }
        static void Main(string[] args)
        {
            int B = Convert.ToInt32(Console.ReadLine());
            int J = Convert.ToInt32(Console.ReadLine());

            int resenie = IzbrojZaednickiDelitel(B, J);
            Console.WriteLine("Ima: "+ resenie+ " nacini da gi podeli ovoskite.");
        }
    }
}
