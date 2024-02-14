using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z42.ListMetodaDatoteka
{
    internal class Program
    {
        static List<string> DadotekaLista(string path)
        {
            var listaStr = new List<string>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    listaStr.Add(s);
                }

            }
            return listaStr;
        }
        static void Main(string[] args)
        {
            string path = @"c:\temp\hashtable1.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Kire");
                    sw.WriteLine("Darko");
                    sw.WriteLine("Zorica");
                    sw.WriteLine("Antimon");
                    sw.WriteLine("Vladimir");
                    sw.WriteLine("Darko");
                    sw.WriteLine("vlatko");
                    sw.WriteLine("dime");
                    sw.WriteLine("dule");
                }
            }

            Hashtable myTable = new Hashtable();
            var listaIminja= new List<string>(); 
            listaIminja = DadotekaLista(path);
            for(int i=0; i < listaIminja.Count; i++)
            {
                if (!myTable.ContainsKey(listaIminja[i][0]))
                {
                    myTable.Add(listaIminja[i][0], listaIminja[i]);
                }
                else if (myTable.ContainsKey(listaIminja[i][0]))
                {
                    myTable[listaIminja[i][0]] = myTable[listaIminja[i][0]] + " " + listaIminja[i];
                }
            }
            foreach (DictionaryEntry element in myTable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }
        }
    }
}
