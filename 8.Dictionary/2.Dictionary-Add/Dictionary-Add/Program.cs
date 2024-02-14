using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Add
{
    //ZA BRISHENJE
    //ja ostranuvame so AuthorList.Remove("Mahesh Chand");
    //brisi stie elementi AuthorList.Clear();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2. Primer. Imame lista cities so key:string, value:string. Listata ne se podreduva");
            Console.WriteLine();
            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine();

            cities["UK"] = cities["UK"] + "  Bitola";
            cities["USA"] = cities["USA"] + "  Strumica";
            cities["India"] = cities["India"] + "  Demir Hisar";
            Console.Write("Dodavame kaj so e klucot cities[UK] Bitola, kluc:USA value:Strumica i  cities[\"India\"] = cities[\"UK\"] + \"  Demir Hisar");
            Console.WriteLine();
            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
