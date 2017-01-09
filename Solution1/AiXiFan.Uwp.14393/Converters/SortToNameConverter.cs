using AiXiFan.Models;
using System;
using Windows.UI.Xaml.Data;

namespace AiXiFan.Uwp.Converters
{
    public class SortToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var sort = (Sort)value;
            switch (sort)
            {
                case Sort.ViewsDescending:
                    return "围观最多";

                case Sort.CommentsDescending:
                    return "评论最多";

                case Sort.PublishNewest:
                    return "最新发布";

                case Sort.ReplyNewest:
                    return "最新回复";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}