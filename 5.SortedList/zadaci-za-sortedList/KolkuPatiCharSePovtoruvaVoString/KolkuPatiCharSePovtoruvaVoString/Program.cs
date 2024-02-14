using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkuPatiCharSePovtoruvaVoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Da izbroime kolku pati sekoj char se povtorvua vo sortiranata lista
             SortedList<char, int> numberNames = new SortedList<char, int>();// podreduvanje na bukva sekoja bukva po broj kolku ja ima i se sortira od najmala bukva kon najgolema bidejki kluc e char
              string s = "vladimirvvvv";

              for (int i = 0; i < s.Length; i++)// listanje na sekoj element od stringo
              {


                  if (!numberNames.ContainsKey(s[i]))// ako ja nema bukvata dodelimu vrednost 1
                  {
                      numberNames[s[i]] = 1;

                  }
                  else if (numberNames.ContainsKey(s[i]))// ako ja ima bukvata zgolemi mu ja vrednosta
                  {
                      numberNames[s[i]]++;
                  }
              }


              foreach (KeyValuePair<char, int> v in numberNames)// listaj sekoj element od sortiranata lista
              {
                  Console.WriteLine(v.Key + "  " + v.Value);//pecati
              }

        }
    }
}
