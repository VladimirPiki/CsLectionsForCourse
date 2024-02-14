using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16.GradoviLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Prilep", "Bitola", "Prilep", "Bitola", "Strumica", "Tetovo", "Strumica", "Gostivar", "Kicevo", "Kicevo","Demir Hisar" };
            List<string> unikati = new List<string>();
            string unikat = "";
            for (int i = 0; i < list.Count; i++)
            {
                bool duplikat = true;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        duplikat = false;
                        break;
                    }
                }
                if (duplikat)
                {
                    unikat += list[i];
                    if (unikat.Length > 0)
                    {
                        unikati.Add(unikat);
                    }
            
                }
                unikat = "";

            }
           
            foreach (string u in unikati)
            {
                Console.WriteLine(u);
            }
        }
    }
}
