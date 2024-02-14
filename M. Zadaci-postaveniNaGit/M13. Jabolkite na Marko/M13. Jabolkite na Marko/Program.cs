using System;

namespace M13.Jabolkite_na_Marko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezni parametar
            int pero =10;

            int vnucinja = 4;
            int cenaJabolka = 9;
            int ostanaDaKupi = 0;

            for (int i = 1; i <= 1000; i++)
            {
                int podeleno = i * vnucinja;//Tablica pomnozeno so 4 

                if (podeleno == pero)// Ako e ednakvo ostana da kupi uste 0 jabolka
                {
                    ostanaDaKupi = podeleno - pero;
                    // Console.WriteLine("Ostana da kupi: " + ostanaDaKupi + " jabolka");
                    break;
                }

                if (podeleno > pero)//Vo ovaj uslov go zema prvoto pogolemo od tablicata
                {
                    // Console.WriteLine(podeleno);
                    ostanaDaKupi = podeleno - pero;
                    //Console.WriteLine("Ostana da kupi: " + ostanaDaKupi + " jabolka");
                    break;
                }
            }
            int kolkuPariKePotrosi = ostanaDaKupi * cenaJabolka;// Marko treba da potrosi
            //Console.WriteLine( "Ostana da kupi: "+  ostanaDaKupi+ " jabolka");

            Console.WriteLine("Marko treba da potrosi: " + kolkuPariKePotrosi + " denari");
        }
    }
}
