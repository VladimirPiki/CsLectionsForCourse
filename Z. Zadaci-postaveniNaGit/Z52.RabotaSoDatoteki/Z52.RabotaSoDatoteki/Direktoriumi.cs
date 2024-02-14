using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Z52.RabotaSoDatoteki.Direktoriumi;

namespace Z52.RabotaSoDatoteki
{
    /*
 * • Најдете дупликати датотеки во еден директориум или во повеќе директориуми, избришете ги дупликатите датотеки по желба на корисникот.
• Преместете директориум од една на друга локација.
• Најди ги сите датотеки со одредена екстензија во еден или повеќе директориуми.
 * */
    internal class Direktoriumi
    {

        public List<string> DirSearch(string sDir)
        {
            List<string> list = new List<string>();
            try
            {
                bool prvDirektorium = false;
                if (prvDirektorium == false)
                {
                    foreach (string f in Directory.GetFiles(sDir))
                    {
                        //Console.WriteLine(f);
                        list.Add(f);
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        // Console.WriteLine(f);
                        list.Add(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return list;
        }

        public void PremestiCelDirektorium(string sDir, string particijaPrem, string folderPremesti, string folder )
        {
            string krajnaCel = particijaPrem + ":\\" + folderPremesti + "\\" + folder;
            Directory.CreateDirectory(krajnaCel);
           
            try
            {
                bool prvDirektorium = false;
                if (prvDirektorium == false)
                {
                    foreach (string f in Directory.GetFiles(sDir))
                    {
                        string ime = Path.GetFileName(f);

                    File.Move(f, particijaPrem + ":\\" + folderPremesti + "\\" + folder+"\\"+ime);
                         // Console.WriteLine(ime);
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    string imeFolder= Path.GetFileName(d);  
               //     Console.WriteLine(d);
                    Directory.CreateDirectory(particijaPrem + ":\\" + folderPremesti + "\\" + folder+"\\"+ imeFolder);
                    foreach (string f in Directory.GetFiles(d))
                    {
                        string ime = Path.GetFileName(f);
                    File.Move(f, particijaPrem + ":\\" + folderPremesti + "\\" + folder + "\\"+ imeFolder +"\\"+ ime);
                      // Console.WriteLine(f);
                    }
                    PremestiCelDirektorium(d, particijaPrem, folderPremesti, folder);
                }
                Directory.Delete(sDir);
                Console.WriteLine("USPESHNO PREMESTEN DIREKTORIUMOT" + sDir);
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

        }

        public string NajdiDuplikatiVoDirektoriumIizbrisiPoZelba(string particija, string folder)
        {
            string vrati = "";
            if (!Directory.Exists(particija + ":\\"))
            {
                vrati = "Particijata sto ja vnesovte ne postoi !!!";
            }
            else
            {
                string[] split = folder.Split('|');

                foreach (string s in split)
                {
                    if (!Directory.Exists(particija + ":\\" + s) || s == "" || s == " ")
                    {
                        Console.WriteLine(s + "Folderot sto go vnesovte ne postoi !!!");
                    }
                    else
                    {
                        List<string> duplikati = new List<string>();
                        SortedDictionary<string, string> duplicates = new SortedDictionary<string, string>(); ;
                        List<string> orginali = new List<string>();
                        string daliPostojFolderot = particija + ":\\" + s;
                        var list = DirSearch(daliPostojFolderot);
                        foreach (var item in list)
                        {
                            // Console.WriteLine(item);

                            string ime = "";
                            string celoIme = item;
                            string[] result = celoIme.Split(' ');
                            if (result.Length > 1)
                            {
                                for (int i = 0; i < result.Length; i++)
                                {
                                    ime = result[0];
                                    break;
                                }
                                duplikati.Add(celoIme);
                                duplicates.Add(celoIme, ime);
                            }
                            else
                            {
                                ime = result[0];
                                orginali.Add(ime);
                            }
                        }

                        foreach (var i in orginali)
                        {
                            Console.WriteLine("Orginalna dadoteka:"+i);    
                        }
                        Console.WriteLine();
                        foreach (var i in duplikati)
                        {
                            Console.WriteLine("Duplikat dadoteka:" + i);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Izbriste duplikat so vnesuvanje na imeto na fajlot, dokolku sakate povekje duplikati istovremeno pomegju imeto na fajlovite vnesete prava crta | i duplikati od podfolderot");
                        string izbrisiFile=Console.ReadLine();
                        string[] razdeliFajloj = izbrisiFile.Split('|');
                        foreach(string imeNaFajl in razdeliFajloj)
                        {
                            string dadotekaIzbrisi = particija + ":\\" + s + "\\" + imeNaFajl;
                            if (!File.Exists(dadotekaIzbrisi)){ 
                            
                                Console.WriteLine(imeNaFajl + " Imeto na dadotekata sto go vnesovte ne postoi !!!");
                            }
                            else
                            {
                                File.Delete(dadotekaIzbrisi);
                                Console.WriteLine(dadotekaIzbrisi+ " USPESHNO IZBRISANA !!!");
                            }
                            //   Console.WriteLine(imeNaFajl);
                        }
                        Console.WriteLine();

                    }

                }
            }
            return vrati;
        }

        public string PremesteteDirektoriumOdEdnaLokacijaNaDruga(string particija, string folder,string particijaPrem,string folderPremesti)
        {
            string vrati = "";
            if (!Directory.Exists(particija + ":\\"))
            {
                vrati = "Particijata sto ja vnesovte ne postoi !!!";
            }
            else if (!Directory.Exists(particija + ":\\" + folder) || folder == ""|| folder == " ")
            {
                vrati = "Folderot sto go vnesovte ne postoi!!!";
            }
            else
            {

                Console.WriteLine(particija);
                Console.WriteLine(particijaPrem);
                Console.WriteLine(folderPremesti);
                Console.WriteLine(folder);
                if (Directory.Exists(particijaPrem + ":\\" + folderPremesti + "\\" +folder))
                {
                    vrati = "Direktoriumot so pateka: " + particijaPrem + ":\\" + folderPremesti + "\\" + folder + " postoi na toa mesto";
                }
                else
                {
                  PremestiCelDirektorium(particija + ":\\" + folder, particijaPrem, folderPremesti,  folder);
                }
                
            }
           
            return vrati;
        }

        public string NajdiGiSiteDadotekiSoOdredenaEkstenzija(string particija, string folder,string ekstenzijaBaraj)
        {
            string vrati = "";
            if (!Directory.Exists(particija + ":\\"))
            {
                vrati = "Particijata sto ja vnesovte ne postoi !!!";
            }
            else
            {
                string[] split = folder.Split('|');

                foreach (string s in split)
                {
                    if (!Directory.Exists(particija + ":\\" + s) || s == "" || s == " ")
                    {
                        Console.WriteLine(s + "Folderot sto go vnesovte ne postoi !!!");
                    }
                    else
                    {
              
                        string daliPostojFolderot = particija + ":\\" + s;
                        var list = DirSearch(daliPostojFolderot);
                        foreach (var item in list)
                        {
                            string[] ekstenzija = item.Split('.');
                            foreach (string ext in ekstenzija)
                            {
                                if (ext == ekstenzijaBaraj)
                                {
                                    Console.WriteLine(item);
                                }
                            }

                        }

                    }

                }
            }
            return vrati;
        }


    }
}
