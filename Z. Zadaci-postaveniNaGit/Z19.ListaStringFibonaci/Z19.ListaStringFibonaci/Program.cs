using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z19.ListaStringFibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "prilep", "bitolaaa", "bitolaaa", "strumicaaa", "teeetovo", "strumicaaa", "gostivariii", "kicevvvvo", "kicevvvvo", "demirhisarc" };
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
                    // Console.WriteLine(list[i]);
                }
                unikat = "";

            }

            string unique = "";// Ja polnam so char za da mozam da ja dodam vo listata posebno kako string
            List<string> listaSoUnikati = new List<string>();
            foreach (string u in unikati)
            {
                if (unique.Length == 0)
                {
                    foreach (char ch in u)
                    {
                        bool razlikuva = true;

                        for (int i = 0; i < unique.Length; i++)
                        {
                            if (ch == unique[i])// provervam unikatnite dali gi ima vo stringot ako gi ima false 
                            {
                                razlikuva = false;
                                break;
                            }
                        }

                        if (razlikuva)// ako ja nema vo unikatnata vo proverkata go polnam stringot so char od unikatnata
                        {
                            unique += ch;
                        }
                    }

                    listaSoUnikati.Add(unique);// Tuka ja dodavam
                }
                unique = "";

            }
      
            foreach (string l in listaSoUnikati)
            {
                bool pripagja = false;
                int broj = l.Length;

                int prv = 0;
                int vtor = 1;
                int tret = 2;

                while (tret < broj)
                {
                    tret = vtor + prv;
                    prv = vtor;
                    vtor = tret;
                    if (broj == tret)
                    {
                        pripagja = true;
                    }
                }
                if (pripagja)
                {
                    Console.WriteLine("stringot  " + l + "  pripaja na fibonaci, a negovata dolzina e :" + broj);
                }
            }
       
        }
    }
}
