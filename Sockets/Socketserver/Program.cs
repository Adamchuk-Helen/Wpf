using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socketserver
{
    class Program
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
       
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            SqlDataReader sqlDataReader = null;
            string command = string.Empty;



            IPHostEntry entry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = entry.AddressList[1];
            Socket server = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);


            const int PORT = 2020;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT);



            sqlConnection.Open();
            try
            {
                server.Bind(endPoint);

                const int BACKLOG = 20;
                server.Listen(BACKLOG);
                while (true)
                {
                    Socket client = server.Accept();
                    const int SIZE = 300;
                    var buffer = new byte[SIZE];
                    int count = 0;
                    string data = "";

                    do
                    {
                        count = client.Receive(buffer);
                        data += Encoding.UTF8.GetString(buffer, 0, count);
                    }
                    while (client.Available > 0);
                    Console.WriteLine("Reseive: " + data);

                    try
                    {

                        command = $"SELECT StreetName FROM Streets JOIN IndexForCity   ON IdexessId = IndexForCity.Id WHERE Indexess = { data }";

                        SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        string st = "";
                        while (sqlDataReader.Read())
                        {
                            string street = (sqlDataReader["StreetName"]).ToString();
                            st += street + "\n";
                        }
                        client.Send(Encoding.UTF8.GetBytes(st));

                        sqlDataReader.Close();
                        //sqlConnection.Close();
                        //client.Close();
                    }
                    catch (Exception ex)
                    {
                        break;
                        
                    }
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
