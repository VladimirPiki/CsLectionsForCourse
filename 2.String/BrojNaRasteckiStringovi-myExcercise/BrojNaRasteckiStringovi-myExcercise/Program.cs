using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrojNaRasteckiStringovi_myExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string paramString = "abcdeacdh";


                int brojac = 1;
                int rasteckiSting = 0;
                for (int i = 1; i < paramString.Length; i++)
                {

                    if (paramString[i] > paramString[i - 1])
                    {
                        brojac++;
                        if (i == paramString.Length - 1)
                        {
                            rasteckiSting++;
                        }

                    }
                    else
                    {
                        if (brojac > 0)
                        {
                            rasteckiSting++;

                        }
                        brojac = 0;
                    }


                }
                Console.WriteLine(rasteckiSting);
            }
        }
    }
}
