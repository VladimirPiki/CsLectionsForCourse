using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M31.Baksis
{
    internal class Program
    {
        static double Procent(int broj,int kolkavProcent)
        {
            double procent = ((double)broj / 100) * kolkavProcent;
            return procent;
        }
        static int Baksis(int smetka,int mario)
        {
            int baksis = 0;
            int vkupnaSuma = 0;
            int tablica = 1;
            int nacini = 0;
            int i = 1;
            int maxNacin = 0;
            if (smetka < mario)
            {
                while (i <= smetka)
                {
                    tablica = i * 5;
                    if (tablica <= mario)
                    {
                        baksis = tablica - smetka;
                        vkupnaSuma = smetka + baksis;

                        double petProcenti = Procent(vkupnaSuma,5);
                        double desetProcenti = Procent(vkupnaSuma, 10);
                        if (vkupnaSuma <= mario && vkupnaSuma >= tablica && vkupnaSuma % 5 == 0 && baksis >= petProcenti && desetProcenti >= baksis)
                        {
                            nacini = nacini + 1;

                            if (maxNacin < nacini)
                            {
                                maxNacin = nacini;
                            }
                        }
                    }
                    i++;
                }


            }
            return maxNacin;
        }
        static void Main(string[] args)
        {
            int smetka = 23; //90   2 nacini
            int mario = 24; //100
            int reshenie = Baksis(smetka, mario );
            Console.WriteLine(reshenie);    

          
        }
    }
}
