using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace Z75.ServerPodatoci
{
    internal class Database
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

            public void CreateTable(List<string> koloni)
            {
                OpenConnection();

                string createTable = "CREATE TABLE IF NOT EXISTS Licnosti (";
                for (int i = 0; i < koloni.Count; i++)
                {
                    if (i < koloni.Count - 1)
                        createTable = createTable + koloni[i] + " VARCHAR(40),";
                    else
                    {
                        createTable = createTable + koloni[i] + " VARCHAR(40))";

                    }

                }

                using (SQLiteCommand cmd = new SQLiteCommand(
                 createTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                CloseConnection();


            }

            public void InsertRow(List<string> koloni, List<string> koloniVrednosti)
            {
                OpenConnection();
                try
                {
                    string insertInto = "INSERT INTO Licnosti(";
                    for (int i = 0; i < koloni.Count; i++)
                    {
                        if (i < koloni.Count - 1)
                        {
                            insertInto = insertInto + koloni[i] + ", ";
                        }
                        else
                        {
                            insertInto = insertInto + koloni[i] + " )";
                        }
                    }
                    insertInto = insertInto + " VALUES(";
                    for (int i = 0; i < koloniVrednosti.Count; i++)
                    {
                        if (i < koloniVrednosti.Count - 1)
                        {
                            insertInto = insertInto + "'" + koloniVrednosti[i] + "', ";
                        }
                        else
                        {
                            insertInto = insertInto + "'" + koloniVrednosti[i] + "' )";
                        }

                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(
                    insertInto, connection))
                    {
                        for (int a = 0; a < koloni.Count; a++)
                        {
                            for (int j = a; j < koloniVrednosti.Count; j++)
                            {
                                cmd.Parameters.AddWithValue(koloni[a], koloniVrednosti[j]);
                                break;
                            }

                        }
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (System.Exception excpt)
                {
                    // MessageBox.Show("Ucenikot e zapisan vo baza " + excpt.Message);
                }
                CloseConnection();
            }

            public SQLiteDataReader PrikaziGiSite()
            {
                OpenConnection();
                SQLiteDataReader reader;
                using (SQLiteCommand cmd = new SQLiteCommand(
                    "SELECT * FROM Licnosti", connection))
                {
                    reader = cmd.ExecuteReader();
                }
                return reader;
            }

            public SQLiteDataReader SelectFrom(string kveri)
            {
                OpenConnection();
                SQLiteDataReader reader;
                using (SQLiteCommand cmd = new SQLiteCommand(
                    "SELECT * FROM Licnosti WHERE " + kveri, connection))
                {
                    reader = cmd.ExecuteReader();
                }
                return reader;
        
            }

        }

    }
}
