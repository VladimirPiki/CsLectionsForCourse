using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedListKeyZgolemuva
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> numberNames = new SortedList<string, int>() // Vo ova sortedlist se podredeni po: string e kluc, int e vrednost
                                    {
                                        {"tri",3},
                                        {"eden",1},
                                        {"dva",2}
                                    };
            numberNames["dva"]++;// vo ovaj slucaj dodavme vo listata kade sto ima kluc == dva, i se napravi {key: dva, value: 3}, AKO GO NEMA ke vrati eror bidejki ne postoj takov kluc
            string s = "dva";// Mozime da zgolevame so varijabila od tipot string bidejki e klucot e string, AKO GO NEMA stringot ke vrati error
          numberNames[s]++;// dodavame ustee ednas na klucot "dva" i se napravi {key: dva, value: 4}
            for (int i = 0; i < numberNames.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
            }
        }
    }
}
