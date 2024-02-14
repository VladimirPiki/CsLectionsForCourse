using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32.VmetniBroj5
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
        static List<int> proveriFibonaci(List<int> lista)
        {
            List<int> novaLista = new List<int>();// gi dodavam vo nova lista

            for (int i = 0; i < lista.Count; i++)
            {
                if (pripagjaFibonaci(lista[i]) == true)
                {
                    novaLista.Add(5); // dodaj 5 
                }
                novaLista.Add(lista[i]); // dodaj go brojot so go provervas od listata
            }

            return novaLista; // ja vrakam listata
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            List<int> listaZaProverka = new List<int>() { 10,13,8,7,6,5,4,3,2,1,0 };

            listaZaProverka = proveriFibonaci(listaZaProverka);

            foreach (int a in listaZaProverka)
            { 
                Console.WriteLine(a);
            }
            
        }
    }
}
