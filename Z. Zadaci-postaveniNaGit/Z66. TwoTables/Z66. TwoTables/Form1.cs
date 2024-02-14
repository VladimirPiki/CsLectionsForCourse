using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Z66.TwoTables
{
    /*Z66. TwoTables интерфејс и внесување во две табели  Податоците нека се земаат од tb
    Prva tabela: EMB, ime, prezime, mesto
    Vtora tabela: klas, smer, period(prvo,vtor, treto, cetvrto), Makedonski*/

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
            listView2.Columns.Add("Klas", 100);
            listView2.Columns.Add("Smer", 100);
            listView2.Columns.Add("Period", 100);
            listView2.Columns.Add("Makedonski", 100);

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
                    "CREATE TABLE IF NOT EXISTS Ucenik (EMB INTEGER PRIMARY KEY, Ime TEXT, Prezime TEXT, Mesto TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create Table 2
                using (SQLiteCommand cmd = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Klas (Klas TEXT, Smer TEXT, Period TEXT, Makedonski INTEGER)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable1(long emb, string ime,string prezime,string mesto)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Ucenik (EMB, Ime,Prezime,Mesto) VALUES (@EMB, @Ime,@Prezime,@Mesto)", connection))
                {
                    cmd.Parameters.AddWithValue("@EMB", emb);
                    cmd.Parameters.AddWithValue("@Ime", ime);
                    cmd.Parameters.AddWithValue("@Prezime", prezime);
                    cmd.Parameters.AddWithValue("@Mesto", mesto);

                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable2(string klas, string smer,string period,int makedonski)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Klas (Klas, Smer,Period,Makedonski) VALUES (@Klas, @Smer,@Period, @Makedonski)", connection))
                {
                    cmd.Parameters.AddWithValue("@Klas", klas);
                    cmd.Parameters.AddWithValue("@Smer", smer);
                    cmd.Parameters.AddWithValue("@Period", period);
                    cmd.Parameters.AddWithValue("@Makedonski", makedonski);

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

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=mydatabase.db;Version=3;";
                SQLiteManager objSql =new SQLiteManager(connectionString);
                objSql.CreateTables();


                if (tbMaticen.Text != "" && tbIme.Text != "" && tbPrezime.Text != ""&& tbMesto.Text != "" && cbKlas.Text != "" && cbSmer.Text != "" && cbPeriod.Text != "" && cbMakedonski.Text !="")
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
                            objSql.InsertDataIntoTable2(cbKlas.Text, cbSmer.Text, cbPeriod.Text, makedonski);

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

        private void cbMakedonski_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=mydatabase.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);

                var sqlite_datareader = objSql.SelectFrom("Ucenik");
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

                var sqlite_datareaderKlas = objSql.SelectFrom("Klas");
                listView2.Items.Clear();
                while (sqlite_datareaderKlas.Read())
                {

                    string[] arr = new string[4];
                    ListViewItem itm;

                    arr[0] = sqlite_datareaderKlas.GetValue(0).ToString();
                    arr[1] = sqlite_datareaderKlas.GetValue(1).ToString();
                    arr[2] = sqlite_datareaderKlas.GetValue(2).ToString();
                    arr[3] = sqlite_datareaderKlas.GetInt32(3).ToString();


                    itm = new ListViewItem(arr);
                    listView2.Items.Add(itm);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ima problem so vcituvanje na podatocite od bazata: {ex.Message}");    
            }
        }
    }
}
