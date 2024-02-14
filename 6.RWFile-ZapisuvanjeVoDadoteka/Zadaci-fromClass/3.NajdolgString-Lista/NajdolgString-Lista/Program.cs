using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdolgString_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>() { "vlade", "eleonora", "vladimir", "jvoe", "adad", "aa", "ddd", "", "vladimirk" };


            string path = @"c:\temp\NajdolgString_Lista.txt";
            if (!File.Exists(path))
            {

                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                    for (int i = 0; i < list.Count; i++)
                    {
                        sw.WriteLine(list[i]);
                    }

                }
            }



            string max="";// nadvor ja deklariram
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                s = sr.ReadLine();// citaj prvata linija za da mozis da mu go dodajs na max
              
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Length > max.Length)
                    {
                        max = s;
                    }
                }

            }
            Console.WriteLine("Najdolg string vo listata e :" + max);
        }
    }
}
