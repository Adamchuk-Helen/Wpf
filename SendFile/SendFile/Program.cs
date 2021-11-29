using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Xml.Serialization;

namespace SendFile
{
    public struct CustFile
    { 
        public string Name { get; set; }
        public string Extention { get; set; }
    }
    class Program
    {
        UdpClient server = new UdpClient();
        const string IP = "92.52.138.128";
        const int port = 2020;
        static void Main(string[] args)
        {
            

            var filePath = "pic.jpg";
            SendFile(filePath);

        }
        private static void SendHeader(string filePath)
        {
            var fileInfo = new CustFile
            {
                Name = Path.GetFileNameWithoutExtension(filePath),
                Extention = Path.GetExtension(filePath)
            };

            var stream = new MemoryStream();
            var serial = new XmlSerializer(fileInfo.GetType());
            serial.Serialize(stream, fileInfo);
            var info = stream.ToArray();
            
        }



        private static void SendFile(string filePath)
        {

            var data = System.IO.File.ReadAllBytes(filePath);

        }
    }
}
