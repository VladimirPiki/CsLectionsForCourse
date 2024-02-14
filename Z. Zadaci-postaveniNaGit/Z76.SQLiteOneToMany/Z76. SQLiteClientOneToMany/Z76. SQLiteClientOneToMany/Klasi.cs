using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z76.SQLiteClientOneToMany
{
    internal class Klasi
    {
        public string[] ConvertToStringArray(System.Array values)
        {
            // create a new string array  
            string[] theArray = new string[values.Length];
            // loop through the 2-D System.Array and populate the 1-D String Array  
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }
            return theArray;
        }

        public double SredenProsekNaOcenki(List<string> prosekOcenki)
        {
            double o;
            double vkupnoOcenki = 0;
            double vrednostOcenki = 0;
            double prosek = 0;
            foreach (string ocenka in prosekOcenki)
            {
                vkupnoOcenki++;
                bool daliEbrojka = Double.TryParse(ocenka, out o);
                if (daliEbrojka)
                {
                    vrednostOcenki = vrednostOcenki + o;
                }
            }
            prosek = vrednostOcenki / vkupnoOcenki;
            return prosek;
        }

        public SortedDictionary<int, int> Distribucija(List<string> vrednostiOdRange)
        {
            int vrednost;
            SortedDictionary<int, int> distribucijaOcenki = new SortedDictionary<int, int>();
            for (int i = 0; i < vrednostiOdRange.Count; i++)
            {
                bool tryParse = Int32.TryParse(vrednostiOdRange[i], out vrednost);
                if (tryParse)
                {
                    if (!distribucijaOcenki.ContainsKey(vrednost))
                    {
                        distribucijaOcenki[vrednost] = 1;
                    }
                    else if (distribucijaOcenki.ContainsKey(vrednost))
                    {
                        distribucijaOcenki[vrednost] += 1;
                    }
                }

            }
            return distribucijaOcenki;
        }

        public static string ExcelColumnFromNumber(int column)
        {
            string columnString = "";
            decimal columnNumber = column;
            while (columnNumber > 0)
            {
                decimal currentLetterNumber = (columnNumber - 1) % 26;
                char currentLetter = (char)(currentLetterNumber + 65);
                columnString = currentLetter + columnString;
                columnNumber = (columnNumber - (currentLetterNumber + 1)) / 26;
            }
            return columnString;
        }
    }
}
