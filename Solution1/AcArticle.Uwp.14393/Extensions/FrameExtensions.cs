using AcArticle.Uwp.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AcArticle.Uwp.Extensions
{
    internal static class FrameExtensions
    {
        internal static readonly DependencyProperty PreviousPageProperty = DependencyProperty.Register("PreviousPage", typeof(ViewBase), typeof(FrameExtensions), new PropertyMetadata(default(ViewBase)));

        internal static ViewBase GetPreviousPage(Frame obj)
        {
            return (ViewBase)obj.GetValue(PreviousPageProperty);
        }

        internal static void SetPreviousPage(Frame obj, ViewBase value)
        {
            obj.SetValue(PreviousPageProperty, value);
        }
    }
}