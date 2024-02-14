
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PodatociMemoriraniVoLista_Rekurzija
{
    class Program
    {
        static List<string> pateki = new List<string>();
        static void DirSearch(string sDir)
        {
            try
            {
                bool prvDirektorium = false;
                if (prvDirektorium == false)
                {
                    foreach (string f in Directory.GetFiles(sDir))
                    {
                        pateki.Add(f);
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        pateki.Add(f);
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
            string path = @"C:\temp";
            DirSearch(path);
            foreach (string str in pateki)
            {
                Console.WriteLine(str);
            }
        }
    }
}
