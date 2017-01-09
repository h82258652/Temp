using GalaSoft.MvvmLight.Messaging;

namespace AiXiFan.Uwp.Messages
{
    public class ArticleLoadedMessage : MessageBase
    {
        public ArticleLoadedMessage(string content)
        {
            Content = content;
        }

        public string Content
        {
            get;
        }
    }
}