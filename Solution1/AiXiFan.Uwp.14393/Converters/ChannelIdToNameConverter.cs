using AiXiFan.Models;
using System;
using Windows.UI.Xaml.Data;

namespace AiXiFan.Uwp.Converters
{
    public class ChannelIdToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            ChannelId channelId = (ChannelId)value;
            switch (channelId)
            {
                // TODO
            }

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}