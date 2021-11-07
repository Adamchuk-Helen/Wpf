using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ColorPicker
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        public SolidColorBrush Brush { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private int alpha = 255;

        public int Alpha
        {
            get { return alpha; }
            set
            {
                alpha = value;
                Brush= new SolidColorBrush(Color.FromArgb(Convert.ToByte(alpha),Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        private int red;
        public int Red
        {
            get { return red; }
            set
            {
                red = value;
                Brush = new SolidColorBrush(Color.FromArgb(Convert.ToByte(alpha), Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        private int green;
        public int Green
        {
            get { return green; }
            set
            {
                green = value;
                Brush = new SolidColorBrush(Color.FromArgb(Convert.ToByte(alpha), Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        private int blue;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                Brush = new SolidColorBrush(Color.FromArgb(Convert.ToByte(alpha), Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        public void OnNotify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button newButton = new Button { Height = 30, Width = 50, Content = "Delete" };
            StackPanel stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Height = 70 };
            newButton.Background = Brushes.Orange;
            newButton.Click += NewButton_Click;

            var newLable = new Label { Height = 50, Width = 300, Background = lbColor.Background };
            newLable.Margin = new Thickness(15, 5, 15, 5);

            var newLable1 = new Label {Content=Brush.Color};
            newLable1.Margin = new Thickness(10, 20, 10, 5);


           
            stackPanel.Children.Add(newLable1);
            stackPanel.Children.Add(newLable);
            stackPanel.Children.Add(newButton);
            spShowColors.Children.Add(stackPanel);
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            var bt = sender as Button;
            var sp = bt.Parent;
            spShowColors.Children.Remove((UIElement)sp);


        }
    }  


    
}

       


    

    

