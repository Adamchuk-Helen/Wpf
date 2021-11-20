using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AsyncClient1
{
    class Program
    {
        private const int Port = 2020;
        private const int Size = 100;
        static void Main(string[] args)
        {
             StartClient();  
        }

        private static void StartClient()
        {
            IPHostEntry entry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = entry.AddressList[0];

            Socket client = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.BeginConnect(new IPEndPoint(ip, Port), ConnectCallback, client);
            }
            catch (SocketException e)
            {
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            var client = (Socket)ar.AsyncState;
            client.EndConnect(ar);

            var data = Encoding.UTF8.GetBytes($"Time: {DateTime.Now}");

            client.BeginSend(data, 0, data.Length, SocketFlags.None, SendCallback, client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            var client = (Socket)ar.AsyncState;
            var countBytes = client.EndSend(ar);
            Console.WriteLine("Send to server {0} bytes", countBytes);

            ReceiveFrom(client);
        }

        private static void ReceiveFrom(Socket client)
        {
            var buffer = new byte[Size];

            var data = new
            {
                Socket = client,
                Buffer = buffer,
                Size = Size
            };

            client.BeginReceive(buffer, 0, Size, SocketFlags.None, ReceiveCallback, data);
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            var data = (dynamic)ar.AsyncState;
            var client = (Socket)data.Socket;
            var buffer = (byte[])data.Buffer;

            var countBytes = client.EndReceive(ar);

            var responce = Encoding.UTF8.GetString(buffer, 0, countBytes);

            Console.WriteLine("Received from server ({0}): {1}", client.RemoteEndPoint, responce);
        }
    }
}
