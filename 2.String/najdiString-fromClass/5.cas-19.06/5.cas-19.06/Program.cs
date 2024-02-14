
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.cas_19._06 //Ucime za string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ucime za string - pretstavuva niza od karakteri, posebna klasa koja ima metodi koja sluzi za obrotka

             string str = "asdfasdfasdfa3";
             char ch = '3';

             int brojac = 0;
             for (int i = 0; i < str.Length; i++)
             {
                 if (ch == str[i])
                 {
                     brojac++;
                    Console.WriteLine(ch);
                 }
             }

            //Console.WriteLine(brojac);

            //Vrednost na karakter
            // Console.WriteLine((int)ch);

            //da najdete kolku pati stringo s se povtoruva vo str
         /*   string str = "asdfahsdfhggasdfasfasddddashhmgg";
            string subString = "gg";

            int brojac = 0;
             for (int i = 0; i < str.Length-1; i++)
             {

                if (str[i] == subString[0] && subString[1] == str[i + 1])
                {
                    //Console.WriteLine(subString[0]);
                    brojac++;
                }

             }
            
             Console.WriteLine(brojac);

            //So foreach kolku ima tolku za razmisluvanje

            // Prv primer
            /*int[] broevi = { 2, 3, 5, 8, 10 };
             string[] gradovi = { "Prilep", "Skopje", "Ohrid" };


             for (int i = 0; i < gradovi.Length; i++)
             {
                 Console.WriteLine(gradovi[i]);
             }


             foreach (var grad in gradovi)
             {
                 Console.WriteLine(grad);
             }*/
            /*  int[] broevi = { 2, 3, 5, 8, 10 };
              string[] gradovi = { "Prilep77", "Skopje", "Ohrid" };

              int max = 0;
              for (int i = 0; i < gradovi.Length; i++)
              {
                  if (max < gradovi[i].Length)
                      max = gradovi[i].Length;


              }
              Console.WriteLine(max);
              // povtoruvanje na potsring da njadime resenie kolku pati potstring se povtoruva vo daden string
              // nie imame reseno zadaca koja gi nagja site rastecki podnizi potpolno istiot kod i za opagjacki sting 13 14
              // karakteri unikati 

              string str1 = "adasdasdasdasdf";
              //Unikati od koj e sostaven ovaj string asdf potrebno e da najdime koj se unikati vo ovaj string najdobro e da sostavite nov string koj gi ima unikatite
              string unikati = "asdf";
            */


            string[] gradovi = { "Bitola", "Prilep", "Resen" };
            for(int i=0; i < gradovi.Length; i++)
            {
                for(int j=0; j < gradovi[i].Length; j++)
                {
                    if (gradovi[i] == "Resen")
                    {
                        Console.WriteLine(gradovi[i][j]);
                    }
                }
              //  Console.WriteLine(gradovi[i]);
            }
        }

    }
}
