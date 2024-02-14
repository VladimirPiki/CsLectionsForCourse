using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z48.MultilevelInheritance
{
    interface IEden
    {
        int Lenght(string str);
        bool DaliPostoiOdredenPodstring(string str, string niza);

    }
    internal class ClassA : IEden
    {

        //Одредува должина на стрингот.

        public int Lenght(string str)
        {
            int lenght = str.Length;
            return lenght;
        }



        //Бара дали постои одреден подстринг.

        public bool DaliPostoiOdredenPodstring(string str, string niza)
        {
            bool match = false;


            for (int i = 0; i <= str.Length - niza.Length; i++)
            {
                bool isto = true;

                for (int j = 0; j < niza.Length; j++)
                {
                    if (str[i + j] != niza[j])
                    {
                        isto = false;
                        break;
                    }
                }

                if (isto)
                {
                    match = true;
                }
            }

            return match;

        }




    }



    interface IDva
    {
        int BrojPovtoruvanja(string str, string niza);
        string BrisenjePodstring(string str, string niza);

    }

    internal class ClassB : IDva
    {


        //Брои колку пати се повторува одредн подстринг.

        public int BrojPovtoruvanja(string str, string niza)
        {

            int brojac = 0;

            for (int i = 0; i <= str.Length - niza.Length + 1; i++)
            {
                bool isto = true;




                for (int j = 0; j < niza.Length; j++)
                {
                    if (str[i + j] != niza[j])
                    {
                        isto = false;
                        break;
                    }


                }

                if (isto)
                {
                    brojac = brojac + 1;
                }
            }

            return brojac;
        }



        // Брише одредн подстринг.

        public string BrisenjePodstring(string str, string niza)
        {
            string izbrisano = "";




            for (int i = 0; i < str.Length - niza.Length; i++)
            {
                bool isto = false;

                for (int j = 0; j < niza.Length; j++)
                {
                    if (str[i + j] == niza[j])
                    {
                        isto = true;
                    }
                    else
                    {
                        if (i == (str.Length - niza.Length - 1))
                        {
                            for (int k = 0; k < niza.Length; k++)
                            {
                                izbrisano = izbrisano + str[i + k];
                            }
                        }

                        isto = false;
                        break;
                    }

                }

                if (isto)
                {
                    i = i + niza.Length - 1;
                }
                else
                {
                    izbrisano = izbrisano + str[i];
                }


            }

            return izbrisano;
        }


    }


     class ClassC : IEden, IDva
    {

        ClassA obj1 = new ClassA();
        ClassB obj2 = new ClassB();

   
        public int Lenght(string str)
        {
            return obj1.Lenght(str);
        }

        public bool DaliPostoiOdredenPodstring(string str, string niza)
        {
            return obj1.DaliPostoiOdredenPodstring(str, niza);
        }

      public  int BrojPovtoruvanja(string str, string niza)
        {
            return obj2.BrojPovtoruvanja(str, niza);
        }
     public   string BrisenjePodstring(string str, string niza)
        {
            return obj2.BrisenjePodstring(str, niza);
        }



        public string NajdolgaRasteckaPodniza(string str)
        {




            string nizi = "";
            bool pomalo = false;
            string krajno = "";
            int brojac = 1;


            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] < str[i + 1])
                {
                    nizi = nizi + str[i];
                    brojac = brojac + 1;

                    if (i == str.Length - 2)
                    {
                        if (nizi.Length > krajno.Length)
                        {
                            krajno = nizi;
                        }
                        break;
                    }



                }
                else if (str[i] >= str[i + 1] && str[i] > str[i - 1])
                {
                    nizi = nizi + str[i];
                    pomalo = true;
                }

                if (pomalo)
                {


                    if (nizi.Length > krajno.Length)
                    {
                        krajno = nizi;
                    }

                    nizi = "";
                    brojac = 1;
                    pomalo = false;

                }

            }
            return krajno;

        }

        public string NajdolgaOpagackaPodniza(string str)
        {


            string nizi = "";
            bool pomalo = false;
            string krajno = "";
            int brojac = 1;


            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1])
                {
                    nizi = nizi + str[i];
                    brojac = brojac + 1;

                    if (i == str.Length - 2)
                    {
                        if (nizi.Length > krajno.Length)
                        {
                            krajno = nizi;
                        }
                        break;
                    }



                }
                else if (str[i] <= str[i + 1])
                {
                    nizi = nizi + str[i];
                    pomalo = true;
                }

                if (pomalo)
                {


                    if (nizi.Length > krajno.Length)
                    {
                        krajno = nizi;
                    }

                    nizi = "";
                    brojac = 1;
                    pomalo = false;

                }

            }
            return krajno;

        }



    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ClassC obj = new ClassC();
        }
    }
}