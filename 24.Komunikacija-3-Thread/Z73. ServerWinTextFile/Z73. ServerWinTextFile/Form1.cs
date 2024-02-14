
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
using System.Threading;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Z73.ServerWinTextFile
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

                textBox1.Clear();
                textBox1.Text = msg;

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
                    tbPath.Text = fileName;
                    FileStream fileStream = File.Create(fileName);

                    // Receive and save the file data
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                    MessageBox.Show($"File '{fileName}' received and saved.");

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


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Broj povtoruvanja", 120);
            listView1.Columns.Add("Zbor na povtoruvanja", 120);

        }

        private void btnKomunikacija_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the server IP address and port number
                string serverIp = "localhost";
                int serverPort = 8085;

                // Create a TcpClient to connect to the server
                TcpClient client = new TcpClient(serverIp, serverPort);
                MessageBox.Show("Connected to server.");

                // Get the network stream for reading and writing
                NetworkStream stream = client.GetStream();

                // Send a message to the server
                string message = textBox1.Text.ToString();
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                //// Receive a response from the server
                //data = new byte[1024];
                //int bytesRead = stream.Read(data, 0, data.Length);
                //string response = Encoding.ASCII.GetString(data, 0, bytesRead);
                //MessageBox.ShowLine("Server Response: " + response);

                // Close the client connection
                client.Close();
            }
            catch
            {
                MessageBox.Show("Error: ");
            }
        }

        static List<string> razdeli(string str)
        {
            List<string> list = new List<string>();
            string prazenStr = "";
            string split = " ";
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

        static SortedList<string, int> IzborZboroviVoRecenica(List<string> listaZaProverka)
        {
            SortedList<string, int> kolkuPati = new SortedList<string, int>();
            for (int i = 0; i < listaZaProverka.Count; i++)// Gi vadime site stringoj od listata stringoj
            {
                if (!kolkuPati.ContainsKey(listaZaProverka[i]))//Ako go nema stringo mu dodelvame vrednost 1
                {
                    kolkuPati[listaZaProverka[i]] = 1;

                }
                else if (kolkuPati.ContainsKey(listaZaProverka[i]))//Ako go ima stringo ja zgolevame vrednosta
                {
                    kolkuPati[listaZaProverka[i]]++;
                }
            }
            return kolkuPati;
        }

        private void btnVnesiListview_Click(object sender, EventArgs e)
        {
            try
            {
        
                List<string> listaOdTextZborovi = new List<string>();
                using (StreamReader sr = File.OpenText(tbPath.Text))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        listaOdTextZborovi = razdeli(s);
                    }
                }

                SortedList<string, int> listaIzbroeni = new SortedList<string, int>();
                listaIzbroeni = IzborZboroviVoRecenica(listaOdTextZborovi);
                int kolkuZborovi = 0;
                foreach (KeyValuePair<string, int> v in listaIzbroeni)// gi listame dobienite rezulatati od sortiranata lista
                {
                    kolkuZborovi=kolkuZborovi+v.Value;
                    string[] arr = new string[2];
                    ListViewItem itm;

                    arr[0] = v.Key.ToString();
                    arr[1] = v.Value.ToString();

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                MessageBox.Show(kolkuZborovi.ToString());

            }
            catch { MessageBox.Show("Problem so vnesvanje vo listview"); }
        }
    }
}
