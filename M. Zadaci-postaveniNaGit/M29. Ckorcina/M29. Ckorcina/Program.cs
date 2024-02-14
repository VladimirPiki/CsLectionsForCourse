using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M29.Ckorcina
{
    internal class Program
    {
        static int Ckorcinja(int ckorcinja)
        {
            int brojCkorce = 0;
            SortedList<int, int> list = new SortedList<int, int>();
            for (int i = 0; i <= 9; i++)
            {
                if (i == 0)
                {
                    brojCkorce = 6;
                    list.Add(i, brojCkorce);
                }
                else if (i == 1)
                {
                    brojCkorce = 3;
                    list.Add(i, brojCkorce);
                }
                else if (i == 2)
                {
                    brojCkorce = 5;
                    list.Add(i, brojCkorce);
                }
                else if (i == 3)
                {
                    brojCkorce = 5;
                    list.Add(i, brojCkorce);
                }
                else if (i == 4)
                {
                    brojCkorce = 4;
                    list.Add(i, brojCkorce);
                }
                else if (i == 5)
                {
                    brojCkorce = 5;
                    list.Add(i, brojCkorce);
                }
                else if (i == 6)
                {
                    brojCkorce = 5;
                    list.Add(i, brojCkorce);
                }
                else if (i == 7)
                {
                    brojCkorce = 3;
                    list.Add(i, brojCkorce);
                }
                else if (i == 8)
                {
                    brojCkorce = 7;
                    list.Add(i, brojCkorce);

                }
                else if (i == 9)
                {
                    brojCkorce = 5;
                    list.Add(i, brojCkorce);
                }

            }

            string reshenie = "";
            int maxReshenie = 0;
            List<string> reshenija = new List<string>();
            foreach (KeyValuePair<int, int> v in list)
            {
                foreach (KeyValuePair<int, int> a in list)
                {
                    foreach (KeyValuePair<int, int> b in list)
                    {
                        foreach (KeyValuePair<int, int> c in list)
                        {
                            if ((v.Value + a.Value + b.Value + c.Value) == ckorcinja)
                            {

                                // Console.WriteLine(v.Key + " " + a.Key + " " + b.Key + " " + c.Key + "                " + v.Value + " " + a.Value + " " + b.Value + " " + c.Value);
                                // Console.WriteLine(v.Key + " " + a.Key + " " + b.Key + " " + c.Key);
                                reshenie += v.Key + "" + a.Key + "" + b.Key + "" + c.Key;
                                reshenija.Add(reshenie);
                                reshenie = "";
                            }

                        }
                    }
                }
            }


            foreach (string r in reshenija)
            {
                if (r != "")
                {
                    if (maxReshenie < Int16.Parse(r))
                    {
                        maxReshenie = Int16.Parse(r);
                    }
                }

            }
            if (maxReshenie > 0)
            {
                return maxReshenie;
            }
            else
            {
                maxReshenie = -1;
                return maxReshenie;
            }
        }
        static void Main(string[] args)
        {
            int ckorcinja = 13;
            int reshenie = Ckorcinja(ckorcinja);
            Console.WriteLine(reshenie);
        }
    }
}
