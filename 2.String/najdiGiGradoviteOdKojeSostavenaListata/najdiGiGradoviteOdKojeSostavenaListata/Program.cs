using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace najdiGiGradoviteOdKojeSostavenaListata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Vaka e tocna
             *  List<string> list = new List<string>() {"Prilep","Bitola","Prilep","Bitola","Strumica","Tetovo","Strumica","Gostivar" };
              string unikat = "";

              for (int i = 0; i < list.Count; i++)// Ovdee pocnuva vo prvata pozicija od stringot i ja baram dali ja ima vo ostanatite
              {
                  bool duplikat = true;//zadavam promenliva dali e duplikat
                  for (int j = i + 1; j < list.Count; j++)// tuka sekoja sledna pozicija od stringo ja sporedvam so zemenata pozcija  i vrednostite gi sporedvam od stringot
                  {
                      if (list[i] == list[j])// Ako vrednostite se isti imame duplikat vo stringot i ne odi ponatamu prodolzi da baras druga bukva od stringot
                      {
                          duplikat = false;        
                          break;
                      }
                  }
                  if (duplikat)
                  {
                      unikat += list[i];
                      Console.WriteLine(list[i]);
                  }

              }
              Console.WriteLine("   ");
              Console.WriteLine(unikat);*/

            /*List<string> list = new List<string>() { "Prilep", "Bitola", "Prilep", "Bitola", "Strumica", "Tetovo", "Strumica", "Gostivar","kicevo","kicevo" };
            List<string> unikati = new List<string>();
            string unikat = "";
            for (int i = 0; i < list.Count; i++)
            {
                bool duplikat = true;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])// Ako vrednostite se isti imame duplikat vo stringot i ne odi ponatamu prodolzi da baras druga bukva od stringot
                    {
                        duplikat = false;
                        break;
                    }
                }
                if (duplikat)
                {
                     unikat += list[i];
                    if (unikat.Length > 0)
                    {
                        unikati.Add(unikat);
                    }
                    // Console.WriteLine(list[i]);
                }
                    unikat = "";
             
            }
           // Console.WriteLine(unikat);
           foreach(string u in unikati)
            {
                Console.WriteLine(u);
            }*/

   /*         string str = "vladimirkrstevski";// prvo ja provervam [0] i ako ja najdis ne ja zapisvaj kako unikatna, ako ne zapisija
            string unikat = "";
            int brojac = 0;
            for (int i = 0; i < str.Length; i++)// Ovdee pocnuva vo prvata pozicija od stringot i ja baram dali ja ima vo ostanatite
            {
                bool duplikat = true;//zadavam promenliva dali e duplikat
                for (int j = i + 1; j < str.Length; j++)// tuka sekoja sledna pozicija od stringo ja sporedvam so zemenata pozcija  i vrednostite gi sporedvam od stringot
                {
                    if (str[i] == str[j])// Ako vrednostite se isti imame duplikat vo stringot i ne odi ponatamu prodolzi da baras druga bukva od stringot
                    {
                        duplikat = false;
                        break;
                    }
                }
                if (duplikat)
                {
                    unikat += str[i];

                    //Console.WriteLine(str[i]);
                }

                bool poranajdeno = false; // boolean za proverka go klavam ne tocno bidejki ko ke go najdi istio char ke bidi true

                if (poranajdeno)
                {
                    //brojac++; // Ako go pronajdeno zgolemi
                }
            }

            Console.WriteLine(unikat);

            Console.WriteLine(unikat.Length);*/

            List<string> list = new List<string>() { "Prilep", "Bitola", "Prilep", "Bitola", "Strumica", "Tetovo", "Strumica", "Gostivar", "kicevo", "kicevo" };
            List<string> unikati = new List<string>();
            string unikat = "";
            for (int i = 0; i < list.Count; i++)
            {
                bool duplikat = true;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])// Ako vrednostite se isti imame duplikat vo stringot i ne odi ponatamu prodolzi da baras druga bukva od stringot
                    {
                        duplikat = false;
                        break;
                    }
                }
                if (duplikat)
                {
                    unikat += list[i];
                    if (unikat.Length > 0)
                    {
                        unikati.Add(unikat);
                    }
                    // Console.WriteLine(list[i]);
                }
                unikat = "";

            }
  
      
            foreach (string str in unikati)
            {
                Console.WriteLine(str);
                int unikatniKarakteri = 0;

                string unikatStr = "";
                for (int i = 0; i < str.Length; i++)// Ovdee pocnuva vo prvata pozicija od stringot i ja baram dali ja ima vo ostanatite
                {
                   // Console.WriteLine(str[0]);
                    bool duplikatStr = true;//zadavam promenliva dali e duplikat
                    for (int j = i + 1; j < str.Length; j++)// tuka sekoja sledna pozicija od stringo ja sporedvam so zemenata pozcija  i vrednostite gi sporedvam od stringot
                    {
                        if (str[i] == str[j])// Ako vrednostite se isti imame duplikat vo stringot i ne odi ponatamu prodolzi da baras druga bukva od stringot
                        {
                            duplikatStr = false;
                            break;
                        }
                    }
                    if (duplikatStr)
                    {
                        unikatStr += str[i];
                        unikatniKarakteri++;
                       // Console.WriteLine(str[i]);
                    }

  
                }

               // Console.WriteLine(unikatStr);

                //Console.WriteLine(unikatStr.Length);

            }
           // Console.WriteLine(unikatStr);
            //Console.WriteLine(unikatniKarakteri);


        }
    }
}
