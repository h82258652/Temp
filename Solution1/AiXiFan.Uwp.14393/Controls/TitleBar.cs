using AiXiFan.Uwp.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls.Extensions;

namespace AiXiFan.Uwp.Controls
{
    [TemplatePart(Name = TitleZoneTemplateName, Type = typeof(Grid))]
    public class TitleBar : Control
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(TitleBar), new PropertyMetadata(default(string)));

        private const string TitleZoneTemplateName = "PART_TitleZone";

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

            var titleZone = (Grid)GetTemplateChild(TitleZoneTemplateName);
            titleZone.Loaded += (sender, e) =>
            {
                var view = this.GetFirstAncestorOfType<ViewBase>();
                if (view != null)
                {
                    view.TitleBar = titleZone;
                }
            };
        }
    }
}