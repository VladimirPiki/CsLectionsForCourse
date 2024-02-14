using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoda_zadaci
{
    internal class Program
    {
      
            static int Soberi(int a, int b)
            {
                int c;
                c = a + b;
                return c;
            }
            static int Odzemi(int a, int b)
            {
                int c;
                c = a - b;
                return c;
            }
            static int Mnozi(int a, int b)
            {
                int c;
                c = a * b;
                return c;
            }

            static void Main(string[] args)
            {
                int a = 3;
                int b = 4;
                Program obj = new Program();
                int c;
                c = Soberi(a, b);
                Console.WriteLine("Zbirot e edankov na " + c);
                c = Odzemi(a, b);
                Console.WriteLine("Razlika e edankov na " + c);
                c = Mnozi(a, b);
                Console.WriteLine("Proizvoditel e edankov na " + c);
        }


       
    }
}
