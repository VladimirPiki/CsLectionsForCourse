using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M23.Baba_Rada_I_Baba_nada
{
    internal class Program
    {
        static int Raspored(List<int> list)
        {
            int max = 0;

            int soberiOstanati = 0;

            int zbirLista = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
                zbirLista += list[i];
            }

            int povekeMax = 0;
            foreach (int broj in list)
            {
                if (broj == max)
                {
                    povekeMax++;//ako ima isti maksimumi nema da se cekat
                }

            }

            int rezultat;


            if (povekeMax > 1)// nema da se cekat
            {
                rezultat = zbirLista;//zbiro od listata odi krajnovreme
            }
            else
            {
                foreach (int broj in list)
                {
                    if (broj != max)//ako go nema maksimumo
                    {
                        soberiOstanati += broj;//soberi gi site ostanati
                    }

                }

                int cekanje = max - soberiOstanati;//vremeto so ke gopominat vo ostanatite odzemigo od maksimumot

                if (cekanje > 0)//dodajgo cekajanjeto
                {
                    rezultat = zbirLista + cekanje;
                }
                else
                {
                    rezultat = zbirLista;
                }


            }

          return rezultat;
        }
        static void Main(string[] args)
        {
            List<int> parametri = new List<int>() { 6, 2, 1};
            int resenie = Raspored(parametri);
            Console.WriteLine("Ke si zaminat doma za : "+resenie+" minuti");

        }
    }
}
