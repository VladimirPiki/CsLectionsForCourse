using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Z74.ServerWinExcelFile
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

            public void CreateTable(List<string> lisView, string imeNaTabela)
            {
                OpenConnection();

                string createTable = "CREATE TABLE IF NOT EXISTS " + imeNaTabela + "(";
                for (int i = 0; i < lisView.Count; i++)
                {
                    if (i < lisView.Count - 1)
                        createTable = createTable + lisView[i] + " VARCHAR(40),";
                    else
                    {
                        createTable = createTable + lisView[i] + " VARCHAR(40)) ";

                    }

                }

                using (SQLiteCommand cmd = new SQLiteCommand(
                 createTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                CloseConnection();


            }

     /*       public void InsertRow(string ime, string prezime, string godini)
            {
                OpenConnection();
                string insertInto = "INSERT INTO Licnosti(ime,prezime,godini) VALUES(@ime,@prezime,@godini)";

                using (SQLiteCommand cmd = new SQLiteCommand(
                   insertInto, connection))
                {
                    cmd.Parameters.AddWithValue("ime", ime);
                    cmd.Parameters.AddWithValue("prezime",prezime);
                    cmd.Parameters.AddWithValue("godini", godini);
                    cmd.ExecuteNonQuery();
                }
            }*/

            public void InsertRow(List<string> listView, List<string> listValues, string imeNaTabela)
            {
                OpenConnection();
                try
                {
                    string insertInto = "INSERT INTO " + imeNaTabela + "(";
                    for (int i = 0; i < listView.Count; i++)
                    {
                        if (i < listView.Count - 1)
                        {
                            insertInto = insertInto + listView[i] + ", ";
                        }
                        else
                        {
                            insertInto = insertInto + listView[i] + " )";
                        }
                    }
                    insertInto = insertInto + " VALUES(";
                    for (int i = 0; i < listValues.Count; i++)
                    {
                        if (i < listValues.Count - 1)
                        {
                            insertInto = insertInto + "'" + listValues[i] + "', ";
                        }
                        else
                        {
                            insertInto = insertInto + "'" + listValues[i] + "' )";
                        }

                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(
                    insertInto, connection))
                    {
                        for (int a = 0; a < listView.Count; a++)
                        {
                            for (int j = a; j < listValues.Count; j++)
                            {
                                cmd.Parameters.AddWithValue(listView[a], listValues[j]);
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
        }

        }
    }
