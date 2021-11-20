using Styles.Properties;
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

namespace Styles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String [] themesArr = { "light", "dark" };
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Lang_change(object sender, RoutedEventArgs e)
        {
            var menuItem = (sender as MenuItem);
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("Properties/" + menuItem.Tag + ".xaml", UriKind.Relative);

            foreach (MenuItem item in (menuItem.Parent as MenuItem).Items)
            {
                item.IsChecked = false;
            }
            menuItem.IsChecked = !menuItem.IsChecked;
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dictionary);
        }

        public void themeClick(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32((sender as MenuItem).Tag);
            ChangeTemes(index);
          
        }
        public void ChangeTemes(int index)
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("Properties/" + themesArr[index] + ".xaml", UriKind.Relative);
            Resources.MergedDictionaries.Add(dictionary);

        }

        private void pageChange(object sender, RoutedEventArgs e)
        {
            var bt = sender as Button;
            string pass = bt.Content.ToString();
            buttonBlock.Tag = pass + ".xaml";
        }
    }
}
