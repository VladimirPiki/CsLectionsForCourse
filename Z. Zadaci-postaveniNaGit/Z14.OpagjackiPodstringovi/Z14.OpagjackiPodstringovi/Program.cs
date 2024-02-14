using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14.OpagjackiPodstringovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////      1 |  2 |  3 | 4 |5
            string subString = "dcbahdcbaponmlzgfwwa";
            int opagjackiiNizi = 0;
            int brojac = 0;
            bool opagjacka = false;
            for (int i = 1; i < subString.Length; i++)
            {


                //int broj = str[i];
                if (subString[i] > subString[i - 1])
                {
       
                    //Console.WriteLine((int)subString[i] + " > " + (int)subString[i - 1]);
                    if (brojac > 1)
                    {
                        opagjacka = false;
                        opagjackiiNizi++;
                        brojac = 1;
                    }
                }
                else
                {
                    brojac++;
                    //Console.WriteLine((int)subString[i] + " < " + (int)subString[i - 1]);
                    if (subString[i] == subString.Length - 1)
                    {
                        opagjacka = false;
                        opagjackiiNizi++;
                        break;
                    }
                    opagjacka = true;

                }


            }
            if (opagjacka)
            {
                opagjackiiNizi++;
                Console.WriteLine("Substringot e opagjacki");
            }
            Console.WriteLine("Substringot sozdrzi : " + opagjackiiNizi + " opagjacka niza");
        }
    }
}
