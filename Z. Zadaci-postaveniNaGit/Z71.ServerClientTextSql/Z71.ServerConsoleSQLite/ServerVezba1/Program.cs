using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static ServerVezba1.Database;

class Server
{

    public struct Licnost
    {
        public string ime;
        public string prezime;
        public int godini;

    };
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

                string connectionString = "Data Source=test.db;Version=3;";
                SQLiteManager objSql = new SQLiteManager(connectionString);
                objSql.CreateTables();

                //PRIMER 1 BEZ STRUKTURA
                //List<string> koloniVrednosti = new List<string>();
                //List<string> koloniIme = new List<string>() { "ime","prezime","godini"};
                //using (StreamReader sr = File.OpenText(fileName))// StreamReader zapisigo vo sr i otvorigo tekstot
                //{

                //    string s;// zapisigo tekstot vo s
                //    while ((s = sr.ReadLine()) != null)// se dodeka ima tekst polnija s
                //    {
                //        koloniVrednosti.Add(s);
                //        //Console.WriteLine(s);
                //    }
                //}
                //List<string> vrednosti= new List<string>();

                //foreach (string s in koloniVrednosti)
                //{
                //    //int br = 0;
                //    int broj = 0;
                //    //if(broj < 4)
                //    //{
                //        vrednosti.Add((s));
                //    //    broj++;

                //    //}
                //    bool tryParse=Int32.TryParse(s, out broj);
                //    if(tryParse) {
                //        objSql.InsertRow(koloniIme, vrednosti, "Licnosti");
                //        vrednosti.Clear();
                //    }
                //}
                //PRIMER 1 BEZ STRUKTURA

                //VTOR PRIMER SO INSERTLICNOSTI
                List<string> koloniIme = new List<string>() { "ime", "prezime", "godini" };
                Licnost lic = new Licnost();
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        lic.ime = s;
                        lic.prezime = sr.ReadLine();
                        bool isParsable = Int32.TryParse(sr.ReadLine(), out lic.godini);
                        if (isParsable)
                        {
                            objSql.InsertLicnosti(lic.ime, lic.prezime, lic.godini);
                        }
                        else
                            Console.WriteLine("Could not be parsed.");
                    }
                }
                //VTOR PRIMER SO INSERTLICNOSTI


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