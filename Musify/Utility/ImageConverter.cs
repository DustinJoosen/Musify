using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Musify.Utility
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string fileName))
                return null;

            // Assuming LoadImage is a method that converts a file path to a BitmapImage
            BitmapImage bitmap = new();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri($"../../Lib/Uploads/{fileName}", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();

            return bitmap;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}