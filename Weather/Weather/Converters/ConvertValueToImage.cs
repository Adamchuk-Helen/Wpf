using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Weather.Converters
{
    class ConvertValueToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            BitmapImage image = new BitmapImage();

            var val = (int)value;

            switch (val)
            {
                case 1:
                    image.BeginInit();
                    image.UriSource = new Uri(@"C:\Users\Lena\source\repos\Weather\Weather\Resources\01 - s.png", UriKind.Relative);

                    image.EndInit();
                    return image;
                case 2:
                    image.BeginInit();
                    image.UriSource = new Uri(@"C:\Users\Lena\source\repos\Weather\Weather\Resources\02 - s.png", UriKind.Relative);

                    image.EndInit();
                    return image;
                case 3:
                    image.BeginInit();
                    image.UriSource = new Uri(@"C:\Users\Lena\source\repos\Weather\Weather\Resources\03 - s.png", UriKind.Relative);

                    image.EndInit();
                    return image;

                case 4:
                    image.BeginInit();
                    image.UriSource = new Uri(@"C:\Users\Lena\source\repos\Weather\Weather\Resources\04 - s.png", UriKind.Relative);

                    image.EndInit();
                    return image;

                case 5:

                    image.BeginInit();
                    image.UriSource = new Uri(@"C:\Users\Lena\source\repos\Weather\Weather\Resources\05 - s.png", UriKind.Relative);

                    image.EndInit();
                    return image;
                case 6:
                    image.BeginInit();
                    image.UriSource = new Uri(@"C:\Users\Lena\source\repos\Weather\Weather\Resources\06 - s.png", UriKind.Relative);

                    image.EndInit();
                    return image;

            }
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
