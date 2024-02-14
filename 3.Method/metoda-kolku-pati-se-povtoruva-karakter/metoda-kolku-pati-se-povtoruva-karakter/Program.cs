using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoda_kolku_pati_se_povtoruva_karakter
{
    internal class Program
    {
        //Metoda koja proveruva kolku pati se povtoruva odreden karakter+

         static int PatiNaPovtoruvanje(string str, char ch)
          {
              int patiNaPovtoruvanje = 0; ;

              for (int i = 0; i < str.Length; i++)
              {
                  if (str[i] == ch)
                      patiNaPovtoruvanje = patiNaPovtoruvanje + 1;
              }
              return patiNaPovtoruvanje;
          }


          static void Main(string[] args)
          {
              string str = "asdfasdfafdadfadaaa";
              char ch = 'a';
              //Program obj = new Program();
              int c;
              c = PatiNaPovtoruvanje(str, ch);
              Console.WriteLine("Baraniot karakter se povtruva  " + c + "  pati");

          }
    }
}
