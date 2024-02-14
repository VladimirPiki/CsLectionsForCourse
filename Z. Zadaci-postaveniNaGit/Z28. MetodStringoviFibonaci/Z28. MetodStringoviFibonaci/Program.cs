using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28.MetodStringoviFibonaci
{
    internal class Program
    {
       static List<string> ListaBroeviNaFibonaci(List<string> lista)
        {
            List<string> fibonaciLista = new List<string>();
            foreach (string i in lista)
            {

                int prv = 0;
                int vtor = 1;

                if (prv == i.Length || vtor == i.Length)
                {
                    fibonaciLista.Add(i);
                }

                while (vtor < i.Length)
                {
                    int tret = vtor + prv;
                    prv = vtor;
                    vtor = tret;
                    if (vtor == i.Length)
                    {
                        fibonaciLista.Add(i);
                    }
                }


            }
            return fibonaciLista;

        }
        static void Main(string[] args)
        {
            List<string> listaZaProverka = new List<string>() { "", "a", "vv", "bbb", "cccc", "ccccg", "cccchh", "ccccjjj", "cccckkkk", "ccckkkkkkkkc", "nnn", "aaa", "ccccs","123456789101112131415" };
            List<string> fibonaciLista = new List<string>();

            fibonaciLista = ListaBroeviNaFibonaci(listaZaProverka);

            foreach (string a in fibonaciLista)
            {
                Console.WriteLine("Listata so dolzina od fibonaci : " + a);
            }
        }
    }
}
