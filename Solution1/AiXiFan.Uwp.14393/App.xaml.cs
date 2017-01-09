using AiXiFan.Uwp.Views;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

namespace AiXiFan.Uwp
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
            Resuming += OnResuming;
            Suspending += OnSuspending;
        }

        protected override void OnActivated(IActivatedEventArgs args)
        {
            base.OnActivated(args);
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var rootView = Window.Current.Content as RootView;
            if (rootView == null)
            {
                rootView = new RootView(e.SplashScreen);
                rootView.RootFrame.NavigationFailed += OnNavigationFailed;
                Window.Current.Content = rootView;
            }

            //Window.Current.Activate();
            //rootView.RootFrame.Navigate(typeof(HomeView));

            //#if DEBUG
            //            if (System.Diagnostics.Debugger.IsAttached)
            //            {
            //                //this.DebugSettings.EnableFrameRateCounter = true;
            //            }
            //#endif
            //            Frame rootFrame = Window.Current.Content as Frame;

            //            // 不要在窗口已包含内容时重复应用程序初始化，
            //            // 只需确保窗口处于活动状态
            //            if (rootFrame == null)
            //            {
            //                // 创建要充当导航上下文的框架，并导航到第一页
            //                rootFrame = new Frame();

            //                rootFrame.NavigationFailed += OnNavigationFailed;

            //                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
            //                {
            //                    //TODO: 从之前挂起的应用程序加载状态
            //                }

            //                // 将框架放在当前窗口中
            //                Window.Current.Content = rootFrame;
            //            }

            //            if (e.PrelaunchActivated == false)
            //            {
            //                if (rootFrame.Content == null)
            //                {
            //                    // 当导航堆栈尚未还原时，导航到第一页，
            //                    // 并通过将所需信息作为导航参数传入来配置
            //                    // 参数
            //                    rootFrame.Navigate(typeof(HomeView), e.Arguments);
            //                }

            //                //ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(192, 48));

            //                // 确保当前窗口处于活动状态
            //                Window.Current.Activate();
            //            }
        }

        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnResuming(object sender, object e)
        {
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            try
            {
            }
            finally
            {
                deferral.Complete();
            }
        }
    }
}