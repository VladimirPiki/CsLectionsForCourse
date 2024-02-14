using System;
using System.Collections.Generic;

namespace M18.Triagolnik
{
    internal class Program
    {
        static int triagolnik(List<int> vlezniParametri)
        {

            int najgolema = 0;
            int srednaVrednost = 0;//Ja baram srednata vrednost od parametrite
            int uslugi = 0;
            int cenaUslugi = 10;
            int minimalnaCena = 0;
            for (int i = 0; i < vlezniParametri.Count; i++)// go naogjam srednata strana
            {
                 if (vlezniParametri[i] > najgolema)
                 {
                     srednaVrednost = najgolema;
                     najgolema = vlezniParametri[i];
                 }
                 else
                 {
                     if (vlezniParametri[i] > srednaVrednost)
                     {
                         srednaVrednost = vlezniParametri[i];
                     }
                 }



            }
            //Console.WriteLine(srednaVrednost);

            for (int i = 0; i < vlezniParametri.Count; i++)
            {
                if (vlezniParametri[i] == srednaVrednost)// Ako e isti netreba usluga
                {
                    continue;
                }
                if (vlezniParametri[i] > srednaVrednost)// Ako stranata e pogolema od srednata majstoro treba da skrati za da se izramni so srednata dolzina
                {
                    uslugi = vlezniParametri[i] - srednaVrednost; // vo varijabilata uslugi majstoro krati kolku cm tolku uslugi bidejki 1 cm e 1 usluga
                }
                if (vlezniParametri[i] < srednaVrednost)// Ako stranata e pomala od srednata majstoro treba da ja prodolzi za da se izramni so srednata dolzina
                {
                    uslugi = srednaVrednost - vlezniParametri[i];// vo varijabilata uslugi majstoro dodava kolku cm tolku uslugi bidejki 1 cm e 1 usluga

                }
                minimalnaCena += uslugi * cenaUslugi;//Vo varijabilata minimalnaCena racunam

            }
            return minimalnaCena;
        }
        static void Main(string[] args)
        {
            //List<int> vlezniParametri = new List<int>() { 9, 4, 6 };
            // List<int> vlezniParametri = new List<int>() { 1,6,5 };
           List<int>vlezniParametri=new List<int>() { 3,6,5};
            //List<int>vlezniParametri=new List<int>() { 2,2,3};

            Console.WriteLine("Najmalata cena Zoran sto moze da ja napravi e : "+  triagolnik(vlezniParametri)+ " denari");

        }

    }
}
