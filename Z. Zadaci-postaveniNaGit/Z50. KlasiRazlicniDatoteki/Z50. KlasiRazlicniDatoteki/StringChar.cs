using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z50.KlasiRazlicniDatoteki
{
    internal class StringChar
    {
        /* • Пребарува дали одреден карактер постои во стрингот.
	• Брои колку пати се повторува какрактер во по избор во стрингот.
	• Брише карактер по избор.
	• Заменува каракер по избор со друг карактер*/

        public bool DaliPostojOdredenKarakterVoString(string str,char bukva)
        {
            bool daliPostoj = false;
            for(int i=0;i < str.Length; i++)
            {
                if (str[i] == bukva)
                {
                    daliPostoj = true;
                }
            }
            return daliPostoj;
        }

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

        public bool BriseKarakterPoIzbor(string str,char bukva)
        {
            string prezapisigo = "";
            bool daliEizbrisan = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != bukva)
                {
                    prezapisigo += str[i];
                }
            }

            if (str == prezapisigo)
            {
                daliEizbrisan = false;
            }
            else
            {
                daliEizbrisan = true;
            }

            return daliEizbrisan;
        }

        public string ZamenaNaKarakter(string str, char bukva, char bukva1)
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
}
