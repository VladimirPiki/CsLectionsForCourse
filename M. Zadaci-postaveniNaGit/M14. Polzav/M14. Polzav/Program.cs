using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M14.Polzav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezni parametri
            int M = 10;
            int D = 3;
            int N = 2;

            int kolkuDenaIzlez = 1;//pocnuva od prvio den ako go pomini uslovo ke mu se odzemat vo nokjta i ke go zaokruzi deno
            int i = 0;//Kolku metri ima izodeno ili i mi e metri
               
            while(i < M)
            {
                i = i + D;// metri vo tekot na denot
                if (i >= M)// ako gi napraj metrite izlegva vo tekot na denot
                {
                    break;
                }
                i = i - N;// metri vo tekot na nokta
                kolkuDenaIzlez++;
            }
                     
            Console.WriteLine("Na polzavot mu treba "+kolkuDenaIzlez+" dena za izlez");

        }
    }
}
