using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoda_kolekcii
{
    class Program
    {
        //Kolekcii ovde treba obj da se klaj, metodata fakticki da ne bidi static chna
        List<int> PogolemiOdPet(List<int> lis)
        {
            List<int> pogolemi = new List<int>();

            for (int i = 0; i < lis.Count; i++)
            {
                if (lis[i] > 5)
                    pogolemi.Add(lis[i]);
            }
            return pogolemi;
        }


        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 11, 2, 3, 15, 8 };
            List<int> pogolemi = new List<int>();
            Program obj = new Program();

            pogolemi = obj.PogolemiOdPet(lista);

            for (int i = 0; i < pogolemi.Count; i++)
            {
                Console.WriteLine(pogolemi[i]);
            }

        }
    }
}