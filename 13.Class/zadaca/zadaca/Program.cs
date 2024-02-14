using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca
{
    internal class Program
    {
        class Karakter
        {

            string mStr;

            public Karakter()
            {

            }
            public Karakter(string str)
            {
                mStr = str;

            }
            public int GetStrLenght()
            {
                return mStr.Length;
            }

            public int GetCharContains(char karakter)
            {
                int kolkuSePovtoruva = 0;
                foreach(char c in mStr)
                {
                    if(c == karakter)
                    {
                        kolkuSePovtoruva++;
                    }
                }
               
                return kolkuSePovtoruva;
            }

        }
        static void Main(string[] args)
        {
            char bukva = 'r';
            Karakter objLic = new Karakter("Goranrr");
            Console.WriteLine(objLic.GetStrLenght() + "  " + objLic.GetCharContains(bukva));
        }
    }
}
