using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteConsoleS25
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
            FilterGodini(sqlite_conn);
            FilterIme(sqlite_conn);
            Delete(sqlite_conn);
            ReadData(sqlite_conn);
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= C:\\SQLite\\test8.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Problem so povrzuvanjeto so bazata");
            }
            return sqlite_conn;
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

        static void InsertData(SQLiteConnection conn)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = "INSERT INTO Licnosti(id, ime, prezime, godini) VALUES(10,'Goran','Momiroski', 15); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO Licnosti(id, ime, prezime, godini) VALUES(4,'Aleksandar','Mitreski', 25); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO Licnosti(id, ime, prezime, godini) VALUES(7,'Aleksandra','Mitreska', 27); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO Licnosti(id, ime, prezime, godini) VALUES(8,'Aleksandra','Mitreska', 27); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO Licnosti(id, ime, prezime, godini) VALUES(9,'Aleksandra','Mitreska', 27); ";
                sqlite_cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("problem so zapisuvanje vo tabelata, mozno povtoruvanje na id 1");
            }

        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                Console.Write(myreader + "  ");
                string str = sqlite_datareader.GetString(1);
                Console.Write(str + "  ");
                str = sqlite_datareader.GetString(2);
                Console.Write(str + "  ");
                myreader = sqlite_datareader.GetInt32(3);
                Console.Write(myreader + "  ");
                Console.WriteLine();
            }


        }
        static void FilterGodini(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            Console.WriteLine("Postari licnosti od 15 godini");

            //citanje po odreden kriterium na primer po vozrast
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti WHERE godini>15";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                Console.Write(myreader + "  ");
                string str = sqlite_datareader.GetString(1);
                Console.Write(str + "  ");
                str = sqlite_datareader.GetString(2);
                Console.Write(str + "  ");
                myreader = sqlite_datareader.GetInt32(3);
                Console.Write(myreader + "  ");
                Console.WriteLine();
            }

        }

        static void FilterIme(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            Console.WriteLine("Licnosti so ime Goran");

            //citanje po odreden kriterium na primer po ime
            sqlite_cmd.CommandText = "SELECT * FROM Licnosti WHERE ime='Goran'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                Console.Write(myreader + "  ");
                string str = sqlite_datareader.GetString(1);
                Console.Write(str + "  ");
                str = sqlite_datareader.GetString(2);
                Console.Write(str + "  ");
                myreader = sqlite_datareader.GetInt32(3);
                Console.Write(myreader + "  ");
                Console.WriteLine();
            }

        }
        static void Delete(SQLiteConnection conn)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                Console.WriteLine("Brisenje na licnost so id=4");

                //brisenje na licnost so id=1
                sqlite_cmd.CommandText = "DELETE  FROM Licnosti WHERE id=4";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
            }
            catch
            {
                Console.WriteLine("Nema licnost so dadeniot id");
            }



            //conn.Close();
        }
    }
}