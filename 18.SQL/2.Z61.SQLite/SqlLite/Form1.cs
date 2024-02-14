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
using System.IO;

//podatocite od databazata da se prikazat vo list view na prikazipodatoici
namespace SqlLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("id", 70);
            listView1.Columns.Add("ime", 70);
            listView1.Columns.Add("prezime", 120);
            listView1.Columns.Add("godini", 50);

            //citanje na podatocite od baza i zapisuvanje vo listview1
            //SQLiteConnection sqlite_conn;
            //sqlite_conn = CreateConnection();
            //ReadData(sqlite_conn);
        }
        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= C:\\SQLite\\test1.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Problem so povrzuvanjeto so bazata");
            }
            return sqlite_conn;
        }
        public void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti";


            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {
   
                string[] arr = new string[4];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetInt32(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();
                arr[2] = sqlite_datareader.GetValue(2).ToString();
                arr[3] = sqlite_datareader.GetInt32(3).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

                string podatok = "";
                int myreader = sqlite_datareader.GetInt32(0);

                podatok = podatok + " " + myreader.ToString();
                string str = sqlite_datareader.GetString(1);

                podatok = podatok + " " + str;
                str = sqlite_datareader.GetString(2);

                podatok = podatok + " " + str;
                myreader = sqlite_datareader.GetInt32(3);

               podatok = podatok + " " + myreader.ToString();
                MessageBox.Show(podatok.ToString());

            }
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;

            //proverka dali postoi tabela vo bazata
            string daliPostoiTabela = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'Licnosti'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = daliPostoiTabela;
            var exists = sqlite_cmd.ExecuteReader();
            if (!exists.HasRows)
            {
                string createTable = "CREATE TABLE Licnosti(id INTEGER PRIMARY KEY,ime VARCHAR(20),prezime VARCHAR(40),godini INT)";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            try
            {
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Licnosti(id, ime, prezime, godini)  VALUES (@id, @ime, @prezime, @godini)";
                int id = int.Parse(tbId.Text.ToString());
                int godini = int.Parse(tbGodini.Text.ToString());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ime", tbIme.Text);
                cmd.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                cmd.Parameters.AddWithValue("@godini", godini);
                cmd.ExecuteNonQuery();


            }
            catch
            {
                MessageBox.Show("Problem so zapisuvanje vo tabelata, mozno povtoruvanje na id");
            }
        }

        private void btnPrikaziPodatoci_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                ReadData(sqlite_conn);
            }
            catch
            {
                MessageBox.Show("Problem so prikazuvanjeto na podatocite");
            }

        }
    }
}
