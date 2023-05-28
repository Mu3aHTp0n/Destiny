using System;
using System.Globalization;

namespace Destiny.ViewModel
{
    internal class IntConverter
    {
        public object Convert(object value) => (int)value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
