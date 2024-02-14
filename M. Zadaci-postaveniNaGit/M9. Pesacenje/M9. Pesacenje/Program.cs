using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9.Pesacenje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vlezni parametri

            int pesacenjeParam = 15;
            int trcanjeParam = 25;

            int aktivniCekori = 10000; //pesaci 10000 cekori sekoj den
            int pesacenjeCekori = 2;// cekori vo sekunda
            int trcanjeCekori = 4;//cekoriv vo sekunda
            int minutaVoSekundi = 60;//sekundi
           
          int pesacenjeVoMinuta = pesacenjeCekori * minutaVoSekundi;// vo minuta 120
          int trcanjeVoMinuta = trcanjeCekori * minutaVoSekundi;// vo minuta 240

            int pesacenje=pesacenjeParam * pesacenjeVoMinuta;
            int trcanje = trcanjeParam * trcanjeVoMinuta;

            int vkupno = pesacenje + trcanje;
            int nedostasuvaatCekori = aktivniCekori - vkupno;
            Console.WriteLine("Martin treba da ispesaci uste : "+nedostasuvaatCekori+" cekori");
        }
    }
}
