using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace Z41.RabotaSoDatoteki
{
    internal class Program
    {
        static string DaliParticijataPostoi(string particija)
        {
            string vratiParticija = particija + ":\\";
            if (!Directory.Exists(particija + ":\\"))
            {
                vratiParticija = "-1";
            }
            return vratiParticija;
        }

        static string DaliFolderotPostoi(string particija, string folder)
        {
            string vratiFolder = particija + ":\\" + folder;

            if (!Directory.Exists(particija + ":\\" + folder) || folder == "")
            {
                vratiFolder = "-1";
            }
            return vratiFolder;
        }

        static string NajdiDadoteka(string particija, string folder, string imeNaFajl)
        {
            string vrati = "";
            if (!Directory.Exists(particija + ":\\"))
            {
                vrati = "Particijata sto ja vnesovte ne postoi !!!";
            }
            else if (!Directory.Exists(particija + ":\\" + folder) || folder == "")
            {
                vrati = "Folderot sto go vnesovte ne postoi !!!";
            }
            else
            {
                bool postoi = false;
                string[] fileEntries = Directory.GetFiles(particija + ":\\" + folder);
                Console.WriteLine(particija + ":\\" + folder);
                foreach (string fileName in fileEntries)
                {
                    string ime = Path.GetFileNameWithoutExtension(fileName);
                    if (imeNaFajl == ime)
                    {
                        vrati = "Fajlot sto go barate:  " + Path.GetFileName(fileName);
                        postoi = true;
                    }

                }
                if (postoi == false)
                {
                    vrati = "Dadotekata sto ja barate ne postoi !!!";
                }
            }
            return vrati;
        }

        static SortedDictionary<int, string> ListajDadotekaImeNaFajlPoRedenBroj(string particijaIzbrisi, string folderIzbrisi)
        {

            var najdi = new SortedDictionary<int, string>();
            if (!Directory.Exists(particijaIzbrisi + ":\\"))
            {
                Console.WriteLine("Particijata sto ja vnesovte ne postoi !!!");
                najdi.Add(0, "NEPOSTOJ");
            }
            else if (!Directory.Exists(particijaIzbrisi + ":\\" + folderIzbrisi) || folderIzbrisi == "")
            {
                Console.WriteLine("Folderot sto go vnesovte ne postoi !!!");
                najdi.Add(0, "NEPOSTOJ");
            }
            else
            {
                string[] fileEntries = Directory.GetFiles(particijaIzbrisi + ":\\" + folderIzbrisi);

                int redenBroj = 1;
                for (int i = 0; i < fileEntries.Length; i++)
                {
                    najdi.Add(redenBroj, Path.GetFileName(fileEntries[i]));
                    redenBroj++;
                }

            }
            return najdi;
        }
        static SortedDictionary<int, string> ListFileNameWithNumber(string daliPostojFolderot)
        {
            var najdi = new SortedDictionary<int, string>();
            string[] fileEntries = Directory.GetFiles(daliPostojFolderot);

            int redenBroj = 1;
            for (int i = 0; i < fileEntries.Length; i++)
            {
                najdi.Add(redenBroj, Path.GetFileName(fileEntries[i]));
                redenBroj++;
            }
            return najdi;
        }

        static SortedDictionary<int, string> ListDirectory(string particija,string folder)
        {
            var najdi = new SortedDictionary<int, string>();
            string dadoteka = particija + ":\\"+folder;
             string[] fileEntries = Directory.GetDirectories(dadoteka);

              int redenBroj = 1;
              for (int i = 0; i < fileEntries.Length; i++)
              {
                  najdi.Add(redenBroj, Path.GetFileName(fileEntries[i]));
                  redenBroj++;
              }


            return najdi;
        }
        static string DeleteFile(int brojZaBrisenje, SortedDictionary<int, string> najdi, string particijaIzbrisi, string folderIzbrisi)
        {
            string vrati = "";
            bool nepostojTakovBroj = true;
            foreach (KeyValuePair<int, string> n in najdi)
            {
                if (n.Key == brojZaBrisenje)
                {
                    nepostojTakovBroj = false;
                    string imeNaFajlIzbrisi = n.Value;
                    string dadotekaIzbrisi = particijaIzbrisi + ":\\" + folderIzbrisi + "\\" + imeNaFajlIzbrisi;
                    {
                        File.Delete(dadotekaIzbrisi);
                        vrati = "Dadotekata e USPESHNO IZBRISANA !!!";
                    }

                }
            }
            if (nepostojTakovBroj == true)
            {
                vrati = "Ne postoi dadoteka so reden broj " + brojZaBrisenje;
            }
            return vrati;
        }

        static string ImeNaFajlPodRedenBroj(int brojZaPremestuvanje, SortedDictionary<int, string> najdi)
        {
            bool nepostojTakovBroj = true;
            string imeNaFajlPremesti = "";
            foreach (KeyValuePair<int, string> n in najdi)
            {
                if (n.Key == brojZaPremestuvanje)
                {
                    nepostojTakovBroj = false;
                    imeNaFajlPremesti = n.Value;

                }
            }
            if (nepostojTakovBroj == true)
            {
                imeNaFajlPremesti = "-1";
            }
            return imeNaFajlPremesti;
        }

        static void MoveAllFromDir(string source, string dest)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dest);
            if (dirInfo.Exists == false)
                Directory.CreateDirectory(dest);


            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();


            string[] files = Directory.GetFiles(source);
            Int32 i = dirs.Count() + files.Count();
            //   for progress bar

            foreach (string file in files)
            {
                try
                {
                    string name = Path.GetFileName(file);
                    string destFile = Path.Combine(dest, name);
                    // skip some file
                    if (name != "file") File.Move(file, destFile);
                }
                catch
                {

                }
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(dest, subdir.Name);
                if (!Directory.Exists(temppath))
                    try
                    {
                        Directory.Move(subdir.FullName, temppath);
                    }
                    catch
                    {

                    }
            }
            Directory.Delete(source);
        }

        static string MoveFile(int brojZaPremestuvanje, SortedDictionary<int, string> najdi, string particijaPremesti, string folderPremesti, string particijaPremesti2, string folderPremesti2)
        {
            string vrati = "";
            foreach (KeyValuePair<int, string> n in najdi)
            {
                if (n.Key == brojZaPremestuvanje)
                {
                    string imeNaFajlPremesti = n.Value;
                    string dadotekaPremesti = particijaPremesti + ":\\" + folderPremesti + "\\" + imeNaFajlPremesti;
                    string dadotekaPremesti2 = particijaPremesti2 + ":\\" + folderPremesti2 + "\\" + imeNaFajlPremesti;
                    try
                    {
                        if (File.Exists(dadotekaPremesti2))
                            File.Delete(dadotekaPremesti2);

                        // Move the file.
                        File.Move(dadotekaPremesti, dadotekaPremesti2);
                        vrati = "Dadotekata so pateka: " + dadotekaPremesti + " USPESHNO E PREMESTENA vo: " + dadotekaPremesti2;

                    }
                    catch (Exception e)
                    {
                        vrati = "Neuspeshno premestana dadoteka !!! ";
                    }

                }
            }

            return vrati;
        }

       static string MoveDir(int brojZaPremestuvanje, SortedDictionary<int, string> najdi, string particijaPremesti, string folderPremesti, string particijaPremesti2, string folderPremesti2)
        {
            string vrati = "";
            bool nepostojTakovBroj = true;
            foreach (KeyValuePair<int, string> n in najdi)
            {
                if (n.Key == brojZaPremestuvanje)
                {
                    nepostojTakovBroj = false;
                 
                    if(folderPremesti == "")
                    {
                        string imeFolder = n.Value;
                        string dirPremesti = particijaPremesti + ":\\" + imeFolder;
                        string dirPremesti2 = particijaPremesti2 + ":\\" + folderPremesti2 + "\\" + imeFolder;

                        MoveAllFromDir(dirPremesti, dirPremesti2);
                        /*  try
                          {

                              if (Directory.Exists(dirPremesti))
                              {

                                   Directory.CreateDirectory(dirPremesti2);
                                  string[] fileEntries = Directory.GetFiles(dirPremesti);

                                  foreach (string fileName in fileEntries)
                                  {
                                     string  imeNaFajl = Path.GetFileName(fileName);
                                     string dadotekaPremesti2 = particijaPremesti2 + ":\\" + folderPremesti2 + "\\" + imeFolder+"\\"+ imeNaFajl;

                                      File.Move(fileName, dadotekaPremesti2);

                                  }
                                   Directory.Delete(dirPremesti);


                              }
                              else
                              {
                                  Console.WriteLine("Direktoriumot ne postoi !!!");
                              }

                          }
                          catch (Exception e)
                          {
                              vrati = "Neuspeshno premestana dadoteka !!! ";
                          }*/
                    }
                    else
                    {
                        string imeFolder = n.Value;
                        string dirPremesti = particijaPremesti + ":\\" + folderPremesti+"\\"+ imeFolder;
                        string dirPremesti2 = particijaPremesti2 + ":\\" + folderPremesti2 + "\\" + imeFolder;

                        MoveAllFromDir(dirPremesti, dirPremesti2);
                     /*   try
                        {

                            if (Directory.Exists(dirPremesti))
                            {

                                Directory.CreateDirectory(dirPremesti2);
                                string[] fileEntries = Directory.GetFiles(dirPremesti);

                                foreach (string fileName in fileEntries)
                                {
                                    string imeNaFajl = Path.GetFileName(fileName);
                                    string dadotekaPremesti2 = particijaPremesti2 + ":\\" + folderPremesti2 + "\\" + imeFolder + "\\" + imeNaFajl;

                                    File.Move(fileName, dadotekaPremesti2);

                                }
                                Directory.Delete(dirPremesti);


                            }
                            else
                            {
                                Console.WriteLine("Direktoriumot ne postoi !!!");
                            }

                        }
                        catch (Exception e)
                        {
                            vrati = "Neuspeshno premestana dadoteka !!! " + e;
                        }*/
                    }

                }
            }
            if (nepostojTakovBroj == true)
            {
                vrati = "Ne postoi dadoteka so reden broj " + brojZaPremestuvanje;
            }
            return vrati;
        }

        struct Duplikati
        {
            public List<string> duplikati;
            public SortedDictionary<string, string> duplicates;
            public List<string> orginali;
        }

        static List<Duplikati> PovekjeListi(SortedDictionary<int, string> najdi)
        {

            var duplikati = new List<string>();
            var duplicates = new SortedDictionary<string, string>();
            var orginali = new List<string>();

            foreach (KeyValuePair<int, string> n in najdi)
            {
                string ime = "";
                string celoIme = n.Value;
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
            Duplikati dup = new Duplikati
            {
                duplikati = duplikati,
                duplicates = duplicates,
                orginali = orginali
            };
            //Duplikati dup;
            //dup= new Duplikati();
            //dup.duplikati = duplikati; dup.duplicates = duplicates; dup.orginali = orginali;

            List<Duplikati> structDuplikati = new List<Duplikati>();
            structDuplikati.Add(dup);

            return structDuplikati;
        }

        static void VidiDuplikati(List<Duplikati> vratiDuplikati)
        {
            foreach (var i in vratiDuplikati)
            {
                foreach (string o in i.orginali)
                {
                    string[] orginal = o.Split('.');
                    foreach (KeyValuePair<string, string> d in i.duplicates)
                    {
                        string[] extension = d.Key.Split('.');
                        if (d.Value == orginal[0] && extension[1] == orginal[1])
                        {

                            Console.WriteLine("Orginal dadoteka e : " + o);
                            break;
                        }
                    }

                }
                if (i.duplikati.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Duplikati se :");
                    int broj = 1;
                    foreach (string d in i.duplikati)
                    {
                        Console.WriteLine("Reden Broj: " + broj + "  Duplikat: " + d);
                        //  Console.WriteLine(broj+" "+d);
                        broj++;
                    }
                }
                else
                {
                    Console.WriteLine("Ne postojat duplikati !!!");
                }

            }
        }
        static SortedDictionary<int, string> VratiListaDuplikati(List<Duplikati> vratiDuplikati)
        {
            SortedDictionary<int, string> listaDuplikati = new SortedDictionary<int, string>();
            foreach (var i in vratiDuplikati)
            {
                int broj = 1;
                foreach (string d in i.duplikati)
                {
                    listaDuplikati.Add(broj, d);
                    broj++;
                }
            }
            return listaDuplikati;
        }

        //1 zadaca
        static void FindFileInDirectorium()
        {
            Console.WriteLine("1. zadaca -> Najdete dadoteka vo daden direktorium.");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolzi = Console.ReadLine();
            if (prodolzi == "Da" || prodolzi == "da" || prodolzi == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particija = Console.ReadLine();
                Console.WriteLine("Vnesete Folder ili cela pateka na folderi");
                string folder = Console.ReadLine();
                Console.WriteLine("Vnesete Ime na Fajlot");
                string imeNaFajl = Console.ReadLine();
                string najdiDadoteka = NajdiDadoteka(particija, folder, imeNaFajl);
                Console.WriteLine(najdiDadoteka);
            }
        }

        //2 zadaca
        static void DeleteFileUserChoose()
        {
            Console.WriteLine();
            Console.WriteLine("2.  zadaca -> Izbrisete dadoteka po zelba na korisnikot ");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolziIzbrisi = Console.ReadLine();

            if (prodolziIzbrisi == "Da" || prodolziIzbrisi == "da" || prodolziIzbrisi == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particijaIzbrisi = Console.ReadLine();
                Console.WriteLine("Vnesete Folder ili cela pateka na folderi");
                string folderIzbrisi = Console.ReadLine();

                var najdi = new SortedDictionary<int, string>();
                najdi = ListajDadotekaImeNaFajlPoRedenBroj(particijaIzbrisi, folderIzbrisi);
                bool ifExist = false;
                foreach (KeyValuePair<int, string> n in najdi)
                {
                    if (n.Key == 0 && n.Value == "NEPOSTOJ")
                    {
                        ifExist = true;
                        break;
                    }
                    Console.WriteLine("Reden br: " + n.Key + "    Ime  na dadoteka: " + n.Value);
                }
                if (ifExist == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Dokolku e sakate samo eden duplikat da izbrisete vnesete go redniot broj, no dokolku sakate povekje duplikati istovremeno vnesete reden broj, odma pomegju nego vnesete i prava crta |");
                    string brojIliBrojki = Console.ReadLine();
                    string[] splitBroj = brojIliBrojki.Split('|');
                    foreach (string broj in splitBroj)
                    {
                        if (Int32.TryParse(broj, out int redenBrojZaBrisenje))
                        {
                            string deleteFile = DeleteFile(redenBrojZaBrisenje, najdi, particijaIzbrisi, folderIzbrisi);
                            Console.WriteLine(deleteFile);
                        }
                        else
                        {
                            Console.WriteLine("DOZVOLENI SE SAMO BROJKI !!!");
                        }
                    }
                }

            }
        }

        //3 zadaca
        static void MoveFileInAnotherDir()
        {
            Console.WriteLine();
            Console.WriteLine("3.  zadaca -> Premestete dadoteka od edna na druga lokacija po zelba  na korisnikot");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolziSoPremesti = Console.ReadLine();
            if (prodolziSoPremesti == "Da" || prodolziSoPremesti == "da" || prodolziSoPremesti == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particijaPremesti = Console.ReadLine();
                Console.WriteLine("Vnesete Folder ili cela pateka na folderi");
                string folderPremesti = Console.ReadLine();

                var najdi = new SortedDictionary<int, string>();
                najdi = ListajDadotekaImeNaFajlPoRedenBroj(particijaPremesti, folderPremesti);
                bool ifExist = false;
                foreach (KeyValuePair<int, string> n in najdi)
                {
                    if (n.Key == 0 && n.Value == "NEPOSTOJ")
                    {
                        ifExist = true;
                        break;
                    }
                    Console.WriteLine("Reden br: " + n.Key + "    Ime na dadoteka: " + n.Value);
                }

                if (ifExist == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Vnesete go redniot broj za da ja premestite dadotekata");
                    int brojZaPremestuvanje = int.Parse(Console.ReadLine());
                    string imeNaFajl = ImeNaFajlPodRedenBroj(brojZaPremestuvanje, najdi);
                    if (imeNaFajl != "-1")
                    {
                        Console.WriteLine("Vnesete Particija vo koja sakate da ja premestite dadotekata");
                        string particijaPremesti2 = Console.ReadLine();
                        Console.WriteLine("Vnesete Folder vo koja sakate da ja premestite dadotekata");
                        string folderPremesti2 = Console.ReadLine();

                        string isMoved = MoveFile(brojZaPremestuvanje, najdi, particijaPremesti, folderPremesti, particijaPremesti2, folderPremesti2);
                        Console.WriteLine(isMoved);
                    }
                    else
                    {
                        Console.WriteLine("Ne postoi dadoteka so reden broj " + brojZaPremestuvanje);
                    }

                }
            }
        }


        //4 zadaca
        static void FindDuplicatAndDelete()
        {
            Console.WriteLine();
            Console.WriteLine("4. zadaca-> Najdete duplikati dadoteki vo eden ili povelke direktoriumi, izbrisete gi duplikatite po zelba na korisnikot");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolziSoDuplikati = Console.ReadLine();
            if (prodolziSoDuplikati == "Da" || prodolziSoDuplikati == "da" || prodolziSoDuplikati == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particijaDuplikat = Console.ReadLine();
                string daliPostoj = DaliParticijataPostoi(particijaDuplikat);
                if (daliPostoj == "-1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Particijata ne postoi !!!");//tolku kraj zavrshavsh
                }
                else
                {
                        Console.WriteLine();
                        Console.WriteLine("Vnesete gi iminjata na direktoriumi (dokolku ima pod direktoriumi vnesete ja cela pateka) koj sakate da proverite dali sodrzat duplikati, NO ZADOLZITELNO SAMO POMEGJU NIV DA IMA | PRAVA LINIJA. Taka ke se smetat za razlicni direktoriumi.");
                        Console.WriteLine();

                        string folderiOdKonzola = Console.ReadLine();
                        string[] split = folderiOdKonzola.Split('|');

                        foreach (string s in split)
                        {
                            string daliPostojFolderot = DaliFolderotPostoi(particijaDuplikat, s);
                            if (daliPostojFolderot == "-1")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Direktoriumot " + s + " ne postoi !!!");//tolku kraj zavrshavsh
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Direktorium: " + s);

                                // var najdi = new SortedDictionary<int, string>();
                                var najdi = ListFileNameWithNumber(daliPostojFolderot);
                                List<Duplikati> vratiDuplikati = PovekjeListi(najdi);

                                VidiDuplikati(vratiDuplikati);
                                var listaDuplikati = VratiListaDuplikati(vratiDuplikati);
                                if (listaDuplikati.Count > 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Dokolku e sakate samo eden duplikat da izbrisete vnesete go redniot broj, no dokolku sakate povekje duplikati istovremeno vnesete reden broj, odma pomegju nego vnesete i prava crta |");

                                    string brojIliBrojki = Console.ReadLine();

                                    string[] splitBroj = brojIliBrojki.Split('|');
                                    foreach (string broj in splitBroj)
                                    {
                                        if (Int32.TryParse(broj, out int redenBrojZaBrisenje))
                                        {
                                            string deleteFile = DeleteFile(redenBrojZaBrisenje, listaDuplikati, particijaDuplikat, s);
                                            Console.WriteLine(deleteFile);
                                        }
                                        else
                                        {
                                            Console.WriteLine("DOZVOLENI SE SAMO BROJKI !!!");
                                        }
                                    }

                                }


                            }
                        }
                }

            }
        }

        //5. Преместете директориум од една на друга локација.
        //5 zadaca
        static void MoveDirectoryInAnotherLocation()
        {
            Console.WriteLine();
            Console.WriteLine("5. zadaca -> Premestete direktorium od edna na druga lokacija");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolzi = Console.ReadLine();
            if (prodolzi == "Da" || prodolzi == "da" || prodolzi == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particija = Console.ReadLine();
                string daliPostoj = DaliParticijataPostoi(particija);
                if (daliPostoj == "-1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Particijata ne postoi !!!");//tolku kraj zavrshavsh
                }
                else
                {
                    Console.WriteLine("Dali sakate da premestite direktorium SAMO od "+ particija+" particija ??? Da/Ne");
                    string sakateOdParticija = Console.ReadLine();
                    if (sakateOdParticija == "Da" || sakateOdParticija == "da" || sakateOdParticija == "DA")
                    {
                        string prazenFolder = "";
                        var najdi = ListDirectory(particija, prazenFolder);
                        foreach(KeyValuePair<int,string> n in najdi)
                        {
                            Console.WriteLine("Reden Broj: " + n.Key + "  folder: " + n.Value);
                        }
                        string vnesiBroj=Console.ReadLine();
                        if (Int32.TryParse(vnesiBroj, out int broj))
                        {
                            Console.WriteLine("Vnesete Particija vo koja sakate da go premestite directoriumot");
                            string particijaPremesti2 = Console.ReadLine();
                            Console.WriteLine("Dolku sakate da go premestite drug direktorium ili drugi direktoriumi vnesete ja cela pateka. Dokolku nejkite pritisnete ENTER");
                            string folderPremesti2 = Console.ReadLine();

                            string moveDir = MoveDir(broj, najdi, particija, prazenFolder, particijaPremesti2, folderPremesti2);
                            Console.WriteLine(moveDir);
                        }
                        else
                        {
                            Console.WriteLine("DOZVOLENI SE SAMO BROJKI !!!");
                        }




                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Vnesete gi iminjata na direktoriumi (dokolku ima pod direktoriumi vnesete ja cela pateka) koj sakate da proverite dali sodrzat duplikati, NO ZADOLZITELNO SAMO POMEGJU NIV DA IMA | PRAVA LINIJA. Taka ke se smetat za razlicni direktoriumi.");
                        Console.WriteLine();

                        string folderiOdKonzola = Console.ReadLine();
                        string[] split = folderiOdKonzola.Split('|');

                        foreach (string s in split)
                        {
                            string daliPostojFolderot = DaliFolderotPostoi(particija, s);
                            if (daliPostojFolderot == "-1")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Direktoriumot " + s + " ne postoi !!!");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Direktorium: " + s);

                                var najdi = ListDirectory(particija, s);
                                foreach (KeyValuePair<int, string> n in najdi)
                                {
                                    Console.WriteLine("Reden Broj: " + n.Key + "  folder: " + n.Value);
                                }
                                string vnesiBroj = Console.ReadLine();
                                if (Int32.TryParse(vnesiBroj, out int broj))
                                {
                                    Console.WriteLine("Vnesete Particija vo koja sakate da go premestite directoriumot");
                                    string particijaPremesti2 = Console.ReadLine();
                                    Console.WriteLine("Dolku sakate da go premestite drug direktorium ili drugi direktoriumi vnesete ja cela pateka. Dokolku nejkite pritisnete ENTER");
                                    string folderPremesti2 = Console.ReadLine();

                                    string moveDir = MoveDir(broj, najdi, particija, s, particijaPremesti2, folderPremesti2);
                                    Console.WriteLine(moveDir);
                                }
                                else
                                {
                                    Console.WriteLine("DOZVOLENI SE SAMO BROJKI !!!");
                                }

                            }
                        }
                    }

                   
                }
            }
        }

        //6. Најди ги сите датотеки со одредена екстензија во еден или повеќе директориуми.
        //6 zadaca
        static void FindAllFilesWithExtension()
        {
            Console.WriteLine();
            Console.WriteLine("6. zadaca -> Najdi gi site dadoteki so odredena ekstenzija vo eden ili povekje direktoriumu");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolzi = Console.ReadLine();
            if (prodolzi == "Da" || prodolzi == "da" || prodolzi == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particija = Console.ReadLine();
                string daliPostoj = DaliParticijataPostoi(particija);
                if (daliPostoj == "-1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Particijata ne postoi !!!");//tolku kraj zavrshavsh
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Vnesete gi iminjata na direktoriumi (dokolku ima pod direktoriumi vnesete ja cela pateka) koj sakate da proverite dali sodrzat duplikati, NO ZADOLZITELNO SAMO POMEGJU NIV DA IMA | PRAVA LINIJA. Taka ke se smetat za razlicni direktoriumi.");
                    Console.WriteLine();

                    string folderiOdKonzola = Console.ReadLine();
                    string[] split = folderiOdKonzola.Split('|');

                    foreach (string s in split)
                    {
                        string daliPostojFolderot = DaliFolderotPostoi(particija, s);
                        if (daliPostojFolderot == "-1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Direktoriumot " + s + " ne postoi !!!");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Direktorium: " + s);
                            Console.WriteLine("Vnesete odredena ekstenzija");
                            string ekstenzijaBaraj= Console.ReadLine();
                            var najdi = ListFileNameWithNumber(daliPostojFolderot);

                            foreach (KeyValuePair<int, string> n in najdi)
                            {
                               // Console.WriteLine("Reden Broj: " + n.Key + "  dadoteka : " + n.Value);
                                string[] ekstenzija = n.Value.Split('.');
                                foreach(string ext in ekstenzija)
                                {
                                    if(ext == ekstenzijaBaraj)
                                    {
                                        Console.WriteLine(n.Value);
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        //7. Пребарување на датотеки со одредена големина
        //7 zadaca
        static void SearchFileWithSize()
        {
            Console.WriteLine();
            Console.WriteLine("7. zadaca -> Prebaruvanje na dadoteka so odredena golemin");
            Console.WriteLine("Dali sakate da vlezite vo zadacata ? Da/Ne");
            string prodolzi = Console.ReadLine();
            if (prodolzi == "Da" || prodolzi == "da" || prodolzi == "DA")
            {
                Console.WriteLine("Vnesete Particija");
                string particija = Console.ReadLine();
                string daliPostoj = DaliParticijataPostoi(particija);
                if (daliPostoj == "-1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Particijata ne postoi !!!");//tolku kraj zavrshavsh
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Vnesete gi iminjata na direktoriumi (dokolku ima pod direktoriumi vnesete ja cela pateka) koj sakate da proverite dali sodrzat duplikati, NO ZADOLZITELNO SAMO POMEGJU NIV DA IMA | PRAVA LINIJA. Taka ke se smetat za razlicni direktoriumi.");
                    Console.WriteLine();

                    string folderiOdKonzola = Console.ReadLine();
                    string[] split = folderiOdKonzola.Split('|');

                    foreach (string s in split)
                    {
                        string daliPostojFolderot = DaliFolderotPostoi(particija, s);
                        if (daliPostojFolderot == "-1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Direktoriumot " + s + " ne postoi !!!");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Direktorium: " + s);
                            Console.WriteLine();
                            Console.WriteLine("Golemina na dadotekata se prikazuva vo bytes");
                            Console.WriteLine("Dali sakate da se prikazat site fajlovi so odredena golemina ??? Da/Ne");
                            string daliProdolzi= Console.ReadLine();
                            if(daliProdolzi == "Da" || daliProdolzi == "da" || daliProdolzi == "DA")
                            {
                                string[] fileEntries = Directory.GetFiles(daliPostojFolderot);
                                for (int i = 0; i < fileEntries.Length; i++)
                                {
                                    long length = new System.IO.FileInfo(fileEntries[i]).Length;
                                    Console.WriteLine("Ime na fajlot " + fileEntries[i] + "      golemina: " + length + " bytes");
                                }
                            }
                            else
                            {
                                Console.WriteLine("So vnesuvanje na odredena golemina ke s prikazat site fajlovi so pomala i golemina do taja sto ke ja vnesite");
                                Console.WriteLine("Vnesete odredena golemina vo bytes");
                                string vnesiGolemina= Console.ReadLine();

                                if (Int32.TryParse(vnesiGolemina, out int golemina))
                                {
                                    string[] fileEntries = Directory.GetFiles(daliPostojFolderot);
                                    for (int i = 0; i < fileEntries.Length; i++)
                                    {
                                        
                                        long length = new System.IO.FileInfo(fileEntries[i]).Length;
                                        if(golemina >= length)
                                        {
                                            Console.WriteLine("Ime na fajlot " + fileEntries[i] + "      golemina: " + length + " bytes");
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("DOZVOLENI SE SAMO BROJKI !!!");
                                }

                            }
                           
                          
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            //listanje datoteki po ime so ekstenzija
            //1 zadaca
            FindFileInDirectorium();

            //Brisenje dadoteka po zelba na korisnikot
            //2 zadaca
            DeleteFileUserChoose();

            // Premestete dadoteka od edna na druga lokacija po zelba  na korisnikot
            // 3 zadaca
            MoveFileInAnotherDir();

            // Najdete duplikati dadoteki vo eden ili povelke direktoriumi, izbrisete gi duplikatite po zelba na korisnikot
            // 4 zadaca
            FindDuplicatAndDelete();

            //MoveDirectory gi premestuva samo fajlojte od edna na druga lokacija
            //5. Преместете директориум од една на друга локација.
            //5 zadaca
            MoveDirectoryInAnotherLocation();

            //6. Најди ги сите датотеки со одредена екстензија во еден или повеќе директориуми.
            //6 zadaca
            FindAllFilesWithExtension();

            //7. Пребарување на датотеки со одредена големина
            //7 zadaca
            SearchFileWithSize();



        }
    }
}
