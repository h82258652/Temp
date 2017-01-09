using AiXiFan.Uwp.Extensions;
using Windows.Foundation.Metadata;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.AwaitableUI;

namespace AiXiFan.Uwp.Views
{
    public abstract class ViewBase : BindablePage
    {
        public static readonly DependencyProperty TitleBarProperty = DependencyProperty.Register(nameof(TitleBar), typeof(UIElement), typeof(ViewBase), new PropertyMetadata(default(UIElement), TitleBarChanged));

        private bool _isLeaving;

        protected ViewBase()
        {
            base.Loaded += ViewBase_Loaded;
        }

        public new event RoutedEventHandler Loaded;

        public UIElement TitleBar
        {
            get
            {
                return (UIElement)GetValue(TitleBarProperty);
            }
            set
            {
                SetValue(TitleBarProperty, value);
            }
        }

        private static ContentControl PreviousPageContainer
        {
            get
            {
                var rootView = (RootView)Window.Current.Content;
                return rootView.PreviousPageContainer;
            }
        }

        protected virtual Storyboard GetEnterStoryboard()
        {
            return null;
        }

        protected virtual Storyboard GetLeaveStoryboard(NavigationMode navigationMode)
        {
            return null;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            if (ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
            }

            SetTitleBar(null);

            FrameExtensions.SetPreviousPage(Frame, this);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            }

            SetTitleBar(TitleBar);

            var previousPage = FrameExtensions.GetPreviousPage(Frame);
            if (previousPage != null)
            {
                previousPage._isLeaving = true;
                PreviousPageContainer.Content = previousPage;
                await previousPage.WaitForLoadedAsync();
                var leaveStoryboard = previousPage.GetLeaveStoryboard(e.NavigationMode);
                if (leaveStoryboard != null)
                {
                    await leaveStoryboard.BeginAsync();
                }
                PreviousPageContainer.Content = null;
                FrameExtensions.SetPreviousPage(Frame, null);
                previousPage._isLeaving = false;
            }
        }

        private static void TitleBarChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (ViewBase)d;
            var value = (UIElement)e.NewValue;
            obj.SetTitleBar(value);
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (ApiInformation.IsTypePresent("Windows.Phone.UI.Input.BackPressedEventArgs"))
            {
                if (Frame.CanGoBack)
                {
                    e.Handled = true;
                    Frame.GoBack();
                }
            }
        }

        private void SetTitleBar(UIElement customTitleBar)
        {
            var rootView = (RootView)Window.Current.Content;
            if (rootView.RootFrame == Frame)
            {
                Window.Current.SetTitleBar(customTitleBar);
            }
        }

        private void ViewBase_Loaded(object sender, RoutedEventArgs e)
        {
            if (_isLeaving == false)
            {
                Loaded?.Invoke(sender, e);
                var enterStoryboard = GetEnterStoryboard();
                enterStoryboard?.Begin();
            }
        }
    }
}