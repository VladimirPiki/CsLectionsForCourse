using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3.ImeRazlicniKarakteri
{

    internal class Program
    {
        struct Licnost
        {
            public string ime;
            public string prezime;
            public int godini;
        }
        static string ImeRazlicniKarakteri(string ime)
        {
            string unique = "";// Ja polnam so char za da mozam da ja dodam vo listata posebno kako string

            if (unique.Length == 0)
            {
                foreach (char ch in ime)
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

            }

            return unique;
        }

        static void Main(string[] args)
        {
            Licnost lic;

            List<Licnost> listLic = new List<Licnost>();

            Console.WriteLine("Vnesete ime, prezime i godini na licnosta");
            for (int i = 0; i < 3; i++)
            {
                lic.ime = Console.ReadLine();
                lic.prezime = Console.ReadLine();
                lic.godini = Convert.ToInt32(Console.ReadLine());
                listLic.Add(lic);
            }

            string maxIme = "";
            string licnost = "";
            for (int i = 0; i < listLic.Count; i++)
            {
                string unikatnoIme = ImeRazlicniKarakteri(listLic[i].ime);
                if (maxIme.Length < unikatnoIme.Length)
                {
                    maxIme = "";
                    maxIme += unikatnoIme;
                    licnost = "";
                    licnost += listLic[i].ime + " " + listLic[i].prezime + " " + listLic[i].godini;
                }
            }
            Console.WriteLine(licnost);
        }
    }
}
