using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_ContainsKey_TryGetValue
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imame lista numberNames so key:int, value:string. Listata ne se podreduva
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"},
                {"France", "Paris, Lyon, Lille"}
            };
            Console.Write("Primer za Dictionary. Pecatigi vrednostite kaj so ima kluc cities[\"UK\"] i cities[\"USA\"]");
            Console.WriteLine();
            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
           // Console.WriteLine(cities["Macedonia"]); // run-time exception: Key does not exist - KE VRATI ERROR BIDEJKI GO NEMA
            Console.WriteLine();

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.Write("Proveri dali postoj kako kluc France. Ako postoj Pecatigo cities[\"France\"]");
                Console.WriteLine();
                Console.WriteLine(cities["France"]);
                Console.WriteLine();
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.Write("Izvadija vrednosta Ako postoj France i klaja vo string result i ke pecatis preku result");
                Console.WriteLine();
                Console.WriteLine(result);
                Console.WriteLine();
            }

            Console.Write("Koristi ElementAt i pecatija cela lista cities, za vrakjanje na vrednosta kluc-vrednost e preku indexo ");
            Console.WriteLine();
            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
           
                Console.WriteLine("Key: {0}, Value: {1}",
                                                         cities.ElementAt(i).Key,
                                                         cities.ElementAt(i).Value);
            }




        }
    }
}