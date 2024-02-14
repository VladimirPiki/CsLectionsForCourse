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

        private void InitializeTreeView()
        {
            string targetDirectory = @"C:\temp\Z60. RabotaSoDatotekiWindowsForms"; // Replace with your directory path
            DirectoryInfo rootDirectory = new DirectoryInfo(targetDirectory);

            TreeNode rootNode = new TreeNode(rootDirectory.Name);
            PopulateTreeView(rootNode, rootDirectory);
            treeView.Nodes.Add(rootNode);
        }

        private void PopulateTreeView(TreeNode parentNode, DirectoryInfo directory)
        {
            // Add files in the current directory
            foreach (var file in directory.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name);
                parentNode.Nodes.Add(fileNode);
            }

            // Recursively add subdirectories and their files
            foreach (var subDirectory in directory.GetDirectories())
            {
                TreeNode childNode = new TreeNode(subDirectory.Name);
                parentNode.Nodes.Add(childNode);
                PopulateTreeView(childNode, subDirectory);
            }
        }


        private void NajdiDadotekaView(string selekt)
        {
            string targetDirectory = @"C:\temp\"+selekt; // Replace with your directory path
            string imeNaFajl = tBNajdiDadoteka.Text;
            DirectoryInfo rootDirectory = new DirectoryInfo(targetDirectory);

            TreeNode rootNode = new TreeNode(rootDirectory.Name);
            NajdiDadotekaTreeView(rootNode, rootDirectory,imeNaFajl);
          //  treeView.Nodes.Add(rootNode);
        }
        private void NajdiDadotekaTreeView(TreeNode parentNode, DirectoryInfo directory,string imeNaFajl)
        {
            foreach (var file in directory.GetFiles())
            {
              //  MessageBox.Show(file.Name);
                TreeNode fileNode = new TreeNode(file.Name);
                string ime = Path.GetFileNameWithoutExtension(fileNode.Text);
                if (imeNaFajl == ime)
                {
                    MessageBox.Show(file.Name);
                }
            }

            // Recursively add subdirectories and their files
            foreach (var subDirectory in directory.GetDirectories())
            {
                TreeNode childNode = new TreeNode(subDirectory.Name);
                NajdiDadotekaTreeView(childNode, subDirectory,imeNaFajl);
            }
        }

        private void PrikaziTreeView(string sDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sDir);
            treeView.Nodes.Add(directoryInfo.Name);
            RakTreeViewZapisiDir(sDir);
            RekTreeViewDir(sDir);


        }
        private void RakTreeViewZapisiDir(string sDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sDir);

            if (directoryInfo.Exists)
            {
                try
                {

                    DirectoryInfo[] directories = directoryInfo.GetDirectories();
                    bool prvDirektorium = true;
                    if (prvDirektorium == true)
                    {
                        foreach (FileInfo file in directoryInfo.GetFiles())
                        {
                            if (file.Exists)
                            {
                                TreeNode nodes = treeView.Nodes[0].Nodes.Add(file.Name);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void RekTreeViewDir(string sDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sDir);

            if (directoryInfo.Exists)
            {
                try
                {
 
                    DirectoryInfo[] directories = directoryInfo.GetDirectories();
     


                    if (directories.Length > 0)
                    {
                        foreach (DirectoryInfo directory in directories)
                        {
                           // MessageBox.Show(directory.FullName);
                            TreeNode node = treeView.Nodes[0].Nodes.Add(directory.Name);
                            node.ImageIndex = node.SelectedImageIndex = 0;
                            foreach (FileInfo file in directory.GetFiles())
                            {
                                if (file.Exists)
                                {
                                    TreeNode nodes = treeView.Nodes[0].Nodes[node.Index].Nodes.Add(file.Name);
                                }
                            }
                            RekTreeViewDir(directory.FullName);
                        }
  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Rek(string sDir)
        {

            bool prvDirektorium = false;
            if (prvDirektorium == false)
            {

                foreach (string f in Directory.GetFiles(sDir))
                {
                    //Console.WriteLine(f);
                    MessageBox.Show(f);
                }
            }

            foreach (string d in Directory.GetDirectories(sDir))
            {
                foreach (string f in Directory.GetFiles(d))
                {
                    // Console.WriteLine(f);
                }
                Rek(d);
            }
        }

        private void Drvo(string sDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sDir);
            TreeNode patekaNode = new TreeNode(directoryInfo.Name);
            treeView.Nodes.Add(directoryInfo.Name);
            Drvo1(sDir);
        }

        private void Drvo1(string sDir, TreeNode patekaNode)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sDir);
            if (directoryInfo.Exists)
            {
                try
                {
                    DirectoryInfo[] directories = directoryInfo.GetDirectories();

                    bool prvDirektorium = false;
                    if (prvDirektorium == false)
                    {

                        foreach (FileInfo file in directoryInfo.GetFiles())
                        {
                            if (file.Exists)
                            {
                                TreeNode fileNode = new TreeNode(file.Name);
                                patekNode.Nodes.Add(fileNode);
                            }
                        }
                    }

                    foreach (DirectoryInfo directory in directories)
                    {
                        TreeNode node = treeView.Nodes[0].Nodes.Add(directory.Name);
                        node.ImageIndex = node.SelectedImageIndex = 0;
                        foreach (FileInfo file in directory.GetFiles())
                        {
                            if (file.Exists)
                            {
                                TreeNode nodes = treeView.Nodes[0].Nodes[node.Index].Nodes.Add(file.Name);
                            }
                        }
                      //  MessageBox.Show()
                        Drvo1(directory.FullName);
                    }
                }
                catch (System.Exception excpt)
                {
                    Console.WriteLine(excpt.Message);
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string sDir = @"C:\temp\Z60. RabotaSoDatotekiWindowsForms";
            // RekurzijaTreeView(sDir);
            //   Rek1(sDir);
            // InitializeTreeView();
            //PrikaziTreeView(sDir);
            Drvo(sDir);
        }

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
        public List<string> NajdiDadoteka(string pateka, string imeNaFajl)
        {
            List<string>odogoviri= new List<string>();  
            string path = "C:\\temp\\" + pateka;
            string particija = "C";
            string folder = "temp\\"+pateka;
            string vrati = "";
            bool postoi = false;
            var rekurzija = RekurzijaList(particija + ":\\" + folder);
            foreach (var r in rekurzija)
            {

                string ime = Path.GetFileNameWithoutExtension(r);
                if (imeNaFajl == ime)
                {
                   vrati="Fajlot sto go barate:  " + Path.GetFileName(r);
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

        private void btnPocni_Click(object sender, EventArgs e)
        {

            if (treeView.SelectedNode != null)
            {
                try
                {
               
                    string sDir = @"C:\temp\Z60. RabotaSoDatotekiWindowsForms";
                    var selectedNode = treeView.SelectedNode;
                    var folderPath = selectedNode.FullPath;
                   // var reshenie = NajdiDadoteka(selectedNode.FullPath, tBNajdiDadoteka.Text);
                 //   MessageBox.Show(string.Join(Environment.NewLine, reshenie));
                 /*   foreach (var r in reshenie) {
                        MessageBox.Show(r);
                    }
*/
                   NajdiDadotekaView(folderPath);

                }
                catch (System.Exception excpt) {
                    MessageBox.Show("Imate problem so najdi dadoteka."+ excpt);
                }

            }
        }
 
    }
}
