using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            

            var info = $"Sender: {sender}\n Sourse: {e.Source}\n Name event: {e.RoutedEvent.Name}\n Strategy: {e.RoutedEvent.RoutingStrategy}";

            btClick.Items.Add(info);
            
        }

        private void rbClick(object sender, RoutedEventArgs e)
        {
            var rbt = e.Source as RadioButton;
            Title = rbt.Content.ToString();
                
        }
    }
}
