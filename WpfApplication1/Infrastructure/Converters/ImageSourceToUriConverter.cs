using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfApplication1.Infrastructure.Converters
{
    public class ImageSourceToUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";

            return @"/WpfApplication1;component/Icons/" + value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
