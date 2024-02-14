using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace M11.Malo_loto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezini parametri
            // 1,2,3,5,8
            // 2,4,6,7,9
            List<int> niza = new List<int> { 1, 2, 3, 5, 8 };//987

            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            for (int i = 0; i < niza.Count; i++)
            {
                int broj;
                broj = niza[i];
                if (broj > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = broj;
                }
                else
                {
                    if (broj > max2)
                    {
                        max3 = max2;
                        max2 = broj;
                    }
                    else
                    {
                        if (broj > max3)
                        {
                            max3 = broj;
                        }
                    }
                }
            }

            string triBroja =max1+""+max2+""+max3; // Ovde gi klavam vo string za da se doblizat eden do drug
 
            int menavame= int.Parse(triBroja);// Ja menvame so parse od string vo int za da mozime da ja pomnozime so 2 

            int najgolemTrocifren = menavame * 2;

            Console.WriteLine("Najgolem trocifren broj od malo loto : " + menavame+"   i broj koj e 2 pati pogolem od nego : "+najgolemTrocifren);


        }

    
    }
}
