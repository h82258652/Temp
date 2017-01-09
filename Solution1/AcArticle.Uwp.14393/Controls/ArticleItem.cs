using SoftwareKobo.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AcArticle.Uwp.Controls
{
    [TemplatePart(Name = AuthorAvatarImageExBehaviorTemplateName, Type = typeof(ImageExBehavior))]
    public class ArticleItem : Control
    {
        public static readonly DependencyProperty AuthorAvatarProperty = DependencyProperty.Register(nameof(AuthorAvatar), typeof(string), typeof(ArticleItem), new PropertyMetadata(default(string), AuthorAvatarChanged));

        public static readonly DependencyProperty AuthorNameProperty = DependencyProperty.Register(nameof(AuthorName), typeof(string), typeof(ArticleItem), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty CommentCountProperty = DependencyProperty.Register(nameof(CommentCount), typeof(int), typeof(ArticleItem), new PropertyMetadata(default(int)));

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(ArticleItem), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ViewCountProperty = DependencyProperty.Register(nameof(ViewCount), typeof(int), typeof(ArticleItem), new PropertyMetadata(default(int)));

        private const string AuthorAvatarImageExBehaviorTemplateName = "PART_AuthorAvatarImageExBehavior";

        private ImageExBehavior _authorAvatarImageExBehavior;

        public ArticleItem()
        {
            DefaultStyleKey = typeof(ArticleItem);
        }

        public string AuthorAvatar
        {
            get
            {
                return (string)GetValue(AuthorAvatarProperty);
            }
            set
            {
                SetValue(AuthorAvatarProperty, value);
            }
        }

        public string AuthorName
        {
            get
            {
                return (string)GetValue(AuthorNameProperty);
            }
            set
            {
                SetValue(AuthorNameProperty, value);
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

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _authorAvatarImageExBehavior = (ImageExBehavior)GetTemplateChild(AuthorAvatarImageExBehaviorTemplateName);
            UpdateAuthorAvatarImage();
        }

        private static void AuthorAvatarChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (ArticleItem)d;
            obj.UpdateAuthorAvatarImage();
        }

        private void UpdateAuthorAvatarImage()
        {
            if (_authorAvatarImageExBehavior != null)
            {
                _authorAvatarImageExBehavior.Source = AuthorAvatar;
            }
        }
    }
}