using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z23.BrojNaParniBroeviVoLista
{
    internal class Program
    {
        static int brojNaParniBroeviVoLista(List<int>lista)
        {
            int broj = 0;
            foreach (int i in lista) { 
                   if(i % 2 == 0)
                {
                    broj++; 
                }            
            }
            return broj;    
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);    
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("Brojot na parni broevi vo listata iznesuva "+brojNaParniBroeviVoLista(list));

        }
    }
}
