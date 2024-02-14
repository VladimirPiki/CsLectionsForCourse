using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z52.RabotaSoDatoteki
{
    /* 
 Datoteki
• Најдете датотека во даден директориум.
• Избришете даототека по желба на корисникот.
• Преместете датотека од една на друга локација по желба на корисникот.
• Пребарување на датотеки со одредена големина*/

    internal class Dadoteki
    {
        public List<string> RekurzijaList(string sDir)
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
                    RekurzijaList(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return list;
        }
        public string NajdiDadoteka(string particija, string folder, string imeNaFajl)
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
                var rekurzija = RekurzijaList(particija + ":\\" + folder);
                foreach (var r in rekurzija)
                {

                    string ime = Path.GetFileNameWithoutExtension(r);
                    if (imeNaFajl == ime)
                    {
                        Console.WriteLine("Fajlot sto go barate:  " + Path.GetFileName(r));
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

        public string IzbriseteDadotekaPoZelbaNaKorisnikot(string particija, string folder, string imeNaFajl)
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
                //   Console.WriteLine(particija + ":\\" + folder);
                foreach (string fileName in fileEntries)
                {
                    string ime = Path.GetFileName(fileName);
                    if (imeNaFajl == ime)
                    {
                        string dadotekaIzbrisi = particija + ":\\" + folder + "\\" + imeNaFajl;
                        File.Delete(dadotekaIzbrisi);
                        vrati = "Dadotekata e USPESHNO IZBRISANA !!!";
                       // vrati = "Fajlot sto go barate:  " + Path.GetFileName(fileName);
                        postoi = true;
                    }

                }
                if (postoi == false)
                {
                    vrati = "Dadotekata sto probvate da ja izbriste ne postoi !!!";
                }
            }
            return vrati;
        }

        public string PremestiDadotekaOdEdnaVoDrugaLokacijaPoZelbaNaKorisnikot(string particija, string folder, string imeNaFajl, string particijaPremesti2, string folderPremesti2)
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
                //   Console.WriteLine(particija + ":\\" + folder);
                foreach (string fileName in fileEntries)
                {
                    string ime = Path.GetFileName(fileName);
                    if (imeNaFajl == ime)
                    {
                        string dadotekaPremesti = particija + ":\\" + folder + "\\" + imeNaFajl;
                        string dadotekaPremesti2 = particijaPremesti2 + ":\\" + folderPremesti2 + "\\" + imeNaFajl;
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

                        postoi = true;
                    }

                }
                if (postoi == false)
                {
                    vrati = "Dadotekata sto probvate da ja premestite ne postoi !!!";
                }
            }
            return vrati;
        }

        public string PrebarajDadotekiSoOdredenaGolemina(string particija, string folder, string vnesiGolemina)
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

                if (Int32.TryParse(vnesiGolemina, out int golemina))
                {
                    var rekurzija = RekurzijaList(particija + ":\\" + folder);
                    for (int i = 0; i < rekurzija.Count; i++)
                    {

                        long length = new System.IO.FileInfo(rekurzija[i]).Length;
                        if (golemina == length)
                        {
                            Console.WriteLine("Ime na fajlot: " + Path.GetFileName(rekurzija[i]) + "      golemina: " + length + " bytes");
                        }

                    }

                }
                else
                {
                    vrati="DOZVOLENI SE SAMO BROJKI !!!";
                }
            }
            return vrati;
        }

    }
}
