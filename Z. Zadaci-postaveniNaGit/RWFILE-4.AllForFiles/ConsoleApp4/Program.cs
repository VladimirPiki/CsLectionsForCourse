using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //citanje na datoteka
            // Open the file to read from.
            string path = "C:\\temp\\text.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }

            //kopiranje na datoteka
            //var source = @"C:\temp\text.txt";
            //var destination = @"C:\temp\temp\tekst23.txt";
            //try
            //{
            //    File.Copy(source, destination);
            //    //tretiot parametar ovozmzuva da se prezapise datotekata
            //    //File.Copy(source, destination, true);
            //    Console.WriteLine("File copied");
            //}
            //catch (IOException copyError)
            //{
            //    Console.WriteLine(copyError.Message);
            //}



            ////premestuvanje na datoteka
            //string path1 = @"C:\temp\MyTest.txt";
            //string path2 = @"C:\temp\temp2\MyTest.txt";
            //try
            //{
            //    if (File.Exists(path2))
            //        File.Delete(path2);

            //    // Move the file.
            //    File.Move(path1, path2);
            //    Console.WriteLine("{0} was moved to {1}.", path1, path2);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The process failed: {0}", e.ToString());
            //}

            ////listanje na datoteki
            //string[] fileEntries = Directory.GetFiles(@"C:\temp");
            //foreach (string fileName in fileEntries)
            //    Console.WriteLine(fileName);


            //listanje datoteki po ime so ekstenzija
            //string[] fileEntries = Directory.GetFiles(@"C:\temp");
            //foreach (string fileName in fileEntries)
            //    Console.WriteLine(Path.GetFileName(fileName));

            //listanje datoteki po ime bez ekstenzija
            string[] fileEntries = Directory.GetFiles(@"C:\temp");
            foreach (string fileName in fileEntries)
                Console.WriteLine(Path.GetFileNameWithoutExtension(fileName));


            ////listanje na direktoriumi
            //string[] subdirectoryEntries = Directory.GetDirectories(@"C:\Mikrosam Akademija");
            //foreach (string subdirectory in subdirectoryEntries)
            //    Console.WriteLine(subdirectory);


            ////proverka dali postoi daden fajl i negovo brisenje
            //if (File.Exists(destination))
            //{
            //    File.Delete(destination);
            //}
        }
    }
}
