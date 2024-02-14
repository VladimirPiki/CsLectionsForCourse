using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M34.Bulevar
{
    internal class Program
    {
        static List<int> ParniBroevi(int slParceli)
        {
            List<int> listParni = new List<int>();

            for (int i = 1; i <= slParceli; i++)
            {
                if (i % 2 == 0)
                {
                    listParni.Add(i);
                }
            }
            return listParni;
        }

        static List<int> NeparniBroevi(int slParceli)
        {
            List<int> listNeparni = new List<int>();

            for (int i = 1; i <= slParceli; i++)
            {
                if (i % 2 == 0)
                {
 
                }
                else
                {
                    listNeparni.Add(i);
                }
            }
            return listNeparni;
        }
        static List<int> NajmnoguParceli(int zakon,List<int> zgradiNaMesto,List<int> listParni)
        {
            List<int>reshenieLista = new List<int>();
            int temp = zakon;
            int reshenie = 0;
            int imaZgradaTuka = 0;
            int broj = 0;
            int posledniZgradi = 0;
            List<int> gradiTuka = new List<int>();
            for (int i = 0; i < listParni.Count; i++)
            {
                bool uslov = true;
                broj = listParni[i];
                temp = i;
                if (i < listParni.Count - zakon)
                {
                    int test = i + zakon;
                    while (temp <= test)
                    {
                        for (int j = 0; j < zgradiNaMesto.Count; j++)
                        {
                            if (zgradiNaMesto[j] == listParni[temp])
                            {
                                uslov = false;
                                imaZgradaTuka = temp;
                                break;

                            }
                        }
                        temp++;
                    }
                }
                else
                {
                    for (int j = 0; j < zgradiNaMesto.Count; j++)
                    {
                        if (zgradiNaMesto[j] == listParni[i])
                        {
                            posledniZgradi++;
                            break;

                        }
                    }
                }
                if (uslov && posledniZgradi < 1)
                {
                    gradiTuka.Add(broj);
                    i = i + zakon;
                }
                if (uslov == false && i == imaZgradaTuka)
                {
                    i = i + zakon;
                }

            }
            foreach (int g in gradiTuka)
            {
                // reshenie++;
                reshenieLista.Add(g);

            }
            //return reshenie;
            return reshenieLista;
        }

        static int Bulevar(int slParceli, int zakonParni,int zakonNeparni,List<int> zgradiNaMesto)
        {

            List<int> listParni = ParniBroevi(slParceli);
            List<int> listNeparni = NeparniBroevi(slParceli);
            List<int> levaStranaZgradi = NajmnoguParceli(zakonParni, zgradiNaMesto, listParni);
            List<int> desnaStranaZgradi = NajmnoguParceli(zakonNeparni, zgradiNaMesto, listNeparni);
            int levaStranaParni = 0;
            int desnaStranaNeparni = 0;
            foreach (int l in levaStranaZgradi)
            {
                levaStranaParni++;
               // Console.WriteLine(l);
            }
           // Console.WriteLine();
            foreach (int d in desnaStranaZgradi)
            {
                desnaStranaNeparni++;
               // Console.WriteLine(d);
            }
            return levaStranaParni + desnaStranaNeparni;
        }


        static void Main(string[] args)
        {
            int slParceli = 20;
            int zakonParni = 2;
            int zakonNeparni = 2;
            List<int> zgradiNaMesto = new List<int>() {8,20,7,19};
            int reshenie = Bulevar(slParceli, zakonParni, zakonNeparni, zgradiNaMesto);
            Console.WriteLine("najmnogu mozi da se se izgradat "+reshenie+ " zgradi");

        }
    }
}
