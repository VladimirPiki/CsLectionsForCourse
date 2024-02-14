using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;


namespace SQLiteOneToMany
{

    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";

            //create tables
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Create the Ucenici table
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "CREATE TABLE IF NOT EXISTS Ucenici (EMB INTEGER PRIMARY KEY, Ime TEXT)", connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Create the Ocenki table with a foreign key to the Ucenici table
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "CREATE TABLE IF NOT EXISTS Ocenki (ID INTEGER PRIMARY KEY, Klas TEXT, Godina INT, Matematika INT, UceniciEMB INT, FOREIGN KEY(UceniciEMB) REFERENCES Ucenici(ID))", connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Problem so kreiranjeto na tebelite ili konkecijata");
            }


            ////insert data
            //using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            //{
            //    connection.Open();

            //  //////  Insert data into the Department table
            //    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Ucenici (EMB, Ime) VALUES (@EMB, @Ime)", connection))
            //    {
            //        cmd.Parameters.AddWithValue("@EMB", 124);
            //        cmd.Parameters.AddWithValue("@Ime", "Ilija");
            //        cmd.ExecuteNonQuery();
            //    }

            //    // Insert data into the Employee table, associating employees with a department
            //    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Ocenki (Klas, Godina, Matematika, UceniciEMB) VALUES (@Klas, @Godina,@Matematika, @UceniciEMB)", connection))
            //    {
            //        cmd.Parameters.AddWithValue("@Klas", "1");
            //        cmd.Parameters.AddWithValue("@Godina", 2023);
            //        cmd.Parameters.AddWithValue("@Matematika", 5);
            //        cmd.Parameters.AddWithValue("@UceniciEMB", 124);
            //        cmd.ExecuteNonQuery();
            //        cmd.Parameters.AddWithValue("@Klas", "2");
            //        cmd.Parameters.AddWithValue("@Godina", 2023);
            //        cmd.Parameters.AddWithValue("@Matematika", 5);
            //        cmd.Parameters.AddWithValue("@UceniciEMB", 124);
            //        cmd.ExecuteNonQuery();

            //    }

            //    connection.Close();
            //}


            //

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // 
                string query = "SELECT Ocenki.* FROM Ocenki INNER JOIN Ucenici ON Ocenki.UceniciEMB = Ucenici.EMB WHERE Ucenici.EMB = @EMB";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EMB", 124);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int godina = reader.GetInt32(2);
                            //string ime = reader.GetString(0);
                            //Console.WriteLine($"Ucenikot e  : {ime}");
                            Console.WriteLine($"Ucenikot e  : {id + " " + godina}");
                        }
                    }
                }

                connection.Close();
            }


        }
    }

}