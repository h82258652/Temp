using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace AiXiFan.Uwp.Converters
{
    public class IsNullToVisibilityConverter : DependencyObject, IValueConverter
    {
        public static readonly DependencyProperty AllowEmptyStringsProperty = DependencyProperty.Register(nameof(AllowEmptyStrings), typeof(bool), typeof(IsNullToVisibilityConverter), new PropertyMetadata(default(bool)));

        public static readonly DependencyProperty IsInversedProperty = DependencyProperty.Register(nameof(IsInversed), typeof(bool), typeof(IsNullToVisibilityConverter), new PropertyMetadata(default(bool)));

        public bool AllowEmptyStrings
        {
            get
            {
                return (bool)GetValue(AllowEmptyStringsProperty);
            }
            set
            {
                SetValue(AllowEmptyStringsProperty, value);
            }
        }

        public bool IsInversed
        {
            get
            {
                return (bool)GetValue(IsInversedProperty);
            }
            set
            {
                SetValue(IsInversedProperty, value);
            }
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (AllowEmptyStrings)
            {
                if (value == null || value.ToString() == string.Empty)
                {
                    return IsInversed ? Visibility.Visible : Visibility.Collapsed;
                }
                else
                {
                    return IsInversed ? Visibility.Collapsed : Visibility.Visible;
                }
            }
            else
            {
                if (value == null)
                {
                    return IsInversed ? Visibility.Visible : Visibility.Collapsed;
                }
                else
                {
                    return IsInversed ? Visibility.Collapsed : Visibility.Visible;
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}