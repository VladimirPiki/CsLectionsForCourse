using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Packaging;
using System.Threading;
using static Z75.ServerPodatoci.Database;
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Runtime.InteropServices.ComTypes;

namespace Z75.ServerPodatoci
{
    public partial class Form1 : Form
    {
        private Excel.Application ExcelObj = null;
        //Za komunikacija tred
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

                string msg = Encoding.ASCII.GetString(receivedBuffer, 0, count);
                byte[] sendData = Encoding.ASCII.GetBytes(msg);
                int b = sendData.Length;

                tbExcelZaIsprakjanje.Clear();

                List<string> porakaPrimena = razdeli(msg);
                List<string> koloniVrednosti = new List<string>();


                switch (porakaPrimena[0])
                {
                    case "podatociLicnost":
                        for (int i = 1; i < porakaPrimena.Count; i++)
                        {
                            koloniVrednosti.Add(porakaPrimena[i]);
                        }
                        InsertInto(koloniVrednosti);
                        break;
                    case "prebarajIme":
                        Select("ime='" + porakaPrimena[1] + "'");
                        break;
                    case "prebarajPrezime":
                        Select("prezime='" + porakaPrimena[1] + "'");
                        break;
                    case "prebarajGodini":
                        Select("godini='" + porakaPrimena[1] + "'");
                        break;
                    default:
                        MessageBox.Show("Ne e primena nikakva poraka");
                        break;
                }


                //tbPrimiPoraka.Clear();
                //tbPrimiPoraka.Text = msg;

                //Messagex.Show(msg);

            }
        }

        //Za file tred
        public void ThreadProcFile()
        {
            TcpListener server = null;
            try
            {
                // Set the IP address and port number for the server
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 1025;

                // Create a TcpListener to listen for incoming connections
                server = new TcpListener(ipAddress, port);

                // Start listening for client requests
                server.Start();

                // MessageBox.ShowLine("Server is waiting for connections...");

                while (true)
                {
                    // Accept a client connection
                    TcpClient client = server.AcceptTcpClient();
                    //MessageBox.Show("Client connected!");

                    // Get the network stream for reading
                    NetworkStream stream = client.GetStream();

                    // Receive the file name and create a file stream to save the file
                    byte[] fileNameData = new byte[1024];
                    int fileNameBytesRead = stream.Read(fileNameData, 0, fileNameData.Length);
                    string fileName = Encoding.ASCII.GetString(fileNameData, 0, fileNameBytesRead);
                    fileName = Path.GetFileName(fileName);
                    FileStream fileStream = File.Create(fileName);

                    // Receive and save the file data
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                  //
                  //MessageBox.Show($"File '{fileName}' received and saved.");

                    // Close the client connection and file stream
                    fileStream.Close();
                    client.Close();
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                // Stop listening for incoming connections
                server.Stop();
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
                    string fileName = Encoding.ASCII.GetString(fileNameData, 0, fileNameBytesRead);
                    fileName = Path.GetFileName(fileName);
                    FileStream fileStream = File.Create(fileName);

                    // Receive and save the Excel file data
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                    MessageBox.Show($"Excel file '{fileName}' received and saved.");

                    // Close the client connection and file stream
                    fileStream.Close();
                    client.Close();

                    // Read and display the contents of the Excel file (optional)
                    CreateTableAndInsertExcel(fileName); ///RABOTI
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


            // Thread za primanje na tekst
            Thread thread = new Thread(t =>
            {
                ThreadProc();
            })
            {
                IsBackground = true
            };
            thread.Start();

            //Thread za primanje na text file
            Thread threadFile = new Thread(t =>
            {
                ThreadProcFile();
            })
            {
                IsBackground = true
            };
            threadFile.Start();

            //thread za Excel file
            Thread threadExcel = new Thread(t =>
            {
                ThreadProcExcel();
            })
            {
                IsBackground = true
            };
            threadExcel.Start();

            ExcelObj = new Excel.Application();

            if (ExcelObj == null)
            {
                MessageBox.Show("ERROR: EXCEL couldn't be started!");
                System.Windows.Forms.Application.Exit();
            }

            ExcelObj.Visible = true;


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ime", 200);
            listView1.Columns.Add("prezime", 200);
            listView1.Columns.Add("godini", 200);

          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiteZapisi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=Licnosti.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                var sqlite_datareader = objSql.PrikaziGiSite();
                listView1.Items.Clear();
                while (sqlite_datareader.Read())
                {

                    string[] arr = new string[3];
                    ListViewItem itm;

                    arr[0] = sqlite_datareader.GetValue(0).ToString();
                    arr[1] = sqlite_datareader.GetValue(1).ToString();
                    arr[2] = sqlite_datareader.GetValue(2).ToString();

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima problem so prikazvanjeto na site podatoci ! " + ex);
            }
        }

        //Classi
        public void InsertInto(List<string> koloniVrednosti)
        {
            string connectionString = "Data Source=Licnosti.db;Version=3;";
            SQLiteManager objSql = new SQLiteManager(connectionString);
            List<string> koloni = new List<string>() { "ime", "prezime", "godini" };
            objSql.CreateTable(koloni);
            objSql.InsertRow(koloni, koloniVrednosti);
            MessageBox.Show("Uspesno vnesivte vo baza");
        }

        public List<string> razdeli(string str)
        {
            List<string> list = new List<string>();
            string prazenStr = "";
            string split = "#";
            for (int a = 0; a < str.Length; a++)
            {
                foreach (char s in split)
                {
                    if (str[a] != s)
                    {
                        prazenStr += str[a];
                        if (a == str.Length - 1)
                        {
                            list.Add(prazenStr);
                        }
                    }
                    else
                    {
                        list.Add(prazenStr); ;
                        prazenStr = "";
                    }
                }
            }
            return list;
        }

        static void CreateTableAndInsertExcel(string fileName)
        {
            try
            {
                string connectionString = "Data Source=Licnosti.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);

                FileInfo excelFile = new FileInfo(fileName);
                using (var package = new ExcelPackage(excelFile))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    //MessageBox.Show($"Contents of Excel file '{fileName}':");
                    List<string> koloni = new List<string>();
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
                                koloni.Add(result);
                            }

                        }
                    }
                    objSql.CreateTable(koloni);

                    List<string> koloniVrednosti = new List<string>();
                    for (int row = 2; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            if (worksheet.Cells[row, col].Text != "")
                            {
                                string result = worksheet.Cells[row, col].Text.Replace(' ', '_');
                                result = result.Replace('(', '_');
                                result = result.Replace(')', '_');
                                result = result.Replace('.', '_');
                                koloniVrednosti.Add(result);
                            }
                            // Console.Write(worksheet.Cells[row, col].Text + "\t");           
                        }
                        // MessageBox.Show();
                        objSql.InsertRow(koloni, koloniVrednosti);
                        koloniVrednosti.Clear();

                    }
                    MessageBox.Show("Uspesno vnesivte vo baza");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima probelm pri vnesuvanjeto vo baza");
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

       public void ExcelDoSql(string fileName)
        {

            try
            {
                bool daliEprebaruvanje = false;
                string clientPrebaruvanje = "";
                string connectionString = "Data Source=Licnosti.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);

                FileInfo excelFile = new FileInfo(fileName);
              

                    Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(excelFile.FullName, 0, true, 5,
                    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);

                    Excel.Sheets sheets = theWorkbook.Worksheets;

                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);


                    int lastUsedRow = 0;
                    lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                   System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                   Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                   false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;



                    for (int i = 1; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "D" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = ConvertToStringArray(myvalues);
                        for(int a=0;a < strArray.Length; a++)
                        {
                            if (strArray[0] != "ime")
                            {
                                clientPrebaruvanje = strArray[0];
                                daliEprebaruvanje = true;
                            }
                            
                            clientPrebaruvanje += "#" + strArray[i];
                        }
                    }

                 
                

                if (daliEprebaruvanje == true)
                {
                    SQLiteDataReader reader;
                    string kveri = "";
                    List<string> porakaPrimena = razdeli(clientPrebaruvanje);
                    List<string> koloniVrednosti = new List<string>();

                    switch (porakaPrimena[0])
                    {
                        case "prebarajIme":
                            kveri = "ime='" + porakaPrimena[1] + "'";
                            break;
                        default:
                            kveri = "";
                            break;
                    }

                    reader = objSql.SelectFrom(kveri);

                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                    {

                        Excel.Workbook wb = ExcelObj.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)ExcelObj.ActiveSheet;
                        ExcelObj.Visible = true;

                        int i = 1;
                        ws.Cells[i, 1].Value = "ime";
                        ws.Cells[i, 2].Value = "prezime";
                        ws.Cells[i, 3].Value = "godini";
                        i++;
                        while (reader.Read())
                        {
                            //MessageBox.Show(reader[0].ToString());
                            ws.Cells[i, 1].Value = reader[0].ToString();
                            ws.Cells[i, 2].Value = reader[1].ToString();
                            ws.Cells[i, 3].Value = reader[2].ToString();
                            i++;
                        }
                        objSql.CloseConnection();

                        string debugDirectory1 = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string exportPath = Path.Combine(debugDirectory1, "sqlResultFromSearch.xlsx");

                        if (File.Exists("C:\\temp\\Z75.ClientServerPodatoci\\prebaruvanjeOdBaza.xlsx"))
                        {
                            File.Delete("C:\\temp\\Z75.ClientServerPodatoci\\prebaruvanjeOdBaza.xlsx");

                        }
                        sfd.FileName = exportPath;
                        //MessageBox.Show(sfd.FileName);
                        wb.SaveAs("C:\\temp\\Z75.ClientServerPodatoci\\prebaruvanjeOdBaza.xlsx");
                        ExcelObj.Quit();
                    }
                    string newText = "C:\\temp\\Z75.ClientServerPodatoci\\prebaruvanjeOdBaza.xlsx";

                    tbExcelZaIsprakjanje.Invoke((MethodInvoker)delegate
                    {
                        tbExcelZaIsprakjanje.Text = newText;
                    });
                    // tbExcelZaIsprakjanje.Text = "C:\\temp\\Z75.ClientServerPodatoci\\test.xlsx";


                /*    if (tbExcelZaIsprakjanje.Text != "")
                    {

                        //MessageBox.Show(prefrliPateka);
                        string novaPateka = tbExcelZaIsprakjanje.Text;
                        //string patekaZaIsprakjanje = tbExcelZaIsprakjanje.Text;
                        ////Od tuka se isprakja do client
                        // Set the server IP address and port number
                        string serverIp = "127.0.0.1";
                        int serverPort = 1027;//12345   1027

                        // Create a TcpClient to connect to the server
                        TcpClient client1 = new TcpClient(serverIp, serverPort);
                        MessageBox.Show("Connected to server.");

                        // Get the network stream for reading and writing
                        NetworkStream stream1 = client1.GetStream();

                        // Specify the Excel file to send
                        string filePath = novaPateka;

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

                        MessageBox.Show($"Excel file '{filePath}' sent successfully.");

                        // Close the client connection
                        client1.Close();
                        //Do tuka se isprakja do client
                    }*/


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima problem so bazata !!!" + ex);
            }

        }

        public void Select(string kveri)
        {
            string prefrliPateka = "";
            try
            {

                string connectionString = "Data Source=Licnosti.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                SQLiteDataReader reader;
                reader = objSql.SelectFrom(kveri);
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                {

                    Excel.Workbook wb = ExcelObj.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)ExcelObj.ActiveSheet;
                    ExcelObj.Visible = true;

                    int i = 1;
                    ws.Cells[i, 1].Value = "ime";
                    ws.Cells[i, 2].Value = "prezime";
                    ws.Cells[i, 3].Value = "godini";
                    i++;
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader[0].ToString());
                        ws.Cells[i, 1].Value = reader[0].ToString();
                        ws.Cells[i, 2].Value = reader[1].ToString();
                        ws.Cells[i, 3].Value = reader[2].ToString();
                        i++;
                    }
                    objSql.CloseConnection();

                    string debugDirectory1 = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string exportPath = Path.Combine(debugDirectory1, "sqlResultFromSearch.xlsx");
                    if (File.Exists(exportPath))//ovaa raboti
                    {


                        File.Delete(exportPath);

                    }
                    wb.SaveAs(exportPath);
                    tbExcelZaIsprakjanje.Invoke((MethodInvoker)delegate
                    {
                        tbExcelZaIsprakjanje.Clear();
                        tbExcelZaIsprakjanje.Text = exportPath;
                    });

                    ExcelObj.Quit();
                }

                System.Threading.Thread.Sleep(1000);

                if (tbExcelZaIsprakjanje.Text != "")
                {

                    //MessageBox.Show(prefrliPateka);
                    string novaPateka = tbExcelZaIsprakjanje.Text;
                    //string patekaZaIsprakjanje = tbExcelZaIsprakjanje.Text;
                    ////Od tuka se isprakja do client
                    // Set the server IP address and port number
                    string serverIp = "127.0.0.1";
                    int serverPort = 1234;//1234   1027

                    // Create a TcpClient to connect to the server
                    TcpClient client1 = new TcpClient(serverIp, serverPort);
                  //  MessageBox.Show("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream1 = client1.GetStream();

                    // Specify the Excel file to send
                    string filePath = novaPateka;

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

                  //  MessageBox.Show($"Excel file '{filePath}' sent successfully.");

                    // Close the client connection
                    client1.Close();
                    //Do tuka se isprakja do client
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima problem so prikazvanjeto na podatocite");
            }
        }

        private void tbExcelZaIsprakjanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrebarajIme_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "")
            {
                tbPrezime.Clear();
                tbGodini.Clear();
                try
                {
                    string connectionString = "Data Source=Licnosti.db;Version=3;";
                    SQLiteManager objSql = new SQLiteManager(connectionString);
                    var sqlite_datareader = objSql.SelectFrom(" ime='"+tbIme.Text+"'");
                    listView1.Items.Clear();
                    while (sqlite_datareader.Read())
                    {

                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = sqlite_datareader.GetValue(0).ToString();
                        arr[1] = sqlite_datareader.GetValue(1).ToString();
                        arr[2] = sqlite_datareader.GetValue(2).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ima problem so prikazvanjeto na site podatoci ! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Popolnetego poleto za ime");
            }
        }

        private void btnPrebarajPrezime_Click(object sender, EventArgs e)
        {
            if (tbPrezime.Text != "")
            {
                tbIme.Clear();
                tbGodini.Clear();
                try
                {
                    string connectionString = "Data Source=Licnosti.db;Version=3;";
                    SQLiteManager objSql = new SQLiteManager(connectionString);
                    var sqlite_datareader = objSql.SelectFrom(" prezime='" + tbPrezime.Text + "'");
                    listView1.Items.Clear();
                    while (sqlite_datareader.Read())
                    {

                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = sqlite_datareader.GetValue(0).ToString();
                        arr[1] = sqlite_datareader.GetValue(1).ToString();
                        arr[2] = sqlite_datareader.GetValue(2).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ima problem so prikazvanjeto na site podatoci ! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Popolnetego poleto za prezime");
            }
        }

        private void btnPrebarajGodini_Click(object sender, EventArgs e)
        {
            if (tbGodini.Text != "")
            {
                tbIme.Clear();
                tbPrezime.Clear();
                try
                {
                    string connectionString = "Data Source=Licnosti.db;Version=3;";
                    SQLiteManager objSql = new SQLiteManager(connectionString);
                    var sqlite_datareader = objSql.SelectFrom("godini='" + tbGodini.Text + "'");
                    listView1.Items.Clear();
                    while (sqlite_datareader.Read())
                    {

                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = sqlite_datareader.GetValue(0).ToString();
                        arr[1] = sqlite_datareader.GetValue(1).ToString();
                        arr[2] = sqlite_datareader.GetValue(2).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ima problem so prikazvanjeto na site podatoci ! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Popolnetego poleto za godini");
            }
        }
    }
}
