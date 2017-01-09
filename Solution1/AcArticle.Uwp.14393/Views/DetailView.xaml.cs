using AcArticle.Uwp.Messages;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AcArticle.Uwp.Views
{
    public sealed partial class DetailView
    {
        private readonly TaskCompletionSource<WebViewDOMContentLoadedEventArgs> _webViewDOMReadyTcs = new TaskCompletionSource<WebViewDOMContentLoadedEventArgs>();

        public DetailView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            Messenger.Default.Unregister(this);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Messenger.Default.Register<ArticleContentLoadedMessage>(this, async message =>
            {
                await _webViewDOMReadyTcs.Task;
                await WebView.InvokeScriptAsync("setContent", new[]
                {
                    message.Content
                });
            });
        }

        private void WebView_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            sender.DOMContentLoaded -= WebView_DOMContentLoaded;
            _webViewDOMReadyTcs.SetResult(args);
        }
    }
}