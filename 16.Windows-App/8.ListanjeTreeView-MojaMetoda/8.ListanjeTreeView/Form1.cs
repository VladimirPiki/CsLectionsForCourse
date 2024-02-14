using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _8.ListanjeTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void test(DirectoryInfo directoryInfo)
        {
            DirectoryInfo[] directories = directoryInfo.GetDirectories();

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (file.Exists)
                {
                    TreeNode nodes = treeView.Nodes[0].Nodes.Add(file.Name);
                }
            }


            if (directories.Length > 0)
            {
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
                        test(directory);
                    }
  

                }
            }

        }
        private void btnPrikazi_Click(object sender, EventArgs e)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\temp\Z60. RabotaSoDatotekiWindowsForms");
            if (directoryInfo.Exists)
            {
                try
                {
                    treeView.Nodes.Add(directoryInfo.Name);
                    test(directoryInfo);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }
    }
}
