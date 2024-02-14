using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16.Stedenje_fromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kroasan = 7;
            int sokce = 4;
            Console.WriteLine("Vnesi suma na denari: "+15);
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
