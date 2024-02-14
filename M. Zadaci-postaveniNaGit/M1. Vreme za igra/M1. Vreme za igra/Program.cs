using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1.Vreme_za_igra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vlezMinuti = 7;
            int nivoJacina = 2;
            int prvoNivo = vlezMinuti;
            int vtoroNivo = prvoNivo * nivoJacina;
            int tretoNivo = vtoroNivo * nivoJacina;
            int cetvrtoNivo = tretoNivo * nivoJacina;
            int izlez = prvoNivo + vtoroNivo + tretoNivo + cetvrtoNivo;
            Console.WriteLine("Vkupno vreme: "+izlez);
        }
    }
}
