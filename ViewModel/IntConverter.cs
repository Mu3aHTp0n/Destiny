using System;
using System.Globalization;
using System.Windows;

namespace Destiny.ViewModel
{
    internal class IntConverter
    {
        public object Convert(object value) => (int)value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return null;
            }
            int result;
            if (int.TryParse(value.ToString(), out result))
            {
                return result;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
