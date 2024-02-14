using System;
using System.IO;
using System.Net.Sockets;
using System.Text;


class ClientVezba1
{

    static void Main()
    {
        try
        {
            // Set the server IP address and port number
            string serverIp = "127.0.0.1";
            int serverPort = 12345;

            // Create a TcpClient to connect to the server
            TcpClient client = new TcpClient(serverIp, serverPort);
            Console.WriteLine("Connected to server.");

            // Get the network stream for reading and writing
            NetworkStream stream = client.GetStream();

            // Specify the file to send
            string filePath = "licnosti.txt";

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
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}