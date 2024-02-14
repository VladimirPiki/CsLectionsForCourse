using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M12.Datum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vlezen parametar N-denovi od denes
            // 2
            // 20
            //64  -- 10maj testirano na list
            //80 -- 26 maj testirano na list

            int denoviOdDenes = 24;

            int denes = 7;// mart
            int maxDenoviZaCekanje = 80;
            int moiPocnuva =denes + denoviOdDenes;

            //Console.WriteLine(moiPocnuva);
            int martDenoj = 30;
            int aprilDenoj=31;
            int mesecNapred=martDenoj + aprilDenoj; 

            for(int i=1;i <= (maxDenoviZaCekanje+denes); i++)
            {
               // Console.WriteLine(i);
               if(i <= martDenoj)
                {
                    if ((i == moiPocnuva))
                    {
                        Console.WriteLine(i + ". mart");
                    }
                }
                else if(martDenoj < i && i <= mesecNapred) // april idi
                {
                    if (i == moiPocnuva)
                    {
                        moiPocnuva = moiPocnuva - martDenoj;
                        Console.WriteLine(moiPocnuva + ". april");
                    }
                }
                else // maj idi
                {
                    if (i == moiPocnuva)
                    {
                        moiPocnuva = moiPocnuva - mesecNapred;
                        Console.WriteLine(moiPocnuva + ". maj");
                    }
                }
            }

   

        }
    }
}
