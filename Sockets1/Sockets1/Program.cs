using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sockets1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostName = Dns.GetHostName();
            Console.WriteLine(hostName);

            PrintInformation(hostName);

        }

        private static void PrintInformation(string hostName)
        {
            IPHostEntry entry = Dns.GetHostEntry(IPAddress.Parse("127.0.0.1"));
            Console.WriteLine(entry.HostName);
            Console.WriteLine("Adresses:");
            foreach (var item in entry.AddressList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
