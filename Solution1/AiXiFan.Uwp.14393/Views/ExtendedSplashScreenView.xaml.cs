using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace AiXiFan.Uwp.Views
{
    public sealed partial class ExtendedSplashScreenView
    {
        private readonly SplashScreen _splashScreen;

        public ExtendedSplashScreenView()
        {
            InitializeComponent();
        }

        public ExtendedSplashScreenView(SplashScreen splashScreen) : this()
        {
            _splashScreen = splashScreen;
        }

        public event EventHandler Completed;

        public Task DismissAsync()
        {
            return Task.CompletedTask;
        }

        private void InitializeTitleBar()
        {
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonForegroundColor = Colors.White;
            titleBar.ButtonHoverBackgroundColor = Colors.Transparent;
            titleBar.ButtonPressedBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
        }

        private void SplashScreenImage_ImageOpened(object sender, RoutedEventArgs e)
        {
            // 图片加载完毕后激活当前窗口，系统 SplashScreen 将会消失。
            Window.Current.Activate();

            InitializeTitleBar();
            Completed?.Invoke(this, EventArgs.Empty);
        }
    }
}