using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M28.Cokoladna_kocka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, m, r, k;
            Tuple<int, int> divresultm, divresultn;
            string[] inputs = Console.ReadLine().Split();
            n = int.Parse(inputs[0]);
            m = int.Parse(inputs[1]);
            r = int.Parse(inputs[2]);
            k = int.Parse(inputs[3]);

            int polinja = Math.Max(m - k, k - 1) + Math.Max(r - 1, n - r);

            Console.WriteLine(polinja);
            divresultm = div(m, 2);
            divresultn = div(n, 2);

            // Check if there's an odd number of rows and columns and if the element is in the middle of the matrix
            if (m % 2 != 0 && n % 2 != 0 && k == divresultm.Item1 + 1 && r == divresultn.Item1 + 1)
            {
                Console.WriteLine(4);
                return;
            }

            // Case when the matrix has an odd number of rows or columns and the element is in an odd row or column
            if ((m % 2 != 0 && k == divresultm.Item1 + 1) || (n % 2 != 0 && r == divresultn.Item1 + 1))
                Console.WriteLine(2);
            else
                Console.WriteLine(1);
        }

        static Tuple<int, int> div(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            return Tuple.Create(quotient, remainder);
        }
   







    /* int N = 2;
     int koloni = 4;
     int R = 1;
     int K = 2
    int N = 6;
    int M = 7;
    int R = 3;
    int K = 4;

    if (N + M > 2)
    {
        R = R - 1;
        K = K - 1;
        List<int> cokolada = new List<int>();

        for (int a = 0; a < N; a++)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    if (j == 0)
                    {
                        j = 1;
                        if (a == R && i == K)
                        {
                            cokolada.Add(-1);
                            // Console.WriteLine(a);
                        }
                        else if (a == R && i == K + j)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }
                        else if (a == R && i == K - j)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }
                        else if (a == R + j && i == K)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }
                        else if (a == R - j && i == K)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }


                    }
                    else
                    {
                        Console.WriteLine(j);
                        if (a == R && i == K + j)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }

                        if (a == R && i == K - j)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }
                        if (a == R + j && i == K)
                        {
                            cokolada.Add(j);
                            //Console.WriteLine(j);
                        }
                        if (a == R - j && i == K)
                        {
                            cokolada.Add(j);
                            // Console.WriteLine(j);
                        }

                        if (a == R - j && i == K + j)
                        {
                            cokolada.Add(j);
                            //  Console.WriteLine(j);
                        }
                        if (a == R - j && i == K - j)
                        {
                            cokolada.Add(j);
                            //  Console.WriteLine(j);
                        }


                        if (a == R + j && i == K + j)
                        {
                            cokolada.Add(j);
                            //  Console.WriteLine(j);
                        }
                        if (a == R + j && i == K - j)
                        {
                            cokolada.Add(j);
                            //  Console.WriteLine(j);
                        }

                    }



                }
            }
        }

        foreach (int i in cokolada)
        {
           // Console.WriteLine(i);
        }





    }
    //if (a == 0 && i == 0)
    // {
    //     cokolada.Add(4);
    // }
    // else if (a == 0 && i == 1)
    // {
    //     cokolada.Add(3);
    // }
    // else if (a == 0 && i == 2)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 0 && i == 3)
    // {
    //     cokolada.Add(3);
    // }
    // else if (a == 0 && i == 4)
    // {
    //     cokolada.Add(4);
    // }
    // ////////////////
    // else if (a == 1 && i == 0)
    // {
    //     cokolada.Add(3);
    // }
    // else if (a == 1 && i == 1)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 1 && i == 2)
    // {
    //     cokolada.Add(1);
    // }
    // else if (a == 1 && i == 3)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 1 && i == 4)
    // {
    //     cokolada.Add(3);
    // }
    // //////////////////
    // else if (a == 2 && i == 0)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 2 && i == 1)
    // {
    //     cokolada.Add(1);
    // }
    // else if (a == 2 && i == 3)
    // {
    //     cokolada.Add(1);
    // }
    // else if (a == 2 && i == 4)
    // {
    //     cokolada.Add(2);
    // }
    // /////////////
    // else if (a == 3 && i == 0)
    // {
    //     cokolada.Add(3);
    // }
    // else if (a == 3 && i == 1)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 3 && i == 2)
    // {
    //     cokolada.Add(1);
    // }
    // else if (a == 3 && i == 3)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 3 && i == 4)
    // {
    //     cokolada.Add(3);
    // }

    // /////////
    // else if (a == 4 && i == 0)
    // {
    //     cokolada.Add(4);
    // }
    // else if (a == 4 && i == 1)
    // {
    //     cokolada.Add(3);
    // }
    // else if (a == 4 && i == 2)
    // {
    //     cokolada.Add(2);
    // }
    // else if (a == 4 && i == 3)
    // {
    //     cokolada.Add(3);
    // }
    // else if (a == 4 && i == 4)
    // {
    //     cokolada.Add(4);
    // }
    ;*/













}






    }


}


