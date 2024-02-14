using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z24.ListaBroeviNaFibonaci
{
    internal class Program
    {
        List<int> ListaBroeviNaFibonaci(List<int> lista)
        {
            List<int> fibonaciLista = new List<int>();
            foreach (int i in lista)
            {

                int prv = 0;
                int vtor = 1;

                if (prv == i || vtor == i)
                {
                    fibonaciLista.Add(i);
                }

                while (vtor < i)
                {
                    int tret = vtor + prv;
                    prv = vtor;
                    vtor = tret;
                    if (vtor == i)
                    {
                        fibonaciLista.Add(i);
                    }
                }


            }
            return fibonaciLista;

        }
        static void Main(string[] args)
        {
            List<int> listaZaProverka = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 88, 89, 10946, 109478 };
            List<int> fibonaciLista = new List<int>();

            Program obj = new Program();
            fibonaciLista = obj.ListaBroeviNaFibonaci(listaZaProverka);

            foreach (int a in fibonaciLista)
            {
                Console.WriteLine("Brojot od fibonaci listata: " + a);
            }
        }
    }
}
