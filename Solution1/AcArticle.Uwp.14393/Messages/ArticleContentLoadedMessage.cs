using GalaSoft.MvvmLight.Messaging;

namespace AcArticle.Uwp.Messages
{
    public class ArticleContentLoadedMessage : MessageBase
    {
        public ArticleContentLoadedMessage(string content)
        {
            Content = content;
        }

        public string Content
        {
            get;
        }
    }
}