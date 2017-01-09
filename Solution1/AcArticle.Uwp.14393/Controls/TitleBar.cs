using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AcArticle.Uwp.Controls
{
    [TemplatePart(Name = TitleZoneTemplateName, Type = typeof(Grid))]
    public class TitleBar : Control
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(TitleBar), new PropertyMetadata(default(string)));

        private const string TitleZoneTemplateName = "PART_TitleZone";

        private Grid _titleZone;

        public TitleBar()
        {
            DefaultStyleKey = typeof(TitleBar);
        }

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _titleZone = (Grid)GetTemplateChild(TitleZoneTemplateName);
            _titleZone.Loaded += TitleZone_Loaded;
        }

        private void TitleZone_Loaded(object sender, RoutedEventArgs e)
        {
            Window.Current.SetTitleBar(_titleZone);
        }
    }
}