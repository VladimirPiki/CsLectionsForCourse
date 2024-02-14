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

namespace Zadaca_treeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Dictionary<char, string> SiteLicnostiSoOdredenaBukvaOdIme(List<string> licnostIme)
        {
            var strings = new Dictionary<char, string>();
            for (int i = 0; i < licnostIme.Count; i++)
            {
                if (!strings.ContainsKey(licnostIme[i][0]))
                {
                    strings[licnostIme[i][0]] = licnostIme[i];

                }
                else if (strings.ContainsKey(licnostIme[i][0]))
                {
                    strings[licnostIme[i][0]] = strings[licnostIme[i][0]] + " " + licnostIme[i];
                }
            }
            return strings;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            List<string> iminja = new List<string>();
            iminja.Add("Vlade");
            iminja.Add("Simona");
            iminja.Add("Vladimir");
            iminja.Add("Vladic");
            iminja.Add("Antimon");
            iminja.Add("Darko");
            iminja.Add("Zorica");
            iminja.Add("Dejan");
            iminja.Add("Antonip");
            iminja.Add("Jovan");

            var ime = new Dictionary<char, string>();
            ime = SiteLicnostiSoOdredenaBukvaOdIme(iminja);
            foreach (KeyValuePair<char, string> i in ime)
            {
                treeView1.Nodes.Add(i.Key.ToString());
 
            }

            for (int i = 0; i < iminja.Count; i++)
            {
                for (int j = 0; j < treeView1.Nodes.Count; j++)
                {
                    string a = Convert.ToString(treeView1.Nodes[j]);
                    string b = Convert.ToString(a[a.Length - 1]);
                    if (Convert.ToString(iminja[i][0]) == b)
                    {
                        treeView1.Nodes[j].Nodes.Add(iminja[i]);
                        break;
                    }
                }
            }
            treeView1.EndUpdate();
        }
    }
}
