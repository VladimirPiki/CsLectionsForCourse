using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M24.Pisi_brisi
{
    internal class Program
    {

        static string NezapisvajBrojNaPozicija(int N,int M,int K)
        {
            int zacuvajK = K;
            string zapisiBrojki = "";
            string brisani = "";
            for (int i = N; i <= M; i++)
            {
                zapisiBrojki += i.ToString();
            }

            for (int a = 0; a < zapisiBrojki.Length; a++)
            {

                if (a == K - 1)
                {
                    K = K + zacuvajK;
                }
                else
                {
                    brisani += zapisiBrojki[a];
                }

            }
            return brisani;
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine()); 
            int K = Convert.ToInt32(Console.ReadLine());

            string resenie = NezapisvajBrojNaPozicija(N, M, K);
            Console.WriteLine("Reshenie: "+resenie.Length);
      
        }
    }
}
