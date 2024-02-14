using System;
using System.Net.Sockets;
using System.Text;

class Client
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

            // Send a message to the server
            string message = "Hello from client!";
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            // Receive a response from the server
            data = new byte[1024];
            int bytesRead = stream.Read(data, 0, data.Length);
            string response = Encoding.ASCII.GetString(data, 0, bytesRead);
            Console.WriteLine("Server Response: " + response);

            // Close the client connection
            client.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}