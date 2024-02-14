using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Z64.LicnostiPodatoci
{

    public class Database
    {

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= C:\\SQLite\\Z64.LicnostiPodatoci.db; Version = 3; New = True; Compress = True; ");
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

        static void CloseConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            try
            {
                if (sqlite_conn != null && sqlite_conn.State == ConnectionState.Open)
                {
                    sqlite_conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problems so zatvoranjeto na  database connection: " + ex.Message);
            }
        }
        public void IskluciKonekcija()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            try
            {
                if (sqlite_conn != null && sqlite_conn.State == ConnectionState.Open)
                {
                    sqlite_conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problems so zatvoranjeto na  database connection: " + ex.Message);
            }
        }

        public string proveriDaliImaKonekcija()
        {
            string pateka = "C:\\SQLite\\Z64.LicnostiPodatoci.db";
            return pateka;
        }
        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;

            string daliPostoiTabela = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'Licnosti'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = daliPostoiTabela;
            var exists = sqlite_cmd.ExecuteReader();
            if (!exists.HasRows)
            {
             string createTable = "CREATE TABLE Licnosti(maticen BIGINT PRIMARY KEY NOT NULL,ime VARCHAR(20),tatkovo_ime VARCHAR(20),prezime VARCHAR(40),datum_ragjanje DATE, adresa VARCHAR(100),mesto_ziveenje VARCHAR(50), klas VARCHAR(50), godina_ucebna VARCHAR(50) )";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            }
        }
        public void KreirajTabela()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
             CloseConnection();
        }

        public void VnesiVoBaza(long maticen, string ime, string tatkovoIme, string prezime, DateTime datumRagjanje, string adresa, string mestoZiveenje, string klas, string godinaUcebna)
        {

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            try
            {
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Licnosti(maticen, ime, tatkovo_ime,prezime,datum_ragjanje,adresa,mesto_ziveenje,klas,godina_ucebna)  VALUES (@maticen, @ime, @tatkovo_ime,@prezime,@datum_ragjanje,@adresa,@mesto_ziveenje,@klas,@godina_ucebna)";

                cmd.Parameters.AddWithValue("@maticen", maticen);
                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@tatkovo_ime", tatkovoIme);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@datum_ragjanje", datumRagjanje);//dtData.Value.Date
                cmd.Parameters.AddWithValue("@adresa", adresa);
                cmd.Parameters.AddWithValue("@mesto_ziveenje", mestoZiveenje);
                cmd.Parameters.AddWithValue("@klas", klas);
                cmd.Parameters.AddWithValue("@godina_ucebna", godinaUcebna);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspesno zapisvuvanje vo tabelata");

            }
            catch (System.Exception excpt)
            {
                MessageBox.Show("Ne moze da se vnese so isti MATICEN BROJ ! "+ excpt);
            }
        }
        public void Vnesi(string koloni, string koloniVrednosti)
        {
            try
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();

                  cmd.CommandText = @"INSERT INTO Licnosti("+koloni+")  VALUES ("+koloniVrednosti+")";
                cmd.ExecuteNonQuery();
                CloseConnection();

            }
            catch (System.Exception excpt)
            {
                MessageBox.Show("Ne moze da se vnese so isti MATICEN BROJ ! "+excpt);
            }
        }




        public SQLiteDataReader PrikaziGiSite()
        {
            SQLiteConnection conn;
            conn = CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti";
                
            sqlite_datareader = sqlite_cmd.ExecuteReader();

          
            return sqlite_datareader;
        }
        public SQLiteDataReader PrikaziGiKadeSto(string uslov)
        {
            SQLiteConnection conn;
            conn = CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti " + uslov;

            sqlite_datareader = sqlite_cmd.ExecuteReader();


            return sqlite_datareader;
        }



    }
}
