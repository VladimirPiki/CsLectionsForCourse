using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4.Mrzlivoto_dzudze___ucilisen_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vkupnoPari = 60;
            int prodavnicaA = 7;
            int prodavnicaB = 4;
            int proizvodiOdA;
            int proizvodiOdB;
            int razlika;

            if (prodavnicaA > prodavnicaB)
            {
                proizvodiOdA = vkupnoPari / prodavnicaA;
                 proizvodiOdB = vkupnoPari / prodavnicaB;
/*                Console.WriteLine("Proizvodi od prodavnica A mozis da kupis : " + proizvodiOdA);
                Console.WriteLine("Proizvodi od prodavnica B mozis da kupis : " + proizvodiOdB);*/

                razlika = proizvodiOdB - proizvodiOdA;
                Console.WriteLine("Vo podalecnata prodavnica mozis da kupis poveke: " + razlika + " podarok od pobliskata");
            }
        }
        }
}
