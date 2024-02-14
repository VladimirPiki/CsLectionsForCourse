using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

public class ClassA
{
    public int OdreduvaDolzinaString(string str)
    {
        return str.Length;
    }
}

// Derived Class
public class ClassB : ClassA
{

    public int KolkuPatiSePovtoruvaOdredenKarakter(string str, char bukva)
    {
        int kolkuSePovtoruva = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == bukva)
            {
                 kolkuSePovtoruva++;
            }
        }
        return kolkuSePovtoruva;
    }

    public string ZamenaNaKarakter(string str,char bukva, char bukva1)
    {
        string novString = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == bukva)
            {
                novString += bukva1;

            }
            else
            {
                novString += str[i];
            }
        }
        return novString;
    }
  



}

// Derived Class
public class ClassC : ClassA
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

    public string ZamenuvaOdredenPodstringSoDrug(string str, string subString, string zameni)
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

namespace Z47.HierarchicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB obj = new ClassB();
            ClassC obj2 = new ClassC();

            //Должинa на стринг
            Console.WriteLine(obj.OdreduvaDolzinaString("Vladimir"));

            //Колку пати се повторува карактер по избор
            Console.WriteLine(obj.KolkuPatiSePovtoruvaOdredenKarakter("Vladimir",'i'));
            //Замена на каркатер по избор
            Console.WriteLine(obj.ZamenaNaKarakter("Vladimir", 'i','e'));


            //Колку пати се повторува подстринг во стрингот
            Console.WriteLine(obj2.KolkuPatiSePovtoruvaOdredenPodstring("Vladimir e vlade i e vlade", "vlade"));

           // Замена на подстринг со друг подстринг
            Console.WriteLine(obj2.ZamenuvaOdredenPodstringSoDrug("Vladimir e vlade i e vlade", "vlade","piki"));





        }
    }
}
