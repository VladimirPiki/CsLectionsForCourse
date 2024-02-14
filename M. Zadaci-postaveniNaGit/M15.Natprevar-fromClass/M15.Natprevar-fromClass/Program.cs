using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15.Natprevar_fromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kroasan = 7;
            int sokce = 4;
            Console.WriteLine("Vnesi suma na denari: ");
            int denari = Convert.ToInt32(Console.ReadLine());
            bool proveri = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i * kroasan + j * sokce == denari)
                    {
                        proveri = true;
                        break;
                    }
                }
            }
            if (proveri)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Ne");
            }
        }
    }
}
