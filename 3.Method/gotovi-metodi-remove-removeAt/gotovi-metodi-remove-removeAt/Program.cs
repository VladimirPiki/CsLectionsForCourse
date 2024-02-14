using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotovi_metodi_remove_removeAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kako se koristi medota remove, da otstranime broevi so odredena vrednost, pr 10 ja ostranuva 10
            var broevi = new List<int>() { 10, 20, 30, 40, 10 };

             bool ima = broevi.Remove(10); // removes the first 10 from a list
             if (ima == true)
             {
                 Console.WriteLine("Otstranet e brojot 10");
             }
             else
             {
                 Console.WriteLine("Ne postoi broj so baranata vrednost");
             }

            broevi.RemoveAt(2); //se otstranuva brojot na pozicija 2

             //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

             foreach (var broj in broevi)
                 Console.WriteLine(broj); //prints 20 30
             
        }
    }
}
