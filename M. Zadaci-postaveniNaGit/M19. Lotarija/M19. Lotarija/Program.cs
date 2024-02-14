using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M19.Lotarija
{
    internal class Program
    {
        static bool lotarija(List <int> izvleceni, List<int> livce)
        {
            bool dobitno = false;
            int brojNaIzvleceni=izvleceni.Count;
            int broj = 0;
            for (int i = 0; i < livce.Count; i++)
            {
                for (int j = 0; j < izvleceni.Count; j++)
                {
                    if (livce[i] == izvleceni[j])
                    {
                        broj++;
                        livce.RemoveAt(i);
                        izvleceni.RemoveAt(j);
                        break;
                    }
                }
            }
            if (broj == brojNaIzvleceni)
            {
                dobitno = true;
            }
            else
            {
                dobitno = false;
            }
            return dobitno;
        }
        static void Main(string[] args)
        {
     
            List<int> livce = new List<int>() { 10, 15, 20, 25, 30, 30, 12, 15, 12, 12, 15, 20, 20, 25, 13, 14, 15, 16, 10, 11, 11, 12, 13, 15, 20, 23, 23, 23, 23, 20 };
            List<int> izvleceni = new List<int>() { 10, 13, 13, 20, 30, 20, 15 };

            if (lotarija(izvleceni,livce))
            {
                Console.WriteLine("DA");
            }else
            {
                Console.WriteLine("NE");
            }

        }
    }
}
