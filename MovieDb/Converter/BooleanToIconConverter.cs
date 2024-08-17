using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MovieDb.Converter
{
    class BooleanToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isOwned = (bool)value;
            return isOwned ? "/Images/check-mark-8-64.png" : "/Images/white-square-32.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isOwned = (bool)value;
            return isOwned ? "/Images/check-mark-8-64.png" : "/Images/white-square-32.png";
        }
    }
}
