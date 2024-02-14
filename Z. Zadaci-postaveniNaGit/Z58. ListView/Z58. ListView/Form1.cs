using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Z58.ListView
{
    /* Z58. ListView
• Од датотека прочитајте 10 личности. 
	• Додавање на личнсти од textBox
	• Додавање на личности од датотека
	• Бришење и додавање личност
	• Наоѓање највозрасна личност
	• Личност која има презиме составено од најмногу различни карактери
	• Личности од одреден број на години
	• Личности чии години припаѓаат на одреден интервал
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ime", 70);
            listView1.Columns.Add("prezime", 120);
            listView1.Columns.Add("godini", 50);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVnesi_Click(object sender, EventArgs e)//	• Додавање на личнсти од textBox
        {

            string[] arr = new string[3];
            ListViewItem itm;

            arr[0] = tbIme.Text;
            arr[1] = tbPrezime.Text;
            arr[2] = tbGodini.Text;

            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

        }

        private void btnVnesiFile_Click(object sender, EventArgs e)//	• Додавање на личности од датотека
        {
            try
            {
                string[] arr = new string[3];
                ListViewItem itm;

                string path = @"c:\temp\Z58.ListView.txt";

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null) // gi cita liniite
                    {
                        arr[0] = s; //prvata redica e ime
                        arr[1] = sr.ReadLine(); // prezime
                        arr[2] = sr.ReadLine();//godini

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ima problem so citanje na podatocite od datoteka");
            }
        }

        private void btnNajvozrasnaLicnost_Click(object sender, EventArgs e)//	• Наоѓање највозрасна личност
        {
            try
            {
                int maxGodini = 0;
                string najvozrasnaLicnost = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string ime = listView1.Items[i].SubItems[0].Text;
                    string prezime = listView1.Items[i].SubItems[1].Text;
                    string godini = listView1.Items[i].SubItems[2].Text;
                    int godina = 0;
                    bool isParsable = Int32.TryParse(godini, out godina);// baraj godini
                    if (isParsable)
                    {
                        if (godina > maxGodini)
                        {
                            maxGodini = godina;
                            najvozrasnaLicnost = ime + " " + prezime + " " + godini;
                        }
                    }
                }
                MessageBox.Show(najvozrasnaLicnost.ToString());
            }
            catch
            {
                MessageBox.Show("Ima problem so citanje nanajvozrasnata licnost");
            }

        }

        private void btnBrisiSelektiranaLic_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ima problem so citanje na podatocite od Selektirana licnost vo listvieww");
            }
        }

        private void btnIntervalGodini_Click(object sender, EventArgs e)//	• Личности чии години припаѓаат на одреден интервал
        {
            try
            {
                if (txtBoxOd.Text != "" && txtBoxDo.Text != "")
                {
                    int a;
                    int b;
                    bool prvoPole = Int32.TryParse(txtBoxOd.Text, out a);
                    bool vtoroPole = Int32.TryParse(txtBoxDo.Text, out b);
                    if (prvoPole == true && vtoroPole == true)
                    {
                        string licnost = "";
                        List<string> list = new List<string>();
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            string ime = listView1.Items[i].SubItems[0].Text;
                            string prezime = listView1.Items[i].SubItems[1].Text;
                            string godini = listView1.Items[i].SubItems[2].Text;
                            int godina = 0;
                            bool isParsable = Int32.TryParse(godini, out godina);// baraj godini
                            if (isParsable)
                            {
                                if (a <= godina && godina <= b)
                                {
                                    listView1.Items[i].Selected = true;
                                    listView1.Select();
                                    licnost = ime + " " + prezime + " " + godina;
                                    list.Add(licnost);
                                    licnost = "";
                                }
                            }


                        }
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Ne postoi takva licnost");
                        }
                        else
                        {
                            MessageBox.Show(string.Join(Environment.NewLine, list));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dozvoleni se samo brojki");
                    }
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete Broevi vo polinjata");
                }
            }
            catch { MessageBox.Show("Ima problem so citanje na podatocite od Intervalot na godini"); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOdredenBrojGodini_Click(object sender, EventArgs e)//	• Личности од одреден број на години
        {
            try
            {
                if (txtBoxOdredenBrGod.Text != "")
                {
                    int a;
                    bool prvoPole = Int32.TryParse(txtBoxOdredenBrGod.Text, out a);
                    if (prvoPole == true)
                    {
                        string licnost = "";
                        List<string> list = new List<string>();
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            string ime = listView1.Items[i].SubItems[0].Text;
                            string prezime = listView1.Items[i].SubItems[1].Text;
                            string godini = listView1.Items[i].SubItems[2].Text;
                            int godina = 0;
                            bool isParsable = Int32.TryParse(godini, out godina);// baraj godini
                            if (isParsable)
                            {
                                if (a == godina)
                                {
                                    listView1.Items[i].Selected = true;
                                    listView1.Select();
                                    licnost = ime + " " + prezime + " " + godina;
                                    list.Add(licnost);
                                    licnost = "";
                                }
                            }


                        }
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Ne postoi takva licnost");
                        }
                        else
                        {
                            MessageBox.Show(string.Join(Environment.NewLine, list));
                        }

                    }
                    else
                    {
                        MessageBox.Show("Dozvoleni se samo brojki");
                    }
                }
                else
                {
                    MessageBox.Show("Zadolzitelno vnesete Broevi vo polinjata");
                }
            }
            catch { MessageBox.Show("Ima problem so citanje na podatocite od odreden broj na godini"); }
        }

        private string RazlicniKarakteri(string prezime)
        {
            string unikati = "";
            for (int i = 0; i < prezime.Length; i++)
            {
                bool jaIma = false;

                for (int a = 0; a < unikati.Length; a++)
                {
                    if (unikati[a] == prezime[i])
                    {
                        jaIma = true;

                        break;
                    }

                }
                if (jaIma != true)
                {
                    unikati += prezime[i];
                }
            }
            return unikati;
        }
        private void btnPrezimeUnikati_Click(object sender, EventArgs e)//	• Личност која има презиме составено од најмногу различни карактери
        {
            try
            {
                string maxUnikati = "";
                string licnost = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string ime = listView1.Items[i].SubItems[0].Text;
                    string prezime = listView1.Items[i].SubItems[1].Text;
                    string godini = listView1.Items[i].SubItems[2].Text;
                    string razKarPrez = RazlicniKarakteri(prezime);
                    if (razKarPrez.Length > maxUnikati.Length)
                    {
                        maxUnikati = razKarPrez;
                        licnost = ime + " " + prezime + " " + godini;
                        listView1.Items[i].Selected = true;
                        listView1.Select();
                    }

                }
                if(licnost.Length == 0)
                {
                    MessageBox.Show("Ne postoi takva licnost");
                }
                else
                {
                    MessageBox.Show(licnost);
                }
         
            }
            catch { MessageBox.Show("Ima problem so citanje na podatocite na licnost koja ima najmnogu razlicni karakteri vo prezimeto"); }
        }

        private void btnZameni_Click(object sender, EventArgs e)//• Бришење и додавање личност
        {
            try
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = txtBzameniIme.Text;
                        arr[1] = txtBzameniPrezime.Text;
                        arr[2] = txtBzameniGodini.Text;

                        itm = new ListViewItem(arr);
                        listView1.Items.Insert(i,itm);
                        listView1.Items[i].Selected = true;
                        listView1.Select();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ima problem so selektriraj, brisi i dodadi nova");
            }

        }
    }
}
