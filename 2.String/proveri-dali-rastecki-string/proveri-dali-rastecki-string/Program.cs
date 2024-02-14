using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proveri_dali_rastecki_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string paramString = "abcdefga";
            bool rastecka = false;

            for (int i = 1; i < paramString.Length; i++)
            {

                if (paramString[i] > paramString[i - 1])
                {
                    rastecka = true;
                }
                else
                {
                    rastecka = false;
                    break;
                }

                Console.WriteLine(paramString[i]);
            }
            if (rastecka)
            {
                Console.WriteLine("Stringot e rastecki");
            }
            else
            {
                Console.WriteLine("Stringot Ne e rastecki");
            }
        }
    }
}
