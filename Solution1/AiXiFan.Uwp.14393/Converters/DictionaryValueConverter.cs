using System;
using System.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace AiXiFan.Uwp.Converters
{
    public class DictionaryValueConverter : DependencyObject, IValueConverter
    {
        public static readonly DependencyProperty DictionaryProperty = DependencyProperty.Register(nameof(Dictionary), typeof(IDictionary), typeof(DictionaryValueConverter), new PropertyMetadata(default(IDictionary)));

        public IDictionary Dictionary
        {
            get
            {
                return (IDictionary)GetValue(DictionaryProperty);
            }
            set
            {
                SetValue(DictionaryProperty, value);
            }
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (Dictionary == null || value == null)
            {
                return null;
            }
            if (Dictionary.Contains(value))
            {
                return Dictionary[value];
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}