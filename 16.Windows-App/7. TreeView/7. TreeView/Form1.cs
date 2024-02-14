using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("A");
            treeView1.Nodes.Add("S");

            treeView1.Nodes[0].Nodes.Add("Atlas");
            treeView1.Nodes[0].Nodes.Add("Avion");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Geografski");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Makedonija");
            treeView1.Nodes[1].Nodes.Add("Skopje");
            treeView1.Nodes[1].Nodes.Add("Struga");
            string str = "Sarajevo";
            treeView1.Nodes[1].Nodes.Add(str);

            treeView1.Nodes.Add("K");

            treeView1.EndUpdate();




        }
    }
}
