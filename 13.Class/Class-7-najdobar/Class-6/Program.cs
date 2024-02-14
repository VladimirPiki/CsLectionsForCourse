using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasi
{
    class Date
    {
        int year, month, day;
        public Date(int year, int month, int day)
        {
            this.year = year;
            //mYear = year;
            this.month = month;
            this.day = day;
        }
        public void prikazi()
        {
            Console.WriteLine(year + " " + month + " " + day);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date obj = new Date(2020, 11, 10);

            obj.prikazi();
        }
    }

}