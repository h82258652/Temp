using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls.Extensions;

namespace AcArticle.Uwp.Behaviors
{
    public class GoBackAction : DependencyObject, IAction
    {
        public object Execute(object sender, object parameter)
        {
            var frame = (sender as DependencyObject)?.GetFirstAncestorOfType<Frame>();
            if (frame != null)
            {
                if (frame.CanGoBack)
                {
                    frame.GoBack();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                frame = Window.Current.Content?.GetFirstDescendantOfType<Frame>();
                if (frame != null && frame.CanGoBack)
                {
                    frame.GoBack();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}