using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UwpControlsDemo
{
    public class StringFormatConverter : IValueConverter
    {
        public string StringFormat { get; set; }


        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return null;

            var format = parameter as string;
            if (String.IsNullOrWhiteSpace(format) == false)
                return String.Format(format, value);

            if (string.IsNullOrWhiteSpace(StringFormat) == false)
                return string.Format(StringFormat, value);

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

}
