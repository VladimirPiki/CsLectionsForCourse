using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P.FileImeFIbonaci
{
    internal class Program
    {
        static bool fibonaci(string file)
        {
            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == file.Length || vtor == file.Length)
            {
                pripagja = true;
            }

            while (vtor < file.Length)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;

                if (vtor == file.Length)
                {
                    pripagja = true;
                }

            }

            return pripagja;
        }
        static void Main(string[] args)
        {

            string[] fileEntries = Directory.GetFiles(@"C:\temp");

            foreach (string fileName in fileEntries)
            {
               
                if (fibonaci(fileName))
                {
                    Console.WriteLine("Fajlot " + fileName + " pripagja na fibonaci");
                }
                else
                {
                    Console.WriteLine("Fajlot ne pripgja na fibonaci");
                }
            }
           
           
        }
    }
}
