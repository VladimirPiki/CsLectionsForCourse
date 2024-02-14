using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M37.Kiki___Riki
{
    internal class Program
    {
        static void KikiRiki()
        {

            int A;
            int nacini = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Vnesete gi brojkite so razdeleno mesto (SPACE) pomegju niv");
            string vnesiBrojki = Console.ReadLine();

            string[] razdeli = vnesiBrojki.Split(' ');

            bool uslov = true;
            for (int i = 0; i < razdeli.Length; i++)
            {
                if (i < 4)
                {
                    bool success = int.TryParse(razdeli[i], out A);
                    if (success)
                    {
                        list.Add(A);
                    }
                    else
                    {
                        Console.WriteLine("DOZVOLENI SE SAMO BROJKI");
                        uslov = false;
                        break;
                    }
                }
                else
                {
                    uslov = false;
                    Console.WriteLine("DOZVOLENI SE SAMO 4 BROJKI");
                    break;
                }


            }

            if (uslov)
            {
                int vkupnoOdTri = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    for (int a = 0; a < list.Count; a++)
                    {
                        if (i != a)
                        {
                            vkupnoOdTri += list[a];
                        }
                    }
                    if (vkupnoOdTri % 2 == 0)
                    {
                        nacini++;
                    }
                    vkupnoOdTri = 0;
                }
                if (nacini == 0)
                {
                    Console.WriteLine("-");
                }
                else if (nacini == 1)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("?");
                }
            }
        }
        static void Main(string[] args)
        {
            KikiRiki();
        }
    }
}
