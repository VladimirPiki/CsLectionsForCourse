using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            //List<int> vlezniParametri = new List<int>() { 9, 4, 6 };// najmala usluga mi e 5
           // List<int> vlezniParametri = new List<int>() { 1,6,5 };// najmala usluga mi e 6
           // List<int> vlezniParametri = new List<int>() { 6, 3, 9 };
           // List<int> vlezniParametri = new List<int>() { 8, 7, 6 };
             //List<int> vlezniParametri = new List<int>() { 3, 6, 5 };
            List<int>vlezniParametri=new List<int>() { 2,2,3};

            List<int> novaLista = new List<int>();
            int uslugi = 0;
            int vkupnoUslugi = 0;
            int minimalnaCena = 0;
            int cenaUslugi = 10;
            for (int i = 0; i < vlezniParametri.Count; i++)// vo ovaj for gi listam site parametri
            {
                for(int a=0; a < vlezniParametri.Count; a++) // so ovaj for pravam da se provervam site uslugi i gi zadavam site strani
                {
                    if (vlezniParametri[i] == vlezniParametri[a])// Ako e isti netreba usluga
                    {
                        continue;
                    }
                    if (vlezniParametri[i] > vlezniParametri[a])// Ako stranata e pogolema od zadadenata strana majstoro treba da skrati za da se izramni so zadadenata strana 
                    {
                        uslugi = vlezniParametri[i] - vlezniParametri[a]; // vo varijabilata uslugi majstoro krati kolku cm tolku uslugi bidejki 1 cm e 1 usluga
                    }
                    if (vlezniParametri[i] < vlezniParametri[a])// Ako stranata e pomala odzadadenata strana  majstoro treba da ja prodolzi za da se izramni so zadadenata strana 
                    {
                        uslugi = vlezniParametri[a] - vlezniParametri[i];// vo varijabilata uslugi majstoro dodava kolku cm tolku uslugi bidejki 1 cm e 1 usluga

                    }
                    vkupnoUslugi = vkupnoUslugi + uslugi;
                  // minimalnaCena += uslugi * cenaUslugi;//Vo varijabilata minimalnaCena racunam
                 
                }
                novaLista.Add(vkupnoUslugi);// vo novata lista gi dodavam site uslugi
                Console.WriteLine(vkupnoUslugi+"   "+i);
                vkupnoUslugi = 0;




            }
            int minUsluga = novaLista[0];// pretpostavuvam deka najmaalata vrednost e na pozicija 0
            foreach (int i in novaLista)// foreach gi listam site uslugi i ja baram najmalata
            {
                
                if (i < minUsluga)
                {
                    minUsluga = i;// dodeluvam vrednost za najmala usluga
                }
            }
            minimalnaCena = minUsluga * cenaUslugi;//Vo varijabilata minimalnaCena racunam
            Console.WriteLine(minimalnaCena);

        }

    }
}
