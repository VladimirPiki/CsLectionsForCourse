using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkuPatiStringSePovtorvaVoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Da najdime koj string kolku pati se povtoruva vo dadena lista

            SortedList<string, int> numberNames = new SortedList<string, int>();// Gi dodavame vo sortirana lista site stringoj i mu dodelvame vrednosti, kluc e string, vrednost e broj (kolku pati se povtorva), se podredvat po prvata bukva od klucot

            List<string> stringoj = new List<string>() { "vladimir", "vladimir", "krstevski", "bitola", "bitola", "da", "da" };



            for (int i = 0; i < stringoj.Count; i++)// Gi vadime site stringoj od listata stringoj
            {


                if (!numberNames.ContainsKey(stringoj[i]))//Ako go nema stringo mu dodelvame vrednost 1
                {
                    numberNames[stringoj[i]] = 1;

                }
                else if (numberNames.ContainsKey(stringoj[i]))//Ako go ima stringo ja zgolevame vrednosta
                {
                    numberNames[stringoj[i]]++;
                }
            }


            foreach (KeyValuePair<string, int> v in numberNames)// gi listame dobienite rezulatati od sortiranata lista
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }

        }
    }
}
