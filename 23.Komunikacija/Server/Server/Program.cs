using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
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

                // Get the client's network stream (for reading and writing)
                NetworkStream stream = client.GetStream();

                // Read data from the client
                byte[] data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesRead);
                Console.WriteLine("Received: " + message);

                // Send a response back to the client
                byte[] response = Encoding.ASCII.GetBytes("Hello from server!");
                stream.Write(response, 0, response.Length);

                // Close the client connection
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