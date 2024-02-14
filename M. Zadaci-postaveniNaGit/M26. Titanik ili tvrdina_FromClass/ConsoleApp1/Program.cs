using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> tvrdina = new List<List<int>>();

            List<int> red1 = new List<int>() { 0, 1, 0, 1 };
            tvrdina.Add(red1);
            List<int> red2 = new List<int>() { 1, 0, 1, 0 };
            tvrdina.Add(red2);
            List<int> red3 = new List<int>() { 0, 1, 0, 1 };
            tvrdina.Add(red3);
            List<int> red4 = new List<int>() { 1, 0, 1, 0 };
            tvrdina.Add(red4);

            List<List<int>> titanik = new List<List<int>>();

            List<int> red1Titanik = new List<int>() { 1, 1, 1, 1 };
            titanik.Add(red1Titanik);
            List<int> red2Titanik = new List<int>() { 1, 1, 1, 0 };
            titanik.Add(red2Titanik);
            List<int> red3Titanik = new List<int>() { 1, 1, 0, 0 };
            titanik.Add(red3Titanik);
            List<int> red4Titanik = new List<int>() { 1, 0, 0, 0 };
            titanik.Add(red4Titanik);

            int X = 0;
            int Y = 0;
            int V = 1;
            bool pripagjaTvrdina=false;
            bool pripagjaTitanik=false;

            if (tvrdina[X][Y] == V)
            {
                pripagjaTvrdina = true;

            }
            if (titanik[X][Y] == V)
            {
                pripagjaTitanik = true;
                Console.WriteLine("Pripagja na Titanik");
            }
            if (pripagjaTvrdina && pripagjaTitanik)
            {
                Console.WriteLine("Dvata tipa");
            }
            else if(pripagjaTvrdina && !pripagjaTitanik)
            {
                Console.WriteLine("Prv tip");
            }else if(pripagjaTitanik && !pripagjaTvrdina)
            {
                Console.WriteLine("Vtor tip");
            }
            else
            {
                Console.WriteLine("Ne e zname od dvata tipa");
            }





        }
    }
}
