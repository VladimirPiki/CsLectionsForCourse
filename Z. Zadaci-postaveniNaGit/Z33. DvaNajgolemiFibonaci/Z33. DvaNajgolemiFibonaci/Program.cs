using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33.DvaNajgolemiFibonaci
{
    internal class Program
    {
        static bool pripagjaFibonaci(int param)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == param)
            {
                pripagja = true;
            }
            if (vtor == param)
            {
                pripagja = true;
            }


            while (vtor < param)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == param)
                {
                    pripagja = true;
                }
            }

            return pripagja;

        }
        static List<int> NajgolemiDvaBroevi(List<int> nizaBroevi)
        {
            List<int> listaSoDvaNajgolemiBroevi = new List<int>();
 
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < nizaBroevi.Count; i++)
            {
                if (nizaBroevi[i] > max1)
                {
                    max2 = max1;
                    max1 = nizaBroevi[i];
                }
                else
                {
                    if (nizaBroevi[i] > max2)
                    {
                        max2 = nizaBroevi[i];
                    }
                }
            }
            listaSoDvaNajgolemiBroevi.Add(max1);
            listaSoDvaNajgolemiBroevi.Add(max2);
            return listaSoDvaNajgolemiBroevi;
        }

        static List<int> proveriFibonaci(List<int> lista)
        {
            List<int> novaLista = new List<int>();
            List<int> listaNajgolemiDvaBroja = new List<int>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (pripagjaFibonaci(lista[i]) == true)
                {
                    novaLista.Add(lista[i]);
                }
              
            }
            listaNajgolemiDvaBroja = NajgolemiDvaBroevi(novaLista);

            return listaNajgolemiDvaBroja; // ja vrakam listata
        }

        static void Main(string[] args)
        {
            List<int> listaZaProverka = new List<int>() { 10,13,22, 10946, 28657, 832040,7,9, 832043, 11 };
            listaZaProverka = proveriFibonaci(listaZaProverka);

            foreach (int a in listaZaProverka)
            {
                Console.WriteLine(a);
            }

        }
    }
}
