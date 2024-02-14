using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"},
                                        {5, "Five"},
                                        {4, "Four"}
                                    };

          numberNames.Remove(1);//removes key 1 pair --- ke se izbrisi po key celo ke go nema vo ovaj primer:    {1, "One"},
           numberNames.Remove(10);//removes key 1 pair, no error if not exists ---  ke se izbrisi po key, NO AKO GO NEMA NEMA DA VRATI ERROR

            /*
             *                  ostanvat vaka 
                          
                                        {2, "Two"},
                                         {3, "Three"},
                                         {4, "Four"} 
                                        {5, "Five"},
                                
             */


            numberNames.RemoveAt(0);//removes key-value pair from index 0 --- ke go izbrisi paro so vrednost od nizata [0] vo sklucajo    {2, "Two"},
            /* numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException -- vo ovaj slucaj vrakja erorr bidejki izlegva od nizata */


            /*                            ostanvat vaka 
                                          
                                         {3, "Three"},
                                         {4, "Four"} 
                                        {5, "Five"},
                                
             */

            foreach (var kvp in numberNames)// var e koga  Type of 'kvp' not clear. nezname so ke vrati kako povratna vrednost i var odlucva sto da vrati
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
