using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientPrimer
{
    public partial class Form1 : Form
    {

        private Form.Form2 objForm2;
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

                string msg = Encoding.UTF8.GetString(receivedBuffer, 0, count);//КИРИЛИЦА UTF8 NAMESTO ASCII bidejki ne ja cita kirilicata
                byte[] sendData = Encoding.UTF8.GetBytes(msg); //КИРИЛИЦА UTF8 NAMESTO ASCII bidejki ne ja cita kirilicata
                int b = sendData.Length;

                txtBox.Clear();
                txtBox.Text = msg;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKomunikacija_Click(object sender, EventArgs e)
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
                string message = txtBox.Text.ToString();
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

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the server IP address and port number
                string serverIp = "127.0.0.1";
                int serverPort = 1025;

                // Create a TcpClient to connect to the server
                TcpClient client = new TcpClient(serverIp, serverPort);
                Console.WriteLine("Connected to server.");

                // Get the network stream for reading and writing
                NetworkStream stream = client.GetStream();

                // Specify the file to send
                string filePath = "test.txt";

                // Send the file name to the server
                byte[] fileNameData = Encoding.ASCII.GetBytes(Path.GetFileName(filePath));
                stream.Write(fileNameData, 0, fileNameData.Length);

                // Send the file data to the server
                byte[] buffer = new byte[1024];
                int bytesRead;
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        stream.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("File sent successfully.");

                // Close the client connection
                client.Close();
            }
            catch
            {
                Console.WriteLine("Error: ");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
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
