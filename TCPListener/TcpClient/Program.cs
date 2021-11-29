using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 2020;
            const int size = 100;
            
            TcpClient client = new TcpClient();
            try
            {
                client.Connect("92.52.138.128", port);
                bool flag = true;
                while (true)
                {
                   
                    
                    using (NetworkStream stream = client.GetStream())
                    {
                        var response = new byte[size];
                        Console.WriteLine("Enter msg to send:");
                        var msg = Console.ReadLine();
                        stream.Write(Encoding.UTF8.GetBytes(response, 0, response.Length));

                        byte[] buffer = new byte[size];
                        int count = 0;
                        do
                        {
                            count += stream.Read(buffer, 0, buffer.Length);
                        } while (stream.DataAvailable);

                        string data = Encoding.UTF8.GetString(buffer, 0, count);
                        Console.WriteLine($"Got: {count} bytes, data: {data}");
                        var responce = $"Responce: got {count} bytes";

                        stream.Write(Encoding.UTF8.GetBytes(responce), 0, responce.Length);
                    }
                    client.Close();




                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
