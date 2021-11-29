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

namespace Tr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += MainWindow_SizeChanged;
        }


        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            foreach (var item in CardsCollection.Children)
            {
                if (item is CreateListPanel)
                {
                    (item as CreateListPanel).ListBoxCard.MaxHeight = WatchSizeWindowName.Data - 100;
                }
            }
        }

        private void button_Click_ListCreatePanel(object sender, RoutedEventArgs e)
            {
                CreateListPanel.Visibility = Visibility.Hidden;
                CreateCardPanel.Visibility = Visibility.Visible;
                textBoxList.Focus();

            }

            private void TextBoxList_LostFocus(object sender, RoutedEventArgs e)
            {
                if (textBoxList.Text == "")
                {
                    CreateListPanel.Visibility = Visibility.Visible;
                    CreateCardPanel.Visibility = Visibility.Collapsed;
                }
            }

            private void TextBoxList_GotFocus(object sender, RoutedEventArgs e)
            {
                textBoxList.Text = "";
            }


            private void button_Click_CardsCreatePanel(object sender, RoutedEventArgs e)
            {
                if (textBoxList.Text == "")
                    textBoxList.Focus();
                else
                {
                    CreateListPanel createListPanel = new CreateListPanel(textBoxList.Text, mainWindow.ActualHeight);
                    SavePanel.Children.Add(createListPanel);
                    textBoxList.Text = "Введите название колонки";
                    textBoxList.Focus();
                }
            }
        
    }
}
