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

namespace Z74.ClientWinExcelFile
{
    public partial class Form1 : Form
    {
        public void ThreadProc()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8085);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
                MessageBox.Show("Tredot za poraki e aktiven");
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


              //  txtBox.Clear();
               // txtBox.Text = msg;

                //Messagex.Show(msg);
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
        }

        private void btnIspratiExcel_Click(object sender, EventArgs e)
        {


            try
            {
                // Set the server IP address and port number
                string serverIp = "127.0.0.1";
                int serverPort = 1027;

                // Create a TcpClient to connect to the server
                TcpClient client = new TcpClient(serverIp, serverPort);
                MessageBox.Show("Connected to server.");

                // Get the network stream for reading and writing
                NetworkStream stream = client.GetStream();

                // Specify the Excel file to send
                string filePath = "test.xlsx";

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

                MessageBox.Show($"Excel file '{filePath}' sent successfully.");

                // Close the client connection
                client.Close();
            }
            catch
            {
                Console.WriteLine("Error: ");
            }
        }
    }
}
