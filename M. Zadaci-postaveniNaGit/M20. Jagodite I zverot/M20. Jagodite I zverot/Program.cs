using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M20.Jagodite_I_zverot
{
    internal class Program
    {
        static int jagoditeIdzvero(int dzveroJadi, int jagodiPocetok)
        {
            int mometalnoNivo = 0;
            int predhodnoNivo = 0;

           
            while (jagodiPocetok >= dzveroJadi)
            {
                jagodiPocetok = jagodiPocetok - dzveroJadi;
                mometalnoNivo = mometalnoNivo + 1;
                if (mometalnoNivo > predhodnoNivo)
                {
                    predhodnoNivo = mometalnoNivo;
                    jagodiPocetok = jagodiPocetok + 3;
                }
            }
            return mometalnoNivo;
        }
        static void Main(string[] args)
        {
            int N = 5;
            int M = 12;
                   
            Console.WriteLine("Dzverot mozi da porasni : "+jagoditeIdzvero(N, M) +" nivoa");
        }
    }
}
