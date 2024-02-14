using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Doagjaat_vakcini___regionalen_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> proizvoditeli = new List<int> { 30, 7, 5, 10, 10 };
            int zastitetni = 2;
            int dveDoziVakcina;
            int maxLugjeZastiteni=0;
               foreach( int vakcini in proizvoditeli)
            {
                dveDoziVakcina = vakcini / zastitetni;
                maxLugjeZastiteni = maxLugjeZastiteni + dveDoziVakcina;
            }
            Console.WriteLine(maxLugjeZastiteni);
        }
  
    }
}
