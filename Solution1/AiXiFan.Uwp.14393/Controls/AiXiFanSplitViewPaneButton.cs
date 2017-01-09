using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AiXiFan.Uwp.Controls
{
    public class AiXiFanSplitViewPaneButton : Button
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(IconElement), typeof(AiXiFanSplitViewPaneButton), new PropertyMetadata(default(IconElement)));

        public AiXiFanSplitViewPaneButton()
        {
            DefaultStyleKey = typeof(AiXiFanSplitViewPaneButton);
        }

        public IconElement Icon
        {
            get
            {
                return (IconElement)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }
    }
}