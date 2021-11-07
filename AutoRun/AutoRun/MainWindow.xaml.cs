using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AutoRun
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RegistryKey key = Registry.CurrentUser;
        public MainWindow()
        {
            InitializeComponent();

            CreateListRun();

        }

        public void CreateListRun()
        {
            
            var run = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            var items = run.GetValueNames();


            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            var run = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                var name = openFileDialog.FileName;
                key.GetValue(name);
                
                run.SetValue(name, name);
            }
        }

        private void DeleteFile(object sender, RoutedEventArgs e)
        {
            var run = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            string delFile = Convert.ToString(listBox1.SelectedItem);
            run.DeleteValue(delFile);
        }
    }
}
