using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Z69.SQLServerLicnostPodatoci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("maticen", 100);
            listView1.Columns.Add("ime", 100);
            listView1.Columns.Add("tatkovo ime", 100);
            listView1.Columns.Add("prezime", 100);
            listView1.Columns.Add("datum na ragjanje", 100);
            listView1.Columns.Add("adresa", 100);
            listView1.Columns.Add("mesto na ziveenje", 100);

            string connetionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            //povrzuvanje so bazata
            connetionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
            con = new SqlConnection(connetionString);
            con.Open();
            sql = "Select maticen, ime, tatkovo_ime,prezime,datum_ragjanje,adresa,mesto_ziveenje from Z69_SQLServerLicnostPodatoci";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (dataReader.Read())
            {

                string[] arr = new string[7];
                ListViewItem itm;

                arr[0] = dataReader.GetInt64(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();
                arr[3] = dataReader.GetValue(3).ToString();
                arr[4] = dataReader.GetValue(4).ToString();
                arr[5] = dataReader.GetValue(5).ToString();
                arr[6] = dataReader.GetValue(6).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            con.Close();
        }
        public void VnesiVoBaza()
        {
   
        }

        private void btnBaza_Click(object sender, EventArgs e)
        {

            try
            {

                if (tbMaticenBr.Text != "" && tbIme.Text != "" && tbTatkovoIme.Text != "" && tbPrezime.Text != "" && tbAdresa.Text != "" && tbMestoZiveenje.Text != "")
                {
                    if (tbMaticenBr.Text.Length == 13)
                    {
                        long maticen;
                        bool parsirajMaticen = Int64.TryParse(tbMaticenBr.Text, out maticen);
                        if (parsirajMaticen)
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
                            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('Z69_SQLServerLicnostPodatoci')";

                            cmd = new SqlCommand(sql, con);

                            int newProdID = (Int32)cmd.ExecuteScalar();
                            if ((Int32)cmd.ExecuteScalar() == 0)
                            {
                                sql = "CREATE TABLE Z69_SQLServerLicnostPodatoci" + "(maticen BIGINT PRIMARY KEY NOT NULL,ime VARCHAR(20),tatkovo_ime VARCHAR(20),prezime VARCHAR(40),datum_ragjanje DATE, adresa VARCHAR(100),mesto_ziveenje VARCHAR(50))";
                                //sql = "CREATE TABLE myTableLicnosti1" + "id int IDENTITY(1, 1) PRIMARY KEY" + "(Ime CHAR(50), Prezime CHAR(255), Godini CHAR(50))";
                                cmd = new SqlCommand(sql, con);
                                cmd.ExecuteNonQuery();
                            }

                            cmd.CommandText = @"INSERT INTO Z69_SQLServerLicnostPodatoci(maticen, ime, tatkovo_ime,prezime,datum_ragjanje,adresa,mesto_ziveenje)  VALUES (@maticen, @ime, @tatkovo_ime,@prezime,@datum_ragjanje,@adresa,@mesto_ziveenje)";

                            cmd.Parameters.AddWithValue("@maticen", maticen);
                            cmd.Parameters.AddWithValue("@ime", tbIme.Text);
                            cmd.Parameters.AddWithValue("@tatkovo_ime", tbTatkovoIme.Text);
                            cmd.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                            cmd.Parameters.AddWithValue("@datum_ragjanje", dtDatumRag.Value.Date);//dtData.Value.Date
                            cmd.Parameters.AddWithValue("@adresa", tbAdresa.Text);
                            cmd.Parameters.AddWithValue("@mesto_ziveenje", tbMestoZiveenje.Text);
                            cmd.ExecuteNonQuery();
              



                            sql = "Select maticen, ime, tatkovo_ime,prezime,datum_ragjanje,adresa,mesto_ziveenje from Z69_SQLServerLicnostPodatoci";
                            cmd = new SqlCommand(sql, con);
                            dataReader = cmd.ExecuteReader();
                            listView1.Items.Clear();
                            while (dataReader.Read())
                            {

                                string[] arr = new string[7];
                                ListViewItem itm;

                                arr[0] = dataReader.GetInt64(0).ToString();
                                arr[1] = dataReader.GetValue(1).ToString();
                                arr[2] = dataReader.GetValue(2).ToString();
                                arr[3] = dataReader.GetValue(3).ToString();
                                arr[4] = dataReader.GetValue(4).ToString();
                                arr[5] = dataReader.GetValue(5).ToString();
                                arr[6] = dataReader.GetValue(6).ToString();

                                itm = new ListViewItem(arr);
                                listView1.Items.Add(itm);
                            }
                            con.Close();
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
            catch { MessageBox.Show("Ima problem so vnesuvanjeto vo baza !"); }
        }

        private void btnBarajPodatoci_Click(object sender, EventArgs e)
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
            connectionString = @"Select maticen, ime, tatkovo_ime,prezime,datum_ragjanje,adresa,mesto_ziveenje from Z69_SQLServerLicnostPodatoci WHERE ";

            if (rbMaticenBroj.Checked == true)
            {
                if (tbMaticenBr.Text.Length == 13)
                {

                    tbIme.Clear();
                    tbTatkovoIme.Clear();
                    tbPrezime.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();

                    long maticen;
                    bool parsirajMaticen = Int64.TryParse(tbMaticenBr.Text, out maticen);
                    if (parsirajMaticen)
                    {

                        try
                        {
                            connectionString += " maticen=" + maticen;
                            cmd = new SqlCommand(connectionString, con);
                            SqlParameter[] param = new SqlParameter[1];

                            param[0] = new SqlParameter("@maticen", maticen);
                            cmd.Parameters.Add(param[0]);
                            dataReader = cmd.ExecuteReader();
                            listView1.Items.Clear();
                            while (dataReader.Read())
                            {

                                string[] arr = new string[7];
                                ListViewItem itm;

                                arr[0] = dataReader.GetInt64(0).ToString();
                                arr[1] = dataReader.GetValue(1).ToString();
                                arr[2] = dataReader.GetValue(2).ToString();
                                arr[3] = dataReader.GetValue(3).ToString();
                                arr[4] = dataReader.GetValue(4).ToString();
                                arr[5] = dataReader.GetValue(5).ToString();
                                arr[6] = dataReader.GetValue(6).ToString();

                                itm = new ListViewItem(arr);
                                listView1.Items.Add(itm);
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                    }

                }
                else
                {
                    MessageBox.Show("Popolnetego prvilno so 13 cifri poleto za maticen broj");
                }
            }



            if (rbIme.Checked == true)
            {
                if (tbIme.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbTatkovoIme.Clear();
                    tbPrezime.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {
                        connectionString += " ime='" + tbIme.Text+"'";
                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@ime", tbIme.Text);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dataReader.Read())
                        {

                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = dataReader.GetInt64(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();
                            arr[3] = dataReader.GetValue(3).ToString();
                            arr[4] = dataReader.GetValue(4).ToString();
                            arr[5] = dataReader.GetValue(5).ToString();
                            arr[6] = dataReader.GetValue(6).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {
                    MessageBox.Show("Popolnetego poleto za ime");
                }
            }



            if (rbPrezime.Checked == true)
            {
                if (tbPrezime.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbIme.Clear();
                    tbTatkovoIme.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {
                        connectionString += " prezime='" + tbPrezime.Text + "'";
                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@prezime", tbPrezime.Text);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dataReader.Read())
                        {

                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = dataReader.GetInt64(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();
                            arr[3] = dataReader.GetValue(3).ToString();
                            arr[4] = dataReader.GetValue(4).ToString();
                            arr[5] = dataReader.GetValue(5).ToString();
                            arr[6] = dataReader.GetValue(6).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {
                    MessageBox.Show("Popolnetegi polinjata za prezime");
                }
            }


            if (rbTatkovoIme.Checked == true)
            {

                if (tbTatkovoIme.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbIme.Clear();
                    tbPrezime.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {

                        connectionString += " tatkovo_ime='" + tbTatkovoIme.Text + "'";
                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@tatkovo_ime", tbTatkovoIme.Text);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dataReader.Read())
                        {

                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = dataReader.GetInt64(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();
                            arr[3] = dataReader.GetValue(3).ToString();
                            arr[4] = dataReader.GetValue(4).ToString();
                            arr[5] = dataReader.GetValue(5).ToString();
                            arr[6] = dataReader.GetValue(6).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {

                    MessageBox.Show("Vnesete tatkovo ime");
                }
            }


            if (rbDatum.Checked == true)
            {
                if (dtDatumRag.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbIme.Clear();
                    tbPrezime.Clear();
                    tbTatkovoIme.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();

                    string formattedDate = dtDatumRag.Value.Date.ToString("yyyy-MM-dd");
                    try
                    {   
                        connectionString += " datum_ragjanje='" + formattedDate + "'";
                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@datum_ragjanje", formattedDate);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dataReader.Read())
                        {

                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = dataReader.GetInt64(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();
                            arr[3] = dataReader.GetValue(3).ToString();
                            arr[4] = dataReader.GetValue(4).ToString();
                            arr[5] = dataReader.GetValue(5).ToString();
                            arr[6] = dataReader.GetValue(6).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {
                    MessageBox.Show("Izberete datum");
                }
            }

            if (rbMestoZiveenje.Checked == true)
            {

                if (tbMestoZiveenje.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbIme.Clear();
                    tbPrezime.Clear();
                    tbTatkovoIme.Clear();
                    tbAdresa.Clear();
                    try
                    {

                        connectionString += " mesto_ziveenje='" + tbMestoZiveenje.Text + "'";
                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@mesto_ziveenje", tbMestoZiveenje.Text);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dataReader.Read())
                        {

                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = dataReader.GetInt64(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();
                            arr[3] = dataReader.GetValue(3).ToString();
                            arr[4] = dataReader.GetValue(4).ToString();
                            arr[5] = dataReader.GetValue(5).ToString();
                            arr[6] = dataReader.GetValue(6).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {

                    MessageBox.Show("Vnesete mesto na ziveenje");
                }
            }

            if (rbAdresa.Checked == true)
            {

                if (tbAdresa.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbIme.Clear();
                    tbPrezime.Clear();
                    tbTatkovoIme.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {

                        connectionString += " adresa='" + tbAdresa.Text + "'";
                        cmd = new SqlCommand(connectionString, con);
                        SqlParameter[] param = new SqlParameter[1];

                        param[0] = new SqlParameter("@adresa", tbAdresa.Text);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dataReader.Read())
                        {

                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = dataReader.GetInt64(0).ToString();
                            arr[1] = dataReader.GetValue(1).ToString();
                            arr[2] = dataReader.GetValue(2).ToString();
                            arr[3] = dataReader.GetValue(3).ToString();
                            arr[4] = dataReader.GetValue(4).ToString();
                            arr[5] = dataReader.GetValue(5).ToString();
                            arr[6] = dataReader.GetValue(6).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {

                    MessageBox.Show("Vnesete adresa");
                }
            }









            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrikaziSite_Click(object sender, EventArgs e)
        {
            try
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
                sql = "Select maticen, ime, tatkovo_ime,prezime,datum_ragjanje,adresa,mesto_ziveenje from Z69_SQLServerLicnostPodatoci";
                cmd = new SqlCommand(sql, con);
                dataReader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (dataReader.Read())
                {

                    string[] arr = new string[7];
                    ListViewItem itm;

                    arr[0] = dataReader.GetInt64(0).ToString();
                    arr[1] = dataReader.GetValue(1).ToString();
                    arr[2] = dataReader.GetValue(2).ToString();
                    arr[3] = dataReader.GetValue(3).ToString();
                    arr[4] = dataReader.GetValue(4).ToString();
                    arr[5] = dataReader.GetValue(5).ToString();
                    arr[6] = dataReader.GetValue(6).ToString();

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Ima problem so prikazvanjeto na site podatoci od baza");
            }
        }
    }
}
