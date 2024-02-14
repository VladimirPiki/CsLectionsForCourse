using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTextIfNotExist
{
    internal class Program
    {
        static List<int> TriNajgolemiBroevi(List <int>niza)
        {
            List<int> listaNajgolemi = new List<int>();
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            for (int i = 0; i < niza.Count; i++)
            {
                int broj;
                broj = niza[i];
                if (broj > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = broj;
                }
                else
                {
                    if (broj > max2)
                    {
                        max3 = max2;
                        max2 = broj;
                    }
                    else
                    {
                        if (broj > max3)
                        {
                            max3 = broj;
                        }
                    }
                }
            }
            listaNajgolemi.Add(max1);
            listaNajgolemi.Add(max2);
            listaNajgolemi.Add(max3);
            return listaNajgolemi;  

        }
        static void Main(string[] args)
        {

            string path = @"c:\temp\Т4. ТriNajgolemi.txt";// pateka do tekst fajlot
            if (!File.Exists(path))// ako ne postoj, ako postoj avtomatski go skoka ovaj i preminva vo StreamReader, a ako go trgnam ! ke go prezapisi
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))// StreamWriter procitaj sw i kreiraj go tekstot
                {
                    sw.WriteLine("1");
                    sw.WriteLine("2");
                    sw.WriteLine("33");
                    sw.WriteLine("11");
                    sw.WriteLine("12");
                    sw.WriteLine("13");
                    sw.WriteLine("4");
                    sw.WriteLine("5");
                    sw.WriteLine("6");
                    sw.WriteLine("7");
                }
            }
            List<int> niza = new List<int>();
            
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))// StreamReader zapisigo vo sr i otvorigo tekstot
            {
                string s;// zapisigo tekstot vo s
                while ((s = sr.ReadLine()) != null)// se dodeka ima tekst polnija s
                {
                    niza.Add(int.Parse(s));
                    //Console.WriteLine(s);
                }
            }
            List<int> listaNajgolemi = new List<int>();
            listaNajgolemi = TriNajgolemiBroevi(niza);
            foreach(int i in listaNajgolemi)
            {
                Console.WriteLine(i);   
            }


        }
    }
}
