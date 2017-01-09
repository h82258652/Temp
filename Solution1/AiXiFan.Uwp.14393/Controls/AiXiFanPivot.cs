using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AiXiFan.Uwp.Controls
{
    public class AiXiFanPivot : Pivot
    {
        public static readonly DependencyProperty IndicatorProperty = DependencyProperty.Register(nameof(Indicator), typeof(FrameworkElement), typeof(AiXiFanPivot), new PropertyMetadata(default(UIElement), IndicatorChanged));

        public AiXiFanPivot()
        {
            DefaultStyleKey = typeof(AiXiFanPivot);
            SelectionChanged += OnSelectionChanged;
        }

        public FrameworkElement Indicator
        {
            get
            {
                return (FrameworkElement)GetValue(IndicatorProperty);
            }
            set
            {
                SetValue(IndicatorProperty, value);
            }
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var scrollViewer = (ScrollViewer)GetTemplateChild("ScrollViewer");
            scrollViewer.ViewChanging += ScrollViewer_ViewChanging;
        }

        private static void IndicatorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ScrollViewer_ViewChanging(object sender, ScrollViewerViewChangingEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}