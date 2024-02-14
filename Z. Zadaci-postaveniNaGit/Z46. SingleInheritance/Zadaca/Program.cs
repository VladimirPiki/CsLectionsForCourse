using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ClassA
    {
        internal string str;

        public int OdreduvaDolzinaString()
        {
            return str.Length;
        }
        public bool DaliPostojOdredenPodstring(string subString)
        {
            bool daliPostoj = false;
            for (int i = 0; i <= str.Length - subString.Length; i++)
            {
                bool pronajdeno = true;

                for (int a = 0; a < subString.Length; a++)
                {
                    if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                    {
                        pronajdeno = false;
                        break;
                    }
                    if (pronajdeno)
                    {
                        daliPostoj = true;
                        break;
                    }
                }
            }
                return daliPostoj;
        }

        public int KolkuPatiSePovtoruvaOdredenPodstring(string subString)
        {
            int kolkuPati= 0;
            for (int i = 0; i <= str.Length - subString.Length; i++)
            {
                bool pronajdeno = true;

                for (int a = 0; a < subString.Length; a++)
                {
                    if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                    {
                        pronajdeno = false;
                        break;
                    }

                }
                if (pronajdeno)
                {
                    kolkuPati++;

                }
            }
            return kolkuPati;
        }
    }

    // Derived class
    class ClassB : ClassA
    {
        public ClassB(string s)
        {
            str = s;
        }
        public bool DaliStringotErastecki()
        {
            bool rastecki = false;
            for(int i =1;i< str.Length; i++)
            {
                if (str[i] > str[i - 1])
                {
                    rastecki = true;
                }
                else
                {
                    rastecki = false; break;
                }
            }
            return rastecki;
        }

        public bool DaliStringotEopagjacki()
        {
            bool opagjacki = false;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] < str[i - 1])
                {
                    opagjacki = true;
                }
                else
                {
                    opagjacki = false; break;
                }
            }
            return opagjacki;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassB Rect = new ClassB("cba");

            Console.WriteLine("Dolzina na string: " + Rect.OdreduvaDolzinaString());
            // Print the area of the object.
            if (Rect.DaliPostojOdredenPodstring("imi")==true)
            {
                Console.WriteLine("Postoj");
            }
            else
            {
                Console.WriteLine("Nepostoj");
            }

    
                Console.WriteLine("Se povtoruva odreden podstring: "+ Rect.KolkuPatiSePovtoruvaOdredenPodstring("imi"));

            Console.WriteLine("Dali e rastecki: " + Rect.DaliStringotErastecki());


            Console.WriteLine("Dali e opagjacki: " + Rect.DaliStringotEopagjacki());

            Console.ReadKey();
        }
    }
}
