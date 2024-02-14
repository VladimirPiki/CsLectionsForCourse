using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajgolemBroj_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 45, 6, 7, 8, 9, 0 };


            string path = @"c:\temp\NajgolemBroj_Lista.txt";
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



            int max;// nadvor ja deklariram
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                s= sr.ReadLine();// citaj prvata linija za da mozis da mu go dodajs na max
                max= int.Parse(s);//smenija od string vo int
                while ((s = sr.ReadLine()) != null)
                {

                    int broj=int.Parse(s);  // vo varijabilata dodavaj ja sekoja s od string vo int
                    if (broj > max)
                    {
                        max = broj;
                    }
                }

            }
            Console.WriteLine("Najgolem broj vo listata e :"+ max);

        }
    }
}
