using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12.PovtoruvanjePodstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////0123456789123456789
            string str = "vladecdefhhgggavavladeaegvladvladeggvladevladevlade";
            string subString = "cde";

            int brojac = 0;

            for (int i = 0; i <= str.Length - subString.Length; i++)// Dolzinata mu ja kratam bidejki ko ke go zgolevam i so str[i+a] ke izlezi od foro i ke klam da gi proveri kolku so e dolzinata na subStringot bidejki poslednite ostanati od stringot ako gi ima pomalce od subString ke bidi ne tocno bidejki nema da gi cita site
            {
                bool poranajdeno = false; // boolean za proverka go klavam ne tocno bidejki ko ke go najdi istio char ke bidi true

                for (int a = 0; a < subString.Length; a++)
                {
        
                    if (str[i+a] == subString[a])// Provervaj sekoe sleden char ako e ist so vo stringot
                    {
                        poranajdeno = true;
                        //Console.WriteLine(subString[a]);
                    }
                    else
                    {
                        poranajdeno = false;
                        break;// ako ne go najdis char izlezi i so toa baraj go vo sledniot i
                    }
                }

                if (poranajdeno)
                {
                    brojac++; // Ako go pronajdeno zgolemi
                }
            }

            Console.WriteLine("Substringot se povtorva " + brojac + " pati vo stringot.");

            ///do tuka
        }
    }
}
