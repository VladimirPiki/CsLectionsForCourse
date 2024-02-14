using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31.BrisiZboroviFibonaci
{
    internal class Program
    {
        //PRV NACIN
        struct Zborovi
        {
            public string zbor;

        }

        static List<Zborovi> VnesiZborovi()
        {
            Zborovi zbo;
            List<Zborovi> listZbo = new List<Zborovi>();

            Console.WriteLine("Vnesete zborovi");
            for (int i = 0; i < 5; i++)
            {
               zbo.zbor = Console.ReadLine();

                listZbo.Add(zbo);
            }
            return listZbo;
        }

        static void PrikaziZborovi(List<Zborovi> Zborovi)
        {
            //Pristapuvanje do podatocite od strukturata
            for (int i = 0; i < Zborovi.Count; i++)
            {
                Console.Write(Zborovi[i].zbor);
                Console.WriteLine();
            }
        }

        static List<Zborovi> brisiFibonaciZbor(List<Zborovi> lisZborovi)
        {
            for (int i = 0; i < lisZborovi.Count; i++)
            {
                if (pripagjaFibonaci(lisZborovi[i].zbor) == true)
                {
                    lisZborovi.Remove(lisZborovi[i]);
                    i = -1;
                }
            }
            return lisZborovi;

        }
        //PRV NACIN

        //VTOR NACIN
        static bool pripagjaFibonaci(string zbor)
        {

            bool pripagja = false;
            int prv = 0;
            int vtor = 1;

            if (prv == zbor.Length || vtor == zbor.Length)
            {
                pripagja = true;
            }

            while (vtor < zbor.Length)
            {
                int tret = vtor + prv;
                prv = vtor;
                vtor = tret;
                if (vtor == zbor.Length)
                {
                    pripagja = true;
                }
            }
            return pripagja;

        }
        static List<string> proveriFibonaci(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (pripagjaFibonaci(lista[i]) == true)
                {
                    lista.Remove(lista[i]);
                    i = -1;
                }
            }
            return lista;

        }
        //VTOR NACIN


        static void Main(string[] args)
        {

            List<Zborovi> listaZboroviVnesi = new List<Zborovi>();
            listaZboroviVnesi = VnesiZborovi();

            listaZboroviVnesi = brisiFibonaciZbor(listaZboroviVnesi);

            for (int a = 0; a < listaZboroviVnesi.Count; a++)
            {
                Console.WriteLine("Prvo reshenie : Zborovi koj ne se izbrisani od listata : " + listaZboroviVnesi[a].zbor);
            }


            //List<string> listaZaProverka = new List<string>() { "", "v", "vv", "vvv", "cccccc" };
            // List<string> listaZaProverka = new List<string>() { "vlade", "vlada", "vladi", "vlatko", "vladimir" };
            List<string> listaZaProverka = new List<string>() { "", "v", "vl", "vlatko", "vladimirk" };

            listaZaProverka = proveriFibonaci(listaZaProverka);

              foreach (string a in listaZaProverka)
              {
                  Console.WriteLine();  
                  Console.WriteLine("Vtoro reshenie: Zborovi koj ne se izbrisani od listata : "+a);
              }
        }
    }
}
