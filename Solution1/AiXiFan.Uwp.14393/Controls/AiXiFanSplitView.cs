using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace AiXiFan.Uwp.Controls
{
    public class AiXiFanSplitView : SplitView
    {
        public static readonly DependencyProperty LightDismissOverlayBackgroundProperty = DependencyProperty.Register(nameof(LightDismissOverlayBackground), typeof(Brush), typeof(AiXiFanSplitView), new PropertyMetadata(default(Brush)));

        public AiXiFanSplitView()
        {
            DefaultStyleKey = typeof(AiXiFanSplitView);
        }

        public Brush LightDismissOverlayBackground
        {
            get
            {
                return (Brush)GetValue(LightDismissOverlayBackgroundProperty);
            }
            set
            {
                SetValue(LightDismissOverlayBackgroundProperty, value);
            }
        }
    }
}