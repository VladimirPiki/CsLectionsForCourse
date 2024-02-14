using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M23.Baba_Rada_I_Baba_nada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            List<int> list = new List<int>() {4,2,1};

            int soberiOstanati = 0;

            int zbirLista = 0;

            for (int i=0; i < list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];
              
                zbirLista += list[i];
            }

            int povekeMax = 0;
            foreach(int broj in list )
            {
                if (broj == max)
                    povekeMax++;
            }

            int rezultat;


            if (povekeMax > 1)
            {
                rezultat=zbirLista;
            }
            else
            {
                foreach(int broj in list )
                {
                    if (broj != max)
                        soberiOstanati += broj;
                }

                int cekanje = max - soberiOstanati;

                for (int i = 0; i < list.Count; i++)
                {
                    soberiOstanati += list[i];
                }

                if (cekanje > 0)
                {
                    rezultat = zbirLista + cekanje;
                }
                else
                    rezultat = zbirLista;

            }

            Console.WriteLine(rezultat);

        }
    }
}
