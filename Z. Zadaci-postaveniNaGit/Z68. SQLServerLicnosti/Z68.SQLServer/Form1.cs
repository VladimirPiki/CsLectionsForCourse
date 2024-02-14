using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z68.SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            // listView1.Columns.Add("id", 70);
            listView1.Columns.Add("ime", 70);
            listView1.Columns.Add("prezime", 120);
            listView1.Columns.Add("godini", 50);

            //proverka dali postoi bazata
            //proverka dali postoi tabelata ako ne postoi se kreira tabela
            string connetionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            //povrzuvanje so bazata
            connetionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
            con = new SqlConnection(connetionString);
            con.Open();


            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('myTableLicnosti1')";
            cmd = new SqlCommand(sql, con);
            //proverka dali postoi tabela
            int newProdID = (Int32)cmd.ExecuteScalar();
            if ((Int32)cmd.ExecuteScalar() == 0)
            {
                sql = "CREATE TABLE myTableLicnosti1" + "(Ime CHAR(50), Prezime CHAR(255), Godini CHAR(50))";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }


            sql = "Select Ime, Prezime, Godini from myTableLicnosti1";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();

            //citame podatoci od baza - tabela
            while (dataReader.Read())
            {
                string[] arr = new string[4];
                ListViewItem itm;

                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
            con.Close();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            //povrzuvanje so bazata
            connetionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
            con = new SqlConnection(connetionString);
            con.Open();


            //proverka dali postoi tabelata ako ne postoi se kreira tabela
            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('myTableLicnosti1')";

            cmd = new SqlCommand(sql, con);

            int newProdID = (Int32)cmd.ExecuteScalar();
            if ((Int32)cmd.ExecuteScalar() == 0)
            {
                sql = "CREATE TABLE myTableLicnosti1" + "(Ime CHAR(50), Prezime CHAR(255), Godini CHAR(50))";
                //sql = "CREATE TABLE myTableLicnosti1" + "id int IDENTITY(1, 1) PRIMARY KEY" + "(Ime CHAR(50), Prezime CHAR(255), Godini CHAR(50))";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

            //https://stackoverflow.com/questions/38145649/c-sharp-insert-data-into-database-windows-form-app
            //dodavanje podatoci vo tabelata
            // Adding records the table  
            string ime, prezime, godini;

            //ime = tbIme.Text;
            //prezime = tbPrezime.Text;
            //godini = tbGodini.Text;
            //ime.ToCharArray();
            cmd.CommandText = @"INSERT INTO myTableLicnosti1 (Ime, Prezime, Godini) VALUES (@ime, @prezime, @godini)";

            cmd.Parameters.AddWithValue("@ime", txtBoxIme.Text);
            cmd.Parameters.AddWithValue("@prezime", txtBoxPrezime.Text);
            cmd.Parameters.AddWithValue("@godini", txtBoxGodini.Text);
            cmd.ExecuteNonQuery();

            //


            //dodavanje na podatocite vo modelot listview vo slucja koga podatocite
            //ne se zemaat od bazata

            //string[] arr = new string[3];
            //ListViewItem itm;

            //arr[0] = tbIme.Text;
            //arr[1] = tbPrezime.Text;
            //arr[2] = tbGodini.Text;

            //itm = new ListViewItem(arr);
            //listView1.Items.Add(itm);
            ///////////////////////

            //Brisenje na podatocite koi se naogjaat vo textBox
            txtBoxIme.Clear();
            txtBoxPrezime.Clear();
            txtBoxGodini.Clear();


            //dodavanje na podatocite koga modelot se azurira so site podatoci od bazata
            //citanje na podatoci od tabelata

            //Brisenje na site podatoci od listView
            listView1.Items.Clear();


            sql = "Select Ime, Prezime, Godini from myTableLicnosti1";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();

            //
            while (dataReader.Read())
            {
                string[] arr = new string[3];
                ListViewItem itm;

                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
            con.Close();

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            int godini = 0;
            try
            {
                if (txtBoxGodini.Text != "")
                {
                    bool daliEbroj = Int32.TryParse(txtBoxGodini.Text, out godini);
                    if (daliEbroj)
                    {
                        string connectionString = null;
                        SqlConnection con;
                        SqlCommand cmd;
                        SqlDataReader dataReader;
                        string sql;
                        listView1.Items.Clear();
                        //povrzuvanje so bazata
                        connectionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
                        con = new SqlConnection(connectionString);
                        con.Open();


                        connectionString = @"select ime,prezime,godini FROM myTableLicnosti1 WHERE godini = @godini; ";

                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@godini", godini);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();

                        //while (dataReader.Read())
                        //{
                        //    listView1.Items.Add(dataReader.GetValue(0).ToString());
                        //}
                        while (dataReader.Read())
                        {
                            string[] arr = new string[3];
                            ListViewItem itm;

                            arr[0] = dataReader.GetValue(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }

                            con.Close();
                        txtBoxIme.Clear();
                        txtBoxPrezime.Clear();
                        txtBoxGodini.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Ve molam vnesete broj");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Problem so prikazuvanjeto na bazata");
            }
        }
             
         
        

       

        private void btnBaza_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            //povrzuvanje so bazata
            connetionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
            con = new SqlConnection(connetionString);
            con.Open();


            //proverka dali postoi tabelata ako ne postoi se kreira tabela
            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('myTableLicnosti1')";

            cmd = new SqlCommand(sql, con);

            int newProdID = (Int32)cmd.ExecuteScalar();
            if ((Int32)cmd.ExecuteScalar() == 0)
            {
                sql = "CREATE TABLE myTableLicnosti1" + "(Ime CHAR(50), Prezime CHAR(255), Godini CHAR(50))";
                //sql = "CREATE TABLE myTableLicnosti1" + "id int IDENTITY(1, 1) PRIMARY KEY" + "(Ime CHAR(50), Prezime CHAR(255), Godini CHAR(50))";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

            listView1.Items.Clear();


            sql = "Select Ime, Prezime, Godini from myTableLicnosti1";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();

            //
            while (dataReader.Read())
            {
                string[] arr = new string[3];
                ListViewItem itm;

                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
            con.Close();
        }

        private void btIme_Click(object sender, EventArgs e)
        {
     
            try
            {
                if (txtBoxIme.Text != "")
                {

                    string connectionString = null;
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    listView1.Items.Clear();
                    //povrzuvanje so bazata
                    connectionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
                    con = new SqlConnection(connectionString);
                    con.Open();


                    connectionString = @"select ime,prezime,godini FROM myTableLicnosti1 WHERE ime = @ime; ";

                    cmd = new SqlCommand(connectionString, con);
                    SqlParameter[] param = new SqlParameter[1];

                    param[0] = new SqlParameter("@ime", txtBoxIme.Text);
                    cmd.Parameters.Add(param[0]);
                    dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }

                    con.Close();
                    txtBoxIme.Clear();
                    txtBoxPrezime.Clear();
                    txtBoxGodini.Clear();
                }
                else
                {
                    MessageBox.Show("Ve molam vnesete Ime za prebaruvanje");
                }
                 
          
                
            }
            catch
            {
                MessageBox.Show("Problem so prikazuvanjeto na bazata");
            }
        }

        private void btnPrezime_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtBoxIme.Text != "" && txtBoxPrezime.Text != "" )
                {

                    string connectionString = null;
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    listView1.Items.Clear();
                    //povrzuvanje so bazata
                    connectionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
                    con = new SqlConnection(connectionString);
                    con.Open();


                    connectionString = @"select ime,prezime,godini FROM myTableLicnosti1 WHERE ime = @ime AND prezime=@prezime; ";

                    cmd = new SqlCommand(connectionString, con);
                    SqlParameter[] param = new SqlParameter[2];

                    param[0] = new SqlParameter("@ime", txtBoxIme.Text);
                    param[1] = new SqlParameter("@prezime", txtBoxPrezime.Text);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }

                    con.Close();
                    txtBoxIme.Clear();
                    txtBoxPrezime.Clear();
                    txtBoxGodini.Clear();
                }
                else
                {
                    MessageBox.Show("Ve molam vnesete Ime i prezime za prebaruvanje");
                }



            }
            catch
            {
                MessageBox.Show("Problem so prikazuvanjeto na bazata");
            }
        }
    }
}
