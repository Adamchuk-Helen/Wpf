using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SocketClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        const int PORT = 2020;
        const int SIZE = 1024;
        public void BtClick(object sender, RoutedEventArgs e)
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IPAddress.Parse("127.0.0.1"), PORT);
                if (client.Connected)
                {
                    
                    try
                    {
                        client.Send(Encoding.UTF8.GetBytes(text.Text));
                        text.Clear();

                        var buffer = new byte[SIZE];
                        client.Receive(buffer);
                        res.Content = Encoding.UTF8.GetString(buffer);
                    }
                    catch
                    {
                        MessageBox.Show("Введіть значення від 10001 до 10061");
                    }

                }
             }
            catch (SocketException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
               client.Close();
            }
        }
    }
}
