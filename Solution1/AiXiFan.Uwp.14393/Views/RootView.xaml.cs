using System;
using Windows.ApplicationModel.Activation;

namespace AiXiFan.Uwp.Views
{
    public sealed partial class RootView
    {
        public RootView()
        {
            InitializeComponent();
        }

        public RootView(SplashScreen splashScreen) : this()
        {
            var extendedSplashScreenView = new ExtendedSplashScreenView(splashScreen);
            EventHandler completedHandler = null;
            completedHandler = async (sender, e) =>
            {
                extendedSplashScreenView.Completed -= completedHandler;
                RootFrame.Navigate(typeof(HomeView));
                await extendedSplashScreenView.DismissAsync();
                RootGrid.Children.Remove(extendedSplashScreenView);
            };
            extendedSplashScreenView.Completed += completedHandler;
            RootGrid.Children.Add(extendedSplashScreenView);
        }
    }
}