using System;
using System.Globalization;
using System.Windows.Data;

namespace VirtualKeyboard.Wpf.Converters
{
    class ContentCaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is string content && value is bool uppercase)
            {
                return uppercase ? content.ToUpper() : content.ToLower();
            }
            return parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}