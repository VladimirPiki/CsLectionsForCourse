using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApendTextToFileExist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\MyTest.txt";//pateka
            if (File.Exists(path))// ako postoj tekst fajl
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(path))// StreamWriter sw znaci citaj ja sw = File.AppendText(path) znaci dopolnigo tekstot ili dodaj tekst vo path
                {
                    sw.WriteLine("Helsssssslo");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }



            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))// istoto znacenje citaj i otvorigo tekstot
            {
                string s;// zapisi se vo ovaj string
                while ((s = sr.ReadLine()) != null)// zapisuvaj se vo ovaj sting se dodeka ima linii za citanje
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
