using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M36.Makedonsko_oro
{
    internal class Program
    {
        static void NajmalceCekori()
        {
            List<int> list = new List<int>() { 0, 0, 1, 1, 1, 2, 2 };
            int cekori = 0;
            double vkupnoMetri = 0;
            int param = 10;
            bool uslov = false;
            while (vkupnoMetri <= param)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i] == 0)
                    {
                    }
                    else if (list[i] == 1)
                    {
                        vkupnoMetri += 0.5;
                    }
                    else if (list[i] == 2)
                    {
                        vkupnoMetri = vkupnoMetri - 0.25;
                    }
                    cekori++;
                    if (vkupnoMetri == param)
                    {
                        uslov = true;
                        break;
                    }

                }
                if (uslov)
                {
                    break;
                }
            }

            Console.WriteLine(cekori);
        }
        static void Main(string[] args)
        {
            NajmalceCekori();
        }
    }
}
