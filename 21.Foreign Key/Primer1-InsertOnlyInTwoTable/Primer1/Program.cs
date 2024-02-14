using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Primer1
{
    internal class Program
    {
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
                    "CREATE TABLE IF NOT EXISTS Table1 (ID INTEGER PRIMARY KEY, Ime TEXT, Godini INT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create Table 2
                using (SQLiteCommand cmd = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Table2 (ID INTEGER PRIMARY KEY, Grad TEXT, Drzava TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable1(string ime, int godini)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Table1 (Ime, Godini) VALUES (@Ime, @Godini)", connection))
                {
                    cmd.Parameters.AddWithValue("@Ime", ime);
                    cmd.Parameters.AddWithValue("@Godini", godini);

                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable2(string grad, string drzava)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Table2 (Grad, Drzava) VALUES (@Grad, @Drzava)", connection))
                {
                    cmd.Parameters.AddWithValue("@Grad", grad);
                    cmd.Parameters.AddWithValue("@Drzava", drzava);

                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }
        }

        static void Main(string[] args)
        {

          //  string connectionString = "Data Source=C:\\SQLite\\mydatabase3.db;Version=3;";
            string connectionString = "Data Source=mydatabase3.db;Version=3;";
            SQLiteManager dbManager = new SQLiteManager(connectionString);

            // Create the tables
            dbManager.CreateTables();

            // Insert data into Table1
            dbManager.InsertDataIntoTable1("Daniel", 37);
            dbManager.InsertDataIntoTable1("Goran", 27);

            // Insert data into Table2
            dbManager.InsertDataIntoTable2("Skopje", "Makedonija");
            dbManager.InsertDataIntoTable2("Paris", "Francija");

            Console.WriteLine("Podatocite se vneseni vo tabelata.");



            // Close connection
            dbManager.CloseConnection();

            // Read data
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create a SQL query to read data from Table1
                string queryTable1 = "SELECT ID, Ime, Godini FROM Table1";
                using (SQLiteCommand cmdTable1 = new SQLiteCommand(queryTable1, connection))
                {
                    using (SQLiteDataReader readerTable1 = cmdTable1.ExecuteReader())
                    {
                        Console.WriteLine("Data from Table1:");
                        while (readerTable1.Read())
                        {
                            int id = readerTable1.GetInt32(0);
                            string ime = readerTable1.GetString(1);
                            int godini = readerTable1.GetInt32(2);
                            Console.WriteLine($"ID: {id}, Ime: {ime}, Godini: {godini}");
                        }
                    }
                }

                // Create a SQL query to read data from Table2
                string queryTable2 = "SELECT ID, Grad, Drzava FROM Table2";
                using (SQLiteCommand cmdTable2 = new SQLiteCommand(queryTable2, connection))
                {
                    using (SQLiteDataReader readerTable2 = cmdTable2.ExecuteReader())
                    {
                        Console.WriteLine("\nData from Table2:");
                        while (readerTable2.Read())
                        {
                            int id = readerTable2.GetInt32(0);
                            string grad = readerTable2.GetString(1);
                            string drzava = readerTable2.GetString(2);
                            Console.WriteLine($"ID: {id}, Grad: {grad}, Drzava: {drzava}");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
