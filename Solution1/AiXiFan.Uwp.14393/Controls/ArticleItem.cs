using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AiXiFan.Uwp.Controls
{
    public sealed class ArticleItem : Control
    {
        public static readonly DependencyProperty ChannelNameProperty = DependencyProperty.Register(nameof(ChannelName), typeof(string), typeof(ArticleItem), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty CommentCountProperty = DependencyProperty.Register(nameof(CommentCount), typeof(int), typeof(ArticleItem), new PropertyMetadata(default(int)));

        public static readonly DependencyProperty OwnerProperty = DependencyProperty.Register(nameof(Owner), typeof(string), typeof(ArticleItem), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(ArticleItem), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ViewCountProperty = DependencyProperty.Register(nameof(ViewCount), typeof(int), typeof(ArticleItem), new PropertyMetadata(default(int)));

        public ArticleItem()
        {
            DefaultStyleKey = typeof(ArticleItem);
        }

        public string ChannelName
        {
            get
            {
                return (string)GetValue(ChannelNameProperty);
            }
            set
            {
                SetValue(ChannelNameProperty, value);
            }
        }

        public int CommentCount
        {
            get
            {
                return (int)GetValue(CommentCountProperty);
            }
            set
            {
                SetValue(CommentCountProperty, value);
            }
        }

        public string Owner
        {
            get
            {
                return (string)GetValue(OwnerProperty);
            }
            set
            {
                SetValue(OwnerProperty, value);
            }
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

        public int ViewCount
        {
            get
            {
                return (int)GetValue(ViewCountProperty);
            }
            set
            {
                SetValue(ViewCountProperty, value);
            }
        }
    }
}