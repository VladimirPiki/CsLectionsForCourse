using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Z72.ServerClientWindowsFormExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnIspratiExcel_Click(object sender, EventArgs e)
        {
 

        }

        private void btnIzberiExcel_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "*.xls"; if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //  MessageBox.Show(this.openFileDialog2.FileName);
                txtFileName.Text = this.openFileDialog1.FileName;

            }
        }

        private void btnIspratiExcel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txtFileName.Text != "")
                {
                    Assembly assembly = Assembly.GetEntryAssembly();

                    string assemblyLocation = assembly.Location;

                    string debugDirectory = System.IO.Path.GetDirectoryName(assemblyLocation);

                    string imeNaFajlot = Path.GetFileName(txtFileName.Text);
                    string destinacija = debugDirectory + "\\" + imeNaFajlot;
                    string imeNaFajlotZaIsprakjanje= Path.GetFileName(destinacija);    
                    if (File.Exists(destinacija))
                    {
                        File.Delete(destinacija);
                    }
                    File.Move(txtFileName.Text, debugDirectory+"\\"+imeNaFajlot);
                    txtImeNaFajlot.Text = imeNaFajlotZaIsprakjanje;
                    MessageBox.Show("excel dokumentot "+ txtImeNaFajlot.Text+" e uspeshno zacuvan i spremen za isprakjanje !!");
                }
                else
                {
                    MessageBox.Show("Zadolzitelno Izberete excel dadoteka");
                }

            }
            catch (Exception ex) { MessageBox.Show("PROBLEM! " + ex); }
          
        }

        private void btnIspratiNaServer_Click(object sender, EventArgs e)
        {
            if(txtImeNaFajlot.Text != "")
            {
                try
                {
                    // Set the server IP address and port number
                    string serverIp = "127.0.0.1";
                    int serverPort = 12345;

                    // Create a TcpClient to connect to the server
                    TcpClient client = new TcpClient(serverIp, serverPort);
                    MessageBox.Show("Connected to server.");

                    // Get the network stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Specify the Excel file to send
                    string filePath = txtImeNaFajlot.Text;

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
                catch (Exception expt)
                {
                    MessageBox.Show("Error: " + expt.Message);
                }
            }
            else
            {
                MessageBox.Show("Ne postoi excel dadoteka vo proektot za isprakjanje");
            }
        }
    }
}
