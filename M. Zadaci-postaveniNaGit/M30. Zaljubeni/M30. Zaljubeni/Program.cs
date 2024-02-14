using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M30.Zaljubeni
{
    internal class Program
    {
        static int Zaljubeni(int M,int N ,int U,int D,int L,List<int> avtobus)
        {
            int reshenie = 0;
            int trosi = 0;
            int minTrosi = 100000;
            int minTrosiSlegvanje = 100000;
            int trosiBezAvtobus = 0;
            int temp = 0;

            //Trosi so avtobus
            for (int i = 0; i < avtobus.Count; i++)
            {
                ///Najdi vo koj avtobus da se kaci
                ///
                if (M > avtobus[i])
                {
                    temp = M;
                    M = M - avtobus[i];
                    trosi = M * D;
                    if (trosi < minTrosi)
                    {
                        minTrosi = trosi;
                    }
                    M = temp;
                    temp = 0;
                    trosi = 0;
                }
                if (M < avtobus[i])
                {
                    temp = M;
                    M = avtobus[i] - M;
                    trosi = M * U;
                    if (trosi < minTrosi)
                    {
                        minTrosi = trosi;
                    }
                    M = temp;
                    temp = 0;
                    trosi = 0;
                }
                if (M == avtobus[i])
                {
                    trosi = 0;
                    if (trosi < minTrosi)
                    {
                        minTrosi = trosi;
                    }
                    trosi = 0;
                }

                //Najdi vo koj avtobus ke slezi
                if (N > avtobus[i])
                {
                    temp = N;
                    N = N - avtobus[i];
                    trosi = N * U;//Krste zivej pogore od postojkata zato ke se kacva Vesna
                    if (trosi < minTrosiSlegvanje)
                    {
                        minTrosiSlegvanje = trosi;
                    }
                    N = temp;
                    temp = 0;
                    trosi = 0;
                }

                if (N < avtobus[i])
                {
                    temp = N;
                    N = avtobus[i] - N;
                    trosi = N * D;//Krste zivej podolu od postojkata zato ke slegva Vesna
                    if (trosi < minTrosiSlegvanje)
                    {
                        minTrosiSlegvanje = trosi;
                    }
                    N = temp;
                    temp = 0;
                    trosi = 0;
                }

                if (N == avtobus[i])
                {
                    trosi = 0;
                    if (trosi < minTrosiSlegvanje)
                    {
                        minTrosiSlegvanje = trosi;
                    }
                    trosi = 0;
                }



            }
            //  Console.WriteLine(minTrosi);
            //Console.WriteLine(minTrosiSlegvanje);

            //Trosi bez avtobus
            if (N > M)//ako krste nagore
            {
                N = N - M;
                trosiBezAvtobus = N * U;
            }
            else if (M > N)
            {
                M = M - N;
                trosiBezAvtobus = M * D;
            }
            else if (M == N)
            {
                trosiBezAvtobus = 0;
            }
            int trosiSoAvtobus = minTrosi + minTrosiSlegvanje;

            if (trosiSoAvtobus < trosiBezAvtobus)
            {
                reshenie = trosiSoAvtobus;
            }
            else
            {
                reshenie = trosiBezAvtobus;
            }
            return reshenie;
        }
        static void Main(string[] args)
        {
            //int M = 4;
            //int N = 9;
            //int U = 2;
            //int D = 1;
            //int L = 2;
            //List<int> avtobus = new List<int>() { 5, 8 };

            int M = 4;
            int N = 9;
            int U = 2;
            int D = 1;
            int L = 6;
            List<int> avtobus = new List<int>() { 1, 3, 6, 10, 11, 14 };

            //int M = 3;
            //int N = 20;
            //int U = 5;
            //int D = 7;
            //int L = 5;
            //List<int> avtobus = new List<int>() { 1, 3, 15, 20, 25 };


            //int M = 20;  //  AKO VESNA ZIVEJ POGORE
            //int N = 5;
            //int U = 5;
            //int D = 7;
            //int L = 5;
            //List<int> avtobus = new List<int>() { 1, 3, 15, 20, 25 };

            //int M = 5;
            //int N = 3;
            //int U = 5;
            //int D = 7;
            //int L = 5;
            //List<int> avtobus = new List<int>() { 10, 30, 15, 20, 25 };
            int reshenie = Zaljubeni(M, N, U, D, L, avtobus);
            Console.WriteLine("Vesna najmalku edinici ke potrosi: " + reshenie);

        }
    }
}
