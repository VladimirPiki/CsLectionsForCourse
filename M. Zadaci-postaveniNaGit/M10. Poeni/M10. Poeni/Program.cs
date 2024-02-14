using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10.Poeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezni parametri
            int P = 5;// poeni od prvo nivo potroseni
            int D = 7; //Za sledno nivo treba da potrosi plus od predhodnoto nivo
            int N = 3; //Nivo na herojot

            int vkupnoPotroseniPoeni=0;
            int pocetok = 0;
            int slednoNivo = 1;
            int vkupnoOdSekoeNivo = 0;
            int prvoNivo = 1;
            int poslednoNivo = 1;
            while( pocetok < N)
            {
                pocetok++;
                if (pocetok == prvoNivo)// Pocnuva od prvo nivo i trosi P
                {
                    vkupnoPotroseniPoeni = vkupnoPotroseniPoeni + P; // potroseni poeni za toj level
                    vkupnoOdSekoeNivo = vkupnoOdSekoeNivo + vkupnoPotroseniPoeni; //Vkupno potroseni poeni
                }
                else //Sekoe naredno nivo
                {
                    while (slednoNivo < N - poslednoNivo) // poslednonto nema nakacvanje
                    {
                        slednoNivo++;
                        vkupnoPotroseniPoeni = (vkupnoPotroseniPoeni + D); // potroseni poeni za toj level + nakacuvanjeto za sleden level 
                        vkupnoOdSekoeNivo = vkupnoOdSekoeNivo + vkupnoPotroseniPoeni;

                    }

                }

            }
           Console.WriteLine("Sevkupno poeni za nakacuvanje nivoa se potroseni : "+ vkupnoOdSekoeNivo+" poeni");
        }
    }
}
