using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Z60.RabotaSoDatotekiWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ime", 200);
            listView1.Columns.Add("pateka", 200);
            listView1.Columns.Add("tip", 150);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TreeViewInicijalizacija()
        {
            string lokacija = @"C:\temp\Z60. RabotaSoDatotekiWindowsForms";
            DirectoryInfo pateka = new DirectoryInfo(lokacija);

            TreeNode patekaNode = new TreeNode(pateka.Name);
            TreeViewRekurzija(patekaNode, pateka);
            treeView.Nodes.Add(patekaNode);
        }

        private void TreeViewRekurzija(TreeNode glavenNode, DirectoryInfo direktorium)
        {
            foreach (var dadoteka in direktorium.GetFiles())
            {
                TreeNode fileNode = new TreeNode(dadoteka.Name);
                glavenNode.Nodes.Add(fileNode);
            }

            foreach (var podDirektorium in direktorium.GetDirectories())
            {
                TreeNode podGlavenNode = new TreeNode(podDirektorium.Name);
                glavenNode.Nodes.Add(podGlavenNode);
                TreeViewRekurzija(podGlavenNode, podDirektorium);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TreeViewInicijalizacija();
        }

        public List<string> RekurzijaList(string sDir)
        {
            List<string> fajloj = new List<string>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    fajloj.Add(f);
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    List<string> podPapki = RekurzijaList(d);
                    foreach (string p in podPapki)
                    {
                        fajloj.Add(p);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return fajloj;
        }
        public List<string> NajdiDadoteka(string pateka, string imeNaFajl)
        {
            List<string> odogoviri = new List<string>();
            string pat = "C:\\temp\\" + pateka;
            string vrati = "";
            bool postoi = false;
            var rekurzija = RekurzijaList(pat);
            foreach (var r in rekurzija)
            {

                string ime = Path.GetFileNameWithoutExtension(r);
                if (imeNaFajl == ime)
                {
                    vrati = "Fajlot sto go barate:  " + Path.GetFileName(r);
                    odogoviri.Add(vrati);
                    vrati = "";
                    postoi = true;
                }

            }
            if (postoi == false)
            {
                vrati = "Dadotekata sto ja barate ne postoi !!!";
                odogoviri.Add(vrati);
                vrati = "";
            }
            return odogoviri;
        }

        public List<string> PrebarajDadotekiSoOdredenaGolemina(string pateka, string vnesiGolemina)
        {
            List<string> odogoviri = new List<string>();
            string pat = "C:\\temp\\" + pateka;
            string vrati = "";
            var rekurzija = RekurzijaList(pat);

            if (Int32.TryParse(vnesiGolemina, out int golemina))
            {

                for (int i = 0; i < rekurzija.Count; i++)
                {
                    long length = new System.IO.FileInfo(rekurzija[i]).Length;
                    if (golemina == length)
                    {
                        vrati = "Ime na fajlot: " + Path.GetFileName(rekurzija[i]) + "      golemina: " + length + " bytes";
                        odogoviri.Add(vrati);
                        vrati = "";
                    }
                }
            }
            else
            {
                vrati = "DOZVOLENI SE SAMO BROJKI !!!";
                odogoviri.Add(vrati);
            }
            return odogoviri;
        }
        public void NajdiDuplikati(string pateka)
        {
            try
            {
                List<string> duplikati = new List<string>();
                SortedDictionary<string, string> duplicates = new SortedDictionary<string, string>(); ;
                List<string> orginali = new List<string>();
                var rekurzija = RekurzijaList(pateka);
                foreach (var r in rekurzija)
                {
                    string ime = "";
                    string celoIme = r;
                    string[] result = celoIme.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                    if (result.Length > 1)
                    {
                        for (int i = 0; i < result.Length; i++)
                        {
                            ime = result[0];
                            //   MessageBox.Show(ime);
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



                foreach (var o in orginali)
                {
                    string[] arr = new string[3];
                    ListViewItem itm;

                    arr[0] = Path.GetFileName(o);
                    arr[1] = o;
                    arr[2] = "ORGINAL";

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                foreach (var i in duplikati)
                {
                    string[] arr = new string[3];
                    ListViewItem itm;

                    arr[0] = Path.GetFileName(i);
                    arr[1] = i;
                    arr[2] = "DUPLIKAT";
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }


            }
            catch (Exception e) { MessageBox.Show("Imate problem so pronaogjanje na duplikat dadoteki"); }
        }

        public void PremestiCelDirektorium(string sDir, string krajnaCel)
        {
            Directory.CreateDirectory(krajnaCel);

            try
            {
                bool prvDirektorium = false;
                if (prvDirektorium == false)
                {
                    foreach (string f in Directory.GetFiles(sDir))
                    {
                        string ime = Path.GetFileName(f);

                        File.Move(f, krajnaCel + "\\" + ime);
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    string imeFolder = Path.GetFileName(d);
                    Directory.CreateDirectory(krajnaCel + "\\" + imeFolder);
                    foreach (string f in Directory.GetFiles(d))
                    {
                        string ime = Path.GetFileName(f);
                        File.Move(f, krajnaCel + "\\" + imeFolder + "\\" + ime);
                    }
                    PremestiCelDirektorium(d, krajnaCel);
                }
                Directory.Delete(sDir);
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

        }

        public List<string> NajdiEkstenzija(string pateka, string ekstenzijaBaraj)
        {
            List<string> odogoviri = new List<string>();
            string pat = "C:\\temp\\" + pateka;
            string vrati = "";
            bool postoi = false;
            var rekurzija = RekurzijaList(pat);
            foreach (var r in rekurzija)
            {
                //    MessageBox.Show(r);
                string[] ekstenzija = r.Split('.');
                foreach (string ext in ekstenzija)
                {
                    if (ext == ekstenzijaBaraj)
                    {
                        vrati = "Fajlot sto go barate:  " + Path.GetFileName(r);
                        odogoviri.Add(vrati);
                        vrati = "";
                        postoi = true;
                    }
                }

            }
            if (postoi == false)
            {
                vrati = "Dadotekata sto ja barate ne postoi !!!";
                odogoviri.Add(vrati);
                vrati = "";
            }
            return odogoviri;
        }


        private void btnPocni_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbNajdiDadoteka.Checked == true)
                {
                    if (treeView.SelectedNode != null)
                    {
                        try
                        {
                            var selektiranaNode = treeView.SelectedNode;
                            var reshenie = NajdiDadoteka(selektiranaNode.FullPath, tBNajdiDadoteka.Text);
                            MessageBox.Show(string.Join(Environment.NewLine, reshenie));

                        }
                        catch (System.Exception excpt)
                        {
                            MessageBox.Show("Imate problem so najdi dadoteka." + excpt);
                        }

                    }
                }

                if (rbIzbrisi.Checked == true)
                {

                    if (treeView.SelectedNode != null)
                    {
                        try
                        {
                            var selektiranaNode = treeView.SelectedNode;
                            var patekaDir = selektiranaNode.FullPath;
                            try
                            {
                                string pateka = "C:\\temp\\" + patekaDir;
                                treeView.SelectedNode.Remove();
                                File.Delete(pateka);
                                MessageBox.Show("Uspeshno izbrisana dadoteka: " + selektiranaNode);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Neuspesno izbrisana dadoteka: " + ex);
                            }
                        }
                        catch (System.Exception excpt)
                        {
                            MessageBox.Show("Imate problem so izbrisete dadoteka." + excpt);
                        }

                    }
                }


                if (rbPremestiDadoteka.Checked == true)
                {

                    if (treeView.SelectedNode != null)
                    {
                        try
                        {
                            string dadotekaZaPremestuvanje = tbdadotekaZaPremestuvanje.Text;
                            if (dadotekaZaPremestuvanje != "")
                            {

                                var selektiranaNode = treeView.SelectedNode;
                                var patekaDir = selektiranaNode.FullPath;
                                string imeNaFajl = Path.GetFileName(dadotekaZaPremestuvanje);
                                string vrati = "";
                                try
                                {
                                    if (File.Exists("C:\\temp\\" + patekaDir + "\\" + imeNaFajl))
                                        File.Delete("C:\\temp\\" + patekaDir + "\\" + imeNaFajl);


                                    File.Move("C:\\temp\\" + dadotekaZaPremestuvanje, "C:\\temp\\" + patekaDir + "\\" + imeNaFajl);
                                    vrati = "Dadotekata so pateka: " + "C:\\temp\\" + dadotekaZaPremestuvanje + " USPESHNO E PREMESTENA vo: " + "C:\\temp\\" + patekaDir + "\\" + imeNaFajl;
                                    TreeNode node = new TreeNode(imeNaFajl);
                                    treeView.SelectedNode.Nodes.Add(node);
                                }
                                catch (Exception ex)
                                {
                                    vrati = "Neuspeshno premestana dadoteka !!! " + ex;
                                }
                                MessageBox.Show(vrati);

                            }
                            else
                            {
                                MessageBox.Show("Ve molam selektirajte dadoteka");
                            }

                        }
                        catch (System.Exception excpt)
                        {
                            MessageBox.Show("Imate problem so premestuvanje na dadotekata. " + excpt);
                        }

                    }
                }

                if (rbOdredenaGolemina.Checked == true)
                {

                    if (treeView.SelectedNode != null)
                    {
                        try
                        {
                            var selektiranaNode = treeView.SelectedNode;

                            var reshenie = PrebarajDadotekiSoOdredenaGolemina(selektiranaNode.FullPath, tbOdredenaGolemina.Text);
                            MessageBox.Show(string.Join(Environment.NewLine, reshenie));
                        }
                        catch (System.Exception excpt)
                        {
                            MessageBox.Show("Imate problem so Odredena Golemina." + excpt);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ve molam izberete dadoteka od treeview");
                    }
                }

                if (rbNajdeteDuplikati.Checked == true)
                {
                    try
                    {
                        List<string> listZaBrisenje = new List<string>();
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (listView1.Items[i].Selected)
                            {

                                if (File.Exists(listView1.Items[i].SubItems[1].Text))
                                {
                                    File.Delete(listView1.Items[i].SubItems[1].Text);
                                    listView1.Items[i].Remove();
                                }

                                //   MessageBox.Show(listView1.Items[i].SubItems[1].Text);

                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so Brisenjeto na duplikatite");
                    }
                }


                if (rbPremestiDir.Checked == true)
                {

                    if (treeView.SelectedNode != null)
                    {
                        try
                        {
                            string direktoriumZaPremestuvanje = tbZacuvajDirPateka.Text;
                            if (direktoriumZaPremestuvanje != "")
                            {

                                var selektiranaNode = treeView.SelectedNode;
                                var patekaDir = selektiranaNode.FullPath;
                                string imeNaDir = Path.GetFileName(direktoriumZaPremestuvanje);
                                if (Directory.Exists("C:\\temp\\" + patekaDir + "\\" + imeNaDir))
                                {
                                    MessageBox.Show("Direktoriumot so pateka: " + "C:\\temp\\" + patekaDir + "\\" + imeNaDir + " postoi na toa mesto");
                                }
                                else
                                {
                                    PremestiCelDirektorium("C:\\temp\\" + direktoriumZaPremestuvanje, "C:\\temp\\" + patekaDir + "\\" + imeNaDir);
                                    MessageBox.Show("USPESHNO PREMESTEN DIREKTORIUMOT " + "C:\\temp\\" + direktoriumZaPremestuvanje);

                                    DirectoryInfo ruta = new DirectoryInfo("C:\\temp\\" + patekaDir + "\\" + imeNaDir);
                                    TreeNode node = new TreeNode(imeNaDir);
                                    treeView.SelectedNode.Nodes.Add(node);
                                    TreeViewRekurzija(node, ruta);
                                }


                            }
                            else
                            {
                                MessageBox.Show("Ve molam selektirajte direktorium");
                            }

                        }
                        catch (System.Exception excpt)
                        {
                            MessageBox.Show("Imate problem so premestuvanje na direktorium. " + excpt);
                        }

                    }

                }



                if (rbNajdiEkstenzija.Checked == true)
                {
                    try
                    {
                        var selektiranaNode = treeView.SelectedNode;
                        var reshenie = NajdiEkstenzija(selektiranaNode.FullPath, tbEkstenzija.Text);
                        MessageBox.Show(string.Join(Environment.NewLine, reshenie));

                    }
                    catch (System.Exception excpt)
                    {
                        MessageBox.Show("Imate problem so najdi odredena ekstenzija." + excpt);
                    }
                }

            }
            catch (System.Exception excpt)
            {
                MessageBox.Show("Imate problem so check box." + excpt);
            }



            /// do tuka e startuvaj zadaca
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPremestiSave_Click(object sender, EventArgs e)
        {
            if (rbPremestiDadoteka.Checked == true)
            {

                if (treeView.SelectedNode != null)
                {
                    try
                    {
                        var selektiranaNode = treeView.SelectedNode;
                        var patekaDir = selektiranaNode.FullPath;
                        tbdadotekaZaPremestuvanje.Text = patekaDir;
                        treeView.SelectedNode.Remove();
                    }
                    catch (System.Exception excpt)
                    {
                        MessageBox.Show("Imate problem so premestuvanje na dadotekata. " + excpt);
                    }

                }
            }

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodadiDir_Click(object sender, EventArgs e)
        {

            if (rbNajdeteDuplikati.Checked == true)
            {

                if (treeView.SelectedNode != null)
                {
                    try
                    {
                        var selektiranaNode = treeView.SelectedNode;
                        var patekaDir = selektiranaNode.FullPath;
                        //lbDir.Items.Add(patekaDir); 
                        NajdiDuplikati("C:\\temp\\" + patekaDir);
                    }
                    catch (System.Exception excpt)
                    {
                        MessageBox.Show("Imate problem so odbiranjeto na direktoriumite. " + excpt);
                    }

                }
            }
        }

        private void btnZacuvajIzborDir_Click(object sender, EventArgs e)
        {
            if (rbPremestiDir.Checked == true)
            {

                if (treeView.SelectedNode != null)
                {
                    try
                    {
                        var selektiranaNode = treeView.SelectedNode;
                        var patekaDir = selektiranaNode.FullPath;
                        tbZacuvajDirPateka.Text = patekaDir;
                        treeView.SelectedNode.Remove();
                    }
                    catch (System.Exception excpt)
                    {
                        MessageBox.Show("Imate problem so premestuvanje na direktoriumot. " + excpt);
                    }

                }
            }

        }
    }
}
