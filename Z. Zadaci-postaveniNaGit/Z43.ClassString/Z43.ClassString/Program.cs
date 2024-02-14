using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z43.ClassString
{

    /* Заменува одреден под стринг со друг по желба на корисникот.
     * Заменува одреден карактер со друг по желба на корисникот
     * Пребарува дали постои одредена подниза и не информира ако постои колку пати се повторува.
     * Od koi karakteri e sostave stringot
     * Koj karakter kolku pati se povtoruva
     * Broj na rastecki podstringovi
     * */
    internal class Program
    {
        class String
        {

            string mStr;

            public String()
            {

            }
            public String(string str)
            {
                mStr = str;
            }

            // Заменува одреден под стринг со друг по желба на корисникот.
             public string GetReplaceSubstring(string subString, string zameni)
             {
                 for (int i = 0; i <= mStr.Length - subString.Length; i++)
                 {
                     bool pronajdeno = true;

                     for (int a = 0; a < subString.Length; a++)
                     {
                         if (mStr[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                         {
                             pronajdeno = false;
                             break;
                         }
                     }


                     if (pronajdeno)
                     {
                         mStr = mStr.Remove(i, subString.Length).Insert(i, zameni);//Stringo ke go izbrisi substringot pocuvajki od pozicijata kaj so go najde baraniot podstring do dolzinata na baraniot podstring. I ke go  vnesi cel podstring so sakame da go zameni, od pozicijata kaj so go najde i izbrisa baraniot podstring.
                         i += zameni.Length - 1;// Posle naogjanjeto na podstringot vo stringot i vnesuvanjeto na posakuvaniot podstring, pozicijata na citacot vo stringot go nosime na poslednata bukva od novo dodadeniot podstring
                     }
                 }
                 //Console.WriteLine(str);
                 return mStr;
             }

            public string ZamenuvaPodstring(string subString, string zameni)
            {
                string prezapisigo = "";
                bool ifSmenato = false;
                for (int i = 0; i <= mStr.Length - subString.Length; i++)
                {
                    bool pronajdeno = true;

                    for (int a = 0; a < subString.Length; a++)
                    {
                        if (mStr[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
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
                    if (i >= mStr.Length)
                    {
                        break;
                    }
                    prezapisigo += mStr[i];


                }
                //Console.WriteLine(str);
                if (ifSmenato)
                {
                    mStr = prezapisigo;
                }

                return mStr;
            }

            //Заменува одреден карактер со друг по желба на корисникот
            public string GetChar(char bukva, char bukva1)
            {
                string novString = "";
                for (int i = 0; i < mStr.Length; i++)
                {
                    if (mStr[i] == bukva)
                    {
                        novString += bukva1;

                    }
                    else
                    {
                        novString += mStr[i];
                    }
                }
                return novString;
            }

            // Пребарува дали постои одредена подниза и не информира ако постои колку пати се повторува.
            public int GetNumberOfSubstring(string subString)
            {
                int kolkuPatiSePovtoruva = 0;
                for (int i = 0; i <= mStr.Length - subString.Length; i++)
                {
                    bool pronajdeno = true;

                    for (int a = 0; a < subString.Length; a++)
                    {
                        if (mStr[i + a] != subString[a]) // Ako slednata bukva od kaj so e citacot ne e ista so bukvata od baraniot podstring nebaraj ponatamu
                        {
                            pronajdeno = false;
                            break;
                        }
                    }


                    if (pronajdeno)
                    {
                        kolkuPatiSePovtoruva++;
                    }
                }
                //Console.WriteLine(str);
                return kolkuPatiSePovtoruva;
            }

            //Od koi karakteri e sostave stringot
            public string GetUnikatiKarakteri()
            {
                string unique = "";

                foreach (char ch in mStr)
                {
                    bool razlikuva = true;

                    for (int i = 0; i < unique.Length; i++)
                    {
                        if (ch == unique[i])// provervam unikatnite dali gi ima vo stringot ako gi ima false 
                        {
                            razlikuva = false;
                            break;
                        }
                    }

                    if (razlikuva)// ako ja nema vo unikatnata vo proverkata go polnam stringot so char od unikatnata
                    {
                        unique += ch;
                    }
                }
                return unique;
            }

            //Koj karakter kolku pati se povtoruva
            public void GetKarakterKolkuPatiPovtoruva()
            {
                SortedList<char, int> numberChar = new SortedList<char, int>();// podreduvanje na bukva sekoja bukva po broj kolku ja ima i se sortira od najmala bukva kon najgolema bidejki kluc e char

                for (int i = 0; i < mStr.Length; i++)// listanje na sekoj element od stringo
                {
                    if (!numberChar.ContainsKey(mStr[i]))// ako ja nema bukvata dodelimu vrednost 1
                    {
                        numberChar[mStr[i]] = 1;

                    }
                    else if (numberChar.ContainsKey(mStr[i]))// ako ja ima bukvata zgolemi mu ja vrednosta
                    {
                        numberChar[mStr[i]]++;
                    }
                }

                foreach (KeyValuePair<char, int> v in numberChar)// listaj sekoj element od sortiranata lista
                {
                    Console.WriteLine(v.Key + "  " + v.Value);//pecati
                }
            }

            //Broj na rastecki podstringovi
            public int GetRasteckiPodstringoviBroj()
            {
                int rasteckiPodsting = 0;
                int brojac = 1;
                for (int i = 1; i < mStr.Length; i++)
                {
                    if (mStr[i] > mStr[i - 1])
                    {
                        brojac++;
                        if (i == mStr.Length-1)
                        {
                            rasteckiPodsting++;
                            break;
                        }
                   
                    }
                    else
                    {
                        if (brojac > 1)
                        {
                            rasteckiPodsting++;
                            brojac = 1;
                        }
                    }
                }

                return rasteckiPodsting;

            }
        }
        static void Main(string[] args)
        {
             String objStr = new String("Jas sum Vladimir ( vlade ) od bitola i me vikaat vlade.");
       /*     String objStr = new String("Jas sum Vladimir ( ");
         if(' ' > '(')
            {
                Console.WriteLine ("tocno");
            }*/

            //Заменува одреден карактер со друг по желба на корисникот
            char bukva1 = 'b';
            char bukvka2 = 'B';
            Console.WriteLine(objStr.GetChar(bukva1, bukvka2));

            //Заменува одреден под стринг со друг по желба на корисникот.
            string baranSubstring = ".";
            string zameni = "Piki";
          //  Console.WriteLine(objStr.GetReplaceSubstring(baranSubstring, zameni));
            Console.WriteLine(objStr.ZamenuvaPodstring(baranSubstring, zameni));

            // Пребарува дали постои одредена подниза и не информира ако постои колку пати се повторува.
            string daliPostoj = "Vladimir";
            if (objStr.GetNumberOfSubstring(daliPostoj) == 0)
            {
                Console.WriteLine("Podnizata " + daliPostoj + " sto ja baravte ne postoi !!!");
            }
            else
            {
                Console.WriteLine("Baranata podniza se povtoruva " + objStr.GetNumberOfSubstring(daliPostoj));
            }

            //Od koi karakteri e sostave stringot
            Console.WriteLine(objStr.GetUnikatiKarakteri());

            //Koj karakter kolku pati se povtoruva
            objStr.GetKarakterKolkuPatiPovtoruva();

            //Broj na rastecki podstringovi
            Console.WriteLine(objStr.GetRasteckiPodstringoviBroj());
        }
    }
}
