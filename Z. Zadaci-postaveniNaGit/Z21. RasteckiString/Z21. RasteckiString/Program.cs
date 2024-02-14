using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z21.RasteckiString
{
    internal class Program
    {
        static bool rasteckiString(string paramString)
        {
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
         
            }
            return rastecka;

        }
        static void Main(string[] args)
        {
            string paramString = "abcdefga";

         
            if (rasteckiString(paramString))
            {
                Console.WriteLine("Stringot "+ paramString+" e rastecki");
            }
            else
            {
                Console.WriteLine("Stringot "+ paramString+" Ne e rastecki");
            }
        }
    }
}
