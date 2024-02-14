using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using Microsoft.Office.Interop.Excel;

namespace Z75.ClientPodatoci
{
    public partial class Form1 : Form
    {


        private Excel.Application ExcelObj = null;
        public struct Licnost
        {
            public string ime;
            public string prezime;
            public string godini;

        };
        public void ThreadProc()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8085);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
               // MessageBox.Show("Tredot za poraki e aktiven");
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


                //Messagex.Show(msg);
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
                int port = 1234;

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

             //       MessageBox.Show($"Excel file '{fileName}' received and saved.");

                    // Close the client connection and file stream
                    fileStream.Close();
                    client.Close();

                    // Read and display the contents of the Excel file (optional)
                    CreateListViewFromServer(fileName); ///RABOTI
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
            listView1.Columns.Add("ime", 200);
            listView1.Columns.Add("prezime", 200);
            listView1.Columns.Add("godini", 200);

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

        private void btnPratiPodatoci_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbPrezime.Text != "" && tbGodini.Text != "")
            {
                try
                {
                    // Set the server IP address and port number
                    string serverIp = "localhost";
                    int serverPort = 8080;

                    // Create a TcpClient to connect to the server
                    TcpClient client = new TcpClient(serverIp, serverPort);
                    Console.WriteLine("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Send a message to the server

                   string message = "podatociLicnost#"+ tbIme.Text+"#" + tbPrezime.Text +"#" + tbGodini.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    //// Receive a response from the server
                    //data = new byte[1024];
                    //int bytesRead = stream.Read(data, 0, data.Length);
                    //string response = Encoding.ASCII.GetString(data, 0, bytesRead);
                    //Console.WriteLine("Server Response: " + response);

                    // Close the client connection
                    client.Close();
                }
                catch(Exception expt)
                {
                    MessageBox.Show("Error: "+ expt);
                }
            }
            else
            {
                MessageBox.Show("Site polimnja za licnosta se zadolzitelni");
            }
        

        }

        private void btnPrikaziDadoteka_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        //MessageBox.Show(selectedFilePath);

                        List<string> koloniIme = new List<string>() { "ime", "prezime", "godini" };
                        Licnost lic = new Licnost();
                        using (StreamReader sr = File.OpenText(selectedFilePath))
                        {
                        
                            string s;
                            while ((s = sr.ReadLine()) != null)
                            {
                                lic.ime = s;
                                lic.prezime = sr.ReadLine();
                                lic.godini=sr.ReadLine();

                                string[] arr = new string[3];
                                ListViewItem itm;

                                arr[0] = lic.ime;
                                arr[1] = lic.prezime;
                                arr[2] = lic.godini;
                                itm=new ListViewItem(arr);
                                listView1.Items.Add(itm);
                            }
                        }


                    }
                }
            }
            catch(Exception expt) { MessageBox.Show("Imate problem so otvoranje na text dadoteka"+ expt); }


        }

        private void btnPratiOdListview_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Excel.Workbook wb = ExcelObj.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                            Excel.Worksheet ws = (Excel.Worksheet)ExcelObj.ActiveSheet;
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
                            tbSnimenExcel.Text = sfd.FileName;

                            ExcelObj.Quit();
                           // MessageBox.Show("Uspeshno e exportirana dadotekata i spremna za isprakjanje vo serverBaza so lokacija "+tbSnimenExcel.Text);
                        }
                    }// do tuka e Excel

                    //Od tuka se isprakja do server
                    // Set the server IP address and port number
                    string serverIp = "127.0.0.1";
                    int serverPort = 1027;

                    System.Threading.Thread.Sleep(1000);

                    // Create a TcpClient to connect to the server
                    TcpClient client = new TcpClient(serverIp, serverPort);
                   // MessageBox.Show("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Specify the Excel file to send
                    string filePath = tbSnimenExcel.Text;

                    // Send the file name to the server
                    byte[] fileNameData = Encoding.ASCII.GetBytes(Path.GetFileName(filePath));
                    stream.Write(fileNameData, 0, fileNameData.Length);

                    // Send the Excel file data to the server
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    using (FileStream fileStream = File.OpenRead(filePath))
                    {
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            stream.Write(buffer, 0, bytesRead);
                        }
                    }

                    //MessageBox.Show($"Excel file '{filePath}' sent successfully.");

                    // Close the client connection
                    client.Close();
                    //Do tuka se isprakja do server


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrebarajIme_Click(object sender, EventArgs e)
        {
            if (tbPrebarajIme.Text != "" )
            {
                tbPrebarajGodini.Clear();
                tbPrebarajPrezime.Clear();
                try
                {
                    // Set the server IP address and port number
                    string serverIp = "localhost";
                    int serverPort = 8080;

                    // Create a TcpClient to connect to the server
                    TcpClient client = new TcpClient(serverIp, serverPort);
                    Console.WriteLine("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Send a message to the server

                    string message = "prebarajIme#" + tbPrebarajIme.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    //// Receive a response from the server
                    //data = new byte[1024];
                    //int bytesRead = stream.Read(data, 0, data.Length);
                    //string response = Encoding.ASCII.GetString(data, 0, bytesRead);
                    //Console.WriteLine("Server Response: " + response);

                    // Close the client connection
                    client.Close();
                }
                catch
                {
                    MessageBox.Show("Error: ");
                }
            }
            else
            {
                MessageBox.Show("Popolnetego poleto za PREBARUVANJE ime");
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
        public void CreateListViewFromServer(string fileName)
        {
            try
            {
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



                for (int i = 2; i <= lastUsedRow; i++)
                {
                    Excel.Range range = worksheet.get_Range("A" + i.ToString(), "D" + i.ToString());
                    System.Array myvalues = (System.Array)range.Cells.Value;
                    string[] strArray = ConvertToStringArray(myvalues);
                    listView1.Invoke((MethodInvoker)delegate {
                        string[] arr = new string[3];
                        ListViewItem itm;

                        arr[0] = strArray[0];
                        arr[1] = strArray[1];
                        arr[2] = strArray[2];

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    });
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima problem so Listview !!! " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrebImeSendExcel_Click(object sender, EventArgs e)
        {
            if(tbPrebImeSendExcel.Text != "")
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                 {
                     if (sfd.ShowDialog() == DialogResult.OK)
                     {
                         Excel.Workbook wb = ExcelObj.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                         Excel.Worksheet ws = (Excel.Worksheet)ExcelObj.ActiveSheet;
                         ExcelObj.Visible = true;
                         ws.Cells[1, 1].Value = "prebarajIme";
                         ws.Cells[1, 2].Value = tbPrebImeSendExcel.Text;

                         // wb.SaveAs(sfd.FileName,XlFileFormat.xlWorkbookDefault,Type.Missing,Type.Missing,true,false,XlSaveAsAccessMode.xlNoChange,XlSaveConflictResolution.xlLocalSessionChanges);
                         wb.SaveAs(sfd.FileName);
                         tbSnimenExcel.Text = sfd.FileName;

                         ExcelObj.Quit();
                      //  MessageBox.Show("Uspeshno e exportirana dadotekata i spremna za isprakjanje vo serverBaza so lokacija " + tbSnimenExcel.Text);
                     }
                 }// do tuka e Excel

              ////  Od tuka se isprakja do server
                //// Set the server IP address and port number
                 string serverIp = "127.0.0.1";
                int serverPort = 1027;

                // Create a TcpClient to connect to the server
                TcpClient client = new TcpClient(serverIp, serverPort);
               // MessageBox.Show("Connected to server.");

                // Get the network stream for reading and writing
                NetworkStream stream = client.GetStream();

                // Specify the Excel file to send
                string filePath = tbSnimenExcel.Text;

                // Send the file name to the server
                byte[] fileNameData = Encoding.ASCII.GetBytes(Path.GetFileName(filePath));
                stream.Write(fileNameData, 0, fileNameData.Length);

                // Send the Excel file data to the server
                byte[] buffer = new byte[1024];
                int bytesRead;
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        stream.Write(buffer, 0, bytesRead);
                    }
                }

             //   MessageBox.Show($"Excel file '{filePath}' sent successfully.");

                // Close the client connection
                client.Close();
              /////  Do tuka se isprakja do server

            }
            else
            {
                MessageBox.Show("Vnesete ime");
            }

        }

        private void btnPrebarajPrezime_Click(object sender, EventArgs e)
        {
            if (tbPrebarajPrezime.Text != "")
            {
                tbPrebarajGodini.Clear();
                tbPrebarajIme.Clear();
                try
                {
                    // Set the server IP address and port number
                    string serverIp = "localhost";
                    int serverPort = 8080;

                    // Create a TcpClient to connect to the server
                    TcpClient client = new TcpClient(serverIp, serverPort);
                    Console.WriteLine("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Send a message to the server

                    string message = "prebarajPrezime#" + tbPrebarajPrezime.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    //// Receive a response from the server
                    //data = new byte[1024];
                    //int bytesRead = stream.Read(data, 0, data.Length);
                    //string response = Encoding.ASCII.GetString(data, 0, bytesRead);
                    //Console.WriteLine("Server Response: " + response);

                    // Close the client connection
                    client.Close();
                }
                catch
                {
                    MessageBox.Show("Error: ");
                }
            }
            else
            {
                MessageBox.Show("Popolnetego poleto za PREBARUVANJE prezime");
            }

        }

        private void btnPrebarajGodini_Click(object sender, EventArgs e)
        {
            if (tbPrebarajGodini.Text != "")
            {
                tbPrebarajPrezime.Clear();
                tbPrebarajIme.Clear();
                try
                {
                    // Set the server IP address and port number
                    string serverIp = "localhost";
                    int serverPort = 8080;

                    // Create a TcpClient to connect to the server
                    TcpClient client = new TcpClient(serverIp, serverPort);
                    Console.WriteLine("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Send a message to the server

                    string message = "prebarajGodini#" + tbPrebarajGodini.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    //// Receive a response from the server
                    //data = new byte[1024];
                    //int bytesRead = stream.Read(data, 0, data.Length);
                    //string response = Encoding.ASCII.GetString(data, 0, bytesRead);
                    //Console.WriteLine("Server Response: " + response);

                    // Close the client connection
                    client.Close();
                }
                catch
                {
                    MessageBox.Show("Error: ");
                }
            }
            else
            {
                MessageBox.Show("Popolnetego poleto za PREBARUVANJE godini");
            }

        }

        private void btnIscistiListView_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
