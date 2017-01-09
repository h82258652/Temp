using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AcArticle.Uwp.Controls
{
    public class Card : ContentControl
    {
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius), typeof(double), typeof(Card), new PropertyMetadata(default(double)));

        public Card()
        {
            DefaultStyleKey = typeof(Card);
        }

        public double CornerRadius
        {
            get
            {
                return (double)GetValue(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }
    }
}