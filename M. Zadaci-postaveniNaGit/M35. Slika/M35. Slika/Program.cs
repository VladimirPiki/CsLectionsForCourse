using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M35.Slika
{
    internal class Program
    {
        static int Kolona(List<int>param)
        {
            int kolona = 0;
            for (int i = 0; i < param.Count; i++)
            {
                if (param[i] == 1)
                {
                    kolona++;
                }
                else
                {
                    kolona = kolona - 1;
                    break;
                }

            }
            return kolona;  
        }
        static void Main(string[] args)
        {
            //List<int> param = new List<int>() { 1, 1, 1, 1, 1 ,1, 1, 1, 1,
            //                                    1, 2, 2, 2, 2, 2, 2, 2, 1,
            //                                    1, 2, 2, 2, 2, 2, 2, 2, 1,
            //                                    1, 2, 2, 2, 2, 2, 2, 2, 1,
            //                                    1, 1, 1, 1, 1, 1, 1, 1, 3 };

            List<int> param = new List<int>() {1, 1, 1,
                                                1, 2, 1,
                                                1, 1, 3 };

            int kolona = Kolona(param); 
            int redica = param.Count / kolona;

            Console.WriteLine(kolona);
            Console.WriteLine(redica);
        }
    }
}
