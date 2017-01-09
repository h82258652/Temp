using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AcArticle.Uwp.Converters
{
    public class TestConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            dynamic d = value;
            return d.Key;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}