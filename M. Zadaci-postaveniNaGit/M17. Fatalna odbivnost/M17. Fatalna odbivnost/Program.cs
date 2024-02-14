using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17.Fatalna_odbivnost
{
    internal class Program
    {
        static int teleportacija(int ziteli, List<int> vlezniParametri)
        {
            int gledaDesno = 1;
            int gledaLevo = 2;
            int teleportiranja = 0;
            int temp = 0;
            for (int i = 1; i < vlezniParametri.Count; i++)
            {
                //  Console.WriteLine(i);
                if (vlezniParametri[i - 1] == gledaDesno && vlezniParametri[i] == gledaLevo)
                {
                    temp = vlezniParametri[i]; // na temporalnata varijabila mu ja zadvame momentalnata vrednost na pozicijata kaj so e i
                    vlezniParametri[i] = vlezniParametri[i - 1]; // Gi menvame mestata momentalanta i ja zema od vrednsota od predhodnata
                    vlezniParametri[i - 1] = temp; // A predhodnata od momentalnata i taka imame zamena na mestata
                    teleportiranja++; // imame teleportiranje

                    if (i > 1) // da ne izlegva od foro
                    {
                        i = i - 2;// koga ke imame teleportiranje ja vrakajme pozicijata na pocetok od kaj so gi provervase vrednostite

                    }
                }
            }
            return teleportiranja;
        }
        static void Main(string[] args)
        {
            // List<int> list = new List<int>() { 1, 2, 1, 2,1,2 };
            //List<int> list = new List<int>() { 1, 2, 1, 2 };
             List<int> list = new List<int>() { 1, 2, 2 };
            // List<int> list = new List<int>() { 1, 2, 2, 1 };
            //List<int> list = new List<int>() { 2, 2, 1, 1 };
            int ziteli = 3;
            Console.WriteLine("imame : " + teleportacija(ziteli, list) + " teleportiranja");

        }
    }
}
