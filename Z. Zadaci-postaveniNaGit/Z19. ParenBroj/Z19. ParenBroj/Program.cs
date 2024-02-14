using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z19.ParenBroj
{
    internal class Program
    {
        static bool parenBroj(int a)
        {
            bool paren=false;
       
            if (a % 2 == 0) { 
                paren=true;
            }
            return paren;
        }
        static void Main(string[] args)
        {
            int a = 36;
           // Console.WriteLine(parenBroj(a));
            if (parenBroj(a))
            {
                Console.WriteLine("Brojot e paren");
            }
            else
            {
                Console.WriteLine("Brojot ne e paren");
            }

        }
    }
}
