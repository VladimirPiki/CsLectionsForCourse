using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7.Panika___drzaven_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////  h   m  s
            List<int> pocna = new List<int> { 12, 0, 0 };

            int pocnaH = pocna[0];
            int pocnaM = pocna[1];
            int pocnaS = pocna[2];
            ////////                                    vlezni parametri
            /*            List<int> vlezniParametri = new List<int> { 12, 59, 50, 6, 7 };*/
            List<int> vlezniParametri = new List<int> { 12, 20, 5, 5, 5 };

            // 1 prasa
            int prasaEdnasH = vlezniParametri[0];
            int prasaEdnasM = vlezniParametri[1];
            int prasaEdnasS = vlezniParametri[2];

            // 2 pov
            int prasaDvapatiM1 = vlezniParametri[3];//6
            int prasaDvapatiS1 = vlezniParametri[4];//7

            int poslednoPrasvanjeH = pocnaH;
            int poslednoPrasvanjeM = pocnaM;
            int poslednoPrasvanjeS = pocnaS;
            if ((pocnaH <= prasaEdnasH && prasaEdnasH < 15) && (0 <= prasaEdnasM && prasaEdnasM < 60) && (0 <= prasaEdnasS && prasaEdnasS < 60) && (0 <= prasaDvapatiM1 && prasaDvapatiM1 < 60) && (0 <= prasaDvapatiS1 && prasaDvapatiS1 < 60))
            {

                if (pocnaH == prasaEdnasH)
                {
                    poslednoPrasvanjeH = pocnaH;
                   // Console.WriteLine(poslednoPrasvanjeH);
                }
                else
                {
                    poslednoPrasvanjeH = prasaEdnasH;
                    // Console.WriteLine(poslednoPrasvanjeH);

                }
                poslednoPrasvanjeM = prasaEdnasM + prasaDvapatiM1;
                if (poslednoPrasvanjeM >= 60)// minuti
                {
                    poslednoPrasvanjeM -= 60;
                    poslednoPrasvanjeH = poslednoPrasvanjeH + 1;
                    //Console.WriteLine(poslednoPrasvanjeH); 
                }
                // Console.WriteLine(poslednoPrasvanjeM);

                poslednoPrasvanjeS = prasaEdnasS + prasaDvapatiS1;
                if (poslednoPrasvanjeS >= 60)//sekundii
                {
                    poslednoPrasvanjeS -= 60;
                    poslednoPrasvanjeM = poslednoPrasvanjeM + 1;
                    // Console.WriteLine(poslednoPrasvanjeM);
                }
                //Console.WriteLine(poslednoPrasvanjeS);

            }
            Console.WriteLine("Posledno prasvanje na Mila e vo : " + poslednoPrasvanjeH + "h " + poslednoPrasvanjeM + "m " + poslednoPrasvanjeS + "s ");





        }
    }
}
