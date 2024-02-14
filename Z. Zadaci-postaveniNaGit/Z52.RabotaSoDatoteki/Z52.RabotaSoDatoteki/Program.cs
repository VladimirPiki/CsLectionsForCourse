using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z52.RabotaSoDatoteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Z52.RabotaSoDatoteki.Dadoteki objDadoteki = new Dadoteki();
            Z52.RabotaSoDatoteki.Direktoriumi objDirektoriumi = new Direktoriumi();

            /*Dadoteki*/
            // Најдете датотека во даден директориум.
          //  Console.WriteLine(objDadoteki.NajdiDadoteka("C", "temp\\Z52.RabotaSoDatoteki\\1.NajdiDadoteka", "najdidadoteka"));
            Console.WriteLine();

            ////• Избришете даототека по желба на корисникот.
          //  Console.WriteLine(objDadoteki.IzbriseteDadotekaPoZelbaNaKorisnikot("C", "temp\\Z52.RabotaSoDatoteki\\2.IzbriseteDadotekaPoZelbaNaKorisnikot", "testiraj.pub"));
            Console.WriteLine();

            ////• Преместете датотека од една на друга локација по желба на корисникот.
         //   Console.WriteLine(objDadoteki.PremestiDadotekaOdEdnaVoDrugaLokacijaPoZelbaNaKorisnikot("C", "temp\\Z52.RabotaSoDatoteki\\\\3.PremestiDadotekaOdEdnaVoDrugaLokacijaPoZelbaNaKorisnikot\\OdTuka", "ovajTekst.txt", "C", "temp\\Z52.RabotaSoDatoteki\\3.PremestiDadotekaOdEdnaVoDrugaLokacijaPoZelbaNaKorisnikot\\Vo"));
            Console.WriteLine();

            ////• Пребарување на датотеки со одредена големина
          //    Console.WriteLine(objDadoteki.PrebarajDadotekiSoOdredenaGolemina("C", "temp\\Z52.RabotaSoDatoteki\\4.PrebarajDadotekiSoOdredenaGolemina", "445658"));
            Console.WriteLine();


            ///*Direktoriumi*/
            //// • Најдете дупликати датотеки во еден директориум или во повеќе директориуми, избришете ги дупликатите датотеки по желба на корисникот.
         //    Console.WriteLine(objDirektoriumi.NajdiDuplikatiVoDirektoriumIizbrisiPoZelba("C", "temp\\Z52.RabotaSoDatoteki\\5.NajdiDuplikatiVoDirektoriumIizbrisiPoZelba|temp\\Z52.RabotaSoDatoteki\\5.NajdiDuplikatiVoDirektoriumIizbrisiPoZelba\\PAPKA1|temp\\Z52.RabotaSoDatoteki\\5.NajdiDuplikatiVoDirektoriumIizbrisiPoZelba\\PAPKA2|NEPOSTOECKA_PAPKA"));
            Console.WriteLine();

            ////• Преместете директориум од една на друга локација.
            Console.WriteLine(objDirektoriumi.PremesteteDirektoriumOdEdnaLokacijaNaDruga("C", "temp\\Z52.RabotaSoDatoteki\\6.PremesteteDirektoriumOdEdnaLokacijaNaDruga\\odTuka", "C", "temp\\Z52.RabotaSoDatoteki\\6.PremesteteDirektoriumOdEdnaLokacijaNaDruga\\vnatre\\tuka"));
           Console.WriteLine();

            ////• Најди ги сите датотеки со одредена екстензија во еден или повеќе директориуми.
          //  Console.WriteLine(objDirektoriumi.NajdiGiSiteDadotekiSoOdredenaEkstenzija("C", "temp\\Z52.RabotaSoDatoteki\\7.NajdiGiSiteDadotekiSoOdredenaEkstenzija", "pub"));
        }
    }
}
