using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8.Pad_na_koncentracija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezni parametri;
            int pocetokM = 3;
            int kraj = 6;

            int pocetok = 0;
            int sekojTret = 3;// minuti
            int crtickiVoPrva = 1;
            int crtickiVoVtora = 2;
            int crtickiVoTreta = 3;
            int vkupnaCrticka = 0;

            while (pocetok < kraj)
            {
                pocetok++;
                int pocetokParam = pocetokM; 
                int crtickaIzbroena = 0;
                while (pocetokParam < kraj)
                {
                    pocetokParam++;


                    if ((pocetok == crtickiVoPrva))
                    {
                        crtickiVoPrva = crtickiVoPrva + sekojTret;
                        // Console.WriteLine("crtickiVoPrva-> " + crtickiVoPrva);
                        crtickaIzbroena = crtickaIzbroena + 1;
                        //Console.WriteLine("crtickaIzbroena-> " + crtickaIzbroena);
                    }
                    else if (pocetok == crtickiVoVtora)
                    {
                        crtickiVoVtora = crtickiVoVtora + sekojTret; /// minuti
                        //Console.WriteLine("crtickiVoVtora-> " + crtickiVoVtora);
                        crtickaIzbroena = crtickaIzbroena + 2;
                        //Console.WriteLine("crtickaIzbroena crtickiVoVtora-> " + crtickaIzbroena);
                    }
                    else if (pocetok == crtickiVoTreta)
                    {
                        crtickiVoTreta = crtickiVoTreta + sekojTret;
                        //Console.WriteLine("crtickiVoTreta -> " + crtickiVoTreta);
                        crtickaIzbroena = crtickaIzbroena + 3;
                        //Console.WriteLine("crtickaIzbroen crtickiVoTreta-> " + crtickaIzbroena);
                    }
                    if (pocetok == pocetokParam)
                    {
                        vkupnaCrticka = vkupnaCrticka + crtickaIzbroena;
                    }


                }


            }
            Console.WriteLine("Vkupno Filip stavil: " + vkupnaCrticka + " crticki");
        }
    }
}
