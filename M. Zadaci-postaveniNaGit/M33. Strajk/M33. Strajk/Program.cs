using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M33.Strajk
{
    internal class Program
    {
        static int KolkuNedeliKeSeProdolziPolugodie(int param)
        {
            int voKojaSedmicaVlegva = 0;
            int dena = 0;
            int denaVoSedmica = 5; //dena
            int sedmiciVkupno = 18;
            int reshenie = 0;
            for (int sedmica = 1; sedmica <= sedmiciVkupno; sedmica++)
            {

                dena = denaVoSedmica * sedmica;

                if (param == dena)
                {
                    voKojaSedmicaVlegva = sedmica + 1;// DODAVAM 1 OTI POCNUVA OD DRUGATA NEDELA VEKJE PETOK GO NAOGJAM VAKA
                    break;
                }
                else if (param < dena)
                {
                    voKojaSedmicaVlegva = sedmica;
                    break;
                }

            }
            int saboti = 0;
            for (int a = voKojaSedmicaVlegva; a <= sedmiciVkupno; a++)
            {
                saboti++;
            }
            int sedmicaSoSeSaboti = 6;
            if (param > saboti)
            {
                param = param - saboti;
                for (int sedmica = 1; sedmica <= sedmiciVkupno; sedmica++)
                {
                    dena = sedmicaSoSeSaboti * sedmica;
                    if (param == dena)
                    {
                        voKojaSedmicaVlegva = sedmica;
                        break;
                    }
                    else if (param < dena)
                    {
                        voKojaSedmicaVlegva = sedmica;
                        break;
                    }
                }
               reshenie = voKojaSedmicaVlegva;
               return reshenie;
            }
            else
            {
               return reshenie;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete denovi");
            int param = Convert.ToInt32(Console.ReadLine());
            int resehenie = KolkuNedeliKeSeProdolziPolugodie(param);
            Console.WriteLine("Polugodieto ke se prodolzi za : " + resehenie+" sedmici");   
     
        }
    }
}
