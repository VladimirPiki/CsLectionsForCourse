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
using static Z72.ServerWindowsFormExcel.Database;
using Excel = Microsoft.Office.Interop.Excel;

namespace Z72.ServerWindowsFormExcel
{

    public partial class Form1 : Form
    {
        private Excel.Application ExcelObj = null;
        public Form1()
        {
            InitializeComponent();

            ExcelObj = new Excel.Application();

            if (ExcelObj == null)
            {
                MessageBox.Show("ERROR: EXCEL couldn't be started!");
                System.Windows.Forms.Application.Exit();
            }

            ExcelObj.Visible = true;
        }

        static void ReadAndDisplayExcelFile(string fileName)
        {
            FileInfo excelFile = new FileInfo(fileName);
            using (var package = new ExcelPackage(excelFile))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

             //   MessageBox.Show($"Contents of Excel file '{fileName}':");

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        // Console.Write(worksheet.Cells[row, col].Text + "\t");
                    }
                    //  MessageBox.Show();
                }

            }
        }

        static void CreateTableAndInsertExcel(string fileName, string imeNaTabela)
        {
            try
            {
                string connectionString = "Data Source=" + imeNaTabela + ".db;Version=3;";
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
                    objSql.CreateTable(koloni, imeNaTabela);

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
                        objSql.InsertRow(koloni, koloniVrednosti, imeNaTabela);
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrimiClient_Click(object sender, EventArgs e)
        {
            TcpListener server = null;
            try
            {
                // Set the IP address and port number for the server
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 12345;

                // Create a TcpListener to listen for incoming connections
                server = new TcpListener(ipAddress, port);

                // Start listening for client requests
                server.Start();

              //  MessageBox.Show("Server is waiting for connections...");

                while (true)
                {
                    // Accept a client connection
                    TcpClient client = server.AcceptTcpClient();
                  //  MessageBox.Show("Client connected!");

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
                    txtFileName.Text = fileName;
                    // Read and display the contents of the Excel file (optional)
                    // ReadAndDisplayExcelFile(fileName);
                    string imeNaTabela = Path.GetFileNameWithoutExtension(fileName);

                    CreateTableAndInsertExcel(fileName, imeNaTabela);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
            finally
            {
                // Stop listening for incoming connections
                server.Stop();
            }
        }





        private void btnVnesiBaza_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFileName.Text != "")
                {
                    string imeNaTabela = Path.GetFileNameWithoutExtension(txtFileName.Text);

                    CreateTableAndInsertExcel(txtFileName.Text, imeNaTabela);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("PROBLEM ! " + ex);
            }
        }
    }
}
