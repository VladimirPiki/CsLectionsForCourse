using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server1
{
    static void Main()
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

            Console.WriteLine("Server is waiting for connections...");

            while (true)
            {
                // Accept a client connection
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Client connected!");

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

                Console.WriteLine($"File '{fileName}' received and saved.");

                // Close the client connection and file stream
                fileStream.Close();
                client.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            // Stop listening for incoming connections
            server.Stop();
        }
    }
}