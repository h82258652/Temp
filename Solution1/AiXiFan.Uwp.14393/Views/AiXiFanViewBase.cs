using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace AiXiFan.Uwp.Views
{
    public abstract class AiXiFanViewBase : ViewBase
    {
        private new Transform RenderTransform
        {
            get
            {
                return base.RenderTransform;
            }
            set
            {
                base.RenderTransform = value;
            }
        }

        protected override Storyboard GetEnterStoryboard()
        {
            if (Frame.BackStackDepth > 0 && Frame.CanGoForward == false)
            {
                var storyboard = new Storyboard();
                var animation = new DoubleAnimation()
                {
                    From = Frame.ActualWidth,
                    To = 0,
                    Duration = TimeSpan.FromSeconds(0.3)
                };
                Storyboard.SetTarget(animation, this);
                if (RenderTransform is CompositeTransform == false)
                {
                    RenderTransform = new CompositeTransform();
                }
                Storyboard.SetTargetProperty(animation, "(UIElement.RenderTransform).(CompositeTransform.TranslateX)");
                storyboard.Children.Add(animation);
                return storyboard;
            }
            else
            {
                RenderTransform = null;
                return null;
            }
        }

        protected override Storyboard GetLeaveStoryboard(NavigationMode navigationMode)
        {
            if (navigationMode == NavigationMode.New)
            {
                var storyboard = new Storyboard();
                var animation = new DoubleAnimation()
                {
                    From = 0,
                    To = 0 - Frame.ActualWidth,
                    Duration = TimeSpan.FromSeconds(0.3)
                };
                Storyboard.SetTarget(animation, this);
                if (RenderTransform is CompositeTransform == false)
                {
                    RenderTransform = new CompositeTransform();
                }
                Storyboard.SetTargetProperty(animation, "(UIElement.RenderTransform).(CompositeTransform.TranslateX)");
                storyboard.Children.Add(animation);
                return storyboard;
            }
            else if (navigationMode == NavigationMode.Back)
            {
                var storyboard = new Storyboard();
                var animation = new DoubleAnimation()
                {
                    From = 0,
                    To = Frame.ActualWidth,
                    Duration = TimeSpan.FromSeconds(0.3)
                };
                Storyboard.SetTarget(animation, this);
                if (RenderTransform is CompositeTransform == false)
                {
                    RenderTransform = new CompositeTransform();
                }
                Storyboard.SetTargetProperty(animation, "(UIElement.RenderTransform).(CompositeTransform.TranslateX)");
                storyboard.Children.Add(animation);
                return storyboard;
            }
            else
            {
                return null;
            }
        }
    }
}