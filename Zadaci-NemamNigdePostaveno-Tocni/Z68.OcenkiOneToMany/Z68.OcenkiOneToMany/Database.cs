using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z68.OcenkiOneToMany
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

            public void CreateTables()
            {
                OpenConnection();

                // Create Table 1
                using (SQLiteCommand cmd = new SQLiteCommand(
                 //   "CREATE TABLE IF NOT EXISTS Ucenici (EMB INTEGER PRIMARY KEY,Prezime TEXT, Tatkovo_ime TEXT, Ime TEXT, Mesto TEXT)", connection))
                 "CREATE TABLE IF NOT EXISTS Ucenici (EMB INTEGER PRIMARY KEY,Презиме TEXT, Татково_име TEXT, Име TEXT, Место TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create Table 2
                using (SQLiteCommand cmd = new SQLiteCommand(
                  //  "CREATE TABLE IF NOT EXISTS Ocenki (ID INTEGER PRIMARY KEY AUTOINCREMENT, Klas TEXT, Smer TEXT, Tromesecie TEXT,Ucebna_godina TEXT, Makedonski INTEGER,Matematika INTEGER,Angliski INTEGER,Programiranje INTEGER,Fizika INTEGER,Avtomatika INTEGER,Objektno_orientirano INTEGER,Muzika INTEGER,Izboren INTEGER,Prakticna_nastava INTEGER, UceniciEMB INT, FOREIGN KEY(UceniciEMB) REFERENCES Ucenici(ID))", connection))
                  "CREATE TABLE IF NOT EXISTS Ocenki (ID INTEGER PRIMARY KEY AUTOINCREMENT, Клас TEXT, Смер TEXT, Тромесечие TEXT,Учебна_Година TEXT, Македонски_јазик INTEGER,Математика INTEGER,Англиски_јазик INTEGER,Програмирање INTEGER,Физика INTEGER,Автоматика INTEGER,Објектно_ориентирано_програмирање INTEGER,Музика INTEGER,Изборен INTEGER,Практична_настава INTEGER, UceniciEMB INT, FOREIGN KEY(UceniciEMB) REFERENCES Ucenici(ID))", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

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
                    MessageBox.Show("Ucenikot e zapisan vo baza " + excpt.Message);
                }
                CloseConnection();
            }

            public void InsertDataIntoTable1(long emb,  string prezime,string tatkovo_ime, string ime, string mesto)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Ucenici (EMB, Prezime,Tatkovo_ime,Ime,Mesto) VALUES (@EMB,@Prezime,@Tatkovo_ime, @Ime,@Mesto)", connection))
                {
                    cmd.Parameters.AddWithValue("@EMB", emb);
                    cmd.Parameters.AddWithValue("@Prezime", prezime);
                    cmd.Parameters.AddWithValue("@Tatkovo_ime", tatkovo_ime);
                    cmd.Parameters.AddWithValue("@Ime", ime);
                    cmd.Parameters.AddWithValue("@Mesto", mesto);

                    cmd.ExecuteNonQuery();
                }

                CloseConnection();
            }

            public void InsertDataIntoTable2(string klas, string smer, string tromesecie,string ucebna_godina, int makedonski, int matematika, int Angliski, int Programiranje, int Fizika, int Avtomatika, int Objektno_orientirano, int Muzika, int Izboren, int Prakticna_nastava, long emb)
            {
                OpenConnection();

                using (SQLiteCommand cmd = new SQLiteCommand(
                    "INSERT INTO Ocenki (Klas, Smer,Tromesecie,Ucebna_godina,Makedonski,Matematika,Angliski,Programiranje,Fizika,Avtomatika,Objektno_orientirano,Muzika,Izboren,Prakticna_nastava,UceniciEMB) VALUES (@Klas, @Smer,@Tromesecie,@Ucebna_godina,@Makedonski,@Matematika,@Angliski,@Programiranje,@Fizika,@Avtomatika,@Objektno_orientirano,@Muzika,@Izboren,@Prakticna_nastava,@UceniciEMB)", connection))
                {
                    cmd.Parameters.AddWithValue("@Klas", klas);
                    cmd.Parameters.AddWithValue("@Smer", smer);
                    cmd.Parameters.AddWithValue("@Tromesecie", tromesecie);
                    cmd.Parameters.AddWithValue("@Ucebna_godina", ucebna_godina);
                    cmd.Parameters.AddWithValue("@Makedonski", makedonski);
                    cmd.Parameters.AddWithValue("@Matematika", matematika);
                    cmd.Parameters.AddWithValue("@Angliski", Angliski);
                    cmd.Parameters.AddWithValue("@Programiranje", Programiranje);
                    cmd.Parameters.AddWithValue("@Fizika", Fizika);
                    cmd.Parameters.AddWithValue("@Avtomatika", Avtomatika);
                    cmd.Parameters.AddWithValue("@Objektno_orientirano", Objektno_orientirano);
                    cmd.Parameters.AddWithValue("@Muzika", Muzika);
                    cmd.Parameters.AddWithValue("@Izboren", Izboren);
                    cmd.Parameters.AddWithValue("@Prakticna_nastava", Prakticna_nastava);
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

    }
}
