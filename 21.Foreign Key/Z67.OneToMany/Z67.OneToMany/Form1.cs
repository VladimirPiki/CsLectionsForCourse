using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z67.OneToMany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("EMB", 100);
            listView1.Columns.Add("Ime", 100);
            listView1.Columns.Add("Prezime", 100);
            listView1.Columns.Add("Mesto", 100);

            listView2.View = System.Windows.Forms.View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("ID", 100);
            listView2.Columns.Add("Klas", 100);
            listView2.Columns.Add("Smer", 100);
            listView2.Columns.Add("Period", 100);
            listView2.Columns.Add("Makedonski", 100);
            listView2.Columns.Add("UceniciEMB", 100);
        }

        public class SQLiteManager
        {
            private SQLiteConnection connection;

            public SQLiteManager(string connectionString)
            {
                connection = new SQLiteConnection(connectionString);
            }

            public void OpenConnection()
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
            }

            public void CloseConnection()
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            public void CreateTables()
            {
                OpenConnection();

                // Create Table 1
                using (SQLiteCommand cmd = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Ucenici (EMB INTEGER PRIMARY KEY, Ime TEXT, Prezime TEXT, Mesto TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create Table 2
                using (SQLiteCommand cmd = new SQLiteCommand(
                   "CREATE TABLE IF NOT EXISTS Ocenki (ID INTEGER PRIMARY KEY AUTOINCREMENT, Klas TEXT, Smer TEXT, Period TEXT, Makedonski INTEGER, UceniciEMB INT, FOREIGN KEY(UceniciEMB) REFERENCES Ucenici(ID))", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable1(long emb, string ime, string prezime, string mesto)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Ucenici (EMB, Ime,Prezime,Mesto) VALUES (@EMB, @Ime,@Prezime,@Mesto)", connection))
                {
                    cmd.Parameters.AddWithValue("@EMB", emb);
                    cmd.Parameters.AddWithValue("@Ime", ime);
                    cmd.Parameters.AddWithValue("@Prezime", prezime);
                    cmd.Parameters.AddWithValue("@Mesto", mesto);

                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable2(string klas, string smer, string period, int makedonski,long emb)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Ocenki (Klas, Smer,Period,Makedonski,UceniciEMB) VALUES (@Klas, @Smer,@Period, @Makedonski,@UceniciEMB)", connection))
                {
                    cmd.Parameters.AddWithValue("@Klas", klas);
                    cmd.Parameters.AddWithValue("@Smer", smer);
                    cmd.Parameters.AddWithValue("@Period", period);
                    cmd.Parameters.AddWithValue("@Makedonski", makedonski);
                    cmd.Parameters.AddWithValue("@UceniciEMB", emb);

                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public SQLiteDataReader SelectFrom(string imeNaTabela)
            {
                OpenConnection();
                SQLiteDataReader reader;
                using (SQLiteCommand cmd = new SQLiteCommand(
                    "SELECT * FROM " + imeNaTabela, connection))
                {
                    reader = cmd.ExecuteReader();
                }
                return reader;

            }


        }

        private void tbMaticen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=mydatabase.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                objSql.CreateTables();

                if (tbMaticen.Text != "" && tbIme.Text != "" && tbPrezime.Text != "" && tbMesto.Text != "" && cbKlas.Text != "" && cbSmer.Text != "" && cbPeriod.Text != "" && cbMakedonski.Text != "")
                {
                    if (tbMaticen.Text.Length == 13)
                    {
                        long maticen;
                        bool parsirajMaticen = Int64.TryParse(tbMaticen.Text, out maticen);

                        int makedonski;
                        bool parsirajMakedonski = Int32.TryParse(cbMakedonski.Text, out makedonski);

                        if (parsirajMaticen && parsirajMakedonski)
                        {
                            objSql.InsertDataIntoTable1(maticen, tbIme.Text, tbPrezime.Text, tbMesto.Text);
                            objSql.InsertDataIntoTable2(cbKlas.Text, cbSmer.Text, cbPeriod.Text, makedonski,maticen);

                            MessageBox.Show("Uspesno vnesivte vo bazata");
                        }
                        else
                        {
                            MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vnesete ispraven maticen broj od 13 cifri !!!");
                    }

                }
                else
                {
                    MessageBox.Show("Site polinja se zadolzitelni");
                }
            }
            catch { MessageBox.Show("Ne moze da vnesuvate ist edinecen maticen broj!"); }
        }

        private void btnSaveTabelaOcenka_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=mydatabase.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                objSql.CreateTables();

                if (tbMaticen.Text != "" && cbKlas.Text != "" && cbSmer.Text != "" && cbPeriod.Text != "" && cbMakedonski.Text != "")
                {
                    if (tbMaticen.Text.Length == 13)
                    {
                        long maticen;
                        bool parsirajMaticen = Int64.TryParse(tbMaticen.Text, out maticen);

                        int makedonski;
                        bool parsirajMakedonski = Int32.TryParse(cbMakedonski.Text, out makedonski);

                        if (parsirajMaticen && parsirajMakedonski)
                        {
                            objSql.InsertDataIntoTable2(cbKlas.Text, cbSmer.Text, cbPeriod.Text, makedonski, maticen);

                            MessageBox.Show("Uspesno vnesivte vo bazata");
                        }
                        else
                        {
                            MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vnesete ispraven maticen broj od 13 cifri !!!");
                    }

                }
                else
                {
                    MessageBox.Show("Site polinja se zadolzitelni");
                }
            }
            catch { MessageBox.Show("Ne moze da vnesuvate ist edinecen maticen broj!"); }
        }

        private void btnPrikaziTabeli_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=mydatabase.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);

                var sqlite_datareader = objSql.SelectFrom("Ucenici");
                listView1.Items.Clear();
                while (sqlite_datareader.Read())
                {

                    string[] arr = new string[4];
                    ListViewItem itm;

                    arr[0] = sqlite_datareader.GetInt64(0).ToString();
                    arr[1] = sqlite_datareader.GetValue(1).ToString();
                    arr[2] = sqlite_datareader.GetValue(2).ToString();
                    arr[3] = sqlite_datareader.GetValue(3).ToString();


                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                }

                var sqlite_datareaderOcenki = objSql.SelectFrom("Ocenki");
                listView2.Items.Clear();
                while (sqlite_datareaderOcenki.Read())
                {

                    string[] arr = new string[6];
                    ListViewItem itm;

                    arr[0] = sqlite_datareaderOcenki.GetInt32(0).ToString();
                    arr[1] = sqlite_datareaderOcenki.GetValue(1).ToString();
                    arr[2] = sqlite_datareaderOcenki.GetValue(2).ToString();
                    arr[3] = sqlite_datareaderOcenki.GetValue(3).ToString();
                    arr[4] = sqlite_datareaderOcenki.GetInt32(4).ToString();
                    arr[5] = sqlite_datareaderOcenki.GetInt64(5).ToString();


                    itm = new ListViewItem(arr);
                    listView2.Items.Add(itm);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ima problem so vcituvanje na podatocite od bazata: {ex.Message}");
            }
        }
    }
    
}
