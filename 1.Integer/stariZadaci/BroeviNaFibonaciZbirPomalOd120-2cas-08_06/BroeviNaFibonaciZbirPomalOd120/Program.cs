using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroeviNaFibonaciZbirPomalOd120
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbirPomal = 120;
            int prv = 0;
            int vtor = 1;
            Console.WriteLine("Broevi na fibonaci koj sto zbie e pomal od 120 : " + prv);
            Console.WriteLine("Broevi na fibonaci koj sto zbie e pomal od 120 : " + vtor);
            int tret;
            int zbir = prv + vtor;
            while (zbir < zbirPomal)
            {

                tret = prv + vtor;
                prv = vtor;
                vtor = tret;
                zbir = zbir + tret;
                Console.WriteLine("Broevi na fibonaci koj sto zbie e pomal od 120 : " + tret);
            }


        }
    }
}
