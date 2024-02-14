using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace М21.Iskrsena_linija
{
    internal class Program
    {
        static int NajgolemBrojVoNiza(List<int> paramList)
        {
            int n = 0;
            for (int i = 0; i < paramList.Count; i++)
            {
                if (n < paramList[i])
                {
                    n = paramList[i];
                }
            }
            return n;
        }

        static int NajmalBrojVoNiza(List<int> paramList)
        {
            int n = paramList[0];
            for (int i = 1; i < paramList.Count; i++)
            {
                if (n > paramList[i])
                {
                    n = paramList[i];

                }
            }
            return n;
        }

        static int PlostinaNaPravoagolnik(List<int> paramList)
        {
            int a;
            a = NajgolemBrojVoNiza(paramList);
            int b;
            b = NajmalBrojVoNiza(paramList);
            int L = 0;
            int maxPlostina = 0;
            int temp = 0;
            for (int i = 0; i < paramList.Count; i++)
            {
                if (paramList[i] == a || paramList[i] == b)
                {
                    paramList.Remove(paramList[i]);
                }

            }
            int a1;
            a1 = NajgolemBrojVoNiza(paramList);//Treta strana
            if (a1 < a)
            {
                temp = a - a1;
                a = a - temp;
            }
            L = a * b;
            if (maxPlostina < L)
            {
                maxPlostina = L;
            }
            return maxPlostina;
        }

        static void Main(string[] args)
        {
           // List<int> list = new List<int>() { 1, 2, 3, 4 };
           // List<int> list = new List<int>() { 3, 4, 3, 4 };
           // List<int> list = new List<int>() { 4, 6, 7, 2 };//12
           List<int> list = new List<int>() { 99, 44, 66, 98 };//4312
           // List<int> list = new List<int>() { 4, 4, 4, 4 };//16
            int L;
            L = PlostinaNaPravoagolnik(list);

            Console.WriteLine("Najgolema plostina na pravoagolnik so mozi da ja sostavi Trpe e : "+L);


        }
    }
}
