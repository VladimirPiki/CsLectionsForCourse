using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z40.ZboroviDatotekaPodredeni
{
    internal class Program
    {
        static List<string> razdeli(string str)
        {
            List<string> list = new List<string>();
            string prazenStr = "";
            string split = " ";
            for (int a = 0; a < str.Length; a++)
            {
                foreach (char s in split)
                {
                    if (str[a] != s)
                    {
                        prazenStr += str[a];
                        if (a == str.Length - 1)
                        {
                            list.Add(prazenStr);
                        }
                    }
                    else
                    {
                        list.Add(prazenStr); ;
                        prazenStr = "";
                    }
                }
            }
            return list;
        }
        static SortedList<int, string> ZboroviDatotekaPodredeniDolzinaNaZbor(List<string> listaZaProverka)
        {
            SortedList<int, string> karakteri = new SortedList<int, string>();
            for (int i = 0; i < listaZaProverka.Count; i++)
            {
                if (listaZaProverka[i] != "")
                {

                    if (!karakteri.ContainsKey(listaZaProverka[i].Length))
                    {
                        karakteri[listaZaProverka[i].Length] = listaZaProverka[i];

                    }
                    else if (karakteri.ContainsKey(listaZaProverka[i].Length))
                    {
                        karakteri[listaZaProverka[i].Length] = karakteri[listaZaProverka[i].Length] + " " + listaZaProverka[i];
                    }
                }
            }
            return karakteri;
        }


        static void Main(string[] args)
        {
            string path = @"c:\temp\tekst2334.txt";
            //   string path = @"c:\temp\Z39.ZboroviDatotekaKarakter.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    /*  sw.WriteLine(" ChatGPT – a generative pre - trained transformer – was fine-tuned on top of GPT-3.5 using supervised learning as well as reinforcement learning.\r\nBoth approaches used human trainers to improve the model's performance. \r\nIn the case of supervised learning, the model was provided with conversations in which the trainers played both sides: \r\nthe user and the AI assistant. In the reinforcement step, human trainers first ranked responses that the model had created in a previous conversation.\r\nThese rankings were used to create 'reward models' that the model was further fine-tuned on using several iterations of Proximal Policy Optimization(PPO).\r\nProximal Policy Optimization algorithms present a cost - effective benefit to trust region policy optimization algorithms;\r\n                        they negate many of the computationally expensive operations with faster performance.The models were trained in \r\ncollaboration with Microsoft on their Azure supercomputing infrastructure.\r\n\r\nIn addition, OpenAI continues to gather data from ChatGPT users that could be used to further train and fine-tune ChatGPT.\r\nUsers are allowed to upvote or downvote the responses they receive from ChatGPT; upon upvoting or downvoting,\r\nthey can also fill out a text field with additional feedback.");*/

                }
            }


            // Open the file to read from.
            string tekst = "";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    tekst += s;
                }

            }

            SortedList<int, string> dolzinaZbor = new SortedList<int, string>();
            List<string> listaZaProverka = new List<string>(); ;
            listaZaProverka = razdeli(tekst);
            dolzinaZbor = ZboroviDatotekaPodredeniDolzinaNaZbor(listaZaProverka);

            foreach (KeyValuePair<int, string> v in dolzinaZbor)
            {
                Console.WriteLine(v.Key + "  " + v.Value);
            }

        }
    }
}
