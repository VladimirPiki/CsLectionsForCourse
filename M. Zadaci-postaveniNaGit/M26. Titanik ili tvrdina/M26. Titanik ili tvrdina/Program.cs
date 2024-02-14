using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M26.Titanik_ili_tvrdina
{
    internal class Program
    {
        static bool Tvdrina(int N, int X, int Y, int V)
        {
            bool tip1 = false;
            List<int> listaPrvRed = new List<int>();
            List<int> listaVtorRed = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    listaPrvRed.Add(0);
                    listaVtorRed.Add(1);
                }
                else if (i % 2 == 0)
                {
                    listaPrvRed.Add(0);
                    listaVtorRed.Add(1);
                }
                else
                {
                    listaPrvRed.Add(1);
                    listaVtorRed.Add(0);
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (i == Y)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < listaPrvRed.Count; j++)
                        {
                            if (j == X)
                            {

                                if (listaPrvRed[j] == V)
                                {
                                    tip1 = true;
                                }

                            }

                        }
                    }
                    else if (i % 2 == 0)
                    {
                        for (int j = 0; j < listaPrvRed.Count; j++)
                        {
                            if (j == X)
                            {
                                if (listaPrvRed[j] == V)
                                {
                                    tip1 = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < listaVtorRed.Count; k++)
                        {
                            if (k == X)
                            {
                                if (listaVtorRed[k] == V)
                                {
                                    tip1 = true;
                                }

                            }

                        }
                    }
                }
            }
            return tip1;
        }
        static bool Titanik(int N, int X, int Y, int V)
        {
            bool tip2 = false;
            int odzemaj = 1;
            List<int> listaTrialognik = new List<int>();
            for (int i = 0; i < N; i++)
            {
                listaTrialognik.Add(1);
            }

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < listaTrialognik.Count; j++)
                    {
                        if (i == X && j == Y && listaTrialognik[j] == V)
                        {
                            tip2 = true;
                        }

                    }
                }
                else if (i % 2 == 0)
                {
                    odzemaj = listaTrialognik.Count - i;
                    for (int j = 0; j < listaTrialognik.Count; j++)
                    {
                        if (j == odzemaj)
                        {
                            listaTrialognik.RemoveAt(j);

                            listaTrialognik.Add(0);
                        }

                        if (i == X && j == Y && listaTrialognik[j] == V)
                        {
                            tip2 = true;
                        }
                    }

                }
                else
                {
                    odzemaj = listaTrialognik.Count - i;
                    for (int j = 0; j < listaTrialognik.Count; j++)
                    {
                        if (j == odzemaj)
                        {
                            listaTrialognik.RemoveAt(j);

                            listaTrialognik.Add(0);

                        }

                        if (i == X && j == Y && listaTrialognik[j] == V)
                        {
                            tip2 = true;
                        }
                    }

                }
            }
            return tip2;
        }

        static void Main(string[] args)
        {
            int N = 4;
            int X = 0;
            int Y = 1;
            int V = 1;
            if (Tvdrina(N, X, Y, V))
            {
                if (Tvdrina(N, X, Y, V) && Titanik(N, X, Y, V))
                {
                    Console.WriteLine("3");
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
            else if (Titanik(N, X, Y, V))
            {
                if (Tvdrina(N, X, Y, V) && Titanik(N, X, Y, V))
                {
                    Console.WriteLine("3");
                }
                else
                {
                    Console.WriteLine("2");
                }

            }
            else
            {
                Console.WriteLine("4");
            }
        }
    }
}
