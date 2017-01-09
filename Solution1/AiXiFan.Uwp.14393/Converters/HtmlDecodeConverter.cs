using System;
using System.Net;
using Windows.UI.Xaml.Data;

namespace AiXiFan.Uwp.Converters
{
    public class HtmlDecodeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var str = value as string ?? value?.ToString();
            return WebUtility.HtmlDecode(str);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}