using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_ReplaceString
{
    internal class Program
    {
        static string ReplaceString(string str,string subString,string zameni)
        {
 
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
                    str = str.Remove(i, subString.Length).Insert(i, zameni);//Stringo ke go izbrisi substringot pocuvajki od pozicijata kaj so go najde baraniot podstring do dolzinata na baraniot podstring. I ke go  vnesi cel podstring so sakame da go zameni, od pozicijata kaj so go najde i izbrisa baraniot podstring.
                    i += zameni.Length - 1;// Posle naogjanjeto na podstringot vo stringot i vnesuvanjeto na posakuvaniot podstring, pozicijata na citacot vo stringot go nosime na poslednata bukva od novo dodadeniot podstring
                }
            }
            return str;
        }

        static string ZamenuvaPodstring(string str,string subString, string zameni)
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

    
    static void Main(string[] args)
        {
            string str = "Jas sum Vladimir ( vlade ) od Bitola i me vikaat vlade.";
            string subString = ".";
            string zameni = "Bladeeee";
            Console.WriteLine(ReplaceString(str,subString,zameni));
            Console.WriteLine(ZamenuvaPodstring(str, subString, zameni));
        }
    }
}
