using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M27.T
{
    internal class Program
    {
        static int ZbirPosledovatelniVoLista(int slobodnoVreme, int epizodi,List<int> list)
        {
            int zbirEpizodi = 0;
            int epizodiIzgledani = 0;
            int maxEpizodi = 0;

            for (int i = 0; i < epizodi; i++)
            {
                for (int a = i; a < list.Count; a++)
                {
                    zbirEpizodi += list[a];
                    if (zbirEpizodi <= slobodnoVreme)
                    {
                        epizodiIzgledani++;

                        if (maxEpizodi < epizodiIzgledani)
                        {
                            maxEpizodi = epizodiIzgledani;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                epizodiIzgledani = 0;
                zbirEpizodi = 0;
            }

            return maxEpizodi;
        }
        static void Main(string[] args)
        {
            int slobodnoVreme = 74;
            int epizodi = 13;
            //List<int> list = new List<int>() {23,21,22,21};// 4  65
            // List<int> list = new List<int>() { 12, 13, 14, 12, 11, 11 };// 6 50
            List<int> list = new List<int>() { 10, 11, 11, 11, 11, 20,10,10,10,10,1,1,1 };// max 9, vreme 74

            int resehenie = ZbirPosledovatelniVoLista(slobodnoVreme, epizodi, list);
            Console.WriteLine("Davido vo slobodnoto vreme moze da izgleda najmnogu: "+ resehenie+" epizodi");   
 
        }
    }
}
