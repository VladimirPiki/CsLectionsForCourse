using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11.KoiSeRasteckiNizizVoListata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////     1                2                    3                4            5           6
            List<int> lista = new List<int> { 3, 4, 55, 44, 10, 17, 18, 55, 40, 39, 12, 13, 14, 9, 8, 10, 11, 12, 10, 11, 12, 11, 23, 45, 56 };

            int rasteckiNizi = 0;
            int brojac = 0;
 
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[i - 1])
                {
                    brojac++;


                    // rastecki.Add(lista[i]);
                    List<List<int>> redici = new List<List<int>>(); // Dodavame dve nizi i gi dodavme elementite od rasteckata niza
                    {
                        
                        List<int> koloni = new List<int>();// vo list koloni dodavme vrednostite
                        koloni.Add(lista[i]);// vrednosti
                        redici.Add(koloni);

                    }
 
                    for (int a = 0; a < redici.Count; a++)// foro ni sluzi za da gi izbrojme redicite
                    {
                       
                        for (int j = 0; j < redici[a].Count; j++)// ni sluzi da gi najdime vrednostite vo redicite, so toa sto ke brojme kolku koloni ima vo redicite
                        {
                            Console.Write(redici[a][j] + "  ");// Ovde gi pecatime vrednostite od kolonite
                        }
                        // Console.WriteLine();
                    }
    

                    if (i == lista.Count - 1)
                    {
                        rasteckiNizi++;

                       // Console.WriteLine();
                        Console.WriteLine("         elementi od  niza : " + rasteckiNizi );// gi pecatime rasteckite nizi 
                        break;
                    }
                }
                else
                {
                    //Console.WriteLine();       
                    if (brojac > 1)
                    {
                        rasteckiNizi++;
                        Console.WriteLine("         elementi od rastecka niza : " + rasteckiNizi);// gi pecatime rasteckite nizi 
                        brojac = 1;
                    }

                }

            }

        }
    }
}
