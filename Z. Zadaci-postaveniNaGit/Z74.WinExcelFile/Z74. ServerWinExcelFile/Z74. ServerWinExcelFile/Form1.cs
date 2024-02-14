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
using System.IO;
using OfficeOpenXml;
using System.Threading;
using System.Data.SQLite;
using static Z74.ServerWinExcelFile.Database;

namespace Z74.ServerWinExcelFile
{
    public partial class Form1 : Form
    {
        //Za komunikacija tred
        public void ThreadProc()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8080);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
                MessageBox.Show("Serverot e aktiviran");
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
                    filePath.Text = fileName;
                    string imeNaTabela = Path.GetFileNameWithoutExtension(fileName);
                    tbTableName.Text = imeNaTabela; 

                    // Read and display the contents of the Excel file (optional)
                    ReadAndDisplayExcelFile(fileName);
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

        }

        public void ReadAndDisplayExcelFile(string fileName)
        {
            FileInfo excelFile = new FileInfo(fileName);
            using (var package = new ExcelPackage(excelFile))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                MessageBox.Show($"Pogledete ja sodrzinata od excel dadotekata vo listview '{fileName}'");

                for (int row = 1; row < 2; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        if (worksheet.Cells[row, col].Text != "")
                        {
                            string result = worksheet.Cells[row, col].Text.Replace(' ', '_');
                            result = result.Replace('(', '_');
                            result = result.Replace(')', '_');
                            result = result.Replace('.', '_');
     
                            listView1.Columns.Add(result, 120);
                        }

                    }
                }

                for (int row = 2; row <= rowCount; row++)
                {
                    ListViewItem itm = new ListViewItem();
                    for (int col = 1; col <= colCount; col++)
                    {
                        string cellText = worksheet.Cells[row, col].Text;
                        if (col == 1)
                        {
                            itm.Text = cellText; 
                        }
                        else
                        {
                            itm.SubItems.Add(cellText); 
                        }
                    }
                    if (itm.SubItems.Count > 0) 
                    {
                        listView1.Items.Add(itm);
                    }
                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if(filePath.Text != "")
            {
                ReadAndDisplayExcelFile(filePath.Text);
            }
            else
            {
                MessageBox.Show("Klientot nema isprateno excel dadoteka !!!");
            }
        }


        public void InsertSelectedListView(string imeNaTabela)
        {
            if (imeNaTabela == "")
            {
                imeNaTabela = "praznaTabela";
            }
            string connectionString = "Data Source=" + imeNaTabela + ".db;Version=3;";
            SQLiteManager objSql = new SQLiteManager(connectionString);
            List<string> koloni = new List<string>();
            foreach (ColumnHeader item in listView1.Columns)
            {
                koloni.Add(item.Text);
            }
            objSql.CreateTable(koloni, imeNaTabela);

            List<string> koloniVrednosti = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {

                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    koloniVrednosti.Add(item.SubItems[i].Text);
                }
                objSql.InsertRow(koloni, koloniVrednosti, imeNaTabela);
                koloniVrednosti.Clear();
            }
        }

        private void btnZacuvajVoBaza_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    InsertSelectedListView(tbTableName.Text);
                    MessageBox.Show("Uspesno zapisvanjeto vo baza !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem so zapisvanjeto vo baza !");
                }
           
            }
            else
            {
                MessageBox.Show("Selektirajte red od listview !!!");
            }
        }


    }
}
