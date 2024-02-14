using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace zadaca
{
    /*Заменува одреден под стринг со друг по желба на корисникот.
     * 
Заменува одреден карактер со друг по желба на корисникот
Пребарува дали постои одредена подниза и не информира ако постои колку пати се повторува. */
    internal class Program
    {
        class Karakter
        {

            string mStr;

            public Karakter()
            {

            }
            public Karakter(string str)
            {
                mStr = str;

            }
            /*   public string GetString(string podstring,string zamena)
               {
                   bool daligoima = false;
                   string goIma = "";
                   for (int i = 0; i < mStr.Length; i++)
                   {
                       if (mStr.Contains(podstring)) {
                       }
                   }

                       return mStr;
               }*/

            public string GetString(char bukva, char bukva1)
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

            public void GetList()
            {
                int rasteckiNizi = 0;
                int brojac = 1;
                bool rastecka = false;
                string rastecki = "";
                List<string> rezultat = new List<string>();
                for (int i = 1; i < mStr.Length; i++)
                {

                    if (mStr[i] > mStr[i - 1])
                    {
                        if (rastecki.Length == 0)
                        {
                            rastecki = rastecki + mStr[i - 1];
                        }
                        rastecki = rastecki + mStr[i];
                        brojac++;
                        if (i == mStr.Length - 1)
                        {
                            rastecka = false;
                            if (rastecki.Length > 1)
                            {

                                rezultat.Add(rastecki);
                            }
                            rasteckiNizi++;

                            break;
                        }

                        rastecka = true;
                    }
                    else
                    {

                        
                            rastecka = false;
                            rasteckiNizi++;
                            if (rastecki.Length > 1)
                            {
                                rezultat.Add(rastecki);
                            }

                            rastecki = "";
                            brojac = 1;
                        

                    }
                   /* foreach (string s in rezultat)
                    {
                        Console.WriteLine(s);
                    }*/

                }
            }


        }
        static void Main(string[] args)
        {
            char bukva1 = 'B';
            char bukvka2 = 'G';
            Karakter objLic = new Karakter("Jas sum Vladimir od Bitola i me vikaat vlade.");
            //Console.WriteLine(objLic.GetString(bukva1, bukvka2));
            objLic.GetList();


        }
    }
}
