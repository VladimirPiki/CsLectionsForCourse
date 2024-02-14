using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoda_najdi_najgolem_broj_lista
{
    internal class Program
    {
        int NajgolemBroj(List<int> lis)
        {
            int najgolemBroj;
            najgolemBroj = lis[0];

            for (int i = 0; i < lis.Count; i++)
            {
                if (najgolemBroj < lis[i])
                    najgolemBroj = lis[i];
            }
            return najgolemBroj;
        }


        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 11, 2, 3, 15, 8 };
            Program obj = new Program();

            Console.WriteLine("Najgolem broj vo nizata e  " + obj.NajgolemBroj(lista));
        }
    }
}
