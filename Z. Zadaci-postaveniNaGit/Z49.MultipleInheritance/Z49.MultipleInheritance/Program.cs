using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ClassA
Одредува должина на стрингот.
Бара дали постои одреден подстринг.
ClassB
Брои колку пати се повторува одредн подстринг.
Брише одредн подстринг.
ClassC
Најдолг растечки подстринг.
Најдолг опаѓачки подстринг.
Заменува одреден подстринг со друг.
*/
interface IClassA
{
    int OdreduvaDolzinaString(string str);
    bool DaliPostojOdredenPodstring(string str, string subString);
}
class ClassA : IClassA
{
    public int OdreduvaDolzinaString(string str)
    {
        return str.Length;
    }

    public bool DaliPostojOdredenPodstring(string str,string subString)
    {
        bool daliPostoj = false;
        for (int i = 0; i <= str.Length - subString.Length; i++)
        {
            bool pronajdeno = true;

            for (int a = 0; a < subString.Length; a++)
            {
                if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                {
                    pronajdeno = false;
                    break;
                }

            }
            if (pronajdeno)
            {
                daliPostoj = true;
                break;
            }
        }
        return daliPostoj;
    }
}

interface IClassB
{
    int KolkuPatiSePovtoruvaOdredenPodstring(string str, string subString);
    bool BrisiOdredenPodstring(string str, string subString);
}
class ClassB : IClassB
{
    public int KolkuPatiSePovtoruvaOdredenPodstring(string str,string subString)
    {
        int kolkuPati = 0;
        for (int i = 0; i <= str.Length - subString.Length; i++)
        {
            bool pronajdeno = true;

            for (int a = 0; a < subString.Length; a++)
            {
                if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                {
                    pronajdeno = false;
                    break;
                }

            }
            if (pronajdeno)
            {
                kolkuPati++;

            }
        }
        return kolkuPati;
    }

    public bool BrisiOdredenPodstring(string str,string subString)
    {
        bool daliEizbrisan = false;
        string prezapisigo = "";

        for (int i = 0; i <= str.Length - subString.Length; i++)
        {

            bool pronajdeno = true;

            for (int a = 0; a < subString.Length; a++)
            {
                if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                {
                    pronajdeno = false;
                    break;
                }
            }

            if (pronajdeno)
            {
                i += subString.Length;
            }
            if (i >= str.Length)
            {
                break;
            }

            prezapisigo += str[i];
        }

        string orginal = "";

        for (int i = 0; i <= str.Length - subString.Length; i++)
        {
            orginal += str[i];
        }

        if (orginal == prezapisigo)
        {
            daliEizbrisan = false;
        }
        else
        {
            daliEizbrisan = true;
        }
        //PROVERKA DALI E IZBRISAN
        //Console.WriteLine(daliEizbrisan+" izbrisan");
        //Console.WriteLine(prezapisigo + " PREZAPISAN");
        //Console.WriteLine(orginal + " ORGINAL");
        //    return prezapisigo;
        return daliEizbrisan;
    }
}

class ClassC : IClassA, IClassB
{
    ClassA obj1 = new ClassA();
    ClassB obj2 = new ClassB();

    public int OdreduvaDolzinaString(string str)
    {
        return obj1.OdreduvaDolzinaString(str);
    }

    public bool DaliPostojOdredenPodstring(string str, string subString)
    {
        return obj1.DaliPostojOdredenPodstring(str, subString);
    }

    public int KolkuPatiSePovtoruvaOdredenPodstring(string str, string subString)
    {
        return obj2.KolkuPatiSePovtoruvaOdredenPodstring(str, subString);
    }

   public bool BrisiOdredenPodstring(string str, string subString)
    {
        return obj2.BrisiOdredenPodstring(str, subString);
    }


    public string NajdolgRasteckiPodstring(string str)
    {
        List<string> listaRastecki = new List<string>();
        string polniLista = "";
        string najdolgRasteckiSubstr = "";
        int rasteckiPodsting = 0;
        int brojac = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] > str[i - 1])
            {
                brojac++;
                polniLista += str[i];
                if (i == str.Length - 1)
                {
                    rasteckiPodsting++;
                    listaRastecki.Add(polniLista);
                    break;
                }

            }
            else
            {
                if (brojac > 1)
                {
                    rasteckiPodsting++;
                    brojac = 1;
                    listaRastecki.Add(polniLista);
                    polniLista = "";
                }
            }
        }
        //     Console.WriteLine(rasteckiPodsting);
        for (int i = 0; i < listaRastecki.Count; i++)
        {
            //   Console.WriteLine(listaRastecki[i]);
            if (najdolgRasteckiSubstr.Length < listaRastecki[i].Length)
            {
                najdolgRasteckiSubstr = listaRastecki[i];
            }
        }
        //  Console.WriteLine();    
        return najdolgRasteckiSubstr;
    }

    public string NajdolgOpagjackiPodstring(string str)
    {
        List<string> listaOpagjacki = new List<string>();
        string polniLista = "";
        string najdolgOpagjackiSubstr = "";
        int opagjackiPodsting = 0;
        int brojac = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] < str[i - 1])
            {
                brojac++;
                polniLista += str[i];
                if (i == str.Length - 1)
                {
                    listaOpagjacki.Add(polniLista);
                    opagjackiPodsting++;
                    break;
                }
            }
            else
            {
                if (brojac > 1)
                {
                    opagjackiPodsting++;
                    brojac = 1;
                    listaOpagjacki.Add(polniLista);
                    polniLista = "";
                }
            }
        }
        //   Console.WriteLine(opagjackiPodsting);
        //foreach (string lR in listaOpagjacki)
        //{
        //   // Console.WriteLine(lR);
        //    if (najdolgOpagjackiSubstr.Length < lR.Length)
        //    {
        //        najdolgOpagjackiSubstr = lR;
        //    }
        //}

        for (int i = 0; i < listaOpagjacki.Count; i++)
        {
             // Console.WriteLine(listaOpagjacki[i]);
            if (najdolgOpagjackiSubstr.Length < listaOpagjacki[i].Length)
            {
                najdolgOpagjackiSubstr = listaOpagjacki[i];
            }
        }
        //Console.WriteLine();
        return najdolgOpagjackiSubstr;
    }

    public string ZamenuvaOdredenPodstringSoDrug(string str,string subString, string zameni)
    {
        string prezapisigo = "";
        bool ifSmenato = false;
        for (int i = 0; i <= str.Length - subString.Length; i++)
        {
            bool pronajdeno = true;

            for (int a = 0; a < subString.Length; a++)
            {
                if (str[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                {
                    pronajdeno = false;
                    break;
                }
            }


            if (pronajdeno)
            {
                i += subString.Length;
                for (int a = 0; a < zameni.Length; a++)
                {
                    prezapisigo += zameni[a];
                }
                ifSmenato = true;
            }
            if (i >= str.Length)
            {
                break;
            }
            prezapisigo += str[i];


        }
        //Console.WriteLine(str);
        if (ifSmenato)
        {
            str = prezapisigo;
        }


        return str;
    }

}

namespace Z49.MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassC obj = new ClassC();

            //Одредува должина на стрингот.
            Console.WriteLine("Odreduva dolzina na stringot: "+obj.OdreduvaDolzinaString("Vladimir"));

            //Бара дали постои одреден подстринг.
            Console.WriteLine("Bara dali postoi odreden podstring: "+obj.DaliPostojOdredenPodstring("Vladimir Krstevski Bitola e od Bitola.","Bitola"));

            //Брои колку пати се повторува одредн подстринг.
            Console.WriteLine("Broi kolku pati se povtoruva odreden podstring: "+obj.KolkuPatiSePovtoruvaOdredenPodstring("Vladimir Krstevski Bitola e od Bitola.", "Bitola"));

            //Брише одредн подстринг.
            Console.WriteLine("Brise odreden podstring: (Ako se izbrisi vrakja True, ako ne se izbrisi vrakja False) "+obj.BrisiOdredenPodstring("Vladimir Krstevski Bitola e od Bitola", "ola"));

            //Најдолг растечки подстринг.
            Console.WriteLine("Najdolg rastecki podstring: "+obj.NajdolgRasteckiPodstring("Vladimir Krstevski Bitola e od Bitola.abcd abcde"));

            //Најдолг опаѓачки подстринг.
            Console.WriteLine("Najdolg opagjacki podstring: "+obj.NajdolgOpagjackiPodstring("Vladimir Krstevski Bitola e od Bitola.wtecba"));

            //Заменува одреден подстринг со друг.                     recenica           baran zbor   zamenigo so        
            Console.WriteLine("Zamenuva odreden podstring: "+obj.ZamenuvaOdredenPodstringSoDrug("Vladimir Krstevski Vlade.", ".",  " Piki"));
        }
    }
}
