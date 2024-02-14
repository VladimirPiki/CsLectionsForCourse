using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rekurzija
{
    class Program
    {
        static void DirSearch(string sDir)
        {
            try
            {
                bool prvDirektorium = false;
                if (prvDirektorium == false)
                {
                    foreach (string f in Directory.GetFiles(sDir))
                    {
                        Console.WriteLine(f);
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Console.WriteLine(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\temp\Z52.RabotaSoDatoteki\1.NajdiDadoteka";
            DirSearch(path);
        }
    }
}
