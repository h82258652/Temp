using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AiXiFan.Uwp.Controls
{
    public class ButtonEx : Button
    {
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(ButtonEx), new PropertyMetadata(default(CornerRadius)));

        public ButtonEx()
        {
            DefaultStyleKey = typeof(ButtonEx);
        }

        public CornerRadius CornerRadius
        {
            get
            {
                return (CornerRadius)GetValue(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }
    }
}