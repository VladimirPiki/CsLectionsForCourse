using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data.Common;
using System.Data.SQLite;
using static Z68.OcenkiOneToMany.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;
using OfficeOpenXml;
using System.Reflection;
using System.Globalization;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace Z68.OcenkiOneToMany
{

    public partial class Form1 : Form
    {
        static public string prosekKlas;

        static public List<string> prosekUcenikIme = new List<string>();
        static public List<string> prosekUcenikProsek = new List<string>();

        static public List<string> prosekPredmetIme = new List<string>();
        static public List<string> prosekPredmetProsek = new List<string>();

        static public List<string[]> distribucijaOcenkiLista = new List<string[]>();
        static public List<string[]> otstapvanjeOcenkiLista = new List<string[]>();
        static public List<string[]> slabiOcenkiLista = new List<string[]>();

        private Excel.Application ExcelObj = null;

     

        public void ThreadProc()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8080);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
                //  MessageBox.Show("Serverot e aktiviran");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            while (true)
            {
                client = server.AcceptTcpClient();
                byte[] receivedBuffer = new byte[1024];
                NetworkStream stream = client.GetStream();
                stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                int count = Array.IndexOf<byte>(receivedBuffer, 0, 0);

                //  string msg = Encoding.ASCII.GetString(receivedBuffer, 0, count);
               // byte[] sendData = Encoding.ASCII.GetBytes(msg);
                string msg = Encoding.UTF8.GetString(receivedBuffer, 0, count);// KIRILICA UTF8
                byte[] sendData = Encoding.UTF8.GetBytes(msg);// KIRILICA UTF8
                int b = sendData.Length;
              //  MessageBox.Show(msg);
               SelectWhere(msg);
            }
        }

        //Za excel 
        public void ThreadProcExcel()
        {
            TcpListener server = null;
            try
            {
                // Set the IP address and port number for the server
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 1027;

                System.Threading.Thread.Sleep(1000);
                // Create a TcpListener to listen for incoming connections
                server = new TcpListener(ipAddress, port);

                // Start listening for client requests
                server.Start();

                //MessageBox.ShowLine("Server is waiting for connections...");

                while (true)
                {
                    // Accept a client connection
                    TcpClient client = server.AcceptTcpClient();
                    // MessageBox.ShowLine("Client connected!");

                    // Get the network stream for reading
                    NetworkStream stream = client.GetStream();

                    // Receive the file name and create a file stream to save the Excel file
                    byte[] fileNameData = new byte[1024];
                    int fileNameBytesRead = stream.Read(fileNameData, 0, fileNameData.Length);
                    string fileName = Encoding.UTF8.GetString(fileNameData, 0, fileNameBytesRead);//КИРИЛИЦА UTF8 NAMESTO ASCII bidejki ne ja cita kirilicata
                    fileName = Path.GetFileName(fileName);
                    FileStream fileStream = File.Create(fileName);

                    // Receive and save the Excel file data
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                   // MessageBox.Show($"Excel file '{fileName}' received and saved.");

                    // Close the client connection and file stream
                    fileStream.Close();
                    client.Close();
                    CreateTableAndInsertExcel(fileName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: ThreadProcExcel" + e.Message);
            }
            finally
            {
                // Stop listening for incoming connections
                server.Stop();
            }
        }



        public Form1()
        {

            InitializeComponent();         

            Thread threadClient = new Thread(t =>
            {
                ThreadProc();
            })
            {
                IsBackground = true
            };
            threadClient.Start();



            //thread za Excel file
            Thread threadExcel = new Thread(t =>
            {
                ThreadProcExcel();
            })
            {
                IsBackground = true
            };
            threadExcel.Start();


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

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

        /*static void CreateTableAndInsertExcel(string fileName)
        {
            try
            {
                string connectionString = "Data Source=Z76_SQLiteServerOneToMany.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                objSql.CreateTables();

                FileInfo excelFile = new FileInfo(fileName);
                using (var package = new ExcelPackage(excelFile))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    //MessageBox.Show($"Contents of Excel file '{fileName}':");
                    List<string> koloniUcenici = new List<string>();
                    List<string> koloniOcenki = new List<string>();
                    for (int row = 1; row <= 1; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            if (worksheet.Cells[row, col].Text != "")
                            {
                                string result = worksheet.Cells[row, col].Text.Replace(' ', '_');
                                result = result.Replace('(', '_');
                                result = result.Replace(')', '_');
                                result = result.Replace('.', '_');
                                if(col < 6)
                                {
                                    koloniUcenici.Add(result);
                                }
                                else
                                {
                                    koloniOcenki.Add(result);   
                                }
                 
                            }

                        }
                    }
                    koloniOcenki.Add("UceniciEMB");
                    List<string> vrednostiUcenici = new List<string>();
                    List<string> vrednostiOcenki = new List<string>();
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string maticen = "";
                        for (int col = 1; col <= colCount; col++)
                        {
                            if (worksheet.Cells[row, col].Text != "")
                            {
                                string result = worksheet.Cells[row, col].Text.Replace(' ', '_');
                                result = result.Replace('(', '_');
                                result = result.Replace(')', '_');
                                result = result.Replace('.', '_');

                                if(col == 1)
                                {
                                    maticen = result;   
                                }

                                if (col < 6)
                                {
                                    
                                    vrednostiUcenici.Add(result);
                                }
                                else
                                {
                                    vrednostiOcenki.Add(result);
                                }
                            }    
                        }
                        vrednostiOcenki.Add(maticen);
                        objSql.InsertRow(koloniUcenici, vrednostiUcenici, "Ucenici");
                        objSql.InsertRow(koloniOcenki, vrednostiOcenki, "Ocenki");

                        vrednostiUcenici.Clear();
                        vrednostiOcenki.Clear();

                    }
                    MessageBox.Show("Uspesno vnesivte vo baza");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima probelm pri vnesuvanjeto vo baza "+ex);
            }

        }*/

        public void CreateTableAndInsertExcel(string fileName)
        {
            try
            {
                Klasi objKlasi = new Klasi();
                string connectionString = "Data Source=Z76_SQLiteServerOneToMany.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                objSql.CreateTables();

                FileInfo excelFile = new FileInfo(fileName);

                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(excelFile.FullName, 0, true, 5,"", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                Excel.Sheets sheets = theWorkbook.Worksheets;
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1); 

                int lastUsedRow = 0;
                lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                // Find the last real column
                int lastUsedColumn = 0;
                lastUsedColumn = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                 System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                 Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious,
                                                 false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;


                string columnName = Klasi.ExcelColumnFromNumber(lastUsedColumn);

                List<string> koloniUcenici = new List<string>();
                List<string> koloniOcenki = new List<string>();
                for (int i = 1; i <= 1; i++)
                {
                    Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                    System.Array myvalues = (System.Array)range.Cells.Value;
                    string[] strArray1 = objKlasi.ConvertToStringArray(myvalues);
                    //  int primaryKey = 1;

                    for (int a=0;a < strArray1.Length; a++)
                    {
                        if(strArray1[a] != "")
                        {
                            string result = strArray1[a].Replace(' ', '_');
                            result = result.Replace('(', '_');
                            result = result.Replace(')', '_');
                            result = result.Replace('.', '_');
                            if (a < 5)
                            {
                                koloniUcenici.Add(result);
                            }
                            else
                            {
                                koloniOcenki.Add(result);
                            }
                        }
                      
                    }
                }
                koloniOcenki.Add("UceniciEMB");

                for (int i = 2; i <= lastUsedRow; i++)
                {
                    List<string> vrednostiUcenici = new List<string>();
                    List<string> vrednostiOcenki = new List<string>();
                    Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                    System.Array myvalues = (System.Array)range.Cells.Value;
                    string[] strArray = objKlasi.ConvertToStringArray(myvalues);
                    //  int primaryKey = 1;
                    string maticen = "";
                    for (int col = 0; col < strArray.Length; col++)
                    {
                       //test =strArray[col]+" ";
                        if (strArray[col] != "")
                        {
                            string result = strArray[col].Replace(' ', '_');
                            result = result.Replace('(', '_');
                            result = result.Replace(')', '_');
                            result = result.Replace('.', '_');

                            if (col == 0)
                            {
                                maticen = result;
                            }

                            if (col < 5)
                            {
                                vrednostiUcenici.Add(result);
                            }
                            else
                            {
                                vrednostiOcenki.Add(result);
                  
                            }
                        }

                    }
                    vrednostiOcenki.Add(maticen);
                    objSql.InsertRow(koloniUcenici, vrednostiUcenici, "Ucenici");
                    objSql.InsertRow(koloniOcenki, vrednostiOcenki, "Ocenki");

                    vrednostiUcenici.Clear();
                    vrednostiOcenki.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima probelm pri vnesuvanjeto vo baza " + ex);
            }

        }

            public void SelectWhere(string kveri)
            {
                try
                {
                    string exportPath = "";
                  //  string patekaZaIsprakjanje = "";
                    string connectionString = "Data Source=Z76_SQLiteServerOneToMany.db;Version=3;";
                    SQLiteManager objSql = new SQLiteManager(connectionString);
                    //   objSql.CreateTables();
                    SQLiteDataReader reader;
                    // reader=objSql.SelectFromToExcel(kveri);
                    reader = objSql.SelectFrom(kveri);

                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                    {
                        Excel.Workbook wb = ExcelObj.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)ExcelObj.ActiveSheet;
                        ExcelObj.Visible = true;

                    int col = 1;
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ws.Cells[1, col].Value = reader.GetName(i);
                        col++;
                    }
                    int row = 2;
                    while (reader.Read())
                    {
                        col = 1;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            ws.Cells[row, col].Value = reader[i].ToString();
                            col++;
                        }
                        row++;
                    };

                     objSql.CloseConnection();

                        string debugDirectory1 = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        // string exportPath = Path.Combine(debugDirectory1, "sqlRezulatatOdPrebarvanjeto.xlsx");
                        exportPath = Path.Combine(debugDirectory1, "sqlRezulatatOdPrebarvanjeto.xlsx");
                        if (File.Exists(exportPath))//ovaa raboti
                        {
                            File.Delete(exportPath);
                        }
                        wb.SaveAs(exportPath);
                       // patekaZaIsprakjanje = exportPath;

                        ExcelObj.Quit();
                    }

                    //System.Threading.Thread.Sleep(1000);

                    if (exportPath != "")
                    {
                        ////Od tuka se isprakja do client
                        // Set the server IP address and port number
                        string serverIp = "127.0.0.1";
                        int serverPort = 1234;//1234   1027
                    System.Threading.Thread.Sleep(1000);
                    // Create a TcpClient to connect to the server
                    TcpClient client1 = new TcpClient(serverIp, serverPort);
                        //  MessageBox.Show("Connected to server.");

                        // Get the network stream for reading and writing
                        NetworkStream stream1 = client1.GetStream();

                        // Specify the Excel file to send
                        string imeNaDadoteka = Path.GetFileName(exportPath);
                        string filePath = imeNaDadoteka;

                        // Send the file name to the server
                        byte[] fileNameData = Encoding.ASCII.GetBytes(Path.GetFileName(filePath));
                        stream1.Write(fileNameData, 0, fileNameData.Length);

                        // Send the Excel file data to the server
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        using (FileStream fileStream = File.OpenRead(filePath))
                        {
                            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                stream1.Write(buffer, 0, bytesRead);
                            }
                        }

                        // Close the client connection
                        client1.Close();
                        //Do tuka se isprakja do client
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ima problem so prikazvanjeto na podatocite !!!" +ex);
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbTromesecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProsekKlas_Click(object sender, EventArgs e)
        {
            ModalessProsekKlas objModalessProsekKlas = new ModalessProsekKlas();
            objModalessProsekKlas.Show();
        }

        private void btnProsekPredmet_Click(object sender, EventArgs e)
        {
            ModalessProsekPredmeti objModalessProsekPredmeti = new ModalessProsekPredmeti();
            objModalessProsekPredmeti.Show();
        }

        private void btnOtstapuvanjePredmet_Click(object sender, EventArgs e)
        {
            ModalessOtstapuvanjePredmeti objModalessOtstapuvanjePredmeti = new ModalessOtstapuvanjePredmeti();
            objModalessOtstapuvanjePredmeti.Show();
        }

        private void btnDistribucijaOtcenki_Click(object sender, EventArgs e)
        {
            ModalessDistribucijaOcenki objModalessDistribucijaOcenki = new ModalessDistribucijaOcenki();
            objModalessDistribucijaOcenki.Show();
        }

        private void btnUceniciSlabiOcenki_Click(object sender, EventArgs e)
        {
            ModalessSlabiOcenki objModalessSlabiOcenki = new ModalessSlabiOcenki();
            objModalessSlabiOcenki.Show();
        }

        private void btnPrezPodatoci_Click(object sender, EventArgs e)
        {
            Klasi objKlasi = new Klasi();
            listView1.Clear();
            listView1.Columns.Clear();
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

                    // Find the last real column
                    int lastUsedColumn = 0;
                    lastUsedColumn = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                     System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                     Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious,
                                                     false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;


                    string columnName = Klasi.ExcelColumnFromNumber(lastUsedColumn);


                    for (int i = 1; i <= 1; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray1 = objKlasi.ConvertToStringArray(myvalues);
                        //  int primaryKey = 1;

                        foreach (var strAr in strArray1)
                        {

                            if (strAr != "")
                            {
                                string result = strAr.Replace(' ', '_');
                                result = result.Replace('(', '_');
                                result = result.Replace(')', '_');
                                result = result.Replace('.', '_');
                                listView1.Columns.Add(result, 120);
                            }
                        }

                    }

                    for (int i = 2; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = objKlasi.ConvertToStringArray(myvalues);
                        ListViewItem itm;
                        itm = new ListViewItem(strArray);
                        listView1.Items.Add(itm);
                    }

                    // sreden prosek na klas
                    List<string> prosekOcenki = new List<string>();
                    for (int i = 2; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("F" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;

                        string[] strArray = objKlasi.ConvertToStringArray(myvalues);

                        foreach (var vrednosti in strArray)
                        {
                            prosekOcenki.Add(vrednosti);
                        }


                    }

                    // MessageBox.Show(string.Join(Environment.NewLine, prosekOcenki));
                    double reshenie = objKlasi.SredenProsekNaOcenki(prosekOcenki);
                    //MessageBox.Show(reshenie.ToString());
                    prosekKlas = reshenie.ToString();
                    //sreden prosek na klas

                    //Prosek po ucenik
                    for (int i = 2; i <= lastUsedRow; i++)
                    {

                        Excel.Range range = worksheet.get_Range("B" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;

                        string[] strArray = objKlasi.ConvertToStringArray(myvalues);
                        string imeNaUcenik = "";
                        List<string> prosekOcenkiUcenik = new List<string>();
                        int kolkuEdiniciIma = 0;
                        //MessageBox.Show(string.Join(Environment.NewLine, strArray));//prikazi vo poraka
                        foreach (var strAr in strArray)
                        {
                            double ocenki;
                            if (strAr != "")
                            {
                                bool daliEocenka = Double.TryParse(strAr, out ocenki);
                                if (daliEocenka)
                                {
                                    prosekOcenkiUcenik.Add(strAr);
                                    if (ocenki == 1)
                                    {
                                        kolkuEdiniciIma++;
                                    }
                                }
                                else
                                {
                                    imeNaUcenik += " " + strAr;
                                }
                            }


                        }
                        if (kolkuEdiniciIma > 0)
                        {
                            string[] arrSlabiOcenki = new string[2];

                            arrSlabiOcenki[0] = imeNaUcenik.ToString();
                            arrSlabiOcenki[1] = kolkuEdiniciIma.ToString();

                            slabiOcenkiLista.Add(arrSlabiOcenki);
                            // MessageBox.Show(imeNaUcenik + " " + kolkuEdiniciIma.ToString());
                        }

                        double prosekNaUcenikot = objKlasi.SredenProsekNaOcenki(prosekOcenkiUcenik);

                        prosekUcenikIme.Add(imeNaUcenik.ToString());
                        prosekUcenikProsek.Add(prosekNaUcenikot.ToString());
                        prosekOcenkiUcenik.Clear();
                    }
                    //Prosek po ucenik

                    //prosek po predmet
                    List<string> prosek = new List<string>();
                    List<string> vrednostiDistribucija = new List<string>();//Distribucija na ocenki
                    List<string> prosekOtstapuvanja = new List<string>();//Otstapuvanje na ocenki
                    string imeNaPredmet = "";
                    double reshenieProsek = 0;
                    List<string> prosekPredmetiIme = new List<string>();

                    List<string> predmeti = new List<string>() { "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };
                    foreach (var p in predmeti)
                    {
                        if (p[0] <= columnName[0])
                        {

                            for (int i = 1; i <= lastUsedRow; i++)
                            {
                                Excel.Range range = worksheet.get_Range(p + i.ToString());
                                if (range != null && range.Value2 != null)
                                {
                                    string cellValue = range.Value2.ToString();
                                    if (i == 1)
                                    {
                                        if (cellValue != "")
                                        {
                                            imeNaPredmet = cellValue;
                                        }

                                    }
                                    else
                                    {
                                        prosek.Add(cellValue);
                                        vrednostiDistribucija.Add(cellValue);//Distribucija na ocenki
                                        prosekOtstapuvanja.Add(cellValue);//Otstapvanje na ocenki
                                    }

                                }

                            }

                            reshenieProsek = objKlasi.SredenProsekNaOcenki(prosek);
                            prosekPredmetIme.Add(imeNaPredmet.ToString());
                            prosekPredmetProsek.Add(reshenieProsek.ToString());

                            //Distribucija ocenki
                            string[] arrDistribucija = new string[6];

                            arrDistribucija[0] = imeNaPredmet.ToString();

                            var distribucija = objKlasi.Distribucija(vrednostiDistribucija);
                            foreach (var d in distribucija)
                            {
                                if (d.Key == 1)
                                {
                                    arrDistribucija[1] = d.Value.ToString();
                                }
                                else if (d.Key == 2)
                                {
                                    arrDistribucija[2] = d.Value.ToString();
                                }
                                else if (d.Key == 3)
                                {
                                    arrDistribucija[3] = d.Value.ToString();
                                }
                                else if (d.Key == 4)
                                {
                                    arrDistribucija[4] = d.Value.ToString();
                                }
                                else if (d.Key == 5)
                                {
                                    arrDistribucija[5] = d.Value.ToString();
                                }
                            }

                            distribucijaOcenkiLista.Add(arrDistribucija);
                            //distribucija ocenki

                            double otstapvanje, sredenProsek;
                            bool tryParseB = Double.TryParse(prosekKlas, out sredenProsek);
                            if (tryParseB)
                            {
                                otstapvanje = reshenieProsek - sredenProsek;
                                string[] arrOtstapvanje = new string[2];

                                arrOtstapvanje[0] = imeNaPredmet.ToString();
                                arrOtstapvanje[1] = otstapvanje.ToString();

                                otstapvanjeOcenkiLista.Add(arrOtstapvanje);

                            }

                            reshenieProsek = 0;
                            prosek.Clear();
                            vrednostiDistribucija.Clear();
                            prosekOtstapuvanja.Clear();

                        }
                    }


                }
            }
            catch (System.Exception excpt) { MessageBox.Show("Imate greska pri otvaranje na excel" + excpt); }
        }

        private void btnNapraviExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Workbook wb = ExcelObj.Workbooks.Add(XlSheetType.xlWorksheet);
                            Worksheet ws = (Worksheet)ExcelObj.ActiveSheet;
                            ExcelObj.Visible = true;
                            int a = 1;
                            int k = 1;
                            int i = 2;
                  
                            foreach (ColumnHeader header in listView1.Columns)
                            {
                                //  MessageBox.Show(header.Text);
                                ws.Cells[a, k] = header.Text;
                                k++;
                            }
                            foreach (ListViewItem item in listView1.Items)
                            {
                                int v = 1;
                                for (int j = 0; j < item.SubItems.Count; j++)
                                {
                                    ws.Cells[i, v] = item.SubItems[j].Text;
                                    v++;
                                }
                                i++;
                                v = 0;
                            }

                            // wb.SaveAs(sfd.FileName,XlFileFormat.xlWorkbookDefault,Type.Missing,Type.Missing,true,false,XlSaveAsAccessMode.xlNoChange,XlSaveConflictResolution.xlLocalSessionChanges);
                            wb.SaveAs(sfd.FileName);
                            tbAttachemt.Text = sfd.FileName;

                            ExcelObj.Quit();
                            MessageBox.Show("Uspeshno e exportirana dadotekata");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ve molam vneste podatoci vo listview");
                }

            }
            catch
            {
                MessageBox.Show("Ima problem so exportiranjeto na excel dadotekata");
            }
        }

        private void btnIspratiMeil_Click(object sender, EventArgs e)
        {
            ModalMeil modalMeil = new ModalMeil();
            modalMeil.ShowDialog(); 
        }

        private void btnSnimiPodatoci_Click(object sender, EventArgs e)
        {
            List<string> listView = new List<string>();
            listView.Add("Клас");
            listView.Add("Смер");
            listView.Add("Тромесечие");
            listView.Add("Учебна_Година");
            //     MessageBox.Show(cbGodinaKlas.Text);
            List<string> ucenicivrednostiListview = new List<string>();
            foreach (ColumnHeader item in listView1.Columns)
            {
                if (item.Text == "EMB" || item.Text == "Презиме" || item.Text == "Татково_име" || item.Text == "Име" || item.Text == "Место")
                {
                    ucenicivrednostiListview.Add(item.Text);
                }
                else
                {
                    listView.Add(item.Text);
                }

            }
            listView.Add("UceniciEMB");//Maticen kolona

            if (listView1.Items.Count > 0)
            {
                if (cbKlas.Text != "Изберете клас" && cbSmer.Text != "Изберете смер" && cbTromesecie.Text != "Изберете тромесечие" && cbUcebnaGodina.Text != "Изберете учебна година")
                {

                    try
                    {

                        string connectionString = "Data Source=Z76_SQLiteServerOneToMany.db;Version=3;";
                        SQLiteManager objSql = new SQLiteManager(connectionString);
                        objSql.CreateTables();

                        foreach (ListViewItem item in listView1.Items)
                        {
                            List<string> listViewValues = new List<string> { cbKlas.Text, cbSmer.Text, cbTromesecie.Text, cbUcebnaGodina.Text };
                            List<string> listViewValuesUcenici = new List<string>();
                            string maticen = "";

                            for (int i = 0; i < item.SubItems.Count; i++)
                            {
                                if (i > 4)
                                {
                                    listViewValues.Add(item.SubItems[i].Text);
                                }
                                else
                                {
                                    listViewValuesUcenici.Add(item.SubItems[i].Text);
                                    if (i == 0)
                                    {
                                        maticen = item.SubItems[i].Text;
                                    }
                                }
                            }
                            listViewValues.Add(maticen);


                            objSql.InsertRow(listView, listViewValues, "Ocenki");
                            objSql.InsertRow(ucenicivrednostiListview, listViewValuesUcenici, "Ucenici");
                        }
                        MessageBox.Show("Uspesno gi vnesivte site podatoci vo baza");

                        listView1.Items.Clear();
                        listView1.Columns.Clear();

                        listView1.Columns.Add("EMB", 40);
                        listView1.Columns.Add("Презиме", 40);
                        listView1.Columns.Add("Татково_име", 40);
                        listView1.Columns.Add("Име", 40);
                        listView1.Columns.Add("Место", 40);
                        listView1.Columns.Add("ID", 40);
                        listView1.Columns.Add("Клас", 40);
                        listView1.Columns.Add("Смер", 40);
                        listView1.Columns.Add("Тромесечие", 40);
                        listView1.Columns.Add("Учебна_Година", 40);
                        listView1.Columns.Add("Македонски_јазик", 40);
                        listView1.Columns.Add("Математика", 40);
                        listView1.Columns.Add("Англиски_јазик", 40);
                        listView1.Columns.Add("Програмирање", 40);
                        listView1.Columns.Add("Физика", 40);
                        listView1.Columns.Add("Автоматика", 40);
                        listView1.Columns.Add("Објектно_ориентирано_програмирање", 40);
                        listView1.Columns.Add("Музика", 40);
                        listView1.Columns.Add("Изборен", 40);
                        listView1.Columns.Add("Практична_настава", 40);
                        listView1.Columns.Add("Статистика", 40); ;
                        listView1.Columns.Add("UceniciEMB", 40);


                        var sqlite_datareader = objSql.SelectFrom("Ucenici INNER JOIN Ocenki ON Ucenici.EMB = Ocenki.UceniciEMB");

                        while (sqlite_datareader.Read())
                        {
                            string[] arr = new string[22];
                            ListViewItem itm;

                            arr[0] = sqlite_datareader.GetValue(0).ToString();
                            arr[1] = sqlite_datareader.GetValue(1).ToString();
                            arr[2] = sqlite_datareader.GetValue(2).ToString();
                            arr[3] = sqlite_datareader.GetValue(3).ToString();
                            arr[4] = sqlite_datareader.GetValue(4).ToString();
                            arr[5] = sqlite_datareader.GetValue(5).ToString();
                            arr[6] = sqlite_datareader.GetValue(6).ToString();
                            arr[7] = sqlite_datareader.GetValue(7).ToString();
                            arr[8] = sqlite_datareader.GetValue(8).ToString();
                            arr[9] = sqlite_datareader.GetValue(9).ToString();
                            arr[10] = sqlite_datareader.GetValue(10).ToString();
                            arr[11] = sqlite_datareader.GetValue(11).ToString();
                            arr[12] = sqlite_datareader.GetValue(12).ToString();
                            arr[13] = sqlite_datareader.GetValue(13).ToString();
                            arr[14] = sqlite_datareader.GetValue(14).ToString();
                            arr[15] = sqlite_datareader.GetValue(15).ToString();
                            arr[16] = sqlite_datareader.GetValue(16).ToString();
                            arr[17] = sqlite_datareader.GetValue(17).ToString();
                            arr[18] = sqlite_datareader.GetValue(18).ToString();
                            arr[19] = sqlite_datareader.GetValue(19).ToString();
                            arr[20] = sqlite_datareader.GetValue(20).ToString();
                            arr[21] = sqlite_datareader.GetInt64(21).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }


                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so zapisuvanjeto vo LISTVIEW !!!");
                    }
                }
                else
                {
                    MessageBox.Show("ZADOLZITELNO IZBERETE gi site opcii za vnesuvanje: klas, smer, tromesecie, ucebna godina");
                }

            }
            else
            {
                MessageBox.Show("Vnesete dadoteka vo listView !!!");
            }

        }

        private void btnPrezemiPodatoci_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> koloni = new List<string>();
                List<string> vrednosti = new List<string>();

                if (tbMaticenBr.Text != "")
                {
                    koloni.Add("EMB=");
                    vrednosti.Add(tbMaticenBr.Text);
                }
                if (cbKlas.Text != "Изберете клас")
                {
                    koloni.Add("Клас=");
                    vrednosti.Add(cbKlas.Text);
                }
                if (cbSmer.Text != "Изберете смер")
                {
                    koloni.Add("Смер=");
                    vrednosti.Add(cbSmer.Text);
                }
                if (cbTromesecie.Text != "Изберете тромесечие")
                {
                    koloni.Add("Тромесечие=");
                    vrednosti.Add(cbTromesecie.Text);
                }
                if (cbUcebnaGodina.Text != "Изберете учебна година")
                {

                    koloni.Add("Учебна_Година=");
                    vrednosti.Add(cbUcebnaGodina.Text);
                }


                string where = "Ucenici INNER JOIN Ocenki ON Ucenici.EMB = Ocenki.UceniciEMB WHERE ";
                for (int i = 0; i < vrednosti.Count; i++)
                {

                    if (i < vrednosti.Count - 1)
                    {
                        where = where + koloni[i] + "'" + vrednosti[i] + "'" + " AND ";

                    }
                    else
                    {
                        where = where + koloni[i] + "'" + vrednosti[i] + "'";
                    }
                }
                richTextBox1.Text = where;

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("EMB", 40);
                listView1.Columns.Add("Презиме", 40);
                listView1.Columns.Add("Татково_име", 40);
                listView1.Columns.Add("Име", 40);
                listView1.Columns.Add("Место", 40);
                listView1.Columns.Add("ID", 40);
                listView1.Columns.Add("Клас", 40);
                listView1.Columns.Add("Смер", 40);
                listView1.Columns.Add("Тромесечие", 40);
                listView1.Columns.Add("Учебна_Година", 40);
                listView1.Columns.Add("Македонски_јазик", 40);
                listView1.Columns.Add("Математика", 40);
                listView1.Columns.Add("Англиски_јазик", 40);
                listView1.Columns.Add("Програмирање", 40);
                listView1.Columns.Add("Физика", 40);
                listView1.Columns.Add("Автоматика", 40);
                listView1.Columns.Add("Објектно_ориентирано_програмирање", 40);
                listView1.Columns.Add("Музика", 40);
                listView1.Columns.Add("Изборен", 40);
                listView1.Columns.Add("Практична_настава", 40);
                listView1.Columns.Add("Статистика", 40); ;
                listView1.Columns.Add("UceniciEMB", 40);

                if(vrednosti.Count > 0 && koloni.Count > 0)
                {
                    string connectionString = "Data Source=Z76_SQLiteServerOneToMany.db;Version=3;";
                    SQLiteManager objSql = new SQLiteManager(connectionString);
                    var sqlite_datareader = objSql.SelectFrom(where);

                    while (sqlite_datareader.Read())
                    {
                        string[] arr = new string[22];
                        ListViewItem itm;

                        arr[0] = sqlite_datareader.GetValue(0).ToString();
                        arr[1] = sqlite_datareader.GetValue(1).ToString();
                        arr[2] = sqlite_datareader.GetValue(2).ToString();
                        arr[3] = sqlite_datareader.GetValue(3).ToString();
                        arr[4] = sqlite_datareader.GetValue(4).ToString();
                        arr[5] = sqlite_datareader.GetValue(5).ToString();
                        arr[6] = sqlite_datareader.GetValue(6).ToString();
                        arr[7] = sqlite_datareader.GetValue(7).ToString();
                        arr[8] = sqlite_datareader.GetValue(8).ToString();
                        arr[9] = sqlite_datareader.GetValue(9).ToString();
                        arr[10] = sqlite_datareader.GetValue(10).ToString();
                        arr[11] = sqlite_datareader.GetValue(11).ToString();
                        arr[12] = sqlite_datareader.GetValue(12).ToString();
                        arr[13] = sqlite_datareader.GetValue(13).ToString();
                        arr[14] = sqlite_datareader.GetValue(14).ToString();
                        arr[15] = sqlite_datareader.GetValue(15).ToString();
                        arr[16] = sqlite_datareader.GetValue(16).ToString();
                        arr[17] = sqlite_datareader.GetValue(17).ToString();
                        arr[18] = sqlite_datareader.GetValue(18).ToString();
                        arr[19] = sqlite_datareader.GetValue(19).ToString();
                        arr[20] = sqlite_datareader.GetValue(20).ToString();
                        arr[21] = sqlite_datareader.GetInt64(21).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);

                    }
                }
                else
                {
                    MessageBox.Show("Ve molam vnesete prebaruvanje !!!");
                }
               
            }
            catch (Exception expt)
            {
                MessageBox.Show("Ima problem so prikazvuvanjeto na podatoicte " + expt);
            }

        }

        private void btnProsekUcenik_Click(object sender, EventArgs e)
        {
            ModalessProsekUcenik objModalessProsekUcenik = new ModalessProsekUcenik();
            objModalessProsekUcenik.Show();
        }

     

    }
}
