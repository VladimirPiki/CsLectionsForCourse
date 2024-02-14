using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;

namespace SamoNaslovOdExcelColumns
{
    public partial class Form1 : Form
    {
        private Excel.Application ExcelObj = null;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //listView1.Columns.Add("id", 300);
            //listView1.Columns.Add("predmeti", 300);

            ExcelObj = new Excel.Application();
            // See if the Excel Application Object was successfully constructed  
            if (ExcelObj == null)
            {
                MessageBox.Show("ERROR: EXCEL couldn't be started!");
                System.Windows.Forms.Application.Exit();
            }
            // Make the Application Visible  
            ExcelObj.Visible = true;
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= C:\\SQLite\\predmeti.db; Version = 3; New = True; Compress = True; ");
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
            sqlite_cmd.CommandText = "SELECT * FROM Predmeti";


            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {

                string[] arr = new string[4];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetInt32(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);


            }
        }

        static void CreateTable(SQLiteConnection conn,string koloni)
        {

            SQLiteCommand sqlite_cmd;

            //proverka dali postoi tabela vo bazata
            string daliPostoiTabela = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'Predmeti'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = daliPostoiTabela;
            var exists = sqlite_cmd.ExecuteReader();
            if (!exists.HasRows)
            {
                string createTable = "CREATE TABLE Predmeti("+koloni+")";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            }

        }


        static void CreateTableA(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;

            //proverka dali postoi tabela vo bazata
            string daliPostoiTabela = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'LicnostiA'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = daliPostoiTabela;
            var exists = sqlite_cmd.ExecuteReader();
            List<string> lisView = new List<string>() { "id", "ime", "prezime", "godini" };
            if (!exists.HasRows)
            {
                //string createTable = "CREATE TABLE Licnosti(id INTEGER PRIMARY KEY,ime VARCHAR(20),prezime VARCHAR(40),godini INT)";

                string createTable = "CREATE TABLE LicnostiA(";
                for (int i = 0; i < lisView.Count; i++)
                {
                    if (i < lisView.Count - 1)
                        createTable = createTable + lisView[i] + " VARCHAR(40),";
                    else
                    {
                        createTable = createTable + lisView[i] + " VARCHAR(40)) ";

                    }

                }




                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            }

        }

        string[] ConvertToStringArray(System.Array values)
        {
            // create a new string array  
            string[] theArray = new string[values.Length];
            // loop through the 2-D System.Array and populate the 1-D String Array  
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }
            return theArray;
        }

        private void btnProcitajPodatoci_Click(object sender, EventArgs e)
        {

            try
            {

                this.openFileDialog1.FileName = "*.xls"; if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //  MessageBox.Show(openFileDialog1.FileName);
                    // Here is the call to Open a Workbook in Excel   
                    // It uses most of the default values (except for the read-only which we set to true)  
                    Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(openFileDialog1.FileName, 0, true, 5,
                    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                    // get the collection of sheets in the workbook  
                    Excel.Sheets sheets = theWorkbook.Worksheets;
                    // get the first and only worksheet from the collection of worksheets  
                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                    // loop through 10 rows of the spreadsheet and place each row in the list view  

                    int lastUsedRow = 0;
                    lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                   System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                   Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                   false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                    string koloni = "";

                    for (int i = 4; i <= 7; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = ConvertToStringArray(myvalues);
                        int primaryKey = 1;

                        foreach (var strAr in strArray)
                        {

                            if (strAr != "")
                            {
                                listView1.Columns.Add(strAr, 70);
                                if (primaryKey == 1)
                                {
                                    koloni += strAr + " VARCHAR(200) PRIMARY KEY NOT NULL";
                                    //SQLiteConnection sqlite_conn;
                                    //sqlite_conn = CreateConnection();
                                    //CreateTable(sqlite_conn, koloni);
                                    primaryKey++;
                                }
                                else
                                {
                                    koloni += "," + strAr + " VARCHAR(200)";

                                }


                            }
                        }

                      //  MessageBox.Show(string.Join(Environment.NewLine, strArray));
                        //  listView1.Items.Add(new ListViewItem(strArray));
                    }
 

                    for (int i = 1; i <= 1; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray1 = ConvertToStringArray(myvalues);
                      //  int primaryKey = 1;

                        foreach (var strAr in strArray1)
                        {
                            
                            if (strAr != "")
                            {
                                listView1.Columns.Add(strAr, 70);
                          
                                 koloni += ","+strAr + " VARCHAR(200)";
   
                    
                            }
                        }

                        //MessageBox.Show(string.Join(Environment.NewLine, strArray));
                        //  listView1.Items.Add(new ListViewItem(strArray));
                    }
                 //   MessageBox.Show(koloni);

                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    CreateTable(sqlite_conn, koloni);

                    for (int i = 8; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = ConvertToStringArray(myvalues);
                        string columnsValue = "";
                        int pk = 1;
                        foreach (var strAr in strArray)
                        {

                            if (strAr != "")
                            {
                                if (pk == 1)
                                {
                                    columnsValue += strAr;
                                    pk++;
                                }
                                else
                                {
                                    columnsValue += ", "+strAr;
                                }
               
                            }
                        }

                        SQLiteCommand cmd;
                        cmd = sqlite_conn.CreateCommand();

                         cmd.CommandText = @"INSERT INTO Premeti(" + koloni + ")  VALUES (" + columnsValue + ")";
                       // string kveri = $"INSERT INTO Premeti(" + koloni + ")  VALUES (" + columnsValue + ")";
                        //cmd.CommandText = kveri;    
                        cmd.ExecuteNonQuery();
                      //  cmd.Parameters.AddWithValue("@godini", godini);
                        MessageBox.Show(string.Join(Environment.NewLine, strArray));
                        //  listView1.Items.Add(new ListViewItem(strArray));
                    }

                }
            }
            catch (System.Exception excpt) { MessageBox.Show("Imate greska pri otvaranje na excel"+excpt); }  

        }

        private void btnPrikaziBaza_Click(object sender, EventArgs e)
        {
            try
            {
                //SQLiteConnection sqlite_conn;
                //sqlite_conn = CreateConnection();
                //ReadData(sqlite_conn);
            }
            catch
            {
                MessageBox.Show("Problem so prikazuvanjeto na podatocite");
            }
        }
    }
}
