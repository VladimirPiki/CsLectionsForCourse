using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13.RasteckiPodstringovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////       1     2    3
            string subString= "abcdbafghibayz";
            int rasteckiNizi = 0;
            int brojac = 0;
            bool rastecka = false;
            string rastecki = "";
            List<string> rezultat = new List<string>();
            for (int i = 1; i < subString.Length; i++)
            {
           
                if (subString[i] > subString[i - 1])
                {
                    brojac++;
                    if (subString[i] == subString.Length - 1)
                    {
                        rastecka = false;
                        rasteckiNizi++;
                        break;
                    }
                rastecki += subString[i];
                    rastecka= true;
                }
                else
                {
                    if (brojac > 1)
                    {
                        rastecka = false;
                        rasteckiNizi++;
                        brojac = 1;
                    }
                   

                }
       

            }
            if (rastecka)
            {
               rasteckiNizi++;
                Console.WriteLine("Substringot e rastecki");
            }
           //Console.WriteLine("Substringot sozdrzi : " + rasteckiNizi + " elementi");
            Console.WriteLine(rastecki);
            foreach (string s in rezultat)
            {
                Console.WriteLine(s);
            }
        }
    }
}
