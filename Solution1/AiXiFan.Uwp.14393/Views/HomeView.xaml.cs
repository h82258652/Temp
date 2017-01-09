using AiXiFan.Models;
using AiXiFan.Uwp.Messages;
using GalaSoft.MvvmLight.Messaging;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace AiXiFan.Uwp.Views
{
    public sealed partial class HomeView
    {
        public HomeView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            // TODO
            var channel = e.Parameter as ChannelData;
            if (channel != null)
            {
                if (channel.Id == (int)ChannelId.Bangumi)
                {
                    Pivot.SelectedIndex = 2;
                    e.Cancel = true;
                }
                if (channel.Id == (int)ChannelId.Entertainment)
                {
                    Pivot.SelectedIndex = 3;
                    e.Cancel = true;
                }
                if (channel.Id == (int)ChannelId.Article)
                {
                    Pivot.SelectedIndex = 4;
                    e.Cancel = true;
                }
            }

            base.OnNavigatingFrom(e);
        }

        private void UpdateCountTextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            var textBlock = (TextBlock)sender;
            Messenger.Default.Register<UpdateCountsLoadedMessage>(textBlock, message =>
            {
                var channel = textBlock.DataContext as ChannelData;
                if (channel != null)
                {
                    var id = channel.Id;
                    var updateCounts = message.UpdateCounts;
                    if (updateCounts.ContainsKey(id))
                    {
                        textBlock.Text = updateCounts[id].ToString();
                    }
                }
            });
        }

        private void UpdateCountTextBlock_Unloaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Unregister(sender);
        }

        private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            // TODO
            SplitView.IsPaneOpen = false;
            Frame.Navigate(typeof(LoginView));
        }
    }
}